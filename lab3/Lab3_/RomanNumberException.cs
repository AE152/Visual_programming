using System;

namespace lab3
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException (string message)
            : base(message)
        {}
    }
}
