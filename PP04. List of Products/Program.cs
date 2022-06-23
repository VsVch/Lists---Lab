using System;
using System.Collections.Generic;

namespace PP04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            for (int i = 0; i < numbers; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int j = 0; j < products.Count; j++)
            {
                Console.WriteLine($"{j+1}.{products[j]}");
            }
        }
    }
}
