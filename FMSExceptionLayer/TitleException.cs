using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSExceptionLayer
{
    public class TitleException : Exception
    {
        public TitleException() { }
        public TitleException(string message) : base(message)
        {

        }

    }
}
