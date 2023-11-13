using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Exceptions
{
    internal class CapacityException : StackException
    {
        public CapacityException(string message) : base(message)
        {
        }
    }
}
