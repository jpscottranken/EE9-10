using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

/*
 *      In this exercise, you'll add code that 
 *      calculates the number of nights, total 
 *      price, and average price for a 
 *      reservation based on the arrival and 
 *      departure dates the user enters.
 *      
 *      1.  Create the GUI in Extra Exercise 9-1.
 *      
 *      2.  Modify the Click event handler for the 
 *          Calculate button so it gets the arrival 
 *          and departure dates the user enters. 
 *          
 *          Then, calculate the number of days 
 *          between those dates, calculate the total 
 *          price based on a price per night of $120, 
 *          calculate the average price per night, 
 *          and display the results.
 *          
 *      3.  Test the app to be sure it works correctly.
 *          At this point, the average price will be the 
 *          same as the nightly price.
 *          
 *      Enhance the way the form works
 *      ==============================
 *      
 *      4.  Add an event handler for the Load event of 
 *          the form. This event handler should get the 
 *          current date and three days after the 
 *          current date and assign these dates to the 
 *          Arrival Date and Departure Date text boxes 
 *          as default values. 
 *          
 *          Be sure to format the dates as shown above.
 *          
 *      5.  Modify the Click event handler for the 
 *          Calculate button so Friday and Saturday 
 *          nights are charged at $150 and other nights 
 *          are charged at $120. 
 *          
 *          One way to do this is to use a while loop 
 *          that checks the day for each date of the 
 *          reservation.
 *          
 *      6.  Test the app to be sure that the default 
 *          dates are displayed correctly and that the 
 *          totals are calculated correctly.
 *          
 *      Add code to validate the dates
 *      ==============================
 *      
 *      7.  Add code to the IsDateTime() method that 
 *          checks that a value is a valid date.
 *          
 *      8.  Add code to the IsWithinDateRange() method 
 *          that checks that a value is within a date 
 *          range that includes the minimum and maximum
 *          dates that are passed to it.
 *          
 *      9.  Add code to the IsLaterDate() method that 
 *          compares the two values passed to it and 
 *          makes sure the second value is later than 
 *          the first value.
 *          
 *      10. Add code to the IsValidDate() method that 
 *          uses the IsDateTime(), IsWithinDateRange(), 
 *          and IsLaterDate() methods to validate the 
 *          arrival and departure dates.
 *          
 *          These dates should be in a range from the 
 *          current date to five years after the current 
 *          date, and the departure date should be later 
 *          than the arrival date.
 *          
 *      11. Modify the Click event handler for the 
 *          Calculate button so it uses the IsValidData() 
 *          method to validate the arrival and departure 
 *          dates.
 *          
 *      12. Test the app to be sure the dates are 
 *          validated properly.
 */

namespace EE9_1
{
    public partial class Form1 : Form
    {
        //  Declare and initialize program constants
        const decimal NWPRICEPERNIGHT = 120.00m;
        const decimal WEPRICEPERNIGHT = 150.00m;

        public Form1()
        {
            InitializeComponent();
        }

        /*
         *  Modify the Click event handler for the 
         *  Calculate button so it gets the arrival 
         *  and departure dates the user enters. 
         *          
         *  Then, calculate the number of days 
         *  between those dates, calculate the total 
         *  price based on a price per night of $120, 
         *  calculate the average price per night, 
         *  and display the results.
         */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string arriveDate = GetArrivalDate();

            //if (IsNullOrEmpty(arriveDate))
            if (arriveDate == "")
            {
                return;
            }

            string departDate = GetDepartureDate(arriveDate);

            if (departDate == "")
            {
                return;
            }

            int totalDaysStayed = CalculateStayDays(DateTime.Parse(arriveDate),
                                                    DateTime.Parse(departDate));

            CalculateTotalCost(arriveDate, departDate, totalDaysStayed);
        }

        private string GetArrivalDate()
        {
            DateTime today = DateTime.Now;
            DateTime arriveDate;
            string ad = dtpArrivalDate.Value.ToString();

            if (DateTime.TryParse(ad, out arriveDate) && arriveDate < DateTime.Now)
            {
                ShowErrorMessage("You Cannot Set An Arrival Date In The Past!",
                                 "INVALID ARRIVAL DATE");
                return "";
            }

            return dtpArrivalDate.Value.ToShortDateString();
        }

        private string GetDepartureDate(string ad)
        {
            DateTime departureDate;
            string dd = dtpDepartureDate.Value.ToString();

            if (DateTime.TryParse(dd, out departureDate) && 
               departureDate < DateTime.Parse(ad))
            {
                ShowErrorMessage("Departure Date Must Be Later Than Arrival Date!",
                                 "INVALID DEPARTURE DATE");
                return "";
            }

            return dtpDepartureDate.Value.ToShortDateString();
        }

        private int CalculateStayDays(DateTime ad, DateTime dd)
        {
            return (int)(dd - ad).TotalDays;
        }

        private void CalculateTotalCost(string arrive, string depart, int tds)
        {
            decimal totalCost = 0.00m;
            decimal avgCost = 0.00m;

            DateTime ad = DateTime.Parse(arrive);
            DateTime dd = DateTime.Parse(depart);

            for (DateTime d = ad; d < dd; d = d.AddDays(1))
            {
                DayOfWeek dw = d.DayOfWeek;
                if (d.DayOfWeek == DayOfWeek.Friday ||
                    d.DayOfWeek == DayOfWeek.Saturday)
                {
                    totalCost += WEPRICEPERNIGHT;
                }
                else
                {
                    totalCost += NWPRICEPERNIGHT;
                }
            }

            avgCost = totalCost / tds;

            txtNumberOfNights.Text       = $"{tds}";
            txtTotalPrice.Text           = $"{totalCost:c}";
            txtAveragePricePerNight.Text = $"{avgCost:c}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNumberOfNights.Text = "";
            txtTotalPrice.Text = "";
            txtAveragePricePerNight.Text = "";
            SetDefaultDates();
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
                Close();
                //Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

       /*
        *   Add an event handler for the Load event of
        *   the form.This event handler should get the 
        *   current date and three days after the
        *   current date and assign these dates to the
        *   Arrival Date and Departure Date text boxes 
        *   as default values.
        *
        *   Be sure to format the dates as shown above.
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultDates();
        }

        private void SetDefaultDates()
        {
            dtpArrivalDate.Value   = DateTime.Today;
            dtpDepartureDate.Value = DateTime.Today.AddDays(3);
        }
    }
}
