using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Exceptions
{
    public class StackOverFlowException : StackException
    {
        public StackOverFlowException(string message) : base(message)
        {
        }
    }
}
