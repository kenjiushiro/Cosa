using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FileDoesNotExist : Exception
    {
        public FileDoesNotExist(string message) : base(message)
        {
        }

        public FileDoesNotExist(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
