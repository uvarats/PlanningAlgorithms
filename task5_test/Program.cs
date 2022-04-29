using System;
using System.Collections.Generic;
using System.Threading;

namespace Task5_OS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CyclicManager cyclicManager = new CyclicManager(500);
            cyclicManager.AddProcess(new Process(750));
            cyclicManager.AddProcess(new Process(1000));
            cyclicManager.AddProcess(new Process(200));
            cyclicManager.AddProcess(new Process(100));
            cyclicManager.AddProcess(new Process(500));
            cyclicManager.AddProcess(new Process(2000));
            

            cyclicManager.Start();

            Thread.Sleep(3000);

            //cyclicManager.AddProcess(new Process(300));
            //cyclicManager.AddProcess(new Process(888));
        }
    }
}
