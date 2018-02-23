using System;

namespace GasMileage
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("NegativeNumberException Exception")
        {
            // uses base class constructor
        }

        public NegativeNumberException(string messageValue) : base(messageValue)
        {
            // uses base class constructor
        }

        public NegativeNumberException(string messageValue, Exception inner) : base(messageValue, inner)
        {
            // uses base class constructor
        }
    }
}
