/*This would be part of manager capabilites to add menu items. Only Partially complete.
 * I used this as practice to get used to creating the database entities and creating a form*/

   


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RestaurantPOSFINAL{
    public partial class AddProduct : Form
    {
        private RestaurantDatabaseEntities RDE = new RestaurantDatabaseEntities();                    //Creates new instance of Databasemodel
        
        public AddProduct()
        {
            InitializeComponent();                                                 //Creates Form
            categoryBox.DataSource = RDE.MenuCategories.Local;                     //Links source for dropdown menu to database
            categoryBox.DisplayMember = "Description";                             //Category in table to display in dropdown menu
            categoryBox.ValueMember = "Category";                                  //Table Value referenced in drop down menu
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuItemTbl Item = new MenuItemTbl();                   //New instance of a Menu Item

            Item.Description = descriptionTxt.Text;                 //Sets Items description to info in text box

            Item.Price =Convert.ToDecimal(priceTxt.Text);           //Sets Item price to text converted to decimal in text box

            Item.ItemCategory = Convert.ToInt32(categoryBox.SelectedValue);     //Sets item category to seleced value

            RDE.MenuItemTbls.Add(Item);                                         //Adds item to Database Instance
        }
            
            
        
    }
}
