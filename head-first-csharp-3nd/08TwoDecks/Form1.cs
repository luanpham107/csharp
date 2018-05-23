using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08TwoDecks
{
    public partial class Form1 : Form
    {
        List<Card> deck1 = new List<Card>();
        List<Card> deck2 = new List<Card>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ReDrawDeck(int DeckNumber)
        {
            if(DeckNumber == 1)
            {
                listBoxDeck1.Items.Clear();
                foreach (string cardName in deck1)
            }
        }
    }
}
