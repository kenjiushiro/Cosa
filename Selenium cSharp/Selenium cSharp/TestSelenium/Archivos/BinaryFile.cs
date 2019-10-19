using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using Excepciones;

namespace Archivos
{
    public class BinaryFile<T> : AppDataFile<T>
    {
        #region Constructores
        private BinaryFile() : base()
        {
        }

        public BinaryFile(string fileName) : base(fileName)
        {
        }
        public BinaryFile(string folderName, string fileName) : base(folderName, fileName)
        {
        }
        #endregion

        public override T ReadFile()
        {
            Directory.CreateDirectory(this.Directoryi);
            BinaryFormatter ser;

            if (File.Exists(this.FullPath))
            {
                using (FileStream fs = new FileStream(this.FullPath, FileMode.Open))
                {
                    ser = new BinaryFormatter();
                    T data = (T)ser.Deserialize(fs);
                    return data;
                }
            }
            else
            {
                File.Create(this.FullPath).Close();
                throw new FileDoesNotExist("No se encontro el file " + this.FullPath);
            }
        }


        public override void WriteFile(T data)
        {
            if (!File.Exists(this.FullPath))
                File.Create(this.FullPath).Close();

            BinaryFormatter ser;
            using (FileStream fs = new FileStream(this.FullPath, FileMode.Open))
            {
                ser = new BinaryFormatter();
                ser.Serialize(fs, data);
                fs.Close();
            }
        }


    }
}
