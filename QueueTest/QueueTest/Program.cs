using System;
using static LinkedListLibrary.ListNode;
using QueueInheritanceLibrary;

namespace QueueTest
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueInheritance queue = new QueueInheritance();

            for (int i = 0; i < 5; ++i)
            {
                Console.Write("Enter a value: ");
                var userInput = Console.ReadLine();
                queue.Enqueue(userInput);
                queue.Display();
            }

            object removedObject = null;

            try
            {
                while (true)
                {
                    removedObject = queue.Dequeue();
                    Console.WriteLine(removedObject + " dequeued");
                    queue.Display();
                }
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine(emptyListException.StackTrace);
            }

            // hold
            Console.ReadKey();
        }
    }
}
