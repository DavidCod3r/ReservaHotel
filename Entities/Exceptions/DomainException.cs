using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
