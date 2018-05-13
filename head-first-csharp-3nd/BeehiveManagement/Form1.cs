using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveManagement
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            comboBoxJobList.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol"});

            queen = new Queen(workers);
        }

        private void buttonAssignJob_Click(object sender, EventArgs e)
        {
            if ((queen.AssignWork(comboBoxJobList.Text, (int)numericUpDownShiftsNum.Value) == false))
                MessageBox.Show("No workers are avaiable to do the job '" + comboBoxJobList.Text + "', The queen bee says ...");
            else
                MessageBox.Show("The job '" + comboBoxJobList.Text + "' will be done in "
                    + numericUpDownShiftsNum.Value + " shifts", "The queen bee says...");

        }        

        private void buttonWorkTHeNextShift_Click_1(object sender, EventArgs e)
        {
            textBoxReport.Text = queen.WorkTheNextShift();

        }
    }
}

