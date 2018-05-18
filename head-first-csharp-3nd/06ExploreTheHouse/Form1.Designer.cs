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
            this.textBoxShowDescription = new System.Windows.Forms.TextBox();
            this.buttonGoHere = new System.Windows.Forms.Button();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.buttonGoThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowDescription
            // 
            this.textBoxShowDescription.Location = new System.Drawing.Point(13, 13);
            this.textBoxShowDescription.Multiline = true;
            this.textBoxShowDescription.Name = "textBoxShowDescription";
            this.textBoxShowDescription.Size = new System.Drawing.Size(314, 166);
            this.textBoxShowDescription.TabIndex = 0;
            this.textBoxShowDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(110, 187);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(217, 21);
            this.comboBoxLocation.TabIndex = 2;
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
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.buttonGoHere);
            this.Controls.Add(this.textBoxShowDescription);
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowDescription;
        private System.Windows.Forms.Button buttonGoHere;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Button buttonGoThroughTheDoor;
    }
}

