using System;

namespace RecursiveBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // not altered from book unless noted
            int searchInt;
            int position;

            BinaryArray searchArray = new BinaryArray(15);
            Console.WriteLine(searchArray);
            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (searchInt != -1 )
            {
                // added code
                searchArray.Location = -1;
                position = searchArray.RecursiveBinarySearch(searchInt, 0, 14);
                // end added code

                //position = searchArray.BinarySearch(searchInt);
                if (position == -1)
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("The integer {0} was found in position {1}.\n", searchInt, position);
                Console.Write("Please enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
