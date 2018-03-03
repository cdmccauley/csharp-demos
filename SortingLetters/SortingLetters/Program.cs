using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            string userInput;
            List<char> charList = new List<char>();

            // get input
            Console.Write("Enter a sentence: ");
            userInput = Console.ReadLine();

            // insert letters into List
            foreach (char character in userInput)
                if (Char.IsLetter(character))
                    charList.Add(character);

            // display results of query that sorts the list in ascending order
            Console.WriteLine("\nSort Ascending:");
            var ascendSortQuery =
                from character in charList
                orderby character ascending
                select character;
            foreach (char character in ascendSortQuery)
                Console.Write(character);

            // display results of query that sorts the list in descending order
            Console.WriteLine("\n\nSort Descending:");
            var descendSortQuery =
                from character in charList
                orderby character descending
                select character;
            foreach (char character in descendSortQuery)
                Console.Write(character);

            // display results of query that sorts the list in ascending order with no duplicates
            Console.WriteLine("\n\nSort Ascending, Remove Duplicates:");
            var noDuplicateAscendSortQuery =
                from character in charList.Distinct()
                orderby character ascending
                select character;
            foreach (char character in noDuplicateAscendSortQuery)
                Console.Write(character);

            // hold console
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
