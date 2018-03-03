using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            string userInput;
            List<char> charList = new List<char>();
            StringBuilder missingChars = new StringBuilder();

            var pangramQuery =
                from character in charList
                group character by character into charGroup
                select charGroup.Key;

            // get input
            Console.Write("Enter a sentence: ");
            userInput = Console.ReadLine().ToLower();

            // get characters used
            foreach (char character in userInput)
                if (Char.IsLetter(character))
                    charList.Add(character);

            // determine if pangram, indicate what is missing when false
            if (pangramQuery.Count() == 26)
                Console.WriteLine("\nA pangram was entered.");
            else
            {
                for (int i = 97; i <= 122; ++i) // unicode lowercase alphabet range
                    if (!pangramQuery.Contains((char)i))
                        missingChars.Append((char)i);
                Console.WriteLine("\nA pangram was not entered. The entry is missing: {0}", missingChars);
            }

            // hold console
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
