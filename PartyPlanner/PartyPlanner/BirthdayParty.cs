using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class BirthdayParty
    {

        public const int CostOfFoodPerPerson = 25;

        private const decimal FancyDecoPerPerson = 15.00M;
        private const decimal FancyDecoFee = 50.00M;
        private const decimal NonFancyDecoPerPerson = 7.50M;
        private const decimal NonFancyDecoFee = 30.00M;

        private int numberOfPeople;
        public int NumberOfPeople
        {
            set { numberOfPeople = value; }
        }

        private string cakeWriting;
        public string CakeWriting
        {
            set { cakeWriting = value; }
        }

        private int ActualLength
        {
            get { return cakeWriting.Length > MaxWritingLength() ? MaxWritingLength() : cakeWriting.Length; }
        }

        public bool CakeWritingTooLong
        {
            get { return cakeWriting.Length > MaxWritingLength() ? true : false; }
        }

        private bool fancyDecorations;
        public bool FancyDecorations
        {
            set { fancyDecorations = value; }
        }

        // Returns size of the cake.
        private int CakeSize()
        {
            return numberOfPeople <= 4 ? 8 : 16;
        }

        // Returns the max cake writing length
        private int MaxWritingLength()
        {
            return CakeSize() == 8 ? 16 : 40;
        }

        // Returns total cost of the party
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * numberOfPeople;
                decimal cakeCost = CakeSize() == 8 ? 40M + (ActualLength * .25M) : 75M + (ActualLength * .25M);
                return totalCost + cakeCost;
            }
        }

        /// <summary>
        /// BirthdayParty constructor
        /// </summary>
        /// <param name="numberOfPeople"></param>
        /// <param name="fancyDecorations"></param>
        /// <param name="cakeWriting"></param>
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        // Returns total cost of decorations
        private decimal CalculateCostOfDecorations()
        {
            return fancyDecorations ? (numberOfPeople * FancyDecoPerPerson) + FancyDecoFee : (numberOfPeople * NonFancyDecoPerPerson) + NonFancyDecoFee;
        }

    }
}
