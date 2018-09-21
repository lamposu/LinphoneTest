using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinphoneWrapper
{
    /// <summary>
    /// All methods that returns a LinphoneStatus with a value != 0 as an error code in C are translated in C# by throwing a LinphoneException
    /// </summary>
    public class LinphoneException : Exception
    {
        public LinphoneException() : base() { }
        public LinphoneException(string message) : base(message) { }
        public LinphoneException(string message, System.Exception inner) : base(message, inner) { }
    }
}
