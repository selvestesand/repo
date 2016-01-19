using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class Party
    {

        public const int CostOfFoodPerPerson = 25;
        private const decimal FancyDecoPerPerson = 15.00M;
        private const decimal FancyDecoFee = 50.00M;
        private const decimal NonFancyDecoPerPerson = 7.50M;
        private const decimal NonFancyDecoFee = 30.00M;

        //private int numberOfPeople;
        public int NumberOfPeople { get; set; }

        private bool fancyDecorations;
        public bool FancyDecorations
        {
            set { fancyDecorations = value; }
        }

        public virtual decimal Cost
        {
            get
            {
                //Starting with cost of decorations
                decimal totalCost = CalculateCostOfDecorations();
                //Adding cost of food per person
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                //Adding additional fee if > 12 people attent the party
                totalCost += NumberOfPeople > 12 ? 100M : 0M;
                //TOTAL COST
                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            return fancyDecorations ? (NumberOfPeople * FancyDecoPerPerson) + FancyDecoFee : (NumberOfPeople * NonFancyDecoPerPerson) + NonFancyDecoFee;
        }

    }
}
