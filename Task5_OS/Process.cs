using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task4_OS.Utils;

namespace Task5_OS
{
    public class Process
    {
        private static int id = 1;
        private long executionTime; //in miliseconds
        private Thread executionThread;
        private Stopwatch sw;
        private ManualResetEvent mre;
        private int priority;
        private Logger logger;
        public static int upperPriority = 3;

        public int Id { get; set; }
        public int Priority 
        { 
            get => priority;
            set {
                if (value >= 0 && value <= upperPriority)
                {
                    priority = value;
                }
            }
        }
        public long RemainingTime
        {
            get
            {
                return executionTime - sw.ElapsedMilliseconds;
            }
        }
        //public bool IsAlive
        //{
        //    get
        //    {
        //        return executionThread != null ? executionThread.IsAlive : false;
        //    }
        //}
        public System.Threading.ThreadState ThreadState
        {
            get
            {
                return executionThread != null ?
                    executionThread.ThreadState :
                    System.Threading.ThreadState.Unstarted;
            }
        }
        public Process(long executionTime, int priority, Logger logger)
        {
            Id = id++;
            this.executionTime = executionTime;
            Priority = priority;
            this.logger = logger;
            mre = new ManualResetEvent(true);
            sw = new Stopwatch();
        }
        public Process(long executionTime, Logger logger) : this(executionTime, 50, logger) { }
        public void Execute()
        {
            if (executionThread == null)
            {
                InitializeThread();

                executionThread.Start();
            }
            else if (executionThread.IsAlive && executionThread.ThreadState == System.Threading.ThreadState.WaitSleepJoin)
            {
                mre.Set();
                sw.Start();
                logger.Log($"Процесс {Id} возобновил свою работу. Оставшееся время выполнения {RemainingTime} мс.");
            }
        }

        public void Pause()
        {
            sw.Stop();
            mre.Reset();
            logger.Log($"Процесс {Id} приостановлен. Время выполнения {sw.ElapsedMilliseconds} мс.");
        }
        private void InitializeThread()
        {
            executionThread = new Thread(() =>
            {
                sw.Start();
                logger.Log($"Процесс {Id} начал свою работу. Ожидаемое время выполнения: {executionTime}.");
                while (true)
                {
                    Thread.Sleep(10);
                    if (sw.ElapsedMilliseconds >= executionTime)
                    {
                        logger.Log($"Процесс {Id} завершил свое выполнение. Время выполнения: {sw.ElapsedMilliseconds} мс.");
                        sw.Stop();
                        return;
                    }
                    mre.WaitOne();
                }
            });
        }
    }
}
