using System;
using System.Collections.Generic;
using System.Text;

namespace FirstNameSort
{
    class SomeException : Exception
    {
        public SomeException()
        { }
        public SomeException(string message) : base(message)
        { }
    }
}
