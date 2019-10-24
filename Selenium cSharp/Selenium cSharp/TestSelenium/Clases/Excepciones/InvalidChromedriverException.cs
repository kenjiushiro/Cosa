using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Excepciones
{
    public class InvalidChromedriverException:Exception
    {
        public InvalidChromedriverException(string message) : base(message)
        {
        }

        public InvalidChromedriverException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
