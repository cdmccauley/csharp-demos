using System;

namespace PayrollSystem0
{
    class Date // Date class from project DateTest instead of from book
    {
        // declarations
        private int year;
        private int month;
        private int day;
        private static int[] daysPerMonth =
                    { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // property
        public int Year
        {
            get
            {
                return year;
            }
            private set
            {
                if (value >= 1900 && value <= 2200)
                    year = value;
                else
                {
                    Console.WriteLine("Invalid year ({0}) set to 1900.", value);
                    year = 1900;
                }
            }
        }

        // property
        public int Month
        {
            get
            {
                return month;
            }
            private set
            {
                if (value > 0 && value <= 12)
                    month = value;
                else
                {
                    Console.WriteLine("Invalid month ({0}) set to 1.", value);
                    month = 1;
                }
            }
        }

        // property
        public int Day
        {
            get
            {
                return day;
            }
            private set
            {
                if (value > 0 && value <= daysPerMonth[Month])
                    day = value;
                else if (Month == 2 && value == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                    day = value;
                else
                {
                    Console.WriteLine("Invalid day ({0}) set to 1.", value);
                    day = 1;
                }
            }
        }

        // constructor
        public Date(int theMonth, int theDay, int theYear)
        {
            Month = theMonth;
            Year = theYear;
            Day = theDay;
        }

        // increment day by 1
        public void NextDay()
        {
            if (Month == 2 && (Day + 1) == 29 && (Year % 400 == 0 || (Year % 4 == 0 && Year % 100 != 0)))
                ++Day;
            else if ((Day + 1) > daysPerMonth[Month])
            {
                Day = 1;
                if ((Month + 1) > 12)
                {
                    Month = 1;
                    if ((Year + 1) > 2200)
                    {
                        Year = 2200;
                        Month = 12;
                        Day = daysPerMonth[12];
                        Console.WriteLine("Maximum date reached.");
                    }
                    else
                        ++Year;
                }
                else
                    ++Month;
            }
            else
                ++Day;
        }

        // increment day by int numDays
        public void AddDays(int numDays)
        {
            for (int i = 0; i < numDays; ++i)
            {
                NextDay();
                Console.WriteLine(ToString());
            }
        }

        // ToString() override
        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }
    }
}