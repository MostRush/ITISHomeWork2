using System;
using System.Collections.Generic;

namespace ControlWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = 30;

            var list = new List<int>();
            var rand = new Random();

            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(1, 100));
            }

            var newList = new List<int>();

            for (int k = 0; k < list.Count; k++)
            {
                var value = 0;

                for (int i = 0; i < k; i++)
                {
                    value += list[i];
                }

                newList.Add(value);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
