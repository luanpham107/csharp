using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyEstimation
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty(5, radioButton_HealthyOption.Checked, radioButton_FancyDecor.Checked);            
            dinnerParty.SetHealthyOption(radioButton_HealthyOption.Checked);
            dinnerParty.CalculateCostOfDecorations(radioButton_FancyDecor.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown_birthdayPeopleNum.Value, 
                checkBox_birthdayFanDecor.Checked, textBox1.Text);
            DisplayBirthdayPartyCost();
        }

        // Dinner Party cost
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(radioButton_HealthyOption.Checked);
            label_Cost.Text = Cost.ToString("c");
        }

        private void radioButton_FancyDecor_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(radioButton_FancyDecor.Checked);
            DisplayDinnerPartyCost();
        }

        private void radioButton_HealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(radioButton_HealthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            decimal Cost = dinnerParty.CalculateCost(radioButton_HealthyOption.Checked);
            label_Cost.Text = Cost.ToString("c");
        }

        //Birthday Cost

        private void numericUpDown_birthdayPeopleNum_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown_birthdayPeopleNum.Value;
            DisplayBirthdayPartyCost();
        }


        public void DisplayBirthdayPartyCost()
        {
            decimal cost = birthdayParty.CalculateCost();
            label_BirthdayCostOut.Text = cost.ToString("c");

        }

        private void checkBox_birthdayFanDecor_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(checkBox_birthdayFanDecor.Checked);
            DisplayBirthdayPartyCost();
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox1.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
