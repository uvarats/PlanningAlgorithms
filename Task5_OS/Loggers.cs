using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4_OS.Utils;

namespace Task5_OS
{
    public class Loggers
    {
        private static Loggers instance;
        public static Loggers Instance
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }
                throw new NullReferenceException();
            }
        }
        public Logger CyclicLogger { get; private set; }
        public Logger PriorityLogger { get; private set; }
        private Loggers(Logger cyclicLogger, Logger priorityLogger)
        {
            CyclicLogger = cyclicLogger;
            PriorityLogger = priorityLogger;
        }
        public static Loggers Initialize(Logger cyclicLogger, Logger priorityLogger)
        {
            instance ??= new Loggers(cyclicLogger, priorityLogger);
            return instance;
        }

    }
}
