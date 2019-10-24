using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            if(!File.Exists(path))
                throw new FileNotFoundException("The file " + path + " could not be found.");
            else
            {

                try
                {
                    wb = excel.Workbooks.Open(path);
                }
                catch(Exception e)
                {
                    Debug.Print(e.Message);
                    throw new WorkbookNotFound("The workbook " + this.path + " could not be opened.");
                }

                try
                {
                    sh = wb.Worksheets[sheet];
                }
                catch
                {
                    this.Close();
                    throw new WorksheetNotFound("The worksheet " + sheet  + " could not be found");
                }
            }

        }


        private int GetSheetIndex(string sheetName)
        {
            int retorno = -1;

            foreach(Worksheet ws in wb.Worksheets)
            {
                Debug.WriteLine(ws.Name);
                if (ws.Name == sheetName)
                {
                    retorno = ws.Index;
                }
            }
            return retorno;

        }
        public string Range(long row, long col)
        {
            return sh.Cells[row, col].Value + "";
        }

        public void Close()
        {
            try
            {
               Marshal.ReleaseComObject(sh);
            }
            catch(Exception ex)
            {

            }
            try
            {
                //WRITE close and release
                wb.Close();
                Marshal.ReleaseComObject(wb);
                //!WRITE quit and release
                excel.Quit();
                Marshal.ReleaseComObject(excel);
                //cleanup
                Debug.Print("Empezo collect");
                GC.Collect();
                Debug.Print("Termino Collect");
                GC.WaitForPendingFinalizers();
                Debug.Print("Termino pending finalizers");
            }
            catch(Exception)
            {

            }
        }

        







    }
}
