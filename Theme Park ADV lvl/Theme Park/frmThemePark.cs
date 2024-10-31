using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theme_Park
{
    public partial class frmThemePark : Form
    {
        //--------------------Global Variables-------------------------------------------------
        private const Decimal REGULAR_PRICE = 49.95m;
        private const Decimal SENIOR_PRICE = 39.95m;
        private const Decimal TAX_RATE = 0.06m;

        private static Int32 intSumRegular = 0;
        private static Int32 intSumSenior = 0;

        private static Decimal decRegularTotal = 0;
        private static Decimal decSeniorTotal = 0;
        private static Decimal decTotalAmount = 0;

        private static Int32 intTotalTransactions = 0;

        //--------------------Variables to Enable & Disable buttons-------------------------------------------------
        private void EnabledButtons()
        {
            btnCal.Enabled = true;
            btnClear.Enabled = true;
            btnClearAll.Enabled = true;
            btnSum.Enabled = true;

        }
        private void DisableButtons()
        {
            btnCal.Enabled = false;
            btnClear.Enabled = false;
            btnClearAll.Enabled = false;
            btnSum.Enabled = false;

        }
        public frmThemePark()
        {
            InitializeComponent();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        //--------------------Exit Button-------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemePark_Load(object sender, EventArgs e)
        {
            btnCal.Enabled = false;// --------- diable buttons cal and clear on start
            btnClear.Enabled = false;
            btnClearAll.Enabled = false;
            btnSum.Enabled = false;
        }

        //--------------------Enable and disable text and buttons -------------------------------------------------
        private void txtRegular_TextChanged_1(object sender, EventArgs e)
        {
            if (txtRegular.Text.Trim().Length > 0)
            {
                EnabledButtons();
            }
            else if ((txtRegular.Text.Trim().Length > 0) || (txtRegular.Text.Trim().Length > 0))
            {
                EnabledButtons();
            }
            else
            {
                DisableButtons();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtSenior.Text.Trim().Length > 0)
            {
                EnabledButtons();
            }
            else if ((txtSenior.Text.Trim().Length > 0) || (txtSenior.Text.Trim().Length > 0))
            {
                EnabledButtons();
            }
            else
            {
                DisableButtons();
            }
        }
       
        

        //---------------void for clear and clearAll--------------------------------------

        private void ClearAll()
        {
            //Clear summary warning
            DialogResult btnDialog;
            string strResponse;

            strResponse = "Do you really want to clear all summary";
            //clicked button
            btnDialog = MessageBox.Show(strResponse, "chapter Four", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            

            //Clear Yes
            if (btnDialog == DialogResult.Yes)
            {
                //summary totals to zero
                intSumRegular = 0;
                intSumSenior = 0;

                Clear();
                DisableButtons();
            }

        }
        private void Clear()
        {
            txtRegular.Text = "";
            txtSenior.Text = "";
            lblTotal.Text = "";
            
            //disable
            DisableButtons();

            //enable
            EnabledButtons();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
            btnExit.Focus();
        }

        //------------------Calculation Funtion----------------------------------------------------------------
        private void Calculate(int regular, int senior)
        {
            decimal decRegular = 0;
            decimal decSenior = 0;
            decimal decTotal = 0;

            try
            {
                // Ensure at least one ticket type is selected
                if (regular > 0 || senior > 0)
                {
                    // Update cumulative counts for regular and senior tickets
                    intSumRegular += regular;
                    intSumSenior += senior;

                    // Calculate individual totals for regular and senior tickets
                    decRegular = regular * REGULAR_PRICE;
                    decSenior = senior * SENIOR_PRICE;

                    // Add to cumulative totals for regular and senior sales
                    decRegularTotal += decRegular;
                    decSeniorTotal += decSenior;

                    // Calculate the total amount for this transaction including tax
                    decTotal = (decRegular + decSenior) * (1 + TAX_RATE);

                    // Add this transaction's total to the grand total
                    decTotalAmount += decTotal;

                    // Increment total transactions count
                    intTotalTransactions += 1;

                    // Update the total label with the formatted amount
                    lblTotal.Text = decTotal.ToString("C");
                }
                else
                {
                    // Handle case where no valid input is provided
                    MessageBox.Show("Please enter at least one valid ticket quantity.");
                }
            }
            catch (Exception ex)
            {
                // Display or log the exception for debugging
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // Variables to hold parsed values
            int intSenior = 0;
            int intRegular = 0;

            try
            {
                // Attempt to parse both text boxes
                bool isRegularValid = Int32.TryParse(txtRegular.Text.Trim(), out intRegular);
                bool isSeniorValid = Int32.TryParse(txtSenior.Text.Trim(), out intSenior);

                // Check if at least one valid input is provided
                if (isRegularValid || isSeniorValid)
                {
                    // Call the Calculate method with parsed values
                    Calculate(intRegular, intSenior);
                }
                else
                {
                    // If neither input is valid, show a message
                    MessageBox.Show("Please enter valid numbers for regular or senior tickets.");
                }
            }
            catch (Exception ex)
            {
                // Display exception message for debugging
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //----------------Message window for Summary-----------------
            string msg = "Thank You:";
            string Caption = "Stevens Theme Park";
            decimal avgCost = decTotalAmount / intTotalTransactions;
            string summary = $"Total Transactions: {intTotalTransactions}\nAverage Cost per Transaction: {avgCost:C}\nYou Pay: {decTotalAmount:C}";
            decimal totalOfReg = intSumRegular * REGULAR_PRICE;
            decimal totalOfSen = intSumSenior * SENIOR_PRICE;

            try
            {
                if (decTotalAmount > 0)
                {
                    MessageBox.Show(msg + Environment.NewLine +
                        "Total # of Seniors:" + intSumSenior.ToString() + Environment.NewLine +
                        "Total Senior Amount :" + totalOfSen.ToString() + Environment.NewLine +
                        "Total # of Regulars:"  + intSumRegular.ToString() + Environment.NewLine +
                        "Total Regular Ammount:" + totalOfReg.ToString() + Environment.NewLine +
                        summary.ToString() + Environment.NewLine ,Caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception ex)
            {

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
