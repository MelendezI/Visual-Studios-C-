using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramExercise
{
    public partial class frmQuizOne : Form
    {
        // Constants for skateboard prices
        const decimal BluePrice = 24.99m;
        const decimal YellowPrice = 15.97m;

        // Tax rates
        const decimal InStateTax = 0.04m;
        const decimal OutStateTax = 0.06m;

        // Accumulators for summary totals
        int totalBlue = 0;
        int totalYellow = 0;
        decimal totalAmmount = 0;

        public frmQuizOne()
        {
            InitializeComponent();
        }
        private void disabledButtons(object sender, EventArgs e)  //OOP of Disabled buttons
        {
            btnCalculate.Enabled = false;
            btnClearALL.Enabled = false;
            btnClearNxt.Enabled = false;
        }
        private void enabledButtons(object sender, EventArgs e)  //OOP of Enabled buttons
        {
            btnCalculate.Enabled = true;
            btnClearALL.Enabled = true;
            btnClearNxt.Enabled = true;
            ckShowTotals.Enabled = true;
        }
        private void frmQuizOne_Load(object sender, EventArgs e)
        {
            disabledButtons(sender, e);
            ckShowTotals.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous error messages
            errorProvider1.Clear();
            bool hasError = false;

            if (!int.TryParse(txtBlue.Text, out int quantityBlue) || quantityBlue < 0)
            {
                errorProvider1.SetError(txtBlue, "Please enter a valid quantity.");
                hasError = true;
            }

            //Yellow skateboard (defaults to 0 if empty)
            int quantityYellow = 0;
            if (!string.IsNullOrWhiteSpace(txtYellow.Text))
            {
                if (!int.TryParse(txtYellow.Text, out quantityYellow) || quantityYellow < 0)
                {
                    errorProvider1.SetError(txtYellow, "Please enter a valid quantity.");
                    hasError = true;
                }
            }

            // Stop if there are errors
            if (hasError) return;

            // Calculate (without tax)
            decimal subtotal = (quantityBlue * BluePrice) + (quantityYellow * YellowPrice);


            decimal total = subtotal;

            // Apply the correct tax based on the selected checkbox
            if (ckStateTax.Checked)
            {
                total += subtotal * InStateTax;  // Add in-state tax
            }
            else if (ckOutStateTax.Checked)
            {
                total += subtotal * OutStateTax;  // Add out-of-state tax
            }

            totalBlue += quantityBlue;
            totalYellow += quantityYellow;
            totalAmmount += total;

            lblTotalAmt.Text = $"Total (with tax): {total:C}";

            // Notify the user that the calculation was successful
            MessageBox.Show("Calculation Successful!");
        }

        private void btnClearALL_Click(object sender, EventArgs e)
        {
            {
                totalBlue = 0;
                totalYellow = 0;
                totalAmmount = 0;

                txtBlue.Text = "";
                txtYellow.Text = "";
                lblTotalAmt.Text = "";
                lblSumInfo.Text = "";

                MessageBox.Show("All of Sale Data is Cleared!");
                txtBlue.Focus();
            }
        }

        private void ckShowTotals_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowTotals.Checked)
            {
                lblSumInfo.Text = $"Blue Sales: {totalBlue}\n" +
                                  $"Yellow Sales: {totalYellow}\n" +
                                  $"Total Revenue: {totalAmmount:C}";
            }
            else
            {
                lblSumInfo.Text = "";  // Clear the summary display
            }
        }

        private void btnClearNxt_Click(object sender, EventArgs e)
        {
            txtBlue.Text = "";
            txtYellow.Text = "";
            lblTotalAmt.Text = "";

            MessageBox.Show("Current Sale CLeared!");
            txtBlue.Focus();  // Set focus to the first input field
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckOutStateTax_CheckedChanged(object sender, EventArgs e) //Disabled and Enabled depending on whats checked Tax buttons
        {
            if (ckOutStateTax.Checked)
            {
                ckStateTax.Enabled = false;

            }
            if (!ckOutStateTax.Checked)
            {
                ckStateTax.Enabled = true;
            }
        }

        private void ckStateTax_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckStateTax.Checked)
            {
                ckOutStateTax.Enabled = false;

            }
            if (!ckStateTax.Checked)
            {
                ckOutStateTax.Enabled = true;
            }
        }

        private void txtBlue_TextChanged(object sender, EventArgs e)
        {
            enabledButtons(sender, e);

            if (txtBlue.Text.Length < 1)
            {
                disabledButtons(sender, e);
            }
        }

        private void txtYellow_TextChanged(object sender, EventArgs e)
        {
            enabledButtons(sender, e);

            if (txtYellow.Text.Length < 1)
            {
                disabledButtons(sender, e);
            }
        }

        private void grpSumInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
