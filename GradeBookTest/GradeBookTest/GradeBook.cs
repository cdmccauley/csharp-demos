using System;

namespace CSharpGradeBook
{
    class GradeBook
    {
        public string CourseName { get; set; }
        public string CourseInstructor { get; set; }

        public GradeBook(string course, string instructor)
        {
            CourseName = course;
            CourseInstructor = instructor;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for {0}!\nPresented by {1}\n", CourseName, CourseInstructor);
        }
    }
}
