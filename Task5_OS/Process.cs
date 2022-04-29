using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        public int Id { get; set; }
        public int Priority 
        { 
            get => priority;
            set {
                if (value >= 10 && value <= 100)
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
        public Process(long executionTime, int priority)
        {
            Id = id++;
            this.executionTime = executionTime;
            Priority = priority;
            mre = new ManualResetEvent(true);
            sw = new Stopwatch();
        }
        public Process(long executionTime) : this(executionTime, 50) { }
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
                Console.WriteLine($"Процесс {Id} возобновил свою работу. Оставшееся время выполнения {RemainingTime} мс.");
            }
        }

        public void Pause()
        {
            sw.Stop();
            mre.Reset();
            Console.WriteLine($"Процесс {Id} приостановлен. Время выполнения {sw.ElapsedMilliseconds} мс.");
        }
        private void InitializeThread()
        {
            executionThread = new Thread(() =>
            {
                sw.Start();
                Console.WriteLine($"Процесс {Id} начал свою работу. Ожидаемое время выполнения: {executionTime}.");
                while (true)
                {
                    Thread.Sleep(10);
                    if (sw.ElapsedMilliseconds >= executionTime)
                    {
                        Console.WriteLine($"Процесс {Id} завершил свое выполнение. Время выполнения: {sw.ElapsedMilliseconds} мс.");
                        sw.Stop();
                        return;
                    }
                    mre.WaitOne();
                }
            });
        }
    }
}
