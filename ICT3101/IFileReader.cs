using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ICT3101
{
    public interface IFileReader
    {
        string[] Read(string path);
    }
}
