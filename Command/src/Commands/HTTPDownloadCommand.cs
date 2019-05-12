using Command.src.Interfaces;
using Command.src.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.Commands
{
    class HTTPDownloadCommand : ICommand
    {
        private FileMenager _fileMenager;
        private readonly string _addres;
        private readonly string _pathTo;
        public HTTPDownloadCommand(FileMenager fileMenager, string addres, string pathTo)
        {
            _fileMenager = fileMenager;
            _addres = addres;
            _pathTo = pathTo;
        }

        public void Execute()
        {
            _fileMenager.DownloadHTTP(_addres, _pathTo);
        }

        public void UnExecute()
        {
            _fileMenager.DeleteFile(_pathTo);
        }
    }
}
