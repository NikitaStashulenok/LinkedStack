using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedStack.Model
{
    public class My_Stack<T> : ICloneable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;
        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
        public T Peek()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
        public override string ToString()
        {
            return $"In stack -> {Count} elements";
        }

        public object Clone()
        {
            var NewStack = new My_Stack<T>();
            NewStack.items = new List<T>();
            return NewStack;
        }
    }
}
