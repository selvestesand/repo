using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)dinnerNumUpDwn.Value, healthOpCheckBox.Checked, dinnerFancyDecoCheckBox.Checked);
            birthdayParty = new BirthdayParty((int)birthdayNumUpDwn.Value, birthdayFancyDecoCheckBox.Checked, cakeWritingTxtBox.Text);

            DisplayDinnerPartyCost();
            DisplayBirthdayPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            dinnerCostTxtBox.Text = dinnerParty.Cost.ToString("c");
        }


        private void DisplayBirthdayPartyCost()
        {
            birthdayCostTxtBox.Text = birthdayParty.Cost.ToString("c");
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong ? true : false;
        }
        

        private void HealthyOpChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthOpCheckBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void dinnerNumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)dinnerNumUpDwn.Value;
            DisplayDinnerPartyCost();
        }

        private void dinnerFancyOpChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = dinnerFancyDecoCheckBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void cakeWritingTxtBox_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWritingTxtBox.Text;
            DisplayBirthdayPartyCost();
        }

        private void birthdayNumUpDwn_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)birthdayNumUpDwn.Value;
            DisplayBirthdayPartyCost();
        }

        private void birthdayFancyDecoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = birthdayFancyDecoCheckBox.Checked;
            DisplayBirthdayPartyCost();
        }

      

        
    }
}
