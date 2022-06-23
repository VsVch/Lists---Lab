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
            bool isOrigin = false;

            string input = string.Empty;
            while (input != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        isOrigin = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        isOrigin = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(command[1]));
                        isOrigin = true;
                        break;
                    case "Insert":
                        int mum = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, mum);
                        isOrigin = true;
                        break;
                    case "Contains":
                        
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine($"Yes");
                        }
                        else
                        {
                            Console.WriteLine($"No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> Even = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Even.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", Even));
                        break;
                    case "PrintOdd":
                        List<int> Odd = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                Odd.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", Odd));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        
                        if (command[1] == "<")
                        {
                            List<int> newCheck = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <  int.Parse(command[2]))
                                {
                                    newCheck.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", newCheck));
                        }
                        if (command[1] == ">")
                        {
                            List<int> newCheck = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > int.Parse(command[2]))
                                {
                                    newCheck.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", newCheck));
                        }
                        if (command[1] == "<=")
                        {
                            List<int> newCheck = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= int.Parse(command[2]))
                                {
                                    newCheck.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", newCheck));
                        }
                        if (command[1] == ">=")
                        {
                            List<int> newCheck = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= int.Parse(command[2]))
                                {
                                    newCheck.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", newCheck));
                        }

                        break;
                    default:
                        break;
                }



                input = Console.ReadLine();
            }

            if (isOrigin)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

            

        }
    }
}
