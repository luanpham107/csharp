using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRace
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyLabel.Text = Name + " bet " + MyBet.Amount + " on dog#" + MyBet.Dog;
            MyRadioButton.Text = Name + " has " + Cash + "bucks.";

        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            if(Amount <= Cash)
            {
                MyBet = new Bet()
                {
                    Amount = Amount,
                    Dog = Dog,
                    Bettor = this
                };
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            ClearBet();
            UpdateLabels();
        }
    }
}
