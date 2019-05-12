using Command.src.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.src
{
    class Invoker
    {
        public int QueueSize { get; set; } = 20;
        private Queue<ICommand> queue = new Queue<ICommand>();

        public void AddCommand(ICommand command)
        {
                queue.Enqueue(command);
        }

        public ICommand GetCommand()
        {
            return queue.Dequeue();
        }
    }
}
