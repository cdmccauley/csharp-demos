using System;

namespace Time2Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // client code from book
            Time2 t1 = new Time2Test.Time2();
            Time2 t2 = new Time2Test.Time2(2);
            Time2 t3 = new Time2Test.Time2(21, 34);
            Time2 t4 = new Time2Test.Time2(12, 25, 42);
            Time2 t5 = new Time2Test.Time2(27, 74, 99);
            Time2 t6 = new Time2Test.Time2(t4);

            Console.WriteLine("Constructed with:\n");
            Console.WriteLine("t1: all arguments defaulted");
            Console.WriteLine("   {0}", t1.ToUniversalString());
            Console.WriteLine("   {0}\n", t1.ToString());

            Console.WriteLine("t2: hour specified; minute and second defaulted");
            Console.WriteLine("   {0}", t2.ToUniversalString());
            Console.WriteLine("   {0}\n", t2.ToString());

            Console.WriteLine("t3: hour and minute specified; second defaulted");
            Console.WriteLine("   {0}", t3.ToUniversalString());
            Console.WriteLine("   {0}\n", t3.ToString());

            Console.WriteLine("t4: hour, minute and second specified");
            Console.WriteLine("   {0}", t4.ToUniversalString());
            Console.WriteLine("   {0}\n", t4.ToString());

            Console.WriteLine("t5: all invalid values specified");
            Console.WriteLine("   {0}", t5.ToUniversalString());
            Console.WriteLine("   {0}\n", t5.ToString());

            Console.WriteLine("t6: Time2 object t4 specified");
            Console.WriteLine("   {0}", t6.ToUniversalString());
            Console.WriteLine("   {0}\n", t6.ToString());
            // end client code from book

            // hold console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
