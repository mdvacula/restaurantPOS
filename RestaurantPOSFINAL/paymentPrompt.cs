/*This is the class to create a payment prompt. I wanted to also set so it printed after payment*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOSFINAL
{
    public partial class paymentPrompt : Form
    {
        private decimal paymentAmount;

        public delegate void payEvent(object sender, PaySucessfullArgs e);

        public event payEvent PaySuccess;
        
        
        public decimal Amount
        {
            get
            {
                return paymentAmount;
            }
            set
            {
                paymentAmount = value;
                totalTxt.Text = String.Format("{0:c}", paymentAmount);
            }
        }

        public paymentPrompt()
        {
            InitializeComponent();
            this.BringToFront();
        }
            
        private void MadePayment(object sender, EventArgs e)
            {
                decimal total = 0;
                try
                {
                    total = Decimal.Parse(totalTxt.Text.TrimStart('$')) - Decimal.Parse(paymentTxt.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Entry, Check and Try again.");
                    return;
                }


                if (total > 0)
                {
                    totalTxt.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Change Due: " + String.Format("{0:c}", -total));

                    PaySuccess(this, new PaySucessfullArgs() { PaymentMade = true });
                    this.Close();
                }
            }
        
        
        
        public class PaySucessfullArgs: EventArgs    //Custom argument for sucessful payment
        {
            private bool paymentMade;
            
            public bool PaymentMade
            {
                get { return paymentMade; }
                set { paymentMade = value; }
            }
        }

        private void printCheck_Click(object sender, EventArgs e)
        {
            //this would have printed the check from payment screen
        }

        
    
    }
}
 