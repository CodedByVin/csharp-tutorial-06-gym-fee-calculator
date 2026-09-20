using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_prac6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declaring and instantiating variables from user inputs.
            decimal baseFee = nudBaseFee.Value;
            decimal sessionRate = nudSessionRate.Value;
            decimal numOfSessions = nudNumSessions.Value;

            // Calculations.
            decimal totalExVAT = baseFee + (sessionRate * numOfSessions);
            decimal vat = totalExVAT * 0.15m;
            decimal totalIncVAT = totalExVAT + vat;

            // Displaying outputs.
            rtbOutput.Text = "Total ex. VAT: " + "R" + Math.Round(totalExVAT, 2).ToString();
            rtbOutput.Text += "\nVAT: " + "R" + Math.Round(vat, 2).ToString();
            rtbOutput.Text += "\nTotal .inc VAT: " + "R" + Math.Round(totalIncVAT, 2).ToString();
        }
    }
}
