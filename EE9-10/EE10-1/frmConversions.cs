using System;
using System.Windows.Forms;

/*
 *      In Exercise 10-1, you'll add code to a 
 *      form that converts the value the user 
 *      enters based on the selected conversion 
 *      type.
 *      
 *      The app should handle the following 
 *      conversions: 
 *      
 *      Miles to Kilometers   1 mile = 1.6093 kilometers 
 *      Kilometers to Miles   1 kilometer = 0.6214 miles 
 *      Feet To Meters        1 foot = 0.3048 meters 
 *      Meters To Feet        1 meter = 3.2808 feet 
 *      Inches To Centimeters 1 inch = 2.54 centimeters 
 *      Centimeters To Inches 1 centimeter = 0.3937 inches
 *      
 *      1.  Create the GUI shown in EE 10-1.0 directory. 
 *          Display the code for the form, and notice the 
 *          rectangular array whose rows contain the value 
 *          to be displayed in the combo box, the text for 
 *          the labels that identify the two text boxes, 
 *          and the multiplier for the conversion as shown 
 *          above.
 *          
 *      2.  Set the DropDownStyle property of the combo box 
 *          so the user must select an item from the list.
 *          
 *      3.  Add code to load the combo box with the first 
 *          element in each row of the rectangular array, 
 *          and display the first item in the combo box when 
 *          the form is loaded.
 *          
 *      4.  Add code to change the labels for the text boxes, 
 *          clear the calculated length, and move the focus to 
 *          the entry text box when the user selects a different 
 *          item from the combo box.
 *          
 *      5.  Test the app to be sure the conversions are displayed 
 *          in the combo box, the first conversion is selected by 
 *          default, and the labels change appropriately when a 
 *          different conversion is selected.
 *          
 *      6.  Add code to calculate and display the converted length 
 *          when the user clicks the Calculate button.   
 *          
 *          To calculate the length, you can get the index for the 
 *          selected conversion and then use that index to get the 
 *          multiplier from the array. 
 *          
 *          Test the app to be sure this works correctly.
 *          
 *      7.  Add code to check that the user enters a valid decimal 
 *          value for the length. 
 *          
 *          Then, test the app one more time to be sure the 
 *          validation works correctly.
 */

namespace EE10_1
{
    public partial class frmConversions : Form
    {
        //  Declare and initialize program constants
        const string MILE = "Miles";
        const string KILO = "Kilometers";
        const string FEET = "Feet";
        const string METR = "Meters";
        const string INCH = "Inches";
        const string CENT = "Centimeters";
        const string MTOK = "Miles To Kilometers";
        const string KTOM = "Kilometers To Miles";
        const string FTOM = "Feet To Meters";
        const string MTOF = "Meters To Feet";
        const string ITOC = "Inches To Centimeters";
        const string CTOI = "Centimeters To Inches";

        public frmConversions()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //  Valid that the values in both the dropdown list
                //  and the "from" textbox are indeed valid values.
                if (IsValidData())
                {
                    decimal from = Convert.ToDecimal(txtFrom.Text.Trim());
                    SetLabelsAndPerformCalculation(from);
                }
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message + "\n\n" +
                                 fe.GetType().ToString() + "\n" +
                                 fe.StackTrace, "FORMATEXCEPTION");
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            //  Validate the dropdownlist
            errorMessage += IsNoDropDownListOptionSelected(
                ddlConversion.SelectedIndex.ToString(), "DropDown List");

            errorMessage += IsPresent(txtFrom.Text.Trim(), "From TextBox");
            errorMessage += IsDecimal(txtFrom.Text.Trim(), "From TextBox");

            if (errorMessage != "")
            {
                success = false;
                ShowErrorMessage(errorMessage, "ENTRY ERROR");
            }

            return success;
        }

        private string IsNoDropDownListOptionSelected(string value, string name)
        {
            string msg = "";

            if (ddlConversion.SelectedIndex < 0)
            {
                msg = name + " must have a dropdown item selected.\n";
            }

            return msg;
        }

        private string IsPresent(string value, string name)
        {
            string msg = "";

            if (value == "")
            {
                msg = name + " is a required field.\n";
            }

            return msg;
        }

        private string IsDecimal (string value, string name)
        {
            string msg = "";
            decimal result = 0m;

            if (!Decimal.TryParse(value, out result))
            {
                msg = name + " must be a valid decimal value.\n";
                txtFrom.Text = "";
                txtFrom.Focus();
            }
            else if (result <= 0)
            {
                msg = name + " must be a positive (> 0) decimal value.\n";
                txtFrom.Text = "";
                txtFrom.Focus();
            }

            return msg;
        }

        private void SetLabelsAndPerformCalculation(decimal fromValue)
        {
            string fromStr = "";
            string toStr   = "";
            decimal result = 0m;

            if (!IsValidData())
            {
                btnCalculate.Enabled = false;
                return;
            }

            btnCalculate.Enabled = true;

            switch (ddlConversion.SelectedIndex)
            {
                case 0:
                    fromStr = MILE;
                    toStr   = KILO;
                    result  = fromValue * 1.6093m;
                    break;

                case 1:
                    fromStr = KILO;
                    toStr   = MILE;
                    result  = fromValue * 0.6214m;
                    break;

                case 2:
                    fromStr = FEET;
                    toStr   = METR;
                    result = fromValue * 0.3048m;
                    break;

                case 3:
                    fromStr = METR;
                    toStr   = FEET;
                    result  = fromValue * 3.2808m;
                    break;

                case 4:
                    fromStr = INCH;
                    toStr   = CENT;
                    result  = fromValue * 2.54m;
                    break;

                case 5:
                    fromStr = CENT;
                    toStr   = INCH;
                    result  = fromValue * 0.3937m;
                    break;

                default:
                    fromStr = MILE;
                    toStr   = KILO;
                    result  = fromValue * 1.6093m;
                    break;
            }

            lblFrom.Text   = fromStr;
            lblTo.Text     = toStr;
            txtTo.Text     = result.ToString("n4");
            //txtTo.Text = $"{result:n4}");
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFrom.Text = "";
            txtTo.Text   = "";
            lblFrom.Text = "From";
            lblTo.Text   = "To";
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

        private void frmConversions_Load(object sender, EventArgs e)
        {
            LoadDropDownList();
        }

        private void LoadDropDownList()
        {
            ddlConversion.Items.Clear();
            ddlConversion.Items.Add(MTOK);
            ddlConversion.Items.Add(KTOM);
            ddlConversion.Items.Add(FTOM);
            ddlConversion.Items.Add(MTOF);
            ddlConversion.Items.Add(ITOC);
            ddlConversion.Items.Add(CTOI);
            ddlConversion.SelectedIndex = 0;
        }

        private void ddlConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
