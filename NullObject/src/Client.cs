using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.src
{
    class Client
    {
        public void LoggerTest()
        {
            ILogger logger1 = LoggerFactory.GetLogger(LogType.File, "C:\foo.txt");
            logger1.Log("foo bar"); // logowanie do pliku

            ILogger logger2 = LoggerFactory.GetLogger(LogType.None);
            logger2.Log("qux"); // brak logowania
        }
    }
}
