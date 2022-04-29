﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task5_OS
{
    public class PriorityManager : AbstractManager
    {
        public PriorityManager(int oneQuantMiliseconds) : base(oneQuantMiliseconds)
        {
        }

        public override void Start()
        {
            if (innerThread == null)
            {
                innerThread = new Thread(() =>
                {
                    while (true)
                    {
                        mre.WaitOne();

                        Processes = new Queue<Process>(Processes.OrderBy(p => p.Priority).Reverse());

                        Process nextProcess;

                        if (Processes.TryDequeue(out nextProcess))
                        {
                            nextProcess.Execute();
                            Thread.Sleep(oneQuantMiliseconds);
                            if (nextProcess.RemainingTime > 0 && nextProcess.RemainingTime <= 10)
                            {
                                Thread.Sleep((int) nextProcess.RemainingTime);
                                continue;
                            }
                            if (nextProcess.ThreadState != ThreadState.Stopped)
                            {
                                nextProcess.Pause();
                                nextProcess.Priority -= 5;
                                Processes.Enqueue(nextProcess);
                                Console.WriteLine($"Процесс {nextProcess.Id} не успел завершить выполнение за 1 квант, его приоритет был понижен.");
                            }
                        }
                    }
                });
                innerThread.Start();
            }
        }
    }
}
