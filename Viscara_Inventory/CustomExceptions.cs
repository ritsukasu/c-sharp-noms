using System;

namespace Viscara_Inventory
{
    class NumberFormatException : Exception
    {
        public NumberFormatException(string varName) : base(varName) { }
    }

    class StringFormatException : Exception
    {
        public StringFormatException(string varName) : base(varName) { }
    }

    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string varName) : base(varName) { }
    }
}
