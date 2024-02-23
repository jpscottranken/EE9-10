using System;
using System.Windows.Forms;

/*
 *      Write code to parse an email address
 *      and a city, state zipcode.
 *      
 *      1.  Create the GUI shown in Extra Exercise 9-2;
 *      
 *      2.  Add code to parse the email address into two 
 *          parts when the user clicks the Parse button: 
 *          the user name   before the @ sign and 
 *          the domain name after  the @ sign. 
 *          
 *          Be sure to check that the email contains an 
 *          @ sign before you parse it, and display an 
 *          error message if it doesn't. 
 *          
 *          Also, be sure to remove any leading or trailing 
 *          spaces that the user enters.
 *          
 *          Display the results in a dialog like the first 
 *          one shown.
 *          
 *      3.  Test the app with both valid and invalid email 
 *          addresses to be sure it works correctly.
 *          
 *      Add code to format a street address
 *      ===================================
 *      
 *      4.  Add code to format the city, state, and zip code 
 *          when the user clicks the Format button. 
 *          
 *          To do that, create a string that contains the 
 *          city, state, and zip code and then use the 
 *          Insert() method to insert the appropriate 
 *          characters. 
 *          
 *          Be sure that the two-character state code is in 
 *          uppercase. (You can assume that the user enters a
 *          appropriate data in each text box.) 
 *          
 *          Display the results in a dialog like the second one 
 *          shown.
 *          
 *      5.  Test the app to be sure it formats the city, state, 
 *          and zip code correctly.
 */

namespace EE9_2
{
    public partial class Form1 : Form
    {
        //  Declare and initialize program constants
        const string NOEMAIL    = "NO EMAIL ADDRESS PROVIDED!";
        const string MALFORMED  = "MALFORMED EMAIL (NO '@')!";
        const string USERNAME   = "User Name: ";
        const string DOMAINNAME = "Domain Name: ";
        const string CITYSTATEZIP = "City, State, Zip: ";
        const string FO         = "FORMATTED OUTPUT!";
        const string NUN        = "NO USER NAME!";
        const string NDN        = "NO DOMAIN NAME";
        const string PEA        = "PARSED EMAIL ADDRESS";

        //  Declare and initialize class variables
        string msg;
        string[] pieces;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseEmail_Click(object sender, EventArgs e)
        {
            ParseTheEmail();
        }

        private void ParseTheEmail()
        {
            bool result;
            msg = "";

            try
            {
                result = IsPresent(txtEmailAddress.Text,
                                   txtEmailAddress.Tag.ToString());

                if (!result)
                {
                    throw new ArgumentNullException();
                }

                //  If we get to here, the email texbox
                //  was not empty. Make sure it has a '@'.
                result = ContainsAnAtSign(txtEmailAddress.Text,
                                          txtEmailAddress.Tag.ToString());

                if (!result)
                {
                    throw new FormatException();
                }

                //  If we get to here, there was an
                //  email in the textbox with an '@'
                //  in it. Parse the email into the
                //  user name and domain name.
                //  Then display them both.
                SplitUpTheEmail();
            }
            catch (ArgumentNullException ane)
            {
                ClearForm();
                ShowErrorMessage("SystemMessage:\t" + ane.Message +
                                 "\n\nProgrammer Message:\t" + msg,
                                 NOEMAIL);
                txtEmailAddress.Focus();
            }
            catch (FormatException fe)
            {
                ClearForm();
                ShowErrorMessage("SystemMessage:\t" + fe.Message +
                                 "\n\nProgrammer Message:\t" + msg,
                                 MALFORMED);
                txtEmailAddress.Text = "";
                txtEmailAddress.Focus();
            }
        }

        private bool IsPresent(string value, string name)
        {
            bool retVal = true;
            msg = "";

            if (value == "")
            {
                msg += name + " is a required field!\n";
                retVal = false;
            }

            return retVal;
        }

        private bool ContainsAnAtSign(string value, string name)
        {
            bool retVal = true;
            msg = "";

            if (!value.Contains("@"))
            {
                msg += name + " does not contain '@'\n";
                retVal = false;
            }

            return retVal;
        }

        private void SplitUpTheEmail()
        {
            string userName;
            string domainName;
            string outputStr = "";

            pieces = txtEmailAddress.Text.Split('@');
            userName = pieces[0];
            domainName = pieces[1];

            if (userName == "")
            {
                ShowErrorMessage("No User Name Was Entered", NUN);
                txtEmailAddress.Text = "";
                txtEmailAddress.Focus();
                return;
            }

            if (domainName == "")
            {
                ShowErrorMessage("No Domain Name Was Entered", NDN);
                txtEmailAddress.Text = "";
                txtEmailAddress.Focus();
                return;
            }

            //  Valid email address entered
            outputStr += USERNAME + userName + "\n";
            outputStr += DOMAINNAME + domainName;
            ShowErrorMessage(outputStr, PEA);
        }


        private void btnFormatAddress_Click(object sender, EventArgs e)
        {
            FormatTheAddress();
        }

        private void FormatTheAddress()
        {
            if (txtCity.Text.Trim() == "")
            {
                ShowErrorMessage("You Must Enter A City!!!",
                                 "NO CITY PROVIDED");
                txtCity.Focus();
                return;
            }

            if (txtState.Text.Trim() == "")
            {
                ShowErrorMessage("You Must Enter A State!!!",
                                 "NO STATE PROVIDED");
                txtState.Focus();
                return;
            }

            if (txtZipCode.Text.Trim() == "")
            {
                ShowErrorMessage("You Must Enter A Zip Code!!!",
                                 "NO ZIPCODE PROVIDED");
                txtZipCode.Focus();
                return;
            }

            //  There was input for the city, the
            //  state, and the zipcode. So display all.
            string outputStr = CITYSTATEZIP;
            outputStr += txtCity.Text + ", ";
            outputStr += txtState.Text.ToUpper() + " ";
            outputStr += txtZipCode.Text;
            ShowErrorMessage(outputStr, FO);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEmailAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            txtEmailAddress.Focus();
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
