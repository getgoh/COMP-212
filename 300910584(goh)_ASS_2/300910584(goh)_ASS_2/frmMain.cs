using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300910584_goh__ASS_2
{
    public partial class frmMain : Form
    {
        private double subTotal = 0, tax = 0, total = 0;
        List<MenuItem> menuItemList;

        public frmMain()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            menuItemList = getMenuItemList();

            cmbBeverage.DataSource = menuItemList.Where(a => a.Category.Equals("Beverage")).ToList();
            cmbBeverage.DisplayMember = "DisplayItem";
            cmbBeverage.ValueMember = "Id";

            cmbAppetizer.DataSource = menuItemList.Where(a => a.Category.Equals("Appetizer")).ToList();
            cmbAppetizer.DisplayMember = "DisplayItem";
            cmbAppetizer.ValueMember = "Id";

            cmbMainCourse.DataSource = menuItemList.Where(a => a.Category.Equals("Main Course")).ToList();
            cmbMainCourse.DisplayMember = "DisplayItem";
            cmbMainCourse.ValueMember = "Id";

            cmbDessert.DataSource = menuItemList.Where(a => a.Category.Equals("Dessert")).ToList();
            cmbDessert.DisplayMember = "DisplayItem";
            cmbDessert.ValueMember = "Id";
        }

        private List<MenuItem> getMenuItemList()
        {
            List<MenuItem> menuItemList = new List<MenuItem>();

            menuItemList.Add(new MenuItem(1, "Soda", "Beverage", 1.95));
            menuItemList.Add(new MenuItem(2, "Tea", "Beverage", 1.5));
            menuItemList.Add(new MenuItem(3, "Coffee", "Beverage", 1.25));
            menuItemList.Add(new MenuItem(4, "Mineral Water", "Beverage", 2.95));
            menuItemList.Add(new MenuItem(5, "Juice", "Beverage", 2.5));
            menuItemList.Add(new MenuItem(6, "Milk", "Beverage", 1.5));
            menuItemList.Add(new MenuItem(7, "Buffalo Wings", "Appetizer", 5.95));
            menuItemList.Add(new MenuItem(8, "Buffalo Figners", "Appetizer", 6.95));
            menuItemList.Add(new MenuItem(9, "Potato Skins", "Appetizer", 8.95));
            menuItemList.Add(new MenuItem(10, "Nachos", "Appetizer", 8.95));
            menuItemList.Add(new MenuItem(11, "Mushroom Caps", "Appetizer", 10.95));
            menuItemList.Add(new MenuItem(12, "Shrimp Cocktail", "Appetizer", 12.95));
            menuItemList.Add(new MenuItem(13, "Chips and Salsa", "Appetizer", 6.95));
            menuItemList.Add(new MenuItem(14, "Seafood Alfredo", "Main Course", 15.95));
            menuItemList.Add(new MenuItem(15, "Chicken Alfredo", "Main Course", 13.95));
            menuItemList.Add(new MenuItem(16, "Chicken Picatta", "Main Course", 13.95));
            menuItemList.Add(new MenuItem(17, "Turkey Club", "Main Course", 11.95));
            menuItemList.Add(new MenuItem(18, "Lobster Pie", "Main Course", 19.95));
            menuItemList.Add(new MenuItem(19, "Prime Rib", "Main Course", 20.95));
            menuItemList.Add(new MenuItem(20, "Shrimp Scampi", "Main Course", 18.95));
            menuItemList.Add(new MenuItem(21, "Turkey Dinner", "Main Course", 13.95));
            menuItemList.Add(new MenuItem(22, "Stuffed Chicken", "Main Course", 14.95));
            menuItemList.Add(new MenuItem(23, "Apple Pie", "Dessert", 5.95));
            menuItemList.Add(new MenuItem(24, "Sundae", "Dessert", 3.95));
            menuItemList.Add(new MenuItem(25, "Carrot Cake", "Dessert", 5.95));
            menuItemList.Add(new MenuItem(26, "Mud Pie", "Dessert", 4.95));
            menuItemList.Add(new MenuItem(27, "Apple Crisp", "Dessert", 5.95));

            return menuItemList;
        }

        private void cmbMainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem currItem = menuItemList.Where(a => a.Id.Equals(int.Parse(cmbMainCourse.SelectedValue.ToString()))).FirstOrDefault();

            process(currItem);
        }

        private void cmbAppetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem currItem = menuItemList.Where(a => a.Id.Equals(int.Parse(cmbAppetizer.SelectedValue.ToString()))).FirstOrDefault();

            process(currItem);
        }

        private void cmbDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem currItem = menuItemList.Where(a => a.Id.Equals(int.Parse(cmbDessert.SelectedValue.ToString()))).FirstOrDefault();

            process(currItem);
        }

        private void btnClearBill_Click(object sender, EventArgs e)
        {
            subTotal = 0.00;
            tax = 0;
            total = 0;

            string sSub = string.Format("Sub Total: ${0:0.##}", subTotal);

            txtSubtotal.Text = "Sub Total: $0.00";
            txtTax.Text = "Tax: $0.00";
            txtTotal.Text = "Total: $0.00";

            dgvItems.Rows.Clear();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            Process.Start("IEXPLORE.EXE", "https://www.letseat.at/");
        }

        private void cmbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem currItem = menuItemList.Where(a => a.Id.Equals(int.Parse(cmbBeverage.SelectedValue.ToString()))).FirstOrDefault();

            process(currItem);
        }

        private void process(MenuItem currItem)
        {
            if (currItem == null)
                return;

            subTotal += currItem.Price;
            tax += currItem.Price * .15;
            total = subTotal + tax;
            

            txtSubtotal.Text = string.Format("Sub Total: ${0:0.##}", subTotal);
            txtTax.Text = string.Format("Tax: ${0:0.##}", +tax);
            txtTotal.Text = string.Format("Total: ${0:0.##}", total);

            dgvItems.Rows.Add(currItem.Name, "$" + currItem.Price);
        }
    }
}
