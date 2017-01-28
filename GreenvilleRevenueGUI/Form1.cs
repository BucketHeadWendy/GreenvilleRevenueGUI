//Derek West & Dan Plummer
//1/26/2017
//Chapter 3, Case Problem 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class GreenvilleGUI : Form
    {
        public GreenvilleGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lastYear, thisYear, admission, currentRevenue;
            

            lastYear = Convert.ToInt32(lastBox.Text);
            thisYear = Convert.ToInt32(thisBox.Text);
            admission = 25;
            currentRevenue = admission * thisYear;

            bool moreThisYear = thisYear > lastYear;

            lastYearBox.Text = "There were " + lastYear + " contestants last year, and " + thisYear + " constestants this year.";
            thisYearBox.Text = "To say that there were more contestants this year than last year would be: " + moreThisYear;
            revenueBox.Text = "Expected revenue for this year's competition is: $" + currentRevenue;
          

        }
    }
}
