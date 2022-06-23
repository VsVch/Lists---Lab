using System;
using System.Collections.Generic;
using System.Linq;

namespace PP06._List_Manipulation_Basics
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
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        int mum = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, mum);
                        break;

                    default:
                        break;
                }



                input = Console.ReadLine();
            }



            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
