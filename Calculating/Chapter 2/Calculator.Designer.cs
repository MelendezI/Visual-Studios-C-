namespace Chapter_2
{
    partial class Calculator
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
            this.grpPriceCal = new System.Windows.Forms.GroupBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBetter = new System.Windows.Forms.Button();
            this.btnBest = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpPriceCal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPriceCal
            // 
            this.grpPriceCal.Controls.Add(this.btnCal);
            this.grpPriceCal.Controls.Add(this.btnExit);
            this.grpPriceCal.Controls.Add(this.lblPrice);
            this.grpPriceCal.Controls.Add(this.label1);
            this.grpPriceCal.Controls.Add(this.lblQuantity);
            this.grpPriceCal.Controls.Add(this.lblTotalCost);
            this.grpPriceCal.Controls.Add(this.textBox1);
            this.grpPriceCal.Controls.Add(this.textBox2);
            this.grpPriceCal.Location = new System.Drawing.Point(177, 96);
            this.grpPriceCal.Name = "grpPriceCal";
            this.grpPriceCal.Size = new System.Drawing.Size(292, 246);
            this.grpPriceCal.TabIndex = 0;
            this.grpPriceCal.TabStop = false;
            this.grpPriceCal.Text = "Price Calculator";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(102, 187);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(35, 85);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(32, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Cost:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantity.Location = new System.Drawing.Point(35, 49);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 20);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalCost.Location = new System.Drawing.Point(117, 130);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(132, 29);
            this.lblTotalCost.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnGood
            // 
            this.btnGood.Location = new System.Drawing.Point(475, 111);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(75, 23);
            this.btnGood.TabIndex = 1;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBetter
            // 
            this.btnBetter.Location = new System.Drawing.Point(475, 160);
            this.btnBetter.Name = "btnBetter";
            this.btnBetter.Size = new System.Drawing.Size(75, 23);
            this.btnBetter.TabIndex = 2;
            this.btnBetter.Text = "Better";
            this.btnBetter.UseVisualStyleBackColor = true;
            // 
            // btnBest
            // 
            this.btnBest.Location = new System.Drawing.Point(475, 212);
            this.btnBest.Name = "btnBest";
            this.btnBest.Size = new System.Drawing.Size(75, 23);
            this.btnBest.TabIndex = 3;
            this.btnBest.Text = "Best";
            this.btnBest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBest);
            this.Controls.Add(this.btnBetter);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.grpPriceCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPriceCal.ResumeLayout(false);
            this.grpPriceCal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPriceCal;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBetter;
        private System.Windows.Forms.Button btnBest;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}