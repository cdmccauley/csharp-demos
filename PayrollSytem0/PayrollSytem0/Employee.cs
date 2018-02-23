namespace PayrollSystem0
{
    abstract class Employee // base class
    {
        // declarations
        private Date birthDate;

        // properties
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string SocialSecurityNumber { get; private set; }

        public object BirthDate
        {
            get => birthDate;
            private set => birthDate = (Date)value;
        }

        // constructor
        public Employee(string first, string last, string ssn, string bday)
        {
            char dateDelimiter = '/';
            string[] dateValues = new string[3];

            dateValues = bday.Split(dateDelimiter);
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
            BirthDate = new Date(int.Parse(dateValues[0]), int.Parse(dateValues[1]), int.Parse(dateValues[2]));
        }

        // ToString() override
        public override string ToString()
        {
            return string.Format("{0} {1}\nsocial security number: {2}\nbirth date: {3}", FirstName, LastName, SocialSecurityNumber, BirthDate);
        }

        // return total earned for period
        public abstract decimal Earnings();
    }
}