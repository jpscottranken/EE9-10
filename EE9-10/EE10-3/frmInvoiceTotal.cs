using System;
using System.Windows.Forms;

/*
 *      Extra 10-3 Add a second form to an app
 *      
 *      In Exercise 10-3, you;ll add a second form
 *      to an Invoice Total app that lets the user
 *      change the sales tax percent.
 *      
 *      1.  Create the GUI shown in Extra Exercise 10-3.
 *      
 *      2.  Change the name of the existing form to 
 *          frmInvoiceTotal.
 *          
 *      Create the Sales Tax form
 *      
 *      3.  Add another form named frmSalesTax to the 
 *          project.
 *          
 *      4.  Add a label, text box, and two buttons to the
 *          new form and set the properties of the form 
 *          and its controls so they appear as shown above.
 *          
 *          When the user presses the Enter key, the Click
 *          event of the OK button should fire.
 *          
 *          When the user presses the Esc key, the Click
 *          event of the Cancel button should fire.
 *          
 *     5.   Add code to get the sales tax, store it in the
 *          Tag property of the form, and set the DialogResult
 *          property of the form to OK when the user clicks
 *          the OK button.
 *          
 *      Modify the code for the Invoice Total form
 *      
 *      6.  Change the SalesTax constant that’s declared in
 *          the Invoice Total form so its value can be changed.
 *      
 *      7.  Add a Change Percent button to the Invoice Total
 *          form as shown above. 
 *          
 *          Then, add code that displays the Sales Tax form and
 *          gets the result when the user clicks this button.
 *          
 *          If the user clicks the OK button on the Sales Tax
 *          form, this event handler should store the new sales
 *          tax percent in the sales tax variable and change
 *          the Tax label on the form so it displays the correct
 *          tax. 
 *          
 *          Test the app to be sure this works correctly.
 *          
 *      8.  Add data validation to the Sales Tax form to check
 *          that the user enters a decimal value between 0 and
 *          10 (noninclusive).
 *          
 *          To make that easier, you can copy the IsPresent(),
 *          IsDecimal(), and IsWithinRange() methods from the
 *          Invoice Total form.
 *          
 *          Test the app to be sure the validation works
 *          correctly.
 */

namespace EE10_3
{
    public partial class frmInvoiceTotal : Form
    {
        //  Declare and initialize global constant
        const decimal DISCOUNTRATE   =       0.1m;
        const decimal MINPRODUCTCOST =       1.00m;
        const decimal MAXPRODUCTCOST = 1000000.00m;

        //  Declare and initialize class variables
        decimal taxRate     = 0.0775m;
        decimal productCost = 0.00m;

        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                CalculateTotals();
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += IsPresent(txtProductTotal.Text.Trim(), "Product Total");
            errorMessage += IsDecimal(txtProductTotal.Text.Trim(), "Product Total");
            errorMessage += IsWithinRange(txtProductTotal.Text.Trim(), "Product Total",
                                         MINPRODUCTCOST, MAXPRODUCTCOST);

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "ENTRY ERROR");
            }

            return success;
        }

        private string IsPresent(string value, string name)
        {
            string msg = "";

            if (value == "")
            {
                msg = $"{name} is a required field.\n";
            }

            return msg;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";

            if (!decimal.TryParse(value, out productCost))
            {
                msg = $"{name} must be a valid decimal value.\n";
            }

            return msg;
        }

        private string IsWithinRange(string value, string name,
                                     decimal min, decimal max)
        {
            string msg = "";

            if (productCost < min || productCost > max)
            {
                msg = $"{name} must be between {min} and {max}";    
            }

            return msg;
        }

        private void CalculateTotals()
        {
            decimal discountAmount = productCost * DISCOUNTRATE;
            decimal subtotal       = productCost - discountAmount;
            decimal taxTotal       = subtotal * taxRate;
            decimal finalTotal     = subtotal + taxTotal;

            txtProductTotal.Text   = $"{productCost:c}";
            txtDiscountAmount.Text = $"{discountAmount:c}";
            txtSubtotal.Text       = $"{subtotal:c}";
            txtTax.Text            = $"{taxTotal:c}";
            txtTotal.Text          = $"{finalTotal:c}";
        }

        private void btnChangePct_Click(object sender, EventArgs e)
        {
            ShowOtherForm();
        }

        private void ShowOtherForm()
        {
            ClearForm();
            Form frmSalaesTax = new frmSalesTax();
            DialogResult result = frmSalaesTax.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                taxRate     = Convert.ToDecimal(frmSalaesTax.Tag);
                lblTax.Text = $"Tax ({taxRate}%): ";
                taxRate    /= 100;
                ClearForm();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtProductTotal.Text = "";
            txtDiscountAmount.Text = "";
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtProductTotal.Focus();
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
    }
}
