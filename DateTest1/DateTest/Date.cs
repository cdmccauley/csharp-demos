using System;

namespace DateTest
{
    class Date
    {
        // properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // constructor
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // return string representation of date
        public string DisplayDate()
        {
            return (Month.ToString() + "/" + Day.ToString() + "/" + Year.ToString());
        }
    }
}
