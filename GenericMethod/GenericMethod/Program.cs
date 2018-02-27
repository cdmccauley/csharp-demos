using System;

namespace GenericMethod
{
    class Program
    {
        // custom exception
        class InvalidIndexException : Exception // derived
        {
            public InvalidIndexException() : base("Invalid index value.")
            {
            }

            public InvalidIndexException(string exception) : base(exception)
            {
            }

            public InvalidIndexException(string exception, Exception inner) : base(exception, inner)
            {
            }
        }

        static void Main(string[] args)
        {
            // declarations
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            // code from book
            Console.WriteLine("Array intArray contains: ");
            DisplayArray(intArray);
            Console.WriteLine("Array doubleArray contains: ");
            DisplayArray(doubleArray);
            Console.WriteLine("Array charArray contains: ");
            DisplayArray(charArray);
            // end code from book

            // demo overloaded DisplayArray() with intArray
            Console.WriteLine("DisplayArray(intArray, -1, 2):");
            Console.WriteLine("Displayed {0} elements.\n", DisplayArray(intArray, -1, 2));
            Console.WriteLine("DisplayArray(intArray, 3, 5):");
            Console.WriteLine("Displayed {0} elements.\n", DisplayArray(intArray, 3, 5));

            // demo overloaded DisplayArray() with doubleArray
            Console.WriteLine("DisplayArray(doubleArray, 4, 2):");
            Console.WriteLine("Displayed {0} elements.\n", DisplayArray(doubleArray, 4, 2));
            Console.WriteLine("DisplayArray(doubleArray, 2, 4):");
            Console.WriteLine("Displayed {0} elements.\n", DisplayArray(doubleArray, 2, 4));

            // demo overloaded DisplayArray() with charArray
            Console.WriteLine("DisplayArray(charArray, 0, 5):");
            Console.WriteLine("Displayed {0} elements.\n", DisplayArray(charArray, 0, 5));
            Console.WriteLine("DisplayArray(charArray, 0, 2):");
            Console.WriteLine("Displayed {0} elements.\n", DisplayArray(charArray, 0, 2));

            // hold
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // code from book
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (T element in inputArray)
                Console.Write(element + " ");

            Console.WriteLine("\n");
        }
        // end code from book

        // overloaded DisplayArray()
        private static int DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {
            int elementCount = 0;

            try
            {
                // validation
                if (lowIndex < 0 || highIndex > (inputArray.Length - 1) || lowIndex >= highIndex)
                    throw new InvalidIndexException("An index value is invalid."); // throw custom exception
                else
                {
                    for (int i = lowIndex; i <= highIndex; ++i)
                    {
                        Console.Write(inputArray[i] + " ");
                        ++elementCount;
                    }
                    Console.Write("\n");
                }
            }
            catch (InvalidIndexException e)
            {
                Console.WriteLine(e.Message);
            }

            // return number of elements displayed
            return elementCount;
        }
    }
}
