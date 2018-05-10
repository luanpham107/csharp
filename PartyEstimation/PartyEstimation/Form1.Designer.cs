namespace PartyEstimation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton_HealthyOption = new System.Windows.Forms.CheckBox();
            this.radioButton_FancyDecor = new System.Windows.Forms.CheckBox();
            this.label_Cost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_BirthdayCostOut = new System.Windows.Forms.Label();
            this.label_BirthdayCost = new System.Windows.Forms.Label();
            this.label_CakeWriting = new System.Windows.Forms.Label();
            this.checkBox_birthdayFanDecor = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_birthdayPeopleNum = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_birthdayPeopleNum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 204);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton_HealthyOption);
            this.tabPage1.Controls.Add(this.radioButton_FancyDecor);
            this.tabPage1.Controls.Add(this.label_Cost);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(214, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton_HealthyOption
            // 
            this.radioButton_HealthyOption.AutoSize = true;
            this.radioButton_HealthyOption.Location = new System.Drawing.Point(5, 95);
            this.radioButton_HealthyOption.Name = "radioButton_HealthyOption";
            this.radioButton_HealthyOption.Size = new System.Drawing.Size(96, 17);
            this.radioButton_HealthyOption.TabIndex = 13;
            this.radioButton_HealthyOption.Text = "Healthy Option";
            this.radioButton_HealthyOption.UseVisualStyleBackColor = true;
            this.radioButton_HealthyOption.CheckedChanged += new System.EventHandler(this.radioButton_HealthyOption_CheckedChanged);
            // 
            // radioButton_FancyDecor
            // 
            this.radioButton_FancyDecor.AutoSize = true;
            this.radioButton_FancyDecor.Location = new System.Drawing.Point(5, 72);
            this.radioButton_FancyDecor.Name = "radioButton_FancyDecor";
            this.radioButton_FancyDecor.Size = new System.Drawing.Size(115, 17);
            this.radioButton_FancyDecor.TabIndex = 12;
            this.radioButton_FancyDecor.Text = "Fancy Decorations";
            this.radioButton_FancyDecor.UseVisualStyleBackColor = true;
            this.radioButton_FancyDecor.CheckedChanged += new System.EventHandler(this.radioButton_FancyDecor_CheckedChanged);
            // 
            // label_Cost
            // 
            this.label_Cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Cost.Location = new System.Drawing.Point(57, 127);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(100, 20);
            this.label_Cost.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numer of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label_BirthdayCostOut);
            this.tabPage2.Controls.Add(this.label_BirthdayCost);
            this.tabPage2.Controls.Add(this.label_CakeWriting);
            this.tabPage2.Controls.Add(this.checkBox_birthdayFanDecor);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numericUpDown_birthdayPeopleNum);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(214, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_BirthdayCostOut
            // 
            this.label_BirthdayCostOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_BirthdayCostOut.Location = new System.Drawing.Point(46, 142);
            this.label_BirthdayCostOut.Name = "label_BirthdayCostOut";
            this.label_BirthdayCostOut.Size = new System.Drawing.Size(160, 22);
            this.label_BirthdayCostOut.TabIndex = 6;
            // 
            // label_BirthdayCost
            // 
            this.label_BirthdayCost.AutoSize = true;
            this.label_BirthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BirthdayCost.Location = new System.Drawing.Point(8, 151);
            this.label_BirthdayCost.Name = "label_BirthdayCost";
            this.label_BirthdayCost.Size = new System.Drawing.Size(32, 13);
            this.label_BirthdayCost.TabIndex = 5;
            this.label_BirthdayCost.Text = "Cost";
            // 
            // label_CakeWriting
            // 
            this.label_CakeWriting.AutoSize = true;
            this.label_CakeWriting.Location = new System.Drawing.Point(8, 83);
            this.label_CakeWriting.Name = "label_CakeWriting";
            this.label_CakeWriting.Size = new System.Drawing.Size(68, 13);
            this.label_CakeWriting.TabIndex = 3;
            this.label_CakeWriting.Text = "Cake Writing";
            // 
            // checkBox_birthdayFanDecor
            // 
            this.checkBox_birthdayFanDecor.AutoSize = true;
            this.checkBox_birthdayFanDecor.Location = new System.Drawing.Point(11, 54);
            this.checkBox_birthdayFanDecor.Name = "checkBox_birthdayFanDecor";
            this.checkBox_birthdayFanDecor.Size = new System.Drawing.Size(115, 17);
            this.checkBox_birthdayFanDecor.TabIndex = 2;
            this.checkBox_birthdayFanDecor.Text = "Fancy Decorations";
            this.checkBox_birthdayFanDecor.UseVisualStyleBackColor = true;
            this.checkBox_birthdayFanDecor.CheckedChanged += new System.EventHandler(this.checkBox_birthdayFanDecor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of people";
            // 
            // numericUpDown_birthdayPeopleNum
            // 
            this.numericUpDown_birthdayPeopleNum.Location = new System.Drawing.Point(11, 19);
            this.numericUpDown_birthdayPeopleNum.Name = "numericUpDown_birthdayPeopleNum";
            this.numericUpDown_birthdayPeopleNum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_birthdayPeopleNum.TabIndex = 0;
            this.numericUpDown_birthdayPeopleNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_birthdayPeopleNum.ValueChanged += new System.EventHandler(this.numericUpDown_birthdayPeopleNum_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 204);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_birthdayPeopleNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox radioButton_HealthyOption;
        private System.Windows.Forms.CheckBox radioButton_FancyDecor;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_BirthdayCostOut;
        private System.Windows.Forms.Label label_BirthdayCost;
        private System.Windows.Forms.Label label_CakeWriting;
        private System.Windows.Forms.CheckBox checkBox_birthdayFanDecor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_birthdayPeopleNum;
        private System.Windows.Forms.TextBox textBox1;
    }
}

