using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace biblioteca.Infrastructure.Exceptions
{
    public class PrestamoException : Exception
    {
        public PrestamoException(string message) : base(message) 
        {
        }
    }
}
