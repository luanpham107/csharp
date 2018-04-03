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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Cost = new System.Windows.Forms.Label();
            this.radioButton_FancyDecor = new System.Windows.Forms.CheckBox();
            this.radioButton_HealthyOption = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer of People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // label_Cost
            // 
            this.label_Cost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Cost.Location = new System.Drawing.Point(64, 127);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(100, 20);
            this.label_Cost.TabIndex = 5;
            // 
            // radioButton_FancyDecor
            // 
            this.radioButton_FancyDecor.AutoSize = true;
            this.radioButton_FancyDecor.Location = new System.Drawing.Point(12, 72);
            this.radioButton_FancyDecor.Name = "radioButton_FancyDecor";
            this.radioButton_FancyDecor.Size = new System.Drawing.Size(115, 17);
            this.radioButton_FancyDecor.TabIndex = 6;
            this.radioButton_FancyDecor.Text = "Fancy Decorations";
            this.radioButton_FancyDecor.UseVisualStyleBackColor = true;
            this.radioButton_FancyDecor.CheckedChanged += new System.EventHandler(this.radioButton_FancyDecor_CheckedChanged);
            // 
            // radioButton_HealthyOption
            // 
            this.radioButton_HealthyOption.AutoSize = true;
            this.radioButton_HealthyOption.Location = new System.Drawing.Point(12, 95);
            this.radioButton_HealthyOption.Name = "radioButton_HealthyOption";
            this.radioButton_HealthyOption.Size = new System.Drawing.Size(96, 17);
            this.radioButton_HealthyOption.TabIndex = 7;
            this.radioButton_HealthyOption.Text = "Healthy Option";
            this.radioButton_HealthyOption.UseVisualStyleBackColor = true;
            this.radioButton_HealthyOption.CheckedChanged += new System.EventHandler(this.radioButton_HealthyOption_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 158);
            this.Controls.Add(this.radioButton_HealthyOption);
            this.Controls.Add(this.radioButton_FancyDecor);
            this.Controls.Add(this.label_Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.CheckBox radioButton_FancyDecor;
        private System.Windows.Forms.CheckBox radioButton_HealthyOption;
    }
}

