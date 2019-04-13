using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject.src
{
    public enum LogType { None, Console, File }

    class LoggerFactory
    {
        public static readonly object padlock = new object();
        public static LoggerFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (Instance == null)
                    {
                        Instance = new LoggerFactory();
                    }
                    return Instance;
                }
            }
            private set
            {
                Instance = value;
            }
        }

        public static ILogger GetLogger(LogType LogType, string Parameters = null)
        {
            switch(LogType)
            {
                case LogType.Console:
                    return new ConsoleLogger();
                case LogType.File:
                    return new FileLogger(Parameters);
                default:
                    return new NullLogger();
            }
        }
    }
}
