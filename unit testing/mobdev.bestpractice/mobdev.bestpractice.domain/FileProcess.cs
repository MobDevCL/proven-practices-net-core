using System;
using System.IO;

namespace mobdev.bestpractice.domain
{
    public class FileProcess
    {
        public bool FileExist(string fileName)
        {
            if (fileName == "")
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
