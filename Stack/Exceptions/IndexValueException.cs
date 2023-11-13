using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Exceptions
{
    public class IndexValueException : StackException
    {
        public IndexValueException(string message) : base(message)
        {
        }
    }
}
