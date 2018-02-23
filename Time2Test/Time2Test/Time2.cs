namespace Time2Test
{
    public class Time2
    {
        // declaration
        private int second;

        // properties
        public int Second
        {
            get => second % 60;
            private set => second = value;
        }

        public int Minute
        {
            get => ((second - (second % 60) - ((second / 3600) * 3600)) / 60);
        }

        public int Hour
        {
            get => second / 3600;
        }

        // constructor
        public Time2( int h, int m, int s )
        {
            SetTime(h, m, s);
        }

        // constructor
        public Time2() : this(0, 0, 0) { }

        // constructor
        public Time2(int h) : this(h, 0, 0) { }

        // constructor
        public Time2(int h, int m ) : this (h, m, 0) { }

        // constructor
        public Time2(Time2 time) : this (time.Hour, time.Minute, time.Second) { } // seconds

        // sets the time from midnight using seconds from midnight
        public void SetTime( int h, int m, int s )
        {
            Second = ((h >= 0 && h < 24) ? (h * 3600) : 0) // hours
                + ((m >= 0 && m < 60) ? (m * 60) : 0) // minutes
                + ((s >= 0 && s < 60) ? s : 0); // seconds
        }

        // 24 hour string representation of time
        public string ToUniversalString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
        }

        // 12 hour string representation of time
        public override string ToString()
        {
            return string.Format("{0}:{1:D2}:{2:D2} {3}", 
                ((Hour == 0 || Hour == 12) ? 12 : (Hour % 12)), Minute, Second, (Hour < 12 ? "AM" : "PM"));
        }
    }
}
