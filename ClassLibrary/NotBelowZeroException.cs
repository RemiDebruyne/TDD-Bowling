using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NotBelowZeroException : Exception
    {
        public NotBelowZeroException() { }
        public NotBelowZeroException(string message) : base(message) { }

    }
}
