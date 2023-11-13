using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Exceptions
{
    public class StackUnderflowException : StackException
    {
        public StackUnderflowException(string message) : base(message)
        {
        }
    }
}
