using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Exceptions
{
    public class ItemValueException : StackException
    {
        public ItemValueException(string message) : base(message)
        {
        }
    }
}
