using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ICT3101
{
    public class FileReader : IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
