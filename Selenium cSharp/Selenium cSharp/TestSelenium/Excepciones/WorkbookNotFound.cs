using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class WorkbookNotFound : Exception
    {
        public WorkbookNotFound(string message) : base(message)
        {
        }

        public WorkbookNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
