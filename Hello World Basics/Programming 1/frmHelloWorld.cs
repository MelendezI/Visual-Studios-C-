using Microsoft.JScript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming_1
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
            pnlShow.Visible = false; //without this the panel will show at first,without this you will check then uncheck the box then check it again for it to work.

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "Hello World";
            txtFullName.ForeColor = Color.DarkGreen;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // lblMessage.text = ""; 
            txtFullName.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtFullName.Text;
            lblMessage.ForeColor = txtFullName.ForeColor;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void lblMessage_TextChanged(object sender, EventArgs e)
        {
            this.BtnClear.Enabled = true;
            btnShowMe.Enabled = true;
            this.BtnDisplayName.Enabled = true;
            this.rdoBlack.Enabled = true;
            this.rdoBlue.Enabled = true;
            this.rdoGreen.Enabled = true;
            this.rdoRed.Enabled = true;

            if (txtFullName.Text.Length > 0)
            {
                BtnDisplayName.Enabled = true;
            }
            else
            {
                BtnDisplayName.Enabled = false;
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnDisplayName_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtFullName.Text;
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {
            this.BtnClear.Enabled = false;
            BtnClose.Enabled = true;
            this.BtnDisplayName.Enabled = false;
            this.rdoBlack.Enabled = false;
            this.rdoBlue.Enabled = false;
            this.rdoGreen.Enabled = false;
            this.rdoRed.Enabled = false;

        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            txtFullName.ForeColor = Color.Red;
            pnlShow.BackColor = Color.Red;
        }

        private void rdoBlack_CheckedChanged(object sender, EventArgs e)
        {
            txtFullName.ForeColor = Color.Black;
            pnlShow.BackColor = Color.Black;
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            txtFullName.ForeColor = Color.Green;
            pnlShow.BackColor = Color.Green;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtFullName.ForeColor = Color.Blue;
            pnlShow.BackColor = Color.Blue;
        }

        private void pnlShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            pnlShow.Visible = chkShowHide.Checked;  //will make you check the box 2 times for it to work (check the code in the begining)
        }
    }
}
