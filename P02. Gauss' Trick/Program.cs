using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<double> result = new List<double>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - i - 1]);

            }
            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count / 2]);
            }


            Console.WriteLine(string.Join(" ", result));
        }

    }
}
