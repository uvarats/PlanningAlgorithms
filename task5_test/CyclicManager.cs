using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task5_OS;

namespace Task5_OS
{
    public class CyclicManager
    {
        private int oneQuantMiliseconds;
        private Queue<Process> processes;
        private Thread innerThread;

        public CyclicManager(int oneQuantMiliseconds)
        {
            processes = new Queue<Process>();
            this.oneQuantMiliseconds = oneQuantMiliseconds;
        }

        public void Start()
        {
            if (innerThread == null)
            {
                innerThread = new Thread(() =>
                {
                    while (true)
                    {
                        Process nextProcess;

                        processes = new Queue<Process>(processes.OrderBy(p => p.RemainingTime));

                        if (processes.TryDequeue(out nextProcess))
                        {
                            nextProcess.Execute();
                            Thread.Sleep(oneQuantMiliseconds);
                            if (nextProcess.RemainingTime > 0 && nextProcess.RemainingTime <= 10)
                            {
                                Thread.Sleep((int)nextProcess.RemainingTime);
                                continue;
                            }
                            if (nextProcess.ThreadState != ThreadState.Stopped)
                            {
                                nextProcess.Pause();
                                processes.Enqueue(nextProcess);
                                Console.WriteLine($"Процесс {nextProcess.Id} не успел завершить выполнение за 1 квант и был перемещен в конец очереди.");
                            }
                        }
                    }
                });
                innerThread.Start();
            }
        }
        public void AddProcess(Process p)
        {
            Console.WriteLine($"Новый процесс {p.Id} добавлен в очередь.");
            processes.Enqueue(p);
        }
    }
}
