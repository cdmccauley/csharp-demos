using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RemoveDuplicates
{
    class Program
    {
        // gets input from user and arranges into an array of words
        static string[] GetUserWords()
        {
            string userSentence;
            string[] userWords;
            Regex symbolTrim = new Regex(@"^\W+|\W+$");

            Console.Write("Enter a sentence: ");
            userSentence = Console.ReadLine().ToLower();

            userSentence = symbolTrim.Replace(userSentence, string.Empty);
            return userWords = Regex.Split(userSentence, @"\W+\s+\W+|\W+\s+|\s+\W+|\s");
        }

        // finds all non-duplicate words in an array and returns them as a sorted list
        static List<string> GetUniqueWords(string[] userWords)
        {
            List<string> uniqueWords = new List<string>();

            var uniqueWordsQuery =
                from word in userWords
                group word by word into wordGroup
                where wordGroup.Count() == 1
                orderby wordGroup.Key
                select wordGroup.Key;

            foreach (string word in uniqueWordsQuery)
                uniqueWords.Add(word);

            return uniqueWords;
        }

        // displays strings in a list of strings
        static void DisplayUniqueWords(List<string> uniqueWords)
        {
            Console.WriteLine("\nNon-Duplicate Words:");
            foreach (string word in uniqueWords)
                Console.WriteLine(word);
        }

        static void Main(string[] args)
        {
            DisplayUniqueWords(GetUniqueWords(GetUserWords()));

            // hold window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
