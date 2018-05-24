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
        Deck deck1 = new Deck();
        Deck deck2 = new Deck();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            ReDrawDeck(1);
            ReDrawDeck(2);

        }

        private void ReDrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                listBoxDeck1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                    listBoxDeck1.Items.Add(cardName);
                label1.Text = "Deck #1 (" + deck1.Count + " cards)";
            }
            else
            {
                listBoxDeck2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                    listBoxDeck2.Items.Add(cardName);
                label2.Text = "Deck #2 (" + deck2.Count + " cards)";
            }
        }

        private void buttonShuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            ReDrawDeck(1);
        }

        private void buttonShuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            ReDrawDeck(2);
        }

        private void buttonResetDeck2_Click(object sender, EventArgs e)
        {

        }

        private void buttonResetDeck1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            // move to Deck 2
            if (listBoxDeck1.SelectedIndex >= 0)
                if(deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(listBoxDeck1.SelectedIndex));
                }
            ReDrawDeck(1);
            ReDrawDeck(2);

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if(listBoxDeck2.SelectedIndex >= 0)
                if(deck2.Count > 0)
                {
                    deck1.Add(deck2.Deal(listBoxDeck2.SelectedIndex));
                }
            ReDrawDeck(1);
            ReDrawDeck(2);
        }

        private void CreateDeck()
        {
            // Deck 2
            for (Suits i = Suits.Spades; i < Suits.Hearts; i++)
                for (Values j = Values.Ace; j < Values.King; j++)
                    deck2.Add(new Card(i, j));
            // Deck 1
        }

        private void ResetDeck(int deckIndex)
        {
            if (deckIndex == 1)
            {
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < 9; i++)
                    deck1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                deck1.Sort();
            }
            else
                deck2 = new Deck();
        }

    }
}
