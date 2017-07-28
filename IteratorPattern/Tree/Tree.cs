using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Tree
{
    [Serializable]
    public class Tree<T> : IEnumerable<T>
    {
        #region Constructors and Properties
        /// <summary>
        /// Needed for serialization to work
        /// </summary>
        public Tree()
        {
        }

        public Tree(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public Tree<T> LeftChild { get; set; }
        public Tree<T> RightChild { get; set; }
        public bool UseBreadthFirstEnumerator { get; set; }
        #endregion


        #region Methods

        public void Add(T value)
        {
            if (LeftChild == null)
            {
                LeftChild = new Tree<T>();
                return;
            }
            if (RightChild == null)
            {
                RightChild = new Tree<T>();
                return;
            }
            if (LeftChild.Depth() <= RightChild.Depth())
            {
                LeftChild.Add(value);
                return;
            }
            RightChild.Add(value);
        }

        /// <summary>
        /// Determines the depth of the next vacant position in the tree
        /// </summary>
        /// <returns></returns>
        public int Depth()
        {
            if (LeftChild == null || RightChild == null) return 0;
            return 1 + Math.Max(LeftChild.Depth(), RightChild.Depth());
        }

        public IEnumerable<Tree<T>> Children()
        {
            if (LeftChild != null)
            {
                yield return LeftChild;
            }
            if (RightChild != null)
            {
                yield return RightChild;
            }
            yield break;
        } 

        /// <summary>
        /// Iterates over the tree in depth-first fashion and returns a list of the tree's values
        /// </summary>
        /// <returns></returns>
        public List<T> ToList()
        {
            var newList = new List<T>();
            newList.Add(Value);

            if (LeftChild != null)
            {
                newList.AddRange(LeftChild.ToList());
            }
            if (RightChild != null)
            {
                newList.AddRange(RightChild.ToList());
            }
            return newList;
        }


        public IEnumerator<T> GetEnumerator()
        {
            if (UseBreadthFirstEnumerator)
            {
                return new TreeBreadthFirstEnumerator<T>(this);
            }
            return new TreeEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
