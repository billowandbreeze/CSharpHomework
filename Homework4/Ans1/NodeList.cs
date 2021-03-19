using System;
using System.Collections.Generic;
using System.Text;

namespace Ans1
{
    class NodeList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public Node<T> Head
        {
            get => head;
        }

        public Node<T> Tail
        {
            get => tail;
        }

        public NodeList()
        {
            head = null;
            tail = null;
        }

        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        public void ForEach(Action<T> action)
        {
            Node<T> node = head;

            while(node != null)
            {
                action(node.val);
                node = node.next;
            }
        }
    }
}
