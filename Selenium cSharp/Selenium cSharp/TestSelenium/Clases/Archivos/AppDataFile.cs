using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public abstract class AppDataFile<T>
    {
        private string directory;
        private string fileName;
        private string folderName;
        
        #region Constructores
        protected AppDataFile()
        {
            directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        }

        protected AppDataFile(string fileName) : this()
        {
            this.fileName = fileName;
        }
        protected AppDataFile(string folderName, string fileName) : this(fileName)
        {
            this.folderName = folderName;
            this.directory = Path.Combine(directory, folderName);
        }
        #endregion

        #region Properties

        public string Directoryi
        {
            get
            {
                return this.directory;
            }
            set
            {
                this.directory = value;
            }
        }

        public string FolderName
        {
            get
            {
                return this.folderName;
            }
            set
            {
                this.folderName = value;
            }
        }
        public string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }

        public string FullPath
        {
            get
            {
                return Path.Combine(this.Directoryi, this.FileName);
            }
        }
        #endregion

        #region Methods
        public abstract T ReadFile();

        public abstract void WriteFile(T datos);
        #endregion




    }
}
