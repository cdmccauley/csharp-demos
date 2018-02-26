using System;
using StackInheritanceLibrary;
using static LinkedListLibrary.ListNode;

namespace StackInheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StackInheritance stack = new StackInheritance();

            for (int i = 0; i < 5; ++i)
            {
                Console.Write("Enter a value: ");
                var userInput = Console.ReadLine();
                stack.Push(userInput);
                stack.Display();
            }

            try
            {
                while (true)
                {
                    object removedObject = stack.Pop();
                    Console.WriteLine(removedObject + " popped");
                    stack.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine(emptyListException);
            }

            // hold
            Console.ReadKey();
        }
    }
}
