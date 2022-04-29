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
        private Label label;

        public Logger(Label label)
        {
            this.label = label;
        }
        public void Log(string message, Color color)
        {
            if (label.InvokeRequired)
            {
                label.BeginInvoke(
                    new Action(() =>
                        {
                            label.Text = message;
                            label.ForeColor = color;
                        }
                    )
                );
            }
            else
            {
                label.Text = message;
                label.ForeColor = color;
            }

        }
    }
}
