using System;
using System.Linq;
using System.Collections.Generic;
namespace List
{
    class MainClass
    {
        public static void Main()
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArray = command.Split();

                if (commandArray[0] == "Add")
                {

                    int numberToAdd = int.Parse(commandArray[1]);
                    numbers.Add(numberToAdd);
                }
                else if (commandArray[0] == "Remove")
                {
                    int removeNumber = int.Parse(commandArray[1]);
                    numbers.Remove(removeNumber);
                }
                else if (commandArray[0] == "RemoveAt")
                {
                    int removeAtIndex = int.Parse(commandArray[1]);
                    numbers.RemoveAt(removeAtIndex);
                }

                else if (commandArray[0] == "Insert")
                {
                    int insertNumber = int.Parse(commandArray[1]);
                    int insertIndex = int.Parse(commandArray[2]);
                    numbers.Insert(insertIndex, insertNumber);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}