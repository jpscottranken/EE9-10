using System;
using System.Windows.Forms;

/*
 *      In Exercise 10-2, you'll complete a form that 
 *      accepts a lunch order from the user and then 
 *      calculates the order subtotal and total.
 *      
 *      The app should provide for these main courses 
 *      and add-ons: 
 *      Main course     Price   Add-on                      Add-on price
 *      ================================================================
 *      Hamburger       7.95    Lettuce, tomato, & onions     1.25 
 *                              Ketchup, mustard, & mayo 
 *                              French fries
 *                              
 *      Pizza           6.95    Pepperoni                     0.75 
 *                              Sausage 
 *                              Olives 
 *                              
 *      Salad           6.75    Croutons                      0.50 
 *                              Bacon bits 
 *                              Bread sticks
 *
 *      1.  Create the GUI for Extra Exercise 10-2
 *      
 *      2.  Add three radio buttons to the Main Course group box, 
 *          and set their properties so they appear as shown.
 *          
 *      3.  Add a group box for the add-on items. Then, add three 
 *          check boxes to this group box as shown above.
 *          
 *      4.  Code an event handler for the Load event of the form 
 *          that checks the Hamburger radio button when the form 
 *          loads.
 *          
 *      5.  Code a method name ClearTotals() that clears the three 
 *          text boxes and a method named ClearAddOns() that removes 
 *          the check marks from the three check boxes.
 *      
 *      6.  Code an event handler that changes the text that's 
 *          displayed for the Add-ons group box and the three 
 *          check boxes when the user selects a different main 
 *          course. 
 *          
 *          This event handler should also remove the check marks 
 *          from the add-ons and clear the order totals. 
 *          
 *          Test the app to be sure this works correctly.
 *          
 *      7.  Code an event handler that calculates and displays the 
 *          subtotal, tax, and order total when the user clicks the 
 *          Place Order button. 
 *          
 *          The subtotal is the cost of the main course plus the 
 *          cost of the add-ons. The tax is 7.75% of the subtotal. 
 *          And the order total is the subtotal plus the tax. 
 *          
 *          Test the app to be sure this works correctly.
 *          
 *      8.  Code an event handler that clears the order totals 
 *          when the user checks or unchecks an add-on. 
 *          
 *          Then, test the app one more time.
 */

namespace EE10_2
{
    public partial class frmLunchOrder : Form
    {
        //  Declare and initialize program constants
        const string BURGERADDON1 = "Lettuce, Tomato, and Onions";
        const string BURGERADDON2 = "Ketchup, Mustard, and Mayo";
        const string BURGERADDON3 = "French Fries";
        const string BURGERAOCOST = "Add-Ons ($1.25 each)";
        const decimal BURGERMAIN  = 7.95m;
        const decimal BURGERAO    = 1.25m;

        const string PIZZAADDON1 = "Pepperoni";
        const string PIZZAADDON2 = "Sausage";
        const string PIZZAADDON3 = "Olives";
        const string PIZZAAOCOST = "Add-Ons ($0.75 each)";
        const decimal PIZZAMAIN  = 6.95m;
        const decimal PIZZAAO    = 0.75m;

        const string SALADADDON1 = "Croutons";
        const string SALADADDON2 = "Bacon Bits";
        const string SALADADDON3 = "Breadsticks";
        const string SALADAOCOST = "Add-Ons ($0.50 each)";
        const decimal SALADMAIN  = 6.75m;
        const decimal SALADAO    = 0.50m;

        //  Declare and initialize class variables
        decimal taxRate         = 0.0775m;
        decimal priceMainCourse = 0.00m;
        decimal priceAddOn      = 0.00m;


        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            DetermineBill();
        }

        private void DetermineBill()
        {
            int numberOfAddOns = 0;

            if (chkAddOn1.Checked)
            {
                ++numberOfAddOns;
            }

            if (chkAddOn2.Checked)
            {
                ++numberOfAddOns;
            }

            if (chkAddOn3.Checked)
            {
                ++numberOfAddOns;
            }

            decimal subtotal = priceMainCourse + (numberOfAddOns * priceAddOn);
            decimal salesTax = subtotal * taxRate;
            decimal total    = subtotal + salesTax;

            txtSubtotal.Text   = $"{subtotal:c}";
            txtTax.Text        = $"{salesTax:c}";
            txtOrderTotal.Text = $"{total:c}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            ClearAddOns();
            ClearTotals();
        }

        private void ClearAddOns()
        {
            chkAddOn1.Checked = false;
            chkAddOn2.Checked = false;
            chkAddOn3.Checked = false;
        }

        private void ClearTotals()
        {
            txtSubtotal.Text   = "";
            txtTax.Text        = "";
            txtOrderTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            SetBurgerAsDefault();
        }

        private void SetBurgerAsDefault()
        {
            radBurger.Enabled = true;
            chkAddOn1.Text = BURGERADDON1;
            chkAddOn2.Text = BURGERADDON2;
            chkAddOn3.Text = BURGERADDON3;
            ClearAddOns();
            ClearTotals();
        }

        private void radBurger_CheckedChanged(object sender, EventArgs e)
        {
            SetBurger();
        }

        private void SetBurger()
        {
            priceMainCourse = BURGERMAIN;
            priceAddOn      = BURGERAO;

            chkAddOn1.Text = BURGERADDON1;
            chkAddOn2.Text = BURGERADDON2;
            chkAddOn3.Text = BURGERADDON3;
            gbAddOns.Text  = BURGERAOCOST;
            ClearAddOns();
            ClearTotals();
        }

        private void radPizza_CheckedChanged(object sender, EventArgs e)
        {
            SetPizza();
        }

        private void SetPizza()
        {
            priceMainCourse = PIZZAMAIN;
            priceAddOn      = PIZZAAO;

            chkAddOn1.Text = PIZZAADDON1;
            chkAddOn2.Text = PIZZAADDON2;
            chkAddOn3.Text = PIZZAADDON3;
            gbAddOns.Text  = PIZZAAOCOST;
            ClearAddOns();
            ClearTotals();
        }
        private void radSalad_CheckedChanged(object sender, EventArgs e)
        {
            SetSalad();
        }

        private void SetSalad()
        {
            priceMainCourse = SALADMAIN;
            priceAddOn      = SALADAO;

            chkAddOn1.Text = SALADADDON1;
            chkAddOn2.Text = SALADADDON2;
            chkAddOn3.Text = SALADADDON3;
            gbAddOns.Text  = SALADAOCOST;
            ClearAddOns();
            ClearTotals();
        }
    }
}
