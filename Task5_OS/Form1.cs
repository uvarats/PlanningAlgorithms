using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_OS
{
    public partial class MainForm : Form
    {
        private CyclicManager cyclicManager;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            addProcess.Click += addProcess_Click;
            startExecuting.Click += startExecuting_Click;
            pauseExecuting.Click += pauseExecuting_Click;
            cyclicManager = new CyclicManager(500);
            cyclicManager.AddProcess(new Process(750));
            cyclicManager.AddProcess(new Process(1000));
            cyclicManager.AddProcess(new Process(200));
            cyclicManager.AddProcess(new Process(100));
            cyclicManager.AddProcess(new Process(500));
            cyclicManager.AddProcess(new Process(2000));

            queueGrid.DataSource = cyclicManager.Processes.ToList();
            Thread t = new Thread(() =>
            {
                while (true)
                {
                    queueGrid.BeginInvoke(new Action(() =>
                    {
                        queueGrid.DataSource = cyclicManager.Processes.ToList();
                    }));
                    Thread.Sleep(500);
                }
            });
            t.Start();

            Thread.Sleep(3000);

            cyclicManager.AddProcess(new Process(300));
            cyclicManager.AddProcess(new Process(888));
        }
        private void addProcess_Click(object sender, EventArgs e)
        {
            cyclicManager.AddProcess(new Process(Convert.ToInt64(executionTime.Value)));
        }

        private void startExecuting_Click(object sender, EventArgs e)
        {
            cyclicManager.Start();
        }

        private void pauseExecuting_Click(object sender, EventArgs e)
        {
            if (cyclicManager.ExecutionState)
            {
                cyclicManager.Pause();
            } else
            {
                cyclicManager.Resume();
            }
            pauseExecuting.Text = cyclicManager.ExecutionState ? "Приостановить выполнение" : "Возобновить выполнение";
        }
    }
}
