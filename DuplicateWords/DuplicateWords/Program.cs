using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace DuplicateWords
{
    class Program
    {
        // gets input from user as words
        static string[] GetWords()
        {
            string userInput;
            string[] userWords;
            Regex regex = new Regex(@"^\W+|\W+$");

            Console.Write("Enter a sentence: ");
            userInput = Console.ReadLine().ToLower();
            userInput = regex.Replace(userInput, string.Empty); // trim front/back of input to avoid empty strings in split
            userWords = Regex.Split(userInput, @"\W+\s+\W+|\W+\s+|\s+\W+|\s"); // get words from input

            return userWords;
        }

        // uses collection of words to generate a hashtable counting occurrences of each word
        static Hashtable SetHashtable(string[] words)
        {
            Hashtable hashtable = new Hashtable();

            foreach (string word in words)
            {
                if (hashtable.ContainsKey(word))
                    hashtable[word] = ((int)hashtable[word]) + 1;
                else
                    hashtable.Add(word, 1);
            }

            return hashtable;
        }

        // displays a hashtable
        static void DisplayHashtable(Hashtable hashtable)
        {
            Console.WriteLine("\n{0,-8}{1,-8}", "Word:", "Count:");
            foreach (var key in hashtable.Keys)
                Console.WriteLine("{0,-8}{1,-8}", key, hashtable[key]);
        }

        static void Main(string[] args)
        {
            DisplayHashtable(SetHashtable(GetWords()));

            Console.ReadKey();
        }
    }
}
