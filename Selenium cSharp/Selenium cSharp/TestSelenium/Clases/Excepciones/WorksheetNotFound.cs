using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class WorksheetNotFound : Exception
    {
        public WorksheetNotFound(string message) : base(message)
        {
        }

        public WorksheetNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
