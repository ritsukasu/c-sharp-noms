namespace Valencia_Ryan_LabStream
{
    partial class FrmLab1
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
            txtInput = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnRegistration = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new System.Drawing.Point(60, 40);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtInput.Size = new System.Drawing.Size(220, 70);
            txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(110, 140);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(120, 35);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new System.Drawing.Point(110, 190);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new System.Drawing.Size(120, 35);
            btnRegistration.TabIndex = 2;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(340, 270);
            Controls.Add(btnRegistration);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "FrmLab1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRegistration;
    }
}
