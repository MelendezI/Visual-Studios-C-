using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4
{
    public partial class frmLoginForm : Form
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }


        private void Clear()
        {
            //Clears all texts and lables -- the clear 
            this.txtUserName.Clear();
            this.txtPass.Clear();
            this.lblDisplay.Text = "";
        }
        private void frmLoginForm_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnLogin.Enabled = false;
            btnTeacher.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //declaring the variables
            Int32 intUserName = 0;
            Int32 intPassWord = 0;
            try
            {
                intUserName = this.txtUserName.Text.Trim().Length;
                intPassWord = this.txtPass.Text.Trim().Length;

                if (intUserName > 8)
                {
                    this.lblDisplay.Text = "User Name must be 8 charters";
                    this.txtUserName.Focus();
                    this.txtUserName.SelectAll();
                }
                else if (intPassWord < 8)
                {
                    this.lblDisplay.Text = "Pass Word must be 8 charitars";
                    this.txtPass.Focus();
                    this.txtPass.SelectAll();
                }
                else if ((intUserName >= 8) & (intPassWord >= 8))
                {
                    this.lblDisplay.Text = "You Can now Login";
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call Funtion
            Clear();
            //Set focus -- this is calling the "private void btnCear"
            this.txtUserName.Focus();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if ((txtUserName.Text.Trim().Length < 8) || (txtUserName.Text.Trim().Length < 8))
            {
                btnLogin.Enabled = false ;
                btnClear.Enabled = false;
                btnTeacher.Enabled = false;

            }
            else
            {
                btnLogin.Enabled = true;
                btnClear.Enabled = true;
                btnTeacher.Enabled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if ((txtPass.Text.Trim().Length < 8) || (txtPass.Text.Trim().Length < 8))
            {
                btnLogin.Enabled = false;
                btnClear.Enabled = false;
                btnTeacher.Enabled = false;

            }
            else
            {
                btnLogin.Enabled = true;
                btnClear.Enabled = true;
                btnTeacher.Enabled = true;
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            //declaring the cariable
            Int32 intUserName = 0;

            try
            {
                intUserName = this.txtUserName.Text.Trim().Length;

                    if (intUserName < 8)
                {
                    e.Cancel = true;
                    txtUserName.SelectAll();
                }
                else
                {
                    btnLogin.Enabled = true;
                    btnClear.Enabled = true;
                    btnTeacher.Enabled = true;
                }
                    

            }
            catch (Exception ex)
            {

            }
        }
    }
}
