namespace _06ExploreTheHouse
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGoHere = new System.Windows.Forms.Button();
            this.comboBoxGoHere = new System.Windows.Forms.ComboBox();
            this.buttonGoThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 166);
            this.textBox1.TabIndex = 0;
            // 
            // buttonGoHere
            // 
            this.buttonGoHere.Location = new System.Drawing.Point(13, 186);
            this.buttonGoHere.Name = "buttonGoHere";
            this.buttonGoHere.Size = new System.Drawing.Size(75, 23);
            this.buttonGoHere.TabIndex = 1;
            this.buttonGoHere.Text = "Go here:";
            this.buttonGoHere.UseVisualStyleBackColor = true;
            // 
            // comboBoxGoHere
            // 
            this.comboBoxGoHere.FormattingEnabled = true;
            this.comboBoxGoHere.Location = new System.Drawing.Point(110, 187);
            this.comboBoxGoHere.Name = "comboBoxGoHere";
            this.comboBoxGoHere.Size = new System.Drawing.Size(217, 21);
            this.comboBoxGoHere.TabIndex = 2;
            // 
            // buttonGoThroughTheDoor
            // 
            this.buttonGoThroughTheDoor.Location = new System.Drawing.Point(13, 216);
            this.buttonGoThroughTheDoor.Name = "buttonGoThroughTheDoor";
            this.buttonGoThroughTheDoor.Size = new System.Drawing.Size(314, 23);
            this.buttonGoThroughTheDoor.TabIndex = 3;
            this.buttonGoThroughTheDoor.Text = "Go through the door";
            this.buttonGoThroughTheDoor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 255);
            this.Controls.Add(this.buttonGoThroughTheDoor);
            this.Controls.Add(this.comboBoxGoHere);
            this.Controls.Add(this.buttonGoHere);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGoHere;
        private System.Windows.Forms.ComboBox comboBoxGoHere;
        private System.Windows.Forms.Button buttonGoThroughTheDoor;
    }
}

