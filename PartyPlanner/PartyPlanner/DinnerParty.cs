using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty : Party
    {

        //Set Fancy Deconrations option
        //private bool fancyDecorations;
        //public bool FancyDecorations {

        //Set number of people attending the dinner party
        //private int numberOfPeople;
        //public int NumberOfPeople {
        //    set
        //    {
        //        numberOfPeople = value;
        //        CalculateCostOfDecorations(); !!ADD THIS TO Cost PROPERTY!!
        //    }
        //}

        //    private get
        //    {
        //        return fancyDecorations;
        //    }
        //    set
        //    {
        //        fancyDecorations = value;
        //        CalculateCostOfDecorations();
        //    }
        //}

        //Calculates the cost of decorations
        //private decimal CalculateCostOfDecorations()
        //{
        //    return fancyDecorations ? (numberOfPeople * FancyDecoPerPerson) + FancyDecoFee : (numberOfPeople * NonFancyDecoPerPerson) + NonFancyDecoFee;
        //}

        private const decimal HealthyBeverage = 5.00M;
        private const decimal HealthyDiscount = .95M;
        private const decimal NonHealthyBeverage = 20.00M;

        // DinnerParty constructor 
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
        }

        //Set Healthy beverage option
        private bool healthyOption;
        public bool HealthyOption
        {
            set { healthyOption = value; }
        }

        //Returns the cost of the entire dinner party.
        public override decimal Cost
        {
            get
            {
                //Adding base cost
                decimal totalCost = base.Cost;
                //Adding cost of beverages
                totalCost += healthyOption ? HealthyBeverage * NumberOfPeople : NonHealthyBeverage * NumberOfPeople;
                //Adding potential discount
                totalCost = healthyOption ? totalCost * HealthyDiscount : totalCost;

                return totalCost;
            }
        }


        private decimal CalculateCostOfBeveragesPerPerson()
        {
            throw new NotImplementedException();
        }

    }
}
