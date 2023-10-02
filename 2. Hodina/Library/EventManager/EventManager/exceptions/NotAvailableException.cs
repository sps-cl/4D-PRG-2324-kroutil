using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.exceptions
{
    internal class NotAvailableException : Exception
    {
        public NotAvailableException(string message = "Event není dostupný!") : base(message) { }
    }
}
