namespace Valencia_BasicThreading
{
    partial class FrmBasicThread
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
            lblStatus = new System.Windows.Forms.Label();
            btnRun = new System.Windows.Forms.Button();
            txtOutput = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 16F);
            lblStatus.Location = new System.Drawing.Point(12, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(460, 45);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "-Before starting thread-";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            btnRun.Font = new System.Drawing.Font("Segoe UI", 12F);
            btnRun.Location = new System.Drawing.Point(172, 62);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(140, 40);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtOutput.Font = new System.Drawing.Font("Consolas", 10F);
            txtOutput.ForeColor = System.Drawing.Color.Gainsboro;
            txtOutput.Location = new System.Drawing.Point(12, 115);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtOutput.Size = new System.Drawing.Size(460, 260);
            txtOutput.TabIndex = 2;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 391);
            Controls.Add(txtOutput);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            Name = "FrmBasicThread";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOutput;
    }
}
