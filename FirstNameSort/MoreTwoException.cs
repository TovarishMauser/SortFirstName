using System;
using System.Collections.Generic;
using System.Text;

namespace FirstNameSort
{
    class MoreTwoException : Exception
    {
        public MoreTwoException() { }
        public MoreTwoException(string message):base(message) { }

        MoreTwoException ex = new MoreTwoException("It's mine Exception!");
    }
}
