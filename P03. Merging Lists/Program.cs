using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> num2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> rezult = new List<int>();

            int count = Math.Max(num1.Count, num2.Count);

            for (int i = 0; i < count; i++)
            {
                if (num1.Count > i)
                {
                    rezult.Add(num1[i]);
                }
                if (num2.Count > i)
                {
                    rezult.Add(num2[i]);
                }
            }

            Console.WriteLine(String.Join(" ", rezult));
         }
    }
}
