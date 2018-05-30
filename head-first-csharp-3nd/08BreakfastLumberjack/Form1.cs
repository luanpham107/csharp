using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08BreakfastLumberjack
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> LumberJackStack;

        public Form1()
        {
            InitializeComponent();

            LumberJackStack = new Queue<Lumberjack>();
        }

        private void UpdateView()
        {
            line.Items.Clear();
            UInt16 i = 1;
            foreach(Lumberjack lumberjack in LumberJackStack)
            {
                line.Items.Add(i.ToString() + "." +  lumberjack.Name + "\r\n");
                i++;
            }

            if(LumberJackStack.Count == 0)
            {
                groupBox1.Enabled = false;
                textBoxNextInline.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = LumberJackStack.Peek();
                textBoxNextInline.Text = currentLumberjack.Name + " has " 
                    + currentLumberjack.FlapjackCount + " flapjacks";
            }
        }

        private void buttonAddLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxLumberjackName.Text)) return;
            LumberJackStack.Enqueue(new Lumberjack(textBoxLumberjackName.Text));
            textBoxLumberjackName.Text = "";
            UpdateView();
        }

        private void buttonAddFlapjacks_Click(object sender, EventArgs e)
        {
            if (LumberJackStack.Count == 0) return;
            Flapjack food;
            if (radioButtonCrispy.Checked)
                food = Flapjack.Crispy;
            else if (radioButtonSoggy.Checked)
                food = Flapjack.Soggy;
            else if (radioButtonBrowned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = LumberJackStack.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            textBoxNextInline.Text = currentLumberjack.Name + " has "
                    + currentLumberjack.FlapjackCount + " flapjacks";
        }

        private void buttonLumberjack_Click(object sender, EventArgs e)
        {
            if (LumberJackStack.Count == 0) {
                Console.WriteLine("No lumberjack left!");
                return;
            }
            Lumberjack nextLumberjack = LumberJackStack.Dequeue();
            nextLumberjack.EatFlapjacks();
            textBoxNextInline.Text = "";
            UpdateView();
        }
    }
}
