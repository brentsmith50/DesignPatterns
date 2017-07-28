using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Tree
{
    public class TreeBreadthFirstEnumerator<T> : IEnumerator<T>
    {
        #region Fields and Constructor

        private readonly Tree<T> tree;
        private Tree<T> current;
        private Queue<IEnumerator<Tree<T>>> enumerators = new Queue<IEnumerator<Tree<T>>>();

        public TreeBreadthFirstEnumerator(Tree<T> tree)
        {
            this.tree = tree;
        }
        #endregion

        #region Properties
        public T Current
        {
            get { return this.current.Value; }
        }

        object IEnumerator.Current
        {
            get { return this.Current; }
        }
        #endregion

        #region Methods

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (current == null)
            {
                Reset();
                current = tree;
                enumerators.Enqueue(current.Children().GetEnumerator());
                return true;
            }
            while (enumerators.Count > 0)
            {
                var enumerator = enumerators.Peek();
                if (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    enumerators.Enqueue(current.Children().GetEnumerator());
                    return true;
                }
                else
                {
                    enumerators.Dequeue();
                }
            }
            return false;
        }

        public void Reset()
        {
            this.current = null;
            this.enumerators.Clear();
        }
        #endregion
    }
}
