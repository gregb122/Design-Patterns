using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NullObject.src
{
    class FileLogger : ILogger
    {
        string FilePath { get; set; }
        public FileLogger(string filePath)
        {
            FilePath = filePath;
        }
        public void Log(string message)
        {
            try
            {
                File.WriteAllText(FilePath, message);
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be write:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
