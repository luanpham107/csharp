using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09ExcuseManager
{
    public partial class Form1 : Form
    {
        Excuse currentExcuse = new Excuse();
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private string selectedFolder = "";
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dateTimeLastUsed.Value;
            buttonSave.Enabled =false;
            buttonOpen.Enabled = false;
            buttonRandom.Enabled = false;
        }


        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.textBoxExcuseDescription.Text = currentExcuse.Description;
                this.textBoxResult.Text = currentExcuse.Results;
                this.dateTimeLastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    textBoxLastUsed.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";

            }
            else
                this.Text = "Excuse Manager *";
        }
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                buttonSave.Enabled = true;
                buttonOpen.Enabled = true;
                buttonRandom.Enabled = true;
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxExcuseDescription.Text) || String.IsNullOrEmpty(textBoxResult.Text))
            {
                MessageBox.Show("Please specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog.InitialDirectory = selectedFolder;
            saveFileDialog.Filter = "Text files (*.txt) | *.txt | All file (*.*) | *.*";
            saveFileDialog.FileName = textBoxExcuseDescription.Text + ".txt";
            DialogResult result = saveFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog.FileName);
                MessageBox.Show("Saved excuse");
            }

            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = selectedFolder;
            openFileDialog.Filter = "Text files (*.txt) | *.txt | All files (*.*) | *.*";
            openFileDialog.FileName = textBoxExcuseDescription.Text + ".txt";
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse = new Excuse(openFileDialog.FileName);
            }
            UpdateForm(false);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {        
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);            
        }

        private void textBoxExcuseDescription_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = textBoxExcuseDescription.Text;
            UpdateForm(true);
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = textBoxResult.Text;
            UpdateForm(true);
        }
    }
}
