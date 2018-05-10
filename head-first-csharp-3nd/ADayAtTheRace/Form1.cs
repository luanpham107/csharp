using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    public partial class Form1 : Form
    {
        Random MyRandomizer;
        Greyhound[] GreyhoundArray;
        Guy[] GuyArray;
        Guy CurrentGuy;


        public Form1()
        {
            InitializeComponent();

            MyRandomizer = new Random();
            GreyhoundArray = new Greyhound[4];
            GuyArray = new Guy[3];
            
            

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox_Dog1,
                StartingPosition = pictureBox_Dog1.Left,
                RacetrackLength = pictureBox_RaceTrack.Width - pictureBox_Dog1.Width,
                Location = 0,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox_Dog2,
                StartingPosition = pictureBox_Dog2.Left,
                RacetrackLength = pictureBox_RaceTrack.Width - pictureBox_Dog2.Width,
                Location = 1,
                Randomizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox_Dog3,
                StartingPosition = pictureBox_Dog3.Left,
                RacetrackLength = pictureBox_RaceTrack.Width - pictureBox_Dog3.Width,
                Location = 2,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox_Dog4,
                StartingPosition = pictureBox_Dog4.Left,
                RacetrackLength = pictureBox_RaceTrack.Width - pictureBox_Dog4.Width,
                Location = 3,
                Randomizer = MyRandomizer
            };


            GuyArray = new Guy[3];

            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                MyRadioButton = radioButton_Joe,
                MyLabel = label_JoeLog,
                Cash = 50
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                MyRadioButton = radioButton_Bob,
                MyLabel = label_BobLog,
                Cash = 190
            };

            GuyArray[2] = new Guy()
            {
                Name = "Al",
                MyRadioButton = radioButton_Al,
                MyLabel = label_AlLog,
                Cash = 200
            };

            CurrentGuy = GuyArray[0];

            GuyArray[0].MyRadioButton.Text = GuyArray[0].Name + " has " + GuyArray[0].Cash + "$";
            GuyArray[1].MyRadioButton.Text = GuyArray[1].Name + " has " + GuyArray[1].Cash + "$";
            GuyArray[2].MyRadioButton.Text = GuyArray[2].Name + " has " + GuyArray[2].Cash + "$";
        }

        private void EnableControl(bool isEnable)
        {
            radioButton_Joe.Enabled = isEnable;
            radioButton_Bob.Enabled = isEnable;
            radioButton_Al.Enabled = isEnable;

            numericUpDown_BetAmount.Enabled = isEnable;
            numericUpDown_Dog.Enabled = isEnable;
            button_Race.Enabled = isEnable;
        }
        private void button_Race_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_Bet_Click(object sender, EventArgs e)
        {
            CurrentGuy.MyBet = new Bet()
            {
                Amount = (int)numericUpDown_BetAmount.Value,
                Dog = (int)numericUpDown_Dog.Value
            };
            CurrentGuy.UpdateLabels();
        }

        private void radioButton_Joe_CheckedChanged(object sender, EventArgs e)
        {
            label_WhoIsBet.Text = "Joe";
            CurrentGuy = GuyArray[0];
        }

        private void radioButton_Bob_CheckedChanged(object sender, EventArgs e)
        {
            label_WhoIsBet.Text = "Bob";
            CurrentGuy = GuyArray[1];
        }

        private void radioButton_Al_CheckedChanged(object sender, EventArgs e)
        {
            label_WhoIsBet.Text = "Al";
            CurrentGuy = GuyArray[2];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int dogNum = 0; dogNum < GreyhoundArray.Length; dogNum++)
            {
                if (GreyhoundArray[dogNum].Run())
                {
                    timer1.Stop();
                    int winningDog = dogNum + 1;
                    for(int j = 0; j < GuyArray.Length; j++)
                    {
                        GuyArray[j].Collect(winningDog);
                    }
                    MessageBox.Show("Dog #" + winningDog + " won the race!");

                    for(int i = 0; i< GreyhoundArray.Length; i++)
                    {
                        GreyhoundArray[i].TakeStartingPostion();
                    }
                }
            }
        }
    }

            
}

