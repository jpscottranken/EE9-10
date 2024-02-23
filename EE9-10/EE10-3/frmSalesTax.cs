using System;
using System.Windows.Forms;

namespace EE10_3
{
    public partial class frmSalesTax : Form
    {
        //  Declare and initialize program constants
        const decimal MINTAXRATE =  0.00m;
        const decimal MAXTAXRATE = 10.00m;

        //  Declare and initialize class variable
        decimal taxRate = 0.00m;

        public frmSalesTax()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Tag = txtSalesTax.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += IsPresent(txtSalesTax.Text.Trim(), "Sales Tax");
            errorMessage += IsDecimal(txtSalesTax.Text.Trim(), "Sales Tax");
            errorMessage += IsWithinRange(txtSalesTax.Text.Trim(), "Sales Tax",
                                         MINTAXRATE, MAXTAXRATE);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "ENTRY ERROR");
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

            if (!decimal.TryParse(value, out taxRate))
            {
                msg = $"{name} must be a valid decimal value.\n";
                txtSalesTax.Text = "";
                txtSalesTax.Focus();
            }

            return msg;
        }

        private string IsWithinRange(string value, string name,
                                     decimal min, decimal max)
        {
            string msg = "";

            if (taxRate < min || taxRate > max)
            {
                msg = $"{name} must be between {min} and {max}";
                txtSalesTax.Text = "";
                txtSalesTax.Focus();
            }

            return msg;
        }
    }
}
