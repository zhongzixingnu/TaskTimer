using System;
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
    public partial class TaskForm : Form
    {
        private String m_taskName;
        private int m_taskTime;
        private int m_elapsedTime = 0;
        public TaskForm(String taskName, int taskTime)
        {
            InitializeComponent();
            this.m_taskName = taskName;
            this.m_taskTime = taskTime;
            this.CurrentTaskName.Text = m_taskName;
        }

        private void TaskTimer_Tick(object sender, EventArgs e)
        {
            ++m_elapsedTime;
            if (m_elapsedTime >= m_taskTime * 60)
            {
                this.Notifier.Text = "任务时间到！";
            } else
            {
                int timeLeft = m_taskTime * 60 - m_elapsedTime;
                this.TimeLeft.Text = timeLeft.ToString();
            }
            this.ElapsedTime.Text = m_elapsedTime.ToString();
        }

        private void StopTask_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
