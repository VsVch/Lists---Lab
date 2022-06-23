using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();


            Console.WriteLine(String.Join(" ", SumPairs(firstList, secondList)));
        }

        static List<int> SumPairs(List<int> firstList, List<int> secondList)
        {
            int count = Math.Max(firstList.Count, secondList.Count);
            
            
            List<int> merged = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (firstList.Count > i)
                {
                    merged.Add(firstList[i]);
                }
                if (secondList.Count > i)
                {
                    merged.Add(secondList[i]);
                }
            }

            return merged;
        }
    }
}
