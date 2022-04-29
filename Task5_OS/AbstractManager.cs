using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task5_OS
{
    public abstract class AbstractManager
    {
        protected int oneQuantMiliseconds;
        public Queue<Process> Processes { get; protected set; }
        protected Thread innerThread;
        protected ManualResetEvent mre;

        public bool ExecutionState
        {
            get
            {
                return mre.WaitOne(0);
            }
        }
        public AbstractManager(int oneQuantMiliseconds)
        {
            Processes = new Queue<Process>();
            this.oneQuantMiliseconds = oneQuantMiliseconds;
            mre = new ManualResetEvent(true);
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
