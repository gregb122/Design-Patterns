using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.Receivers
{
    class FileMenager
    {
        public void CopyFile(string from, string to)
        {
            Console.WriteLine("Kopiowanie pliku  " + from + " do " + to);
        }

        public void DeleteFile(string path)
        {
            Console.WriteLine("Usuwanie pliku  " + path);
        }

        public void CreateFile(string path)
        {
            Console.WriteLine("Tworzenie i wypełnianie pliku " + path);
        }

        public void DownloadFTP(string address, string pathTo)
        {
            Console.WriteLine("Pobieranie pliku FTP: " + address + " do " + pathTo);
        }

        public void DownloadHTTP(string address, string pathTo)
        {
            Console.WriteLine("Pobieranie pliku HTTP: " + address + " do " + pathTo);
        }
    }
}
