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
        private PriorityManager priorityManager;
        public MainForm()
        {
            cyclicManager = new CyclicManager(500);
            priorityManager = new PriorityManager(500);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            addProcess.Click += addProcess_Click;
            startExecuting.Click += startExecuting_Click;
            pauseExecuting.Click += pauseExecuting_Click;

            queueGrid.DataSource = cyclicManager.Processes.ToList();
            priorityGrid.DataSource = priorityManager.Processes.ToList();
            Thread t = new Thread(() =>
            {
                while (true)
                {
                    queueGrid.BeginInvoke(new Action(() =>
                    {
                        queueGrid.DataSource = cyclicManager.Processes.ToList();
                    }));
                    priorityGrid.BeginInvoke(new Action(() =>
                    {
                        priorityGrid.DataSource = priorityManager.Processes.ToList();
                    }));
                    Thread.Sleep(500);
                }
            });
            t.Start();
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
            if (sender is Button b)
            {
                if (cyclicManager.ExecutionState)
                {
                    cyclicManager.Pause();
                }
                else
                {
                    cyclicManager.Resume();
                }
                b.Text = cyclicManager.ExecutionState ? "Приостановить выполнение" : "Возобновить выполнение";
            }
        }

        private void priorityStart_Click(object sender, EventArgs e)
        {
            priorityManager.Start();
        }

        private void priorityPause_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                if (priorityManager.ExecutionState)
                {
                    priorityManager.Pause();
                }
                else
                {
                    priorityManager.Resume();
                }
                b.Text = cyclicManager.ExecutionState ? "Приостановить выполнение" : "Возобновить выполнение";
            }
        }

        private void priorityAdd_Click(object sender, EventArgs e)
        {
            priorityManager.AddProcess
                (
                    new Process
                    (
                        Convert.ToInt64(priorityTime.Value),
                        Convert.ToInt32(processPriority.Value)
                    )
                );
        }
    }
}
