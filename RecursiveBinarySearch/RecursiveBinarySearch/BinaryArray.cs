using System;

namespace RecursiveBinarySearch
{
    class BinaryArray
    {
        // // not altered from book
        private int[] data;
        private static Random generator = new Random();

        // property, added to provide public scope
        public int Location { get; set; }

        // not altered from book
        public BinaryArray(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = generator.Next(10, 100);
            Array.Sort(data);
            Location = -1;
        }

        // not altered from book unless noted
        public int BinarySearch(int searchElement)
        {
            int low = 0;
            int high = data.Length - 1;
            int middle = (low + high + 1) / 2;
            Location = -1; // changed from variable to property

            do
            {
                Console.Write(RemainingElements(low, high));
                for (int i = 0; i < middle; i++)
                    Console.Write("   ");
                Console.WriteLine(" * ");
                if (searchElement == data[middle])
                    Location = middle;
                else if (searchElement < data[middle])
                    high = middle - 1;
                else
                    low = middle + 1;
                middle = (low + high + 1) / 2;
            } while ((low <= high) && (Location == -1));
            return Location;
        }

        // performs binary search recursively
        public int RecursiveBinarySearch(int searchElement, int startIndex, int endIndex)
        {
            int low = startIndex;
            int high = endIndex;
            int middle = (startIndex + endIndex + 1) / 2;

            if ((low <= high) && (Location == -1))
            {
                Console.WriteLine(RemainingElements(low, high));
                for (int i = 0; i < middle; i++)
                    Console.Write("   ");
                Console.WriteLine(" * ");
                if (searchElement == data[middle])
                    Location = middle;
                else if (searchElement < data[middle])
                    RecursiveBinarySearch(searchElement, low, (middle - 1));
                else
                    RecursiveBinarySearch(searchElement, (middle + 1), high);
            }
            return Location;
        }

        // not altered from book
        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;

            for (int i = 0; i < low; i++)
                temporary += "   ";
            for (int i = low; i <= high; i++)
                temporary += data[i] + " ";
            temporary += "\n";
            return temporary;
        }

        // not altered from book
        public override string ToString()
        {
            return RemainingElements(0, data.Length - 1);
        }
    }
}
