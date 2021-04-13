using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = "qwertyuiop".ToCharArray();
            var random = new Random();

            var dicsList = new List<Dictionary<string, int>>();

            for (int i = 0; i < 10; i++)
            {
                var dic = new Dictionary<string, int>();

                for (int j = 0; j < 9; j++)
                {
                    dic.Add(keys[j].ToString(), random.Next(1, 100));
                }

                dicsList.Add(dic);
            }

            foreach (var d in dicsList)
            {
                foreach (var i in d)
                {
                    Console.Write($"[{i.Key} {i.Value}] ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            foreach (var dic in MaxDictionary(dicsList))
            {
                Console.WriteLine($"{dic.Key} {dic.Value}");
            }

            Console.WriteLine();

            foreach (var dic in SumDictionary(dicsList))
            {
                Console.WriteLine($"{dic.Key} {dic.Value}");
            }
        }

        static Dictionary<string, int> MaxDictionary(List<Dictionary<string, int>> dictionaries)
        {
            var newDictionary = new Dictionary<string, int>();

            foreach (var d in dictionaries)
            {
                foreach (var item in d)
                {
                    KeyValuePair<string, int> keyValue = default;

                    try
                    {
                        keyValue = newDictionary.First(x => x.Key.Equals(item.Key));
                    }
                    catch { }

                    if (default(KeyValuePair<string, int>).Equals(keyValue))
                    {
                        if (keyValue.Value < item.Value)
                        {
                            newDictionary.Remove(keyValue.Key);
                            newDictionary.Add(keyValue.Key, Math.Max(keyValue.Value, item.Value));

                            continue;
                        }

                        newDictionary.Add(item.Key, item.Value);
                    }

                }
            }

            return newDictionary;
        }

        static Dictionary<string, int> SumDictionary(List<Dictionary<string, int>> dictionaries)
        {
            var newDictionary = new Dictionary<string, int>();

            return newDictionary;
        }
    }
}
