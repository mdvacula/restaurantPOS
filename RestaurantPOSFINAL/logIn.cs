/*This is the login form. The only working employee at this time is employee number 10.
 * I would create another database for storing employee information as well as manager
 * or hourly to control the opening of the windows*/

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
    public partial class logIn : Form
    {

        private int[] employee = { 10 };
        private string incorrect = "Invalid ID try again.";

        public logIn()
        {
            
            InitializeComponent();
        }

        private void logInBut_Click(object sender, EventArgs e)
        {
           try{
            int ID = Convert.ToInt32(employeeIDTxt.Text);
           
            
                if (checkEmployee(ID) == true)
                {
                    Check check = new Check();
                    check.Show();
                }

                else
                    System.Windows.Forms.MessageBox.Show(incorrect);
            }
            catch
            {
                MessageBox.Show(incorrect);
            }

        }

        private bool checkEmployee(int id)
        {
            
                
                if (id == employee[0])
                {
                    return true;
                }

                
                else
                {
                    return false;
                }
        }
    }
}
