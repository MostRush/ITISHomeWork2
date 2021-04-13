using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlWork1
{
    class SetOfStacks<T>
    {
        public int MaxQuantity { get; set; }
        public Stack<Stack<T>> Stacks { get; set; }

        public SetOfStacks(int maxQuantity)
        {
            MaxQuantity = maxQuantity;
            Stacks = new Stack<Stack<T>>();
            Stacks.Push(new Stack<T>(maxQuantity));
        }

        public void Push(T value)
        {
            var stack = Stacks.FirstOrDefault(x => x.Count < MaxQuantity);

            if (stack is null)
            {
                var newStack = new Stack<T>(MaxQuantity);
                newStack.Push(value);

                Stacks.Push(newStack);
            }
            else
            {
                stack.Push(value);
            }
        }

        public T Pop()
        {
            var lastStack = Stacks.LastOrDefault();

            if (lastStack != null)
            {
                T value = lastStack.Pop();

                if (lastStack.Count <= 0)
                    Stacks.Pop();

                return value;
            }
            else
            {
                throw new InvalidOperationException("SetStack empty");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var stacks = new SetOfStacks<int>(10);
            var random = new Random();

            for (int i = 0; i < 100; i++)
                stacks.Push(random.Next(1, 100));

            for (int i = 0; i < 50; i++)
                Console.WriteLine(stacks.Pop() + " ");
        }
    }
}
