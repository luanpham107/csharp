using System;
using System.Collections.Generic;
using System.Text;

namespace _08TwoDecks
{
    public enum Suits
    {
        Spades,
        Clubs,
        Diamons,
        Hearts
    }

    public enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card (Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public string GetCardName()
        {
            return Name;
        }

        public override string ToString()
        {
            return "Name of card is " + Name;
        }
    }
}
