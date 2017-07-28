using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Tree
{
    public class TreeEnumerator<T> : IEnumerator<T>
    {
        #region Fields
        private Tree<T> tree;
        private Tree<T> current;
        private Tree<T> previous;
        private Stack<Tree<T>> breadCrumb = new Stack<Tree<T>>();
        #endregion

        #region Constructor
        public TreeEnumerator(Tree<T> tree)
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
            get { return Current; }
        }

        #endregion

        #region Methods
        
        public bool MoveNext()
        {
            if (current == null)
            {
                Reset();
                this.current = this.tree;
                return true;
            }
            if (current.LeftChild != null)
            {
                return TraverseLeft();
            }
            if (current.RightChild != null)
            {
                return TraverseRight();
            }
            return TraverseUpAndRight();
        }

        private bool TraverseUpAndRight()
        {
            if (this.breadCrumb.Count > 0)
            {
                previous = current;
                while (true)
                {
                    current = breadCrumb.Pop();
                    if (previous != current.RightChild) break;
                }
                if (current.RightChild != null)
                {
                    breadCrumb.Push(current);
                    current = current.RightChild;
                    return true;
                }
            }
            return false;
        }

        private bool TraverseLeft()
        {
            breadCrumb.Push(current);
            current = current.LeftChild;
            return true;
        }

        private bool TraverseRight()
        {
            breadCrumb.Push(current);
            current = current.RightChild;
            return true;
        }

        public void Reset()
        {
            this.current = null;
        }

        public void Dispose()
        {
        }

        #endregion
    }
}
