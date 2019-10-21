using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Clases
{
    public class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet sh;

        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            sh = wb.Worksheets[sheet];
        }
        public Excel(string path, string sheet)
        {
            this.path = path;
            try
            {
                wb = excel.Workbooks.Open(path);
            }
            catch
            {
                throw new WorkbookNotFound("The workbook " + this.path + " could not be opened.");
            }

            try
            {
                sh = wb.Worksheets[sheet];
            }
            catch
            {
                throw new WorksheetNotFound("The worksheet " + sheet  + " could not be found");
            }

        }


        private int GetSheetIndex(string sheetName)
        {
            int retorno = -1;

            foreach(Worksheet ws in wb.Worksheets)
            {
                Console.WriteLine(ws.Name);
                if (ws.Name == sheetName)
                {
                    retorno = ws.Index;
                }
            }
            return retorno;

        }
        public string Range(long row, long col)
        {
            return (string)sh.Cells[row, col].Value;
        }

        public void Close()
        {
            wb.Close();
        }

        







    }
}
