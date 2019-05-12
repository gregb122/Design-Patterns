using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src.Interfaces
{
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
