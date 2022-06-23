using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i--);
                }
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine($"empty");
                return;
            }
            else




            {


                for (int i = 0; i <numbers.Count / 2; i++)
                {
                    int cur = numbers[i];
                    numbers[i] = numbers[numbers.Count - i - 1];
                    numbers[numbers.Count - i - 1] = cur;
                }




                //for (int i = 0; i < numbers.Count; i++)
                //{
                //    int cur = numbers[numbers.Count-i-1];
                //    for (int j = 0; j < numbers.Count; j++)
                //    {
                //        numbers[numbers.Count - j - 1] = numbers[i];
                //        numbers[j] = cur;
                //    }
                    
                //}
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
