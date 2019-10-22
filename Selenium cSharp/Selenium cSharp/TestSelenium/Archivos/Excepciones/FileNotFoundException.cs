using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos.Excepciones
{
    class FileNotFoundException:Exception
    {
        public FileNotFoundException(string message) : base(message)
        {
        }
        public FileNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}

