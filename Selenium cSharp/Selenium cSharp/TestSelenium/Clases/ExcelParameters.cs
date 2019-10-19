using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
    public class ExcelParameters
    {
        private string path;
        private string sheetName;
        private int headerRow;
        private ExcelParameters()
        {

        }

        public ExcelParameters(string path, string sheetname, int headerRow)
        {
            this.path = path;
            this.sheetName = sheetname;
            this.headerRow = headerRow;
        }

        public ExcelParameters(string path, string sheetname) : this(path, sheetname, 1)
        {

        }

        public string Path
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }

        public string SheetName
        {
            get
            {
                return this.sheetName;
            }
            set
            {
                this.sheetName = value;

            }
        }

        public int HeaderRow
        {
            get
            {
                return this.headerRow;
            }
            set
            {
                this.headerRow = value;
            }
        }


    }
}
