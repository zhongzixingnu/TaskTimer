using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class MainForm : Form
    {
        private ArrayList taskForms;
        private int taskCount = 0;
        public MainForm()
        {
            InitializeComponent();
            taskForms = new ArrayList();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            taskForms.Add(new TaskForm(this.TaskName.Text, (int)this.ExpectTime.Value));
            Form currentTask = (Form)taskForms[taskCount];
            currentTask.Show();
            ++taskCount;
        }

        private void StopAllTasks_Click(object sender, EventArgs e)
        {
            foreach (Form f in taskForms)
            {
                f.Close();
            }
            taskForms.Clear();
            taskCount = 0;
        }
    }
}
