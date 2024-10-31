using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ChapterThree
{
    public partial class ChapterThree : Form
    {
        const decimal TAX_RATE = 0.06m;
        private Int32 intSumQuantity = 0;
        private decimal decSumCost = 0;
        private Int32 intSumTransaction = 0;

        private Int32 sumQuantity = 0;
        private decimal sumCost = 0;
        private decimal sumTotal = 0;
        private decimal sumTaxAmt = 0;

        public ChapterThree()
        {
            InitializeComponent();
            // access keys
            btnAvg.Text = "&Average";
            button4.Text = "Show &Total";
            btnSummary.Text = "&Summary";
            button6.Text = "&Clear All";
            button2.Text = "&Clear";

            //Accept and Cancel buttons
            this.AcceptButton = btnAvg;
            this.CancelButton = button3;

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ChapterThree_KeyDown);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSample.Enabled = false;

        }
        private class Transaction
        {
            public int Quantity { get; set; }
            public decimal Cost { get; set; }
            public decimal Tax { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private TextBox GetTaxAmt()
        {
            return taxAmt;
        }

        private decimal Calculate(Int32 quantity, decimal cost, decimal Tax_rate)
        {

            //do calcs
            decimal decSummary;
            //Cal tax
            decSummary = (cost * quantity) * (1 + Tax_rate);

            //store as summary
            intSumQuantity += quantity;
            decSumCost += decSummary;
            decimal sumTotal = decSummary;
            intSumTransaction += 1;

            //return values
            btnSample.Enabled = true;
            return decSumCost;
        }

        private void ChapterThree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                btnAvg.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.T)
            {
                button4.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                btnSummary.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                button6.PerformClick();  //all
            }
            else if (e.Control && e.KeyCode == Keys.L) //for clear
            {
                button3.PerformClick();  //Clear 
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string strFullName;
            Int32 intQuantity;
            decimal decCost, decTotalPay, decTaxRate;
            errorProvider1.Clear();
            try
            {
                intQuantity = Int32.Parse(txtQuantity.Text);
                try
                {
                    decCost = Int32.Parse(txtCost.Text);
                    try
                    {
                        //
                        decTaxRate = Decimal.Parse(taxAmt.Text);
                        lblTotalCost.Text = Calculate(intQuantity, decCost, decTaxRate).ToString("C");
                    }
                    catch (Exception ex)
                    {

                        errorProvider1.SetError(taxAmt, "Error has occured.");
                    }
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtCost, "Error has occured.");
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtQuantity, "Error has occured.");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateDisplay.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtCost.Text = string.Empty;
            taxAmt.Text = string.Empty;

        }

        private void btnSample_Click(object sender, EventArgs e)
        {
            string strMessage = "";
            string strError = " Quantity Must Be grator than Zero";
                try
                {
                    if (intSumQuantity > 0)
                    {
                        strMessage = "Chapter Three" + Environment.NewLine + "Total Quantity Sold: " + intSumQuantity.ToString("N0");
                            MessageBox.Show(strMessage, "Chapter 3", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                else
                {
                MessageBox.Show(strError, "Chapter Three", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtQuantity, "Error has occured!");
                txtQuantity.Focus();
                txtQuantity.SelectAll();
            }

           
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            if (intSumTransaction > 0)
            {
                decimal avgCost = decSumCost / intSumTransaction;
                MessageBox.Show($"Average cost per transaction: {avgCost:C}", "Average", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No transactions to calculate the average.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtCost.Text = string.Empty;
            taxAmt.Text = string.Empty;
            lblTotalCost.Text = string.Empty;
            intSumQuantity = 0;
            decSumCost = 0;
            txtQuantity.Focus();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            string totalSummary = $"Total Quantity: {intSumQuantity}\nTotal Cost: {decSumCost:C}\nTotal Transactions: {intSumTransaction}";
            MessageBox.Show(totalSummary, "Total Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            decimal avgCost = intSumTransaction > 0 ? decSumCost / intSumTransaction : 0;
            string summary = $"Total Cost: {decSumCost:C}\nTotal Transactions: {intSumTransaction}\nAverage Cost per Transaction: {avgCost:C}";
            MessageBox.Show(summary, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
