namespace _08BreakfastLumberjack
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLumberjackName = new System.Windows.Forms.TextBox();
            this.buttonAddLumberjack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNextInline = new System.Windows.Forms.TextBox();
            this.buttonAddFlapjacks = new System.Windows.Forms.Button();
            this.radioButtonSoggy = new System.Windows.Forms.RadioButton();
            this.radioButtonBrowned = new System.Windows.Forms.RadioButton();
            this.radioButtonBanana = new System.Windows.Forms.RadioButton();
            this.radioButtonCrispy = new System.Windows.Forms.RadioButton();
            this.buttonLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.ListBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            // 
            // textBoxLumberjackName
            // 
            this.textBoxLumberjackName.Location = new System.Drawing.Point(133, 13);
            this.textBoxLumberjackName.Name = "textBoxLumberjackName";
            this.textBoxLumberjackName.Size = new System.Drawing.Size(122, 20);
            this.textBoxLumberjackName.TabIndex = 1;
            // 
            // buttonAddLumberjack
            // 
            this.buttonAddLumberjack.Location = new System.Drawing.Point(16, 47);
            this.buttonAddLumberjack.Name = "buttonAddLumberjack";
            this.buttonAddLumberjack.Size = new System.Drawing.Size(239, 23);
            this.buttonAddLumberjack.TabIndex = 2;
            this.buttonAddLumberjack.Text = "Add lumberjack";
            this.buttonAddLumberjack.UseVisualStyleBackColor = true;
            this.buttonAddLumberjack.Click += new System.EventHandler(this.buttonAddLumberjack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Controls.Add(this.textBoxNextInline);
            this.groupBox1.Controls.Add(this.buttonAddFlapjacks);
            this.groupBox1.Controls.Add(this.radioButtonSoggy);
            this.groupBox1.Controls.Add(this.radioButtonBrowned);
            this.groupBox1.Controls.Add(this.radioButtonBanana);
            this.groupBox1.Controls.Add(this.radioButtonCrispy);
            this.groupBox1.Controls.Add(this.buttonLumberjack);
            this.groupBox1.Location = new System.Drawing.Point(133, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a lumberjack";
            // 
            // textBoxNextInline
            // 
            this.textBoxNextInline.Location = new System.Drawing.Point(6, 174);
            this.textBoxNextInline.Multiline = true;
            this.textBoxNextInline.Name = "textBoxNextInline";
            this.textBoxNextInline.Size = new System.Drawing.Size(112, 48);
            this.textBoxNextInline.TabIndex = 7;
            // 
            // buttonAddFlapjacks
            // 
            this.buttonAddFlapjacks.Location = new System.Drawing.Point(7, 144);
            this.buttonAddFlapjacks.Name = "buttonAddFlapjacks";
            this.buttonAddFlapjacks.Size = new System.Drawing.Size(111, 23);
            this.buttonAddFlapjacks.TabIndex = 6;
            this.buttonAddFlapjacks.Text = "Add flapjacks";
            this.buttonAddFlapjacks.UseVisualStyleBackColor = true;
            this.buttonAddFlapjacks.Click += new System.EventHandler(this.buttonAddFlapjacks_Click);
            // 
            // radioButtonSoggy
            // 
            this.radioButtonSoggy.AutoSize = true;
            this.radioButtonSoggy.Location = new System.Drawing.Point(7, 71);
            this.radioButtonSoggy.Name = "radioButtonSoggy";
            this.radioButtonSoggy.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSoggy.TabIndex = 5;
            this.radioButtonSoggy.Text = "Soggy";
            this.radioButtonSoggy.UseVisualStyleBackColor = true;
            // 
            // radioButtonBrowned
            // 
            this.radioButtonBrowned.AutoSize = true;
            this.radioButtonBrowned.Location = new System.Drawing.Point(7, 97);
            this.radioButtonBrowned.Name = "radioButtonBrowned";
            this.radioButtonBrowned.Size = new System.Drawing.Size(67, 17);
            this.radioButtonBrowned.TabIndex = 4;
            this.radioButtonBrowned.Text = "Browned";
            this.radioButtonBrowned.UseVisualStyleBackColor = true;
            // 
            // radioButtonBanana
            // 
            this.radioButtonBanana.AutoSize = true;
            this.radioButtonBanana.Location = new System.Drawing.Point(7, 120);
            this.radioButtonBanana.Name = "radioButtonBanana";
            this.radioButtonBanana.Size = new System.Drawing.Size(62, 17);
            this.radioButtonBanana.TabIndex = 3;
            this.radioButtonBanana.Text = "Banana";
            this.radioButtonBanana.UseVisualStyleBackColor = true;
            // 
            // radioButtonCrispy
            // 
            this.radioButtonCrispy.AutoSize = true;
            this.radioButtonCrispy.Checked = true;
            this.radioButtonCrispy.Location = new System.Drawing.Point(7, 48);
            this.radioButtonCrispy.Name = "radioButtonCrispy";
            this.radioButtonCrispy.Size = new System.Drawing.Size(53, 17);
            this.radioButtonCrispy.TabIndex = 2;
            this.radioButtonCrispy.TabStop = true;
            this.radioButtonCrispy.Text = "Crispy";
            this.radioButtonCrispy.UseVisualStyleBackColor = true;
            // 
            // buttonLumberjack
            // 
            this.buttonLumberjack.Location = new System.Drawing.Point(6, 228);
            this.buttonLumberjack.Name = "buttonLumberjack";
            this.buttonLumberjack.Size = new System.Drawing.Size(112, 23);
            this.buttonLumberjack.TabIndex = 0;
            this.buttonLumberjack.Text = "Next lumberjack";
            this.buttonLumberjack.UseVisualStyleBackColor = true;
            this.buttonLumberjack.Click += new System.EventHandler(this.buttonLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breakfast line";
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(16, 110);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(111, 225);
            this.line.TabIndex = 5;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(7, 20);
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(111, 20);
            this.howMany.TabIndex = 8;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 342);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddLumberjack);
            this.Controls.Add(this.textBoxLumberjackName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLumberjackName;
        private System.Windows.Forms.Button buttonAddLumberjack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLumberjack;
        private System.Windows.Forms.Button buttonAddFlapjacks;
        private System.Windows.Forms.RadioButton radioButtonSoggy;
        private System.Windows.Forms.RadioButton radioButtonBrowned;
        private System.Windows.Forms.RadioButton radioButtonBanana;
        private System.Windows.Forms.RadioButton radioButtonCrispy;
        private System.Windows.Forms.TextBox textBoxNextInline;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.NumericUpDown howMany;
    }
}

