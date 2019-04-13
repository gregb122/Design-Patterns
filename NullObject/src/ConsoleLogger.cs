using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.src
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
