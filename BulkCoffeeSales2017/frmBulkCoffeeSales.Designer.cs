﻿namespace BulkCoffeeSales2017
{
    partial class frmBulkCoffeeSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBulkCoffeeSales));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindPrice = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFullPound = new System.Windows.Forms.RadioButton();
            this.rdoHalfPound = new System.Windows.Forms.RadioButton();
            this.rdoQuarterPound = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulk Coffee Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anju Chawla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnFindPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(28, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee Prices";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(292, 215);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(160, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFindPrice
            // 
            this.btnFindPrice.Location = new System.Drawing.Point(28, 215);
            this.btnFindPrice.Name = "btnFindPrice";
            this.btnFindPrice.Size = new System.Drawing.Size(90, 30);
            this.btnFindPrice.TabIndex = 5;
            this.btnFindPrice.Text = "&Find Price";
            this.btnFindPrice.UseVisualStyleBackColor = true;
            this.btnFindPrice.Click += new System.EventHandler(this.btnFindPrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(353, 105);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TabStop = false;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Regular",
            "Decaffientated",
            "Special Blend"});
            this.cboType.Location = new System.Drawing.Point(353, 57);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 24);
            this.cboType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "&Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFullPound);
            this.groupBox2.Controls.Add(this.rdoHalfPound);
            this.groupBox2.Controls.Add(this.rdoQuarterPound);
            this.groupBox2.Location = new System.Drawing.Point(28, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 146);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantity";
            // 
            // rdoFullPound
            // 
            this.rdoFullPound.AutoSize = true;
            this.rdoFullPound.Location = new System.Drawing.Point(26, 107);
            this.rdoFullPound.Name = "rdoFullPound";
            this.rdoFullPound.Size = new System.Drawing.Size(96, 21);
            this.rdoFullPound.TabIndex = 2;
            this.rdoFullPound.TabStop = true;
            this.rdoFullPound.Text = "F&ull Pound";
            this.rdoFullPound.UseVisualStyleBackColor = true;
            this.rdoFullPound.CheckedChanged += new System.EventHandler(this.rdoQuantity_CheckedChanged);
            // 
            // rdoHalfPound
            // 
            this.rdoHalfPound.AutoSize = true;
            this.rdoHalfPound.Location = new System.Drawing.Point(26, 71);
            this.rdoHalfPound.Name = "rdoHalfPound";
            this.rdoHalfPound.Size = new System.Drawing.Size(99, 21);
            this.rdoHalfPound.TabIndex = 1;
            this.rdoHalfPound.TabStop = true;
            this.rdoHalfPound.Text = "&Half Pound";
            this.rdoHalfPound.UseVisualStyleBackColor = true;
            this.rdoHalfPound.CheckedChanged += new System.EventHandler(this.rdoQuantity_CheckedChanged);
            // 
            // rdoQuarterPound
            // 
            this.rdoQuarterPound.AutoSize = true;
            this.rdoQuarterPound.Location = new System.Drawing.Point(26, 33);
            this.rdoQuarterPound.Name = "rdoQuarterPound";
            this.rdoQuarterPound.Size = new System.Drawing.Size(123, 21);
            this.rdoQuarterPound.TabIndex = 0;
            this.rdoQuarterPound.TabStop = true;
            this.rdoQuarterPound.Text = "&Quarter Pound";
            this.rdoQuarterPound.UseVisualStyleBackColor = true;
            this.rdoQuarterPound.CheckedChanged += new System.EventHandler(this.rdoQuantity_CheckedChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmBulkCoffeeSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBulkCoffeeSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBulkCoffeeSales_FormClosing);
            this.Load += new System.EventHandler(this.frmBulkCoffeeSales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoFullPound;
        private System.Windows.Forms.RadioButton rdoHalfPound;
        private System.Windows.Forms.RadioButton rdoQuarterPound;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

