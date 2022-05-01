using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task5_OS
{
    public class CyclicManager : AbstractManager
    {
        public CyclicManager(int oneQuantMiliseconds) : base(oneQuantMiliseconds, Loggers.Instance.CyclicLogger)
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

                        Process nextProcess;

                        if (Processes.TryDequeue(out nextProcess))
                        {
                            nextProcess.Execute();
                            Thread.Sleep(Quant);
                            if (nextProcess.RemainingTime > 0 && nextProcess.RemainingTime <= 10)
                            {
                                Thread.Sleep((int) nextProcess.RemainingTime);
                                continue;
                            }
                            if (nextProcess.ThreadState != ThreadState.Stopped)
                            {
                                nextProcess.Pause();
                                Processes.Enqueue(nextProcess);
                                logger.Log($"Процесс {nextProcess.Id} не успел завершить выполнение за 1 квант и был перемещен в конец очереди.");
                            }
                        }
                    }
                });
                innerThread.Start();
            }
        }
    }
}
