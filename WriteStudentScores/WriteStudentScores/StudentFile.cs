using System.Collections.Generic;

namespace WriteStudentScores
{
    class StudentFile
    {
        // declarations
        public List<StudentRecord> studentRecords;

        // constructor
        public StudentFile()
        {
            studentRecords = new List<StudentRecord>();
        }

        // inner class, represents single record in file
        public class StudentRecord : StudentFile // derived class
        {
            // declarations
            private string firstName, lastName, className, classNum, classGrade;

            // properties
            public string FirstName
            {
                get => firstName;
                private set => firstName = value;
            }

            public string LastName
            {
                get => lastName;
                private set => lastName = value;
            }

            public string ClassName
            {
                get => className;
                private set => className = value;
            }

            public string ClassNum
            {
                get => classNum;
                private set => classNum = value;
            }

            public string ClassGrade
            {
                get => classGrade;
                private set => classGrade = value;
            }

            // constructor
            public StudentRecord(string first, string last, string cname, string cnum, string cgrade)
            {
                FirstName = first;
                LastName = last;
                ClassName = cname;
                ClassNum = cnum;
                ClassGrade = cgrade;
            }

            // tostring override
            public override string ToString()
            {
                return string.Format("{0}, {1}, {2}, {3}, {4}", FirstName, LastName, ClassName, ClassNum, ClassGrade);
            }
        }
    }
}
