using Command.src.Interfaces;
using Command.src.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.Commands
{
    class CreateFileCommand : ICommand
    {
        private FileMenager _fileMenager;
        private readonly string _pathTo;
        public CreateFileCommand(FileMenager fileMenager, string pathTo)
        {
            _fileMenager = fileMenager;
            _pathTo = pathTo;
        }
        public void Execute()
        {
            _fileMenager.CreateFile(_pathTo);
        }

        public void UnExecute()
        {
            _fileMenager.DeleteFile(_pathTo);
        }
    }
}
