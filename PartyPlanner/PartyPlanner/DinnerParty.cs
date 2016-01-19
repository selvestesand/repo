using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        private const int CostOfFoodPerPerson = 25;
        private const decimal HealthyBeverage = 5.00M;
        private const decimal HealthyDiscount = .95M;
        private const decimal NonHealthyBeverage = 20.00M;
        private const decimal FancyDecoPerPerson = 15.00M;
        private const decimal FancyDecoFee = 50.00M;
        private const decimal NonFancyDecoPerPerson = 7.50M;
        private const decimal NonFancyDecoFee = 30.00M;

        private decimal CostOfBeveragesPerPerson;
        private decimal CostOfDecorations;


        //Set number of people attending the dinner party
        private int numberOfPeople;
        public int NumberOfPeople {
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations();
            }
        }

        //Set Healthy beverage option
        private bool healthyOption;
        public bool HealthyOption {
            set
            {
                healthyOption = value;
                CostOfBeveragesPerPerson = healthyOption ? HealthyBeverage : NonHealthyBeverage;
            }
        }

        //Set Fancy Deconrations option
        private bool fancyDecorations;
        public bool FancyDecorations {

            private get
            {
                return fancyDecorations;
            }
            set
            {
                fancyDecorations = value;
                CalculateCostOfDecorations();
            }
        }


        //Returns the cost of the entire dinner party.
        public decimal Cost
        {
            get
            {
                decimal cost = (((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * numberOfPeople) + CostOfDecorations);
                cost += numberOfPeople > 12 ? 100M : 0M;
                return healthyOption ? cost * HealthyDiscount : cost; ;
            }
        }


        // DinnerParty constructor 
        public DinnerParty(int numberOfPeople, bool healtyOption, bool fancyDecorations)
        {
            HealthyOption = healtyOption;
            FancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
        }


        //Calculates the cost of decorations
        private void CalculateCostOfDecorations()
        {
            CostOfDecorations = fancyDecorations ? (numberOfPeople * FancyDecoPerPerson) + FancyDecoFee : (numberOfPeople * NonFancyDecoPerPerson) + NonFancyDecoFee;
        }


    }
}
