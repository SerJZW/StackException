using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Exceptions
{
    internal class NullException : StackException
    {
        public NullException(string message) : base(message)
        {
        }
    }
}
