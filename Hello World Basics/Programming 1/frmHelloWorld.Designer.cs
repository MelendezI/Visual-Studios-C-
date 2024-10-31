namespace Programming_1
{
    partial class frmHelloWorld
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelloWorld));
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnShowMe = new System.Windows.Forms.Button();
            this.BtnDisplayName = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlShow = new System.Windows.Forms.Panel();
            this.chkShowHide = new System.Windows.Forms.CheckBox();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(148, 156);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(279, 20);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextChanged += new System.EventHandler(this.lblMessage_TextChanged);
            // 
            // btnShowMe
            // 
            this.btnShowMe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowMe.Location = new System.Drawing.Point(148, 435);
            this.btnShowMe.Name = "btnShowMe";
            this.btnShowMe.Size = new System.Drawing.Size(62, 31);
            this.btnShowMe.TabIndex = 2;
            this.btnShowMe.Text = "Show Me";
            this.toolTip1.SetToolTip(this.btnShowMe, "Will Enter Hello World");
            this.btnShowMe.UseVisualStyleBackColor = false;
            this.btnShowMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDisplayName
            // 
            this.BtnDisplayName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDisplayName.CausesValidation = false;
            this.BtnDisplayName.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnDisplayName.Location = new System.Drawing.Point(487, 93);
            this.BtnDisplayName.Name = "BtnDisplayName";
            this.BtnDisplayName.Size = new System.Drawing.Size(106, 41);
            this.BtnDisplayName.TabIndex = 3;
            this.BtnDisplayName.Text = "Display Name";
            this.toolTip1.SetToolTip(this.BtnDisplayName, "Display Current Text to Panel");
            this.BtnDisplayName.UseVisualStyleBackColor = false;
            this.BtnDisplayName.Click += new System.EventHandler(this.BtnDisplayName_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClear.Location = new System.Drawing.Point(487, 143);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(106, 28);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.BtnClear, "Clear Current Displayed Text");
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.Location = new System.Drawing.Point(487, 249);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 33);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Add to Panel";
            this.toolTip1.SetToolTip(this.btnPrint, "Converts Text into Selected Color within Panel");
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Location = new System.Drawing.Point(533, 379);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 31);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.toolTip1.SetToolTip(this.BtnClose, "Exit Program");
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.button5_Click);
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.rdoBlue);
            this.grpColor.Controls.Add(this.rdoRed);
            this.grpColor.Controls.Add(this.rdoBlack);
            this.grpColor.Controls.Add(this.rdoGreen);
            this.grpColor.Location = new System.Drawing.Point(148, 195);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(279, 87);
            this.grpColor.TabIndex = 8;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color Selection";
            this.grpColor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(174, 54);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(46, 17);
            this.rdoBlue.TabIndex = 14;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(22, 28);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 17);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoBlack
            // 
            this.rdoBlack.AutoSize = true;
            this.rdoBlack.Location = new System.Drawing.Point(174, 28);
            this.rdoBlack.Name = "rdoBlack";
            this.rdoBlack.Size = new System.Drawing.Size(52, 17);
            this.rdoBlack.TabIndex = 12;
            this.rdoBlack.TabStop = true;
            this.rdoBlack.Text = "Black";
            this.rdoBlack.UseVisualStyleBackColor = true;
            this.rdoBlack.CheckedChanged += new System.EventHandler(this.rdoBlack_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(22, 54);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(54, 17);
            this.rdoGreen.TabIndex = 13;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(148, 93);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(279, 45);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pnlShow
            // 
            this.pnlShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlShow.Location = new System.Drawing.Point(148, 305);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(279, 105);
            this.pnlShow.TabIndex = 11;
            this.toolTip1.SetToolTip(this.pnlShow, "Display Current Selected Color");
            this.pnlShow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShow_Paint);
            // 
            // chkShowHide
            // 
            this.chkShowHide.AutoSize = true;
            this.chkShowHide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkShowHide.Location = new System.Drawing.Point(433, 305);
            this.chkShowHide.Name = "chkShowHide";
            this.chkShowHide.Size = new System.Drawing.Size(86, 18);
            this.chkShowHide.TabIndex = 12;
            this.chkShowHide.Text = "Show/Hide";
            this.toolTip1.SetToolTip(this.chkShowHide, "Will Show/Hide Color Panel");
            this.chkShowHide.UseVisualStyleBackColor = true;
            this.chkShowHide.CheckedChanged += new System.EventHandler(this.chkShowHide_CheckedChanged);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 522);
            this.Controls.Add(this.chkShowHide);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDisplayName);
            this.Controls.Add(this.btnShowMe);
            this.Controls.Add(this.txtFullName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHelloWorld";
            this.Text = "HelloWorld";
            this.Load += new System.EventHandler(this.frmHelloWorld_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnShowMe;
        private System.Windows.Forms.Button BtnDisplayName;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.CheckBox chkShowHide;
    }
}