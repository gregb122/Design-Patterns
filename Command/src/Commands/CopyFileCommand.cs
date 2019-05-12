using Command.src.Interfaces;
using Command.src.Receivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.Commands
{
    class CopyFileCommand : ICommand
    {
        private FileMenager _fileMenager;
        private readonly string _pathFrom;
        private readonly string _pathTo;
        public CopyFileCommand(FileMenager fileMenager, string pathFrom, string pathTo)
        {
            _fileMenager = fileMenager;
            _pathFrom = pathFrom;
            _pathTo = pathTo;
        }

        public void Execute()
        {
            _fileMenager.CopyFile(_pathFrom, _pathTo);
        }

        public void UnExecute()
        {
            _fileMenager.DeleteFile(_pathTo);
        }
    }
}
