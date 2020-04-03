using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{

    public interface IDoubleLinkedListNode<T>
    {
        T Value { get; set; }
        DoubleLinkedNode<T> Next { get; set; }
        DoubleLinkedNode<T> Prev { get; set; }
    }

    public interface IDoubleLinkedList<T>
    {
        DoubleLinkedNode<T> First { get; set; }
        DoubleLinkedNode<T> Last { get; set; }

        void Reverse();
        void AddFirst(T value); // insert new node with given value at the start of the list
        void AddLast(T value); // insert new node with given value at the end of the list
    }


    public class DoubleLinkedNode<T> : IDoubleLinkedListNode<T>
    {
        T data;
        DoubleLinkedNode<T> pNext;
        DoubleLinkedNode<T> pPrev;

        public T Value
        {
            set { data = value; }
            get { return data; }
        }

        public DoubleLinkedNode<T> Next
        {
            get { return pNext; }
            set { pNext = value; }
        }

        public DoubleLinkedNode<T> Prev
        {
            get { return pPrev; }
            set { pPrev = value; }
        }

        public DoubleLinkedNode(T data, DoubleLinkedNode<T> pNext = null, DoubleLinkedNode<T> pPrev = null) : base()
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            this.data = data;
            this.pNext = pNext;
            this.pPrev = pPrev;
        }
    }

    public class DoubleLinkedList<T> : IDoubleLinkedList<T>, IEnumerable<T>
    {
        int count = 0;
        DoubleLinkedNode<T> head = null;
        DoubleLinkedNode<T> tail = null;

        public DoubleLinkedNode<T> First
        {
            get { return head; }
            set { head = value; }
        }

        public DoubleLinkedNode<T> Last
        {
            get { return tail; }
            set { tail = value; }
        }

        public int Count
        {
            get => count;
        }

        public void AddFirst(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var node = new DoubleLinkedNode<T>(value, head, null);

            if (head == null)
            {
                head = node;
            }
            else
            {
                head.Prev = node;
            }

            head = node;

            count++;

        }

        public void AddLast(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            var node = new DoubleLinkedNode<T>(value, null, tail);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }

            tail = node;

            count++;

        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public void Reverse()
        {
            DoubleLinkedNode<T> prev = null;
            DoubleLinkedNode<T> current = head;
            DoubleLinkedNode<T> next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

    }
}
