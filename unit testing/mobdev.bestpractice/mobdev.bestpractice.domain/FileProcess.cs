using System;
using System.IO;

namespace mobdev.bestpractice.domain
{
    public class FileProcess
    {
        private string name;
        public FileProcess(string name)
        {
            this.name = name;
        }

        public bool FileExist(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(fileName);
            
        }

        public bool ValidRows(string fileName)
        {
            return false;
        }
    }
}
