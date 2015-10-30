using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraNaMe4ove.Exceptions
{
    class ObjectOutOfMapException : Exception
    {
        public ObjectOutOfMapException(string message) : base(message)
        {

        }
    }
}
