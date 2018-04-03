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
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty()
            {
                NumberOfPeople = 5
            };
            dinnerParty.SetHealthyOption(radioButton_HealthyOption.Checked);
            dinnerParty.CalculateCostOfDecorations(radioButton_FancyDecor.Checked);
            DisplayDinnerPartyCost();
        }

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
    }
}
