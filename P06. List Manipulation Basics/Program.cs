using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while (input != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    int numAdd = int.Parse(command[1]);
                    numbers.Add(numAdd);
                }
                if (command[0] == "Remove")
                {
                    int numRev = int.Parse(command[1]);
                    numbers.Remove(numRev);
                }
                if (command[0] == "RemoveAt")
                {
                    int numRem = int.Parse(command[1]);
                    numbers.RemoveAt(numRem);
                }
                if (command[0] == "Insert")
                {
                    int numIsert = int.Parse(command[1]);
                    int indexInsert = int.Parse(command[2]);
                    numbers.Insert(indexInsert, numIsert);
                }



                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
