using System;
using System.Collections.Generic;

namespace SortedDictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> dictionary = CollectWords(); // unaltered

            DisplayDictionary(dictionary); // unaltered

            // hold
            Console.ReadKey();
        }

        // altered code from book
        private static SortedDictionary<char, int> CollectWords() 
        {
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>(); 

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            char[] characters = input.ToCharArray(); 

            foreach (char character in characters) 
            {
                char charKey; 

                if (Char.IsLetter(character)) 
                {
                    charKey = character; 

                    if (dictionary.ContainsKey(charKey)) 
                    {
                        ++dictionary[charKey]; 
                    }
                    else
                        dictionary.Add(charKey, 1);
                }
            }

            return dictionary;
        }

        // unaltered code from book
        private static void DisplayDictionary<K, V>(SortedDictionary<K, V> dictionary)
        {
            Console.WriteLine("\nSorted dictionary contains:\n{0,-12}{1,-12}", "Key:", "Value:");

            foreach (K key in dictionary.Keys)
                Console.WriteLine("{0,-12}{1,-12}", key, dictionary[key]);

            Console.WriteLine("\nsize: {0}", dictionary.Count);
        }
    }
}
