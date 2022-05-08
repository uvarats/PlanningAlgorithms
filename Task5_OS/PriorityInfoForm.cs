using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5_OS
{
    public partial class PriorityInfoForm : Form
    {
        public PriorityInfoForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PriorityInfo priorityInfo = PriorityInfo.Instance;
            priorityInfo.ProcessCount = Convert.ToInt32(processCount.Value);
            priorityInfo.PrioritiesCount = Convert.ToInt32(prioritiesCount.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
