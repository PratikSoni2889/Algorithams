using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print List of algorithams
            PrintAlgorithamList();
        }

        private static void PrintAlgorithamList()
        {
            Console.WriteLine("===============================");
            Console.WriteLine($"1. Get Count of duplicate characters from the string\n" +
                              $"2. Print all distinct characters of a string in order (3 Methods)\n");
            Console.WriteLine("===============================");
            Console.WriteLine("NOTE: Press ESC anytime to EXIT");
            Console.Write("Please enter the algoritham number you want to execute: ");
            var input = Console.ReadLine();

            ExecuteAlgoritham(input);
        }

        private static void ExecuteAlgoritham(string input)
        {
            switch (input)
            {
                case "1":
                    GetCountOfDuplicateCharactersFromString();
                    break;
                case "2":
                    RemoveRepetativeCharacterFromStringAndThenPrintTheString();
                    break;
                default:
                    Console.WriteLine("Oops! Please enter valid selection.");
                    PrintAlgorithamList();
                    break;
            }
        }

        private static void RemoveRepetativeCharacterFromStringAndThenPrintTheString()
        {
            Console.WriteLine("Description....");
            Console.WriteLine($"Given a string, find the all distinct (or non-repeating characters) in it.\n" +
                              $"For example, if the input string is “Geeks for Geeks”, then output should be ‘for’ \n" +
                              $"and if input string is “Geeks Quiz”, then output should be ‘GksQuiz’. \n\n" +
                              $"The distinct characters should be printed in same order as they appear in input string.");



            throw new NotImplementedException();
        }

        private static void GetCountOfDuplicateCharactersFromString()
        {
            Console.Write("Please enter string you want to check: ");
            var str = Console.ReadLine();
            var charArray = str.ToArray();

            var dict = new Dictionary<char, int>();

            foreach (var c in charArray)
            {
                if (!dict.ContainsKey(c))
                {
                    var count = charArray.Count(s => s==c);
                    dict.Add(c, count);

                    if (count>1)
                    {
                        Console.WriteLine($"'{c}' occrred for {count} times");
                    }
                }
            }

            Console.WriteLine("Execution completed successfully.");
            PrintAlgorithamList();
        }
    }
}
