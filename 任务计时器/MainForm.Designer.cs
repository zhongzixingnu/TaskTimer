
namespace TaskTimer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskName = new System.Windows.Forms.TextBox();
            this.ExpectTime = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.StopAllTasks = new System.Windows.Forms.Button();
            this.taskNameLable = new System.Windows.Forms.Label();
            this.expectTimeLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExpectTime)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(22, 49);
            this.TaskName.Multiline = true;
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(304, 66);
            this.TaskName.TabIndex = 0;
            // 
            // ExpectTime
            // 
            this.ExpectTime.Location = new System.Drawing.Point(22, 168);
            this.ExpectTime.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.ExpectTime.Name = "ExpectTime";
            this.ExpectTime.Size = new System.Drawing.Size(304, 38);
            this.ExpectTime.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(377, 49);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(163, 66);
            this.Start.TabIndex = 2;
            this.Start.Text = "开始";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopAllTasks
            // 
            this.StopAllTasks.Location = new System.Drawing.Point(377, 149);
            this.StopAllTasks.Name = "StopAllTasks";
            this.StopAllTasks.Size = new System.Drawing.Size(206, 57);
            this.StopAllTasks.TabIndex = 3;
            this.StopAllTasks.Text = "停止所有任务";
            this.StopAllTasks.UseVisualStyleBackColor = true;
            this.StopAllTasks.Click += new System.EventHandler(this.StopAllTasks_Click);
            // 
            // taskNameLable
            // 
            this.taskNameLable.AutoSize = true;
            this.taskNameLable.Location = new System.Drawing.Point(17, 19);
            this.taskNameLable.Name = "taskNameLable";
            this.taskNameLable.Size = new System.Drawing.Size(120, 27);
            this.taskNameLable.TabIndex = 4;
            this.taskNameLable.Text = "任务名称";
            // 
            // expectTimeLable
            // 
            this.expectTimeLable.AutoSize = true;
            this.expectTimeLable.Location = new System.Drawing.Point(17, 138);
            this.expectTimeLable.Name = "expectTimeLable";
            this.expectTimeLable.Size = new System.Drawing.Size(120, 27);
            this.expectTimeLable.TabIndex = 5;
            this.expectTimeLable.Text = "预期用时";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 235);
            this.Controls.Add(this.expectTimeLable);
            this.Controls.Add(this.taskNameLable);
            this.Controls.Add(this.StopAllTasks);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ExpectTime);
            this.Controls.Add(this.TaskName);
            this.Name = "MainForm";
            this.Text = "任务计时";
            ((System.ComponentModel.ISupportInitialize)(this.ExpectTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.NumericUpDown ExpectTime;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button StopAllTasks;
        private System.Windows.Forms.Label taskNameLable;
        private System.Windows.Forms.Label expectTimeLable;
    }
}

