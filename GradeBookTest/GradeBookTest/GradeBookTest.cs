using System;

namespace CSharpGradeBook
{
    class GradeBookTest
    {
        static void Main(string[] args)
        {
            GradeBook gradeBook1 = new GradeBook("CS101, Introduction to C# Programming", "Chris McCauley");
            GradeBook gradeBook2 = new GradeBook("CS102, Data Structures in C#", "Chris McCauley");

            gradeBook1.DisplayMessage();
            gradeBook2.DisplayMessage();

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
