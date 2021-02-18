
namespace TaskTimer
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CurrentTaskName = new System.Windows.Forms.TextBox();
            this.TimeLeft = new System.Windows.Forms.TextBox();
            this.TaskTimer = new System.Windows.Forms.Timer(this.components);
            this.Notifier = new System.Windows.Forms.TextBox();
            this.StopTask = new System.Windows.Forms.Button();
            this.ElapsedTime = new System.Windows.Forms.TextBox();
            this.任务名称标签 = new System.Windows.Forms.Label();
            this.leftTimeLable = new System.Windows.Forms.Label();
            this.elapsedTimeLable = new System.Windows.Forms.Label();
            this.NotifierLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentTaskName
            // 
            this.CurrentTaskName.Location = new System.Drawing.Point(22, 49);
            this.CurrentTaskName.Name = "CurrentTaskName";
            this.CurrentTaskName.Size = new System.Drawing.Size(364, 38);
            this.CurrentTaskName.TabIndex = 0;
            // 
            // TimeLeft
            // 
            this.TimeLeft.Location = new System.Drawing.Point(22, 137);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(100, 38);
            this.TimeLeft.TabIndex = 1;
            // 
            // TaskTimer
            // 
            this.TaskTimer.Enabled = true;
            this.TaskTimer.Interval = 1000;
            this.TaskTimer.Tick += new System.EventHandler(this.TaskTimer_Tick);
            // 
            // Notifier
            // 
            this.Notifier.Location = new System.Drawing.Point(22, 308);
            this.Notifier.Name = "Notifier";
            this.Notifier.Size = new System.Drawing.Size(364, 38);
            this.Notifier.TabIndex = 2;
            // 
            // StopTask
            // 
            this.StopTask.Location = new System.Drawing.Point(22, 371);
            this.StopTask.Name = "StopTask";
            this.StopTask.Size = new System.Drawing.Size(212, 63);
            this.StopTask.TabIndex = 3;
            this.StopTask.Text = "停止任务";
            this.StopTask.UseVisualStyleBackColor = true;
            this.StopTask.Click += new System.EventHandler(this.StopTask_Click);
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.Location = new System.Drawing.Point(22, 221);
            this.ElapsedTime.Name = "ElapsedTime";
            this.ElapsedTime.Size = new System.Drawing.Size(100, 38);
            this.ElapsedTime.TabIndex = 4;
            // 
            // 任务名称标签
            // 
            this.任务名称标签.AutoSize = true;
            this.任务名称标签.Location = new System.Drawing.Point(17, 19);
            this.任务名称标签.Name = "任务名称标签";
            this.任务名称标签.Size = new System.Drawing.Size(120, 27);
            this.任务名称标签.TabIndex = 5;
            this.任务名称标签.Text = "任务名称";
            // 
            // leftTimeLable
            // 
            this.leftTimeLable.AutoSize = true;
            this.leftTimeLable.Location = new System.Drawing.Point(17, 107);
            this.leftTimeLable.Name = "leftTimeLable";
            this.leftTimeLable.Size = new System.Drawing.Size(162, 27);
            this.leftTimeLable.TabIndex = 6;
            this.leftTimeLable.Text = "剩余时间(s)";
            // 
            // elapsedTimeLable
            // 
            this.elapsedTimeLable.AutoSize = true;
            this.elapsedTimeLable.Location = new System.Drawing.Point(17, 191);
            this.elapsedTimeLable.Name = "elapsedTimeLable";
            this.elapsedTimeLable.Size = new System.Drawing.Size(162, 27);
            this.elapsedTimeLable.TabIndex = 7;
            this.elapsedTimeLable.Text = "已用时间(s)";
            // 
            // NotifierLable
            // 
            this.NotifierLable.AutoSize = true;
            this.NotifierLable.Location = new System.Drawing.Point(17, 278);
            this.NotifierLable.Name = "NotifierLable";
            this.NotifierLable.Size = new System.Drawing.Size(66, 27);
            this.NotifierLable.TabIndex = 8;
            this.NotifierLable.Text = "通知";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 463);
            this.Controls.Add(this.NotifierLable);
            this.Controls.Add(this.elapsedTimeLable);
            this.Controls.Add(this.leftTimeLable);
            this.Controls.Add(this.任务名称标签);
            this.Controls.Add(this.ElapsedTime);
            this.Controls.Add(this.StopTask);
            this.Controls.Add(this.Notifier);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.CurrentTaskName);
            this.Name = "TaskForm";
            this.Text = "Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentTaskName;
        private System.Windows.Forms.TextBox TimeLeft;
        private System.Windows.Forms.Timer TaskTimer;
        private System.Windows.Forms.TextBox Notifier;
        private System.Windows.Forms.Button StopTask;
        private System.Windows.Forms.TextBox ElapsedTime;
        private System.Windows.Forms.Label 任务名称标签;
        private System.Windows.Forms.Label leftTimeLable;
        private System.Windows.Forms.Label elapsedTimeLable;
        private System.Windows.Forms.Label NotifierLable;
    }
}