namespace Valencia_Ryan_LabStream
{
    partial class FrmFileName
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFileName = new System.Windows.Forms.Label();
            txtFileName = new System.Windows.Forms.TextBox();
            btnOkay = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblFileName.Location = new System.Drawing.Point(20, 15);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new System.Drawing.Size(109, 21);
            lblFileName.TabIndex = 0;
            lblFileName.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            txtFileName.Location = new System.Drawing.Point(20, 50);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new System.Drawing.Size(320, 23);
            txtFileName.TabIndex = 1;
            // 
            // btnOkay
            // 
            btnOkay.Location = new System.Drawing.Point(130, 92);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new System.Drawing.Size(100, 30);
            btnOkay.TabIndex = 2;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(360, 140);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            AcceptButton = btnOkay;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOkay;
    }
}
