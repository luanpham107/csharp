using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyEstimation
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecortions);
            }
        }

        private bool fancyDecortions;

        public decimal CostOfBveragesPerPerson;
        public decimal CostOfDecorations = 0;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyDecortions = fancyDecortions;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBveragesPerPerson = 5.0M;
            }
            else
            {
                CostOfBveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * 0.95M;
            }
            else
            {
                return totalCost;
            }
        }

        public virtual void Test()
        {

        }
    }
}
