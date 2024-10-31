using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenus
{
    public partial class frmFunctions : Form
    {
        public static Int32 sumQuantity;
        public static Decimal sumCost, sumDiscount, sumTotal; //---------Gloabal Values---------
        public static Int32 intQuantity = 0;
        public static Decimal TotalAmt = 0;
        public frmFunctions()
        {
            InitializeComponent();
        }
        private decimal Calculate(Int32 quantity, decimal cost, decimal discount)
        {
            // do calc
            decimal decSummary;
            //do calc x2
            decSummary = cost * quantity;
            //Calc Discount
            decSummary = decSummary - ((decSummary * discount) / 100);  //we dont need to declare decSummary a second time but as a good visual


            //store as summary totals
            sumQuantity = quantity;
            sumCost = cost;
            sumTotal = decSummary;
            sumDiscount = discount;
            //return values
            return decSummary;    //-------------- what will be returned by calc ------------------

            //return using function name
            /////calculate = decSummary

        }
        private void button1_Click(object sender, EventArgs e)//Calculate button
        {
            decimal decCost, decSummary, decDiscount, decDiscountAmt;
            try
            {
                intQuantity = Int32.Parse(txtQuantity.Text);
                try
                {
                    //check Cost
                    decCost = Decimal.Parse(txtCost.Text);
                    //check Discount
                    try
                    {
                        decDiscount = Decimal.Parse(txtDiscount.Text);
                        //do calc
                        decSummary = decCost * intQuantity;
                        //call function without return
                        //call func
                        lblTotal.Text = Calculate(intQuantity, decCost, decDiscount).ToString("C");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDiscount.Focus();
                        txtDiscount.SelectAll();
                    }
                }
                catch (Exception ex)
                {
                    txtDiscount.Focus();
                    txtDiscount.SelectAll();

                }
            }
            catch (Exception ex)
            {
                this.errorProvider1.SetError(txtQuantity, "error has occurred in quantity!");
                txtQuantity.Focus();
                txtQuantity.SelectAll();

            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFunctions_Load(object sender, EventArgs e)
        {
            this.mnuEditSumary.Enabled = true;
            this.mnuHideSummary.Enabled = true;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            this.mnuEditSumary.Enabled = true;
            this.mnuHideSummary.Enabled = true;
        }

        private void mnuEditSumary_Click(object sender, EventArgs e)
        {
            frmSummary aForm = new frmSummary();
            //modeless
            aForm.Show();


            //modal
            mnuEditSumary.Checked = true;
            mnuHideSummary.Checked = false;
        }

        private void mnuEditCalc_Click(object sender, EventArgs e)
        {
            if (mnuEditCalc.Checked)
            {
                mnuEditCalc.Checked = false;
            }
            else
            {
                mnuEditCalc.Checked = true;
            }
            button1_Click(sender, e);
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string StrMessage = "";
         StrMessage = "Programmed By:Ish" + Environment.NewLine +
                "Date:" + DateTime.Now.ToString();
            MessageBox.Show(StrMessage, "chapter five", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
