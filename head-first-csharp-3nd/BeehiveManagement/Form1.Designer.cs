namespace BeehiveManagement
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAssignJob = new System.Windows.Forms.Button();
            this.numericUpDownShiftsNum = new System.Windows.Forms.NumericUpDown();
            this.labelShiftsNum = new System.Windows.Forms.Label();
            this.comboBoxJobList = new System.Windows.Forms.ComboBox();
            this.labelJob = new System.Windows.Forms.Label();
            this.buttonWorkTHeNextShift = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAssignJob);
            this.groupBox1.Controls.Add(this.numericUpDownShiftsNum);
            this.groupBox1.Controls.Add(this.labelShiftsNum);
            this.groupBox1.Controls.Add(this.comboBoxJobList);
            this.groupBox1.Controls.Add(this.labelJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // buttonAssignJob
            // 
            this.buttonAssignJob.Location = new System.Drawing.Point(10, 64);
            this.buttonAssignJob.Name = "buttonAssignJob";
            this.buttonAssignJob.Size = new System.Drawing.Size(331, 23);
            this.buttonAssignJob.TabIndex = 5;
            this.buttonAssignJob.Text = "Assign this job to a bee";
            this.buttonAssignJob.UseVisualStyleBackColor = true;
            this.buttonAssignJob.Click += new System.EventHandler(this.buttonAssignJob_Click);
            // 
            // numericUpDownShiftsNum
            // 
            this.numericUpDownShiftsNum.Location = new System.Drawing.Point(249, 36);
            this.numericUpDownShiftsNum.Name = "numericUpDownShiftsNum";
            this.numericUpDownShiftsNum.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownShiftsNum.TabIndex = 4;
            // 
            // labelShiftsNum
            // 
            this.labelShiftsNum.AutoSize = true;
            this.labelShiftsNum.Location = new System.Drawing.Point(226, 20);
            this.labelShiftsNum.Name = "labelShiftsNum";
            this.labelShiftsNum.Size = new System.Drawing.Size(33, 13);
            this.labelShiftsNum.TabIndex = 3;
            this.labelShiftsNum.Text = "Shifts";
            // 
            // comboBoxJobList
            // 
            this.comboBoxJobList.FormattingEnabled = true;
            this.comboBoxJobList.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.comboBoxJobList.Location = new System.Drawing.Point(7, 37);
            this.comboBoxJobList.Name = "comboBoxJobList";
            this.comboBoxJobList.Size = new System.Drawing.Size(236, 21);
            this.comboBoxJobList.TabIndex = 1;
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(7, 20);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(24, 13);
            this.labelJob.TabIndex = 0;
            this.labelJob.Text = "Job";
            // 
            // buttonWorkTHeNextShift
            // 
            this.buttonWorkTHeNextShift.Location = new System.Drawing.Point(376, 12);
            this.buttonWorkTHeNextShift.Name = "buttonWorkTHeNextShift";
            this.buttonWorkTHeNextShift.Size = new System.Drawing.Size(129, 100);
            this.buttonWorkTHeNextShift.TabIndex = 2;
            this.buttonWorkTHeNextShift.Text = "Work the next shift";
            this.buttonWorkTHeNextShift.UseVisualStyleBackColor = true;
            this.buttonWorkTHeNextShift.Click += new System.EventHandler(this.buttonWorkTHeNextShift_Click_1);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(13, 119);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(492, 131);
            this.textBoxReport.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 262);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.buttonWorkTHeNextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxJobList;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.NumericUpDown numericUpDownShiftsNum;
        private System.Windows.Forms.Label labelShiftsNum;
        private System.Windows.Forms.Button buttonAssignJob;
        private System.Windows.Forms.Button buttonWorkTHeNextShift;
        private System.Windows.Forms.TextBox textBoxReport;
    }
}

