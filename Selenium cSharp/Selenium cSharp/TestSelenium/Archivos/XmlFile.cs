using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class XmlFile<T> : AppDataFile<T>
    {
        #region Constructores
        private XmlFile() : base()
        {
        }

        public XmlFile(string fileName) : base(fileName)
        {
        }
        public XmlFile(string folderName, string fileName) : base(folderName, fileName)
        {
        }
        #endregion

        public override T ReadFile()
        {
            Directory.CreateDirectory(this.Directoryi);
            

            if (File.Exists(this.FullPath))
            {
                StreamReader xmlReader = new StreamReader(this.FullPath);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                T data = (T)serializer.Deserialize(xmlReader);
                return data;
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
            
            StreamReader xmlReader = new StreamReader(this.FullPath);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(this.FullPath);
            serializer.Serialize(writer,data);
        }

    }
}
