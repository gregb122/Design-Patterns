using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.src
{
    class NullLogger : ILogger
    {
        public void Log(string message) { }
    }
}
