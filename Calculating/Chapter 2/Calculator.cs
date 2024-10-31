using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_2
{
    public partial class Calculator
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const Decimal TAX_RATE = 0.06;
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            Int32 intQuantity = 0;
            Decimal decPrice = 0;
            Decimal decTotal = 0;
            intQuantity = Int32.Parse(txtQuantity.Text.Trim());
            decPrice = Decimal.Parse(txtPrice.Text.Trim());

            decTotal = (intQuantity * decPrice) * (1 + TAX_RATE);

            lblTotal.Text = decTotal.ToString("C");

        }
    }
}
