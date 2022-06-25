using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    //inheriting exceptions
    public class PersonExcpetion : Exception
    {
        public PersonExcpetion() : base() { }
        
        public PersonExcpetion(string message) : base(message) { }

        public PersonExcpetion(string message, Exception innerException) : base(message, innerException) { }
    }
}
