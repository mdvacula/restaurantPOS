/*This is My Restaurant POS Final Project
 * User can input number (only number 10 accepted).
 * The user can then select menu categories to display menu item buttons
 * Remove items from list (whatever item is selected)
 * Print out a copy of the check
 * Make a payment
 * Start all over again
 * This class was the easiest out of the entire project
 * ==================================================
 * Matthew Vacula
 * Prof.Binowski
 * Computer Science 2
 * ==================================================
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOSFINAL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RestaurantDatabaseEntities RDE = new RestaurantDatabaseEntities();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new logIn());
        }
    }
}
