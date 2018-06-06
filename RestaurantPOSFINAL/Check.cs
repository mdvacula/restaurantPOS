/*This is the Main check interface. This took me a really long time to do but I think it came out pretty well.
 * Still some issues when resizing the window. Could not get things to maintain their form*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOSFINAL
{
    public partial class Check : Form
    {
        private BindingList<MenuItemTbl> menu = new BindingList<MenuItemTbl>();         //new instance of binding list of menu items for check
        private RestaurantDatabaseEntities rde = new RestaurantDatabaseEntities();      //new instance of Database entitiy model

        private decimal checkTotal;                     // private variable for check total

        public decimal Total                            //public variable for total
        {
            get
            {
                return checkTotal;                                  //retrieves check total
            }
            set
            {
                checkTotal = value;
                totalBox.Text = String.Format("{0:C}", checkTotal);     //formats and updates total
            }
        }

        public Check()
        {
            InitializeComponent();                      // builds the check form
            
            createMenuCategories();
            orderedItems.DataSource = menu;             //sets datasource for list
            orderedItems.DisplayMember = "Description";   //sets display of items to description
        }

        private void FormatList(object sender, ListControlConvertEventArgs e) // Formats the Running Menu List
        {
            string currentDescript = ((MenuItemTbl)e.ListItem).Description;     //gets information from menu table references sent item
            string currentPrice = String.Format("{0:c}", ((MenuItemTbl)e.ListItem).Price);  //Formants price currency form in string
            string paddedDescription = currentDescript.PadRight(20);                //spaces out description

            e.Value = paddedDescription + currentPrice;         //displays formated text in check
        }

        private void createMenuCategories()    // Creates menu buttons for items in Category Table
        {
            var Category = from c in rde.MenuCategories
                           select c;


            foreach (var cat in Category)
            {
                Button b = new Button();
                b.Text = cat.Description;
                b.Size = new Size(100, 100);
                b.Tag = cat;
                b.Click += b_Click;
                categoryPanel.Controls.Add(b);
            }
        }

        void b_Click(object sender, EventArgs e) // controls action for button click in Menu Categories
        {
            menuItemBox.Controls.Clear();      //clears items
            Button T = (Button)sender;         //creates buton instance from sender
            MenuCategory t = (MenuCategory)T.Tag;       //sets button category from table reference and sender
            createMenuItems(t.Category);                //creates buttons for specified category
        }

        
        private void createMenuItems(int selection) // switch statement to control creation of buttons
        {
            switch (selection)
            {

                case 1: createApps();               //creates appetizer buttons
                    break;
                case 2: createEntrees();             //creates entree buttons
                    break;
                case 3: createDesserts();           //creates dessert buttons
                    break;
                case 4: createSides();              //creates sides buttons
                    break;
                case 5: createBeverages();          //creates beverage buttons
                    break;
            }

        }


        private void createApps()           // Creates menu buttons for Appetizers from data in Menu Table
        {
            var Items = from I in rde.MenuItemTbls
                        where I.ItemCategory.Equals(1)
                        select I;

            foreach (var item in Items)
            {
                Button I = new Button();                     //creates button instance
                I.Size = new Size(100, 100);                //sets button size
                I.Text = item.Description;                  //sets button text
                I.Tag = item;                               //sets button information
                I.Click += orderItem;                       //on click orders item(sends to check list)
                menuItemBox.Controls.Add(I);                //adds button to menu item flow form
            }
        }
        private void createEntrees()           // Creates menu buttons for Entrees from data in Menu Table
        {
            var Items = from I in rde.MenuItemTbls
                         where I.ItemCategory.Equals(2)
                         select I;

            foreach (var item in Items)
            {
                Button I = new Button();
                I.Size = new Size(100, 100);
                I.Text = item.Description;
                I.Tag = item;
                I.Click += orderItem;
                menuItemBox.Controls.Add(I);
            }
        }

        private void createDesserts()           // Creates menu buttons for Desserts from data in Menu Table
        {
            var Items = from I in rde.MenuItemTbls
                        where I.ItemCategory.Equals(3)
                        select I;

            foreach (var item in Items)
            {
                Button I = new Button();
                I.Size = new Size(100, 100);
                I.Text = item.Description;
                I.Tag = item;
                I.Click += orderItem;
                menuItemBox.Controls.Add(I);
            }
        }

        private void createSides()           // Creates menu buttons for Sides from data in Menu Table
        {
            var Items = from I in rde.MenuItemTbls
                        where I.ItemCategory.Equals(4)
                        select I;

            foreach (var item in Items)
            {
                Button I = new Button();
                I.Size = new Size(100, 100);
                I.Text = item.Description;
                I.Tag = item;
                I.Click += orderItem;
                menuItemBox.Controls.Add(I);
            }
        }

        private void createBeverages()           // Creates menu buttons for Beverages from data in Menu Table
        {
            var Items = from I in rde.MenuItemTbls
                        where I.ItemCategory.Equals(5)
                        select I;

            foreach (var item in Items)
            {
                Button I = new Button();
                I.Size = new Size(100, 100);
                I.Text = item.Description;
                I.Tag = item;
                I.Click += orderItem;
                menuItemBox.Controls.Add(I);
            }
        }

        
        void orderItem(object sender, EventArgs e)              // orders item and sends to Item list, adjusts total
        {
            Button I = (Button)sender;

            MenuItemTbl t = ((MenuItemTbl)I.Tag);

            orderedItems.SelectedIndex = orderedItems.Items.Count - 1;

            Total = Total + Convert.ToDecimal(t.Price);
            menu.Add(t);
        }

        private void removeItem_Click(object sender, EventArgs e)   //removes item from item list, adjusts total
        {
            MenuItemTbl selectedItem = ((MenuItemTbl)orderedItems.SelectedItem);


            Total = Total - Convert.ToDecimal(selectedItem.Price);
            menu.Remove(selectedItem);


        }

        private void makePayment_Click(object sender, EventArgs e)  //action for Make Payment Button
        {
            paymentPrompt payment = new paymentPrompt();        //new instance of payment prompt

            payment.Amount = checkTotal;                        //supplies prompt with check total
            payment.PaySuccess += payment_PaySuccess;           //retrieval of successful payment

            payment.ShowDialog();                               //creates payment dialog action must be completed before continue
        }

        void payment_PaySuccess(object sender, paymentPrompt.PaySucessfullArgs e)   //actions after successful payment
        {
            

            if (e.PaymentMade == true)                  //boolean for payment sucess
            {
                MessageBox.Show("Transaction Complete");        //displays message

                Total = 0;
                menu.Clear();                   //clears list
                totalBox.Clear();                //resets total
            }
        }

        
            private void Reciept()              //Creates print dialog for reciept
            {
            PrintDialog Print = new PrintDialog();          //presents print dialog

            PrintDocument printDocument = new PrintDocument();         

            Print.Document = printDocument;

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            DialogResult result = Print.ShowDialog();

            if (result == DialogResult.OK)              //upon selection of ok
            {
                printDocument.Print();                  //print document
            }

        }

        void printDocument_PrintPage(object sender, PrintPageEventArgs e) // Format for printing reciept
        {
            Graphics graphic = e.Graphics;
            Font f = new Font("Lucida Console", 12);
            float fontHeight = f.GetHeight();
            SolidBrush brush = new SolidBrush(Color.Black);
            int x = 10;
            int y = 10;
            int off = 40;

            graphic.DrawString("Computer Science II Restaurant", new Font("Lucida Console", 18), brush, x, y);
            graphic.DrawString(String.Format("{0}", DateTime.Now), f, brush, x, y + off);

            off = off + 40;
            foreach (MenuItemTbl item in menu)
            {
                string description = item.Description.PadRight(40);
                string total = string.Format("{0:c}", item.Price);
                string line = description + total;

                graphic.DrawString(line, f, new SolidBrush(Color.Black), x, y + off);

                off = off + (int)fontHeight + 5;
            }

            off = off + 20;

            graphic.DrawString("Total Due:".PadRight(40) + String.Format("{0:c}", checkTotal), f, brush, x, y + off);
        }

        private void printItem_Click(object sender, EventArgs e) //Action of printing reciept on Print button click
        {
            Reciept();
        }

    }

}