namespace _08TwoDecks
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonResetDeck1 = new System.Windows.Forms.Button();
            this.buttonShuffleDeck1 = new System.Windows.Forms.Button();
            this.buttonShuffleDeck2 = new System.Windows.Forms.Button();
            this.buttonResetDeck2 = new System.Windows.Forms.Button();
            this.listBoxDeck1 = new System.Windows.Forms.ListBox();
            this.listBoxDeck2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deck #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deck #2";
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(169, 121);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(55, 23);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.Text = ">>";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(169, 165);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(55, 23);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "<<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonResetDeck1
            // 
            this.buttonResetDeck1.Location = new System.Drawing.Point(15, 308);
            this.buttonResetDeck1.Name = "buttonResetDeck1";
            this.buttonResetDeck1.Size = new System.Drawing.Size(147, 23);
            this.buttonResetDeck1.TabIndex = 6;
            this.buttonResetDeck1.Text = "Reset Deck #1";
            this.buttonResetDeck1.UseVisualStyleBackColor = true;
            // 
            // buttonShuffleDeck1
            // 
            this.buttonShuffleDeck1.Location = new System.Drawing.Point(15, 337);
            this.buttonShuffleDeck1.Name = "buttonShuffleDeck1";
            this.buttonShuffleDeck1.Size = new System.Drawing.Size(147, 23);
            this.buttonShuffleDeck1.TabIndex = 7;
            this.buttonShuffleDeck1.Text = "Shuffle Deck #1";
            this.buttonShuffleDeck1.UseVisualStyleBackColor = true;
            // 
            // buttonShuffleDeck2
            // 
            this.buttonShuffleDeck2.Location = new System.Drawing.Point(230, 337);
            this.buttonShuffleDeck2.Name = "buttonShuffleDeck2";
            this.buttonShuffleDeck2.Size = new System.Drawing.Size(147, 23);
            this.buttonShuffleDeck2.TabIndex = 9;
            this.buttonShuffleDeck2.Text = "Shuffle Deck #2";
            this.buttonShuffleDeck2.UseVisualStyleBackColor = true;
            // 
            // buttonResetDeck2
            // 
            this.buttonResetDeck2.Location = new System.Drawing.Point(230, 308);
            this.buttonResetDeck2.Name = "buttonResetDeck2";
            this.buttonResetDeck2.Size = new System.Drawing.Size(147, 23);
            this.buttonResetDeck2.TabIndex = 8;
            this.buttonResetDeck2.Text = "Reset Deck #2";
            this.buttonResetDeck2.UseVisualStyleBackColor = true;
            // 
            // listBoxDeck1
            // 
            this.listBoxDeck1.FormattingEnabled = true;
            this.listBoxDeck1.Location = new System.Drawing.Point(12, 25);
            this.listBoxDeck1.Name = "listBoxDeck1";
            this.listBoxDeck1.Size = new System.Drawing.Size(150, 264);
            this.listBoxDeck1.TabIndex = 10;
            // 
            // listBoxDeck2
            // 
            this.listBoxDeck2.FormattingEnabled = true;
            this.listBoxDeck2.Location = new System.Drawing.Point(230, 25);
            this.listBoxDeck2.Name = "listBoxDeck2";
            this.listBoxDeck2.Size = new System.Drawing.Size(150, 264);
            this.listBoxDeck2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 370);
            this.Controls.Add(this.listBoxDeck2);
            this.Controls.Add(this.listBoxDeck1);
            this.Controls.Add(this.buttonShuffleDeck2);
            this.Controls.Add(this.buttonResetDeck2);
            this.Controls.Add(this.buttonShuffleDeck1);
            this.Controls.Add(this.buttonResetDeck1);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonResetDeck1;
        private System.Windows.Forms.Button buttonShuffleDeck1;
        private System.Windows.Forms.Button buttonShuffleDeck2;
        private System.Windows.Forms.Button buttonResetDeck2;
        private System.Windows.Forms.ListBox listBoxDeck1;
        private System.Windows.Forms.ListBox listBoxDeck2;
    }
}

