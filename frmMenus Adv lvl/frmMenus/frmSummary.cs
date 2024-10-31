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
    public partial class frmSummary : Form
    {

        public frmSummary()
        {

            InitializeComponent();
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {

        }

        private void frmSummary_Activated(object sender, EventArgs e)
        {
            if(frmFunctions.TotalAmt > 0)
            {
                lblQuantity.Text = frmFunctions.sumQuantity.ToString();
                lblTotal.Text = frmFunctions.sumTotal.ToString("C");
                lblDiscount.Text = frmFunctions.sumDiscount.ToString();
                lblPrice.Text = frmFunctions.TotalAmt.ToString("C");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
