using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyEstimation
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;
        public int CakeSize;

        
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            this.CakeWriting = cakeWriting;
        }

        private void CalculateCakeSize()
        {
            if(NumberOfPeople <= 4)
            {
                CakeSize = 8;
            }
            else
            {
                CakeSize = 16;
            }
        }

        private string cakeWriting = "";
        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letter for a " + CakeSize + " inch cake");
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;
            }
        }

        public decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            decimal CakeCost;
            if(CakeSize == 8)
            {
                CakeCost = 40M + cakeWriting.Length * 0.25M;
            }
            else
                CakeCost = 75M + cakeWriting.Length * 0.25M;
            return TotalCost + CakeCost;
        }

        private int numberOfPeople;
        public int NumberOfPeople
        {
            get
            {
                return this.numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.cakeWriting = cakeWriting;
                
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30M;
        }

    }
}
