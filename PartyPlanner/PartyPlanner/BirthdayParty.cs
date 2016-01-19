using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class BirthdayParty : Party
    {

        //private int numberOfPeople;
        //public int NumberOfPeople
        //{
        //    set { numberOfPeople = value; }
        //}

        //private bool fancyDecorations;
        //public bool FancyDecorations
        //{
        //    set { fancyDecorations = value; }
        //}

        //// Returns total cost of decorations
        //private decimal CalculateCostOfDecorations()
        //{
        //    return fancyDecorations ? (numberOfPeople * FancyDecoPerPerson) + FancyDecoFee : (numberOfPeople * NonFancyDecoPerPerson) + NonFancyDecoFee;
        //}

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

        private string cakeWriting;
        public string CakeWriting
        {
            set { cakeWriting = value; }
        }

        public bool CakeWritingTooLong
        {
            get { return cakeWriting.Length > MaxWritingLength() ? true : false; }
        }

        private int ActualLength
        {
            get { return cakeWriting.Length > MaxWritingLength() ? MaxWritingLength() : cakeWriting.Length; }
        }

        // Returns total cost of the party
        public override decimal Cost
        {
            get
            {
                //Adding base cost
                decimal totalCost = base.Cost;
                //Adding cost of the cake
                totalCost += CakeSize() == 8 ? 40M + (ActualLength * .25M) : 75M + (ActualLength * .25M);

                return totalCost;
            }
        }

        // Returns size of the cake.
        private int CakeSize()
        {
            return NumberOfPeople <= 4 ? 8 : 16;
        }

        // Returns the max cake writing length
        private int MaxWritingLength()
        {
            return CakeSize() == 8 ? 16 : 40;
        }




    }
}
