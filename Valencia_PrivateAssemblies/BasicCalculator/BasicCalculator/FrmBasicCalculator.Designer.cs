namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTitle.Location = new System.Drawing.Point(22, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Basic Calculator";
            //
            // txtFirstNumber
            //
            this.txtFirstNumber.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.txtFirstNumber.Location = new System.Drawing.Point(26, 58);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(254, 30);
            this.txtFirstNumber.TabIndex = 1;
            this.txtFirstNumber.Text = "0";
            this.txtFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // cboOperator
            //
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboOperator.Location = new System.Drawing.Point(115, 99);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(76, 26);
            this.cboOperator.TabIndex = 2;
            //
            // txtSecondNumber
            //
            this.txtSecondNumber.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.txtSecondNumber.Location = new System.Drawing.Point(26, 136);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(254, 30);
            this.txtSecondNumber.TabIndex = 3;
            this.txtSecondNumber.Text = "0";
            this.txtSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // pnlTotal
            //
            this.pnlTotal.BackColor = System.Drawing.Color.Black;
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblTotalCaption);
            this.pnlTotal.Location = new System.Drawing.Point(26, 186);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(254, 84);
            this.pnlTotal.TabIndex = 4;
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.lblTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotal.Location = new System.Drawing.Point(3, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "000000";
            //
            // lblTotalCaption
            //
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lblTotalCaption.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalCaption.Location = new System.Drawing.Point(3, 8);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(56, 18);
            this.lblTotalCaption.TabIndex = 0;
            this.lblTotalCaption.Text = "Total:";
            //
            // btnCompute
            //
            this.btnCompute.Location = new System.Drawing.Point(103, 290);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(100, 30);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            //
            // FrmBasicCalculator
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 344);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.cboOperator);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Button btnCompute;
    }
}
