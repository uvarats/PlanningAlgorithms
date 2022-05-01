using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task4_OS.Utils;

namespace Task5_OS
{
    public abstract class AbstractManager
    {
        public int Quant { get; set; }
        public Queue<Process> Processes { get; protected set; }
        protected Thread innerThread;
        protected ManualResetEvent mre;
        protected Logger logger;

        public bool ExecutionState
        {
            get
            {
                return mre.WaitOne(0);
            }
        }
        public AbstractManager(int oneQuantMiliseconds, Logger logger)
        {
            Processes = new Queue<Process>();
            Quant = oneQuantMiliseconds;
            mre = new ManualResetEvent(true);
            this.logger = logger;
        }
        public abstract void Start();
        public void AddProcess(Process p)
        {
            Console.WriteLine($"Новый процесс {p.Id} добавлен в очередь.");
            Processes.Enqueue(p);
        }
        public void Pause()
        {
            mre.Reset();
        }
        public void Resume()
        {
            mre.Set();
        }
    }
}
