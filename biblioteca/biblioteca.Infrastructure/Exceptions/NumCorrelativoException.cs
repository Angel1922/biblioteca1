using System;
using System.Collections.Generic;
using System.Text;

namespace biblioteca.Infrastructure.Exceptions
{
    public class NumCorrelativoException : Exception
    {
        public NumCorrelativoException(string message) : base(message)
        {
        }
    }
}
