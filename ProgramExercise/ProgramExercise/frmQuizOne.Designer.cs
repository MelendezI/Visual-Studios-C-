namespace ProgramExercise
{
    partial class frmQuizOne
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckStateTax = new System.Windows.Forms.CheckBox();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.ckShowTotals = new System.Windows.Forms.CheckBox();
            this.grpSumInfo = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.btnClearNxt = new System.Windows.Forms.Button();
            this.btnClearALL = new System.Windows.Forms.Button();
            this.ckOutStateTax = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSumInfo = new System.Windows.Forms.Label();
            this.grpSumInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Blue Skateboards:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Yellow Skateboards:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Total Amount:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "TSCT Skating Association";
            // 
            // ckStateTax
            // 
            this.ckStateTax.AutoSize = true;
            this.ckStateTax.Location = new System.Drawing.Point(232, 212);
            this.ckStateTax.Name = "ckStateTax";
            this.ckStateTax.Size = new System.Drawing.Size(84, 17);
            this.ckStateTax.TabIndex = 4;
            this.ckStateTax.Text = "In State Tax";
            this.ckStateTax.UseVisualStyleBackColor = true;
            this.ckStateTax.CheckedChanged += new System.EventHandler(this.ckStateTax_CheckedChanged_1);
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTotalAmt.Location = new System.Drawing.Point(285, 244);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(129, 23);
            this.lblTotalAmt.TabIndex = 5;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(288, 113);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(115, 20);
            this.txtBlue.TabIndex = 6;
            this.txtBlue.TextChanged += new System.EventHandler(this.txtBlue_TextChanged);
            // 
            // txtYellow
            // 
            this.txtYellow.Location = new System.Drawing.Point(288, 165);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(115, 20);
            this.txtYellow.TabIndex = 7;
            this.txtYellow.TextChanged += new System.EventHandler(this.txtYellow_TextChanged);
            // 
            // ckShowTotals
            // 
            this.ckShowTotals.AutoSize = true;
            this.ckShowTotals.Location = new System.Drawing.Point(479, 301);
            this.ckShowTotals.Name = "ckShowTotals";
            this.ckShowTotals.Size = new System.Drawing.Size(85, 17);
            this.ckShowTotals.TabIndex = 8;
            this.ckShowTotals.Text = "Show Totals";
            this.ckShowTotals.UseVisualStyleBackColor = true;
            this.ckShowTotals.CheckedChanged += new System.EventHandler(this.ckShowTotals_CheckedChanged);
            // 
            // grpSumInfo
            // 
            this.grpSumInfo.Controls.Add(this.lblSumInfo);
            this.grpSumInfo.Location = new System.Drawing.Point(473, 324);
            this.grpSumInfo.Name = "grpSumInfo";
            this.grpSumInfo.Size = new System.Drawing.Size(225, 114);
            this.grpSumInfo.TabIndex = 9;
            this.grpSumInfo.TabStop = false;
            this.grpSumInfo.Text = "Summary Info";
            this.grpSumInfo.Enter += new System.EventHandler(this.grpSumInfo_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(176, 324);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(288, 366);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(75, 23);
            this.btnCLose.TabIndex = 11;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // btnClearNxt
            // 
            this.btnClearNxt.Location = new System.Drawing.Point(176, 366);
            this.btnClearNxt.Name = "btnClearNxt";
            this.btnClearNxt.Size = new System.Drawing.Size(75, 23);
            this.btnClearNxt.TabIndex = 12;
            this.btnClearNxt.Text = "Clear / Next";
            this.btnClearNxt.UseVisualStyleBackColor = true;
            this.btnClearNxt.Click += new System.EventHandler(this.btnClearNxt_Click);
            // 
            // btnClearALL
            // 
            this.btnClearALL.Location = new System.Drawing.Point(288, 324);
            this.btnClearALL.Name = "btnClearALL";
            this.btnClearALL.Size = new System.Drawing.Size(75, 23);
            this.btnClearALL.TabIndex = 13;
            this.btnClearALL.Text = "ClearAll";
            this.btnClearALL.UseVisualStyleBackColor = true;
            this.btnClearALL.Click += new System.EventHandler(this.btnClearALL_Click);
            // 
            // ckOutStateTax
            // 
            this.ckOutStateTax.AutoSize = true;
            this.ckOutStateTax.Location = new System.Drawing.Point(323, 212);
            this.ckOutStateTax.Name = "ckOutStateTax";
            this.ckOutStateTax.Size = new System.Drawing.Size(92, 17);
            this.ckOutStateTax.TabIndex = 14;
            this.ckOutStateTax.Text = "Out State Tax";
            this.ckOutStateTax.UseVisualStyleBackColor = true;
            this.ckOutStateTax.CheckedChanged += new System.EventHandler(this.ckOutStateTax_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblSumInfo
            // 
            this.lblSumInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSumInfo.Location = new System.Drawing.Point(6, 16);
            this.lblSumInfo.Name = "lblSumInfo";
            this.lblSumInfo.Size = new System.Drawing.Size(213, 95);
            this.lblSumInfo.TabIndex = 15;
            // 
            // frmQuizOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckOutStateTax);
            this.Controls.Add(this.btnClearALL);
            this.Controls.Add(this.btnClearNxt);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpSumInfo);
            this.Controls.Add(this.ckShowTotals);
            this.Controls.Add(this.txtYellow);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.ckStateTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuizOne";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQuizOne_Load);
            this.grpSumInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckStateTax;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.CheckBox ckShowTotals;
        private System.Windows.Forms.GroupBox grpSumInfo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.Button btnClearNxt;
        private System.Windows.Forms.Button btnClearALL;
        private System.Windows.Forms.CheckBox ckOutStateTax;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSumInfo;
    }
}

