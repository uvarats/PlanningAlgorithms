using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_OS.Utils
{
    public class Logger
    {
        private ListBox log;
        private static Logger cyclicInstance;
        private static Logger priorityInstance;

        private Logger(ListBox log)
        {
            this.log = log;
        }
        public void Log(string message)
        {
            if (log.InvokeRequired)
            {
                log.BeginInvoke(
                    new Action(() =>
                        {
                            log.Items.Add(message);
                        }
                    )
                );
            }
            else
            {
                log.Items.Add(message);
            }

        }
    }
}
