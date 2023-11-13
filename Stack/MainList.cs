using Stack.Exceptions;
using System;

namespace Stack
{
    internal class MainList
    {
        public Node? Head { get; private set; }
        public int Count { get; private set; }

        public int this[int index]
        {
            get => GetElementByIndex(index);
            set => SetElementByIndex(index, value);
        }

        public void Add(int item)
        {
            Node newNode = new Node
            {
                Data = item
            };

            if (Head is null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            Count++;
        }

        public int RemoveLast()
        {
            if (Head is null)
            {
                throw new InvalidOperationException("Список пуст.");
            }

            if (Head.Next is null)
            {
                var data = Head.Data;
                Head = null;
                Count = 0;
                return data;
            }

            var current = Head;
            while (current.Next!.Next is not null)
            {
                current = current.Next;
            }

            var last = current.Next;
            current.Next = null;
            Count--;
            return last.Data;
        }

        private int GetElementByIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexValueException("Значение индекса выходит за рамки хранилища");
            }

            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next!;
            }
            return current.Data;
        }

        private void SetElementByIndex(int index, int value)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexValueException("Значение индекса выходит за рамки хранилища");
            }

            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next!;
            }
            current.Data = value;
        }
    }
}
