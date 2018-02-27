using System;

namespace StackTest
{
    class Program
    {
        // altered declarations
        private static double[] doubleElements = new double[5];
        private static int[] intElements = new int[5];
        private static StackTest.Stack<double> doubleStack;
        private static StackTest.Stack<int> intStack;

        static void Main(string[] args)
        {
            // altered assignments
            doubleStack = new Stack<double>(5);
            intStack = new Stack<int>(5);

            // get inputs
            for (int i = 0; i < doubleElements.Length; ++i)
            {
                Console.Write("Enter a value of type double: ");
                doubleElements[i] = Double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < intElements.Length; ++i)
            {
                Console.Write("Enter a value of type int: ");
                intElements[i] = Int32.Parse(Console.ReadLine());
            }

            // from book
            TestPushDouble();
            TestPopDouble();
            TestPushInt();
            TestPopInt();

            // hold
            Console.ReadKey();
        }

        // rest of code from book
        private static void TestPushDouble()
        {
            try
            {
                Console.WriteLine("\nPushing elements onto doubleStack");
                foreach (var element in doubleElements)
                {
                    Console.Write("{0:F1} ", element);
                    doubleStack.Push(element);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("Message: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        private static void TestPopDouble()
        {
            try
            {
                Console.WriteLine("\nPopping elements from doubleStack");
                double popValue;
                while (true)
                {
                    popValue = doubleStack.Pop();
                    Console.Write("{0:F1} ", popValue);
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("Message: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        private static void TestPushInt()
        {
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");
                foreach (var element in intElements)
                {
                    Console.Write("{0} ", element);
                    intStack.Push(element);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("Message: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
            }
        }

        private static void TestPopInt()
        {
            try
            {
                Console.WriteLine("\nPopping elements from intStack");
                int popValue;
                while (true)
                {
                    popValue = intStack.Pop();
                    Console.Write("{0} ", popValue);
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine();
                Console.Error.WriteLine("Message: " + exception.Message);
                Console.Error.WriteLine(exception.StackTrace);
            }
        }
    }
}
