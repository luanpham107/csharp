namespace _09ExcuseManager
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
            this.labelExcuse = new System.Windows.Forms.Label();
            this.textBoxExcuseDescription = new System.Windows.Forms.TextBox();
            this.dateTimeLastUsed = new System.Windows.Forms.DateTimePicker();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.labelLastUsed = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelFiledate = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxLastUsed = new System.Windows.Forms.TextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // labelExcuse
            // 
            this.labelExcuse.AutoSize = true;
            this.labelExcuse.Location = new System.Drawing.Point(13, 16);
            this.labelExcuse.Name = "labelExcuse";
            this.labelExcuse.Size = new System.Drawing.Size(42, 13);
            this.labelExcuse.TabIndex = 0;
            this.labelExcuse.Text = "Excuse";
            // 
            // textBoxExcuseDescription
            // 
            this.textBoxExcuseDescription.Location = new System.Drawing.Point(81, 13);
            this.textBoxExcuseDescription.Name = "textBoxExcuseDescription";
            this.textBoxExcuseDescription.Size = new System.Drawing.Size(249, 20);
            this.textBoxExcuseDescription.TabIndex = 1;
            this.textBoxExcuseDescription.TextChanged += new System.EventHandler(this.textBoxExcuseDescription_TextChanged);
            // 
            // dateTimeLastUsed
            // 
            this.dateTimeLastUsed.Location = new System.Drawing.Point(81, 65);
            this.dateTimeLastUsed.Name = "dateTimeLastUsed";
            this.dateTimeLastUsed.Size = new System.Drawing.Size(249, 20);
            this.dateTimeLastUsed.TabIndex = 2;
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(12, 132);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonFolder.TabIndex = 3;
            this.buttonFolder.Text = "Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // labelLastUsed
            // 
            this.labelLastUsed.AutoSize = true;
            this.labelLastUsed.Location = new System.Drawing.Point(12, 71);
            this.labelLastUsed.Name = "labelLastUsed";
            this.labelLastUsed.Size = new System.Drawing.Size(55, 13);
            this.labelLastUsed.TabIndex = 4;
            this.labelLastUsed.Text = "Last Used";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(13, 42);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result";
            // 
            // labelFiledate
            // 
            this.labelFiledate.AutoSize = true;
            this.labelFiledate.Location = new System.Drawing.Point(13, 100);
            this.labelFiledate.Name = "labelFiledate";
            this.labelFiledate.Size = new System.Drawing.Size(47, 13);
            this.labelFiledate.TabIndex = 6;
            this.labelFiledate.Text = "File date";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(81, 39);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(249, 20);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // textBoxLastUsed
            // 
            this.textBoxLastUsed.Location = new System.Drawing.Point(81, 97);
            this.textBoxLastUsed.Name = "textBoxLastUsed";
            this.textBoxLastUsed.Size = new System.Drawing.Size(249, 20);
            this.textBoxLastUsed.TabIndex = 8;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(255, 132);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 9;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(174, 132);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(93, 132);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 167);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.textBoxLastUsed);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelFiledate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelLastUsed);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.dateTimeLastUsed);
            this.Controls.Add(this.textBoxExcuseDescription);
            this.Controls.Add(this.labelExcuse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExcuse;
        private System.Windows.Forms.TextBox textBoxExcuseDescription;
        private System.Windows.Forms.DateTimePicker dateTimeLastUsed;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Label labelLastUsed;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelFiledate;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxLastUsed;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

