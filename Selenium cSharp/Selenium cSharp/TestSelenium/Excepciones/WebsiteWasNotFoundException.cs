using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class WebsiteWasNotFoundException : Exception
    {
        public WebsiteWasNotFoundException(string message) : base(message)
        {
        }

        public WebsiteWasNotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
