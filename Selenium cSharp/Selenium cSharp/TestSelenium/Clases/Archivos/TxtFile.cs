using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class TxtFile:AppDataFile<string>
    {
        #region Constructores
        private TxtFile():base()
        {
        }

        public TxtFile(string fileName) : base(fileName)
        {
        }
        public TxtFile(string folderName, string fileName):base(folderName,fileName) 
        {
        }
        #endregion

        public override string ReadFile()
        {
            string retorno = "";
            Directory.CreateDirectory(this.Directoryi);
            if (File.Exists(this.FullPath))
            {
                StreamReader sr = new StreamReader(Path.Combine(this.Directoryi, this.FileName));
                retorno = sr.ReadToEnd();
                sr.Close();
            }
            else
                File.Create(this.FullPath).Close();
            return retorno;
        }

        public override void WriteFile(string texto)
        {
            StreamWriter sw = new StreamWriter(this.FullPath);
            sw.Write(texto);
            sw.Close();

        }

    }
}
