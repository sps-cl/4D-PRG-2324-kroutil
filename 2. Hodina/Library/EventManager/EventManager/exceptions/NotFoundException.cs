using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message = "Člověk nebyl nalezena") : base(message) { }
    }
}
