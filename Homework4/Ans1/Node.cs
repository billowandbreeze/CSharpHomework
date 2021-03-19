using System;
using System.Collections.Generic;
using System.Text;

namespace Ans1
{
    class Node<T>
    {
        public Node<T> next;
        public T val;

        public Node(T val)
        {
            next = null;
            this.val = val;
        }
    }
}
