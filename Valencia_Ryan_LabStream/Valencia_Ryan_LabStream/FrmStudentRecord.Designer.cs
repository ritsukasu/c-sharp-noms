namespace Valencia_Ryan_LabStream
{
    partial class FrmStudentRecord
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
            lblTitle = new System.Windows.Forms.Label();
            lvShowText = new System.Windows.Forms.ListView();
            colText = new System.Windows.Forms.ColumnHeader();
            btnRegister = new System.Windows.Forms.Button();
            btnFind = new System.Windows.Forms.Button();
            btnUpload = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            lblTitle.Location = new System.Drawing.Point(12, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(117, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "View Record";
            // 
            // lvShowText
            // 
            lvShowText.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { colText });
            lvShowText.FullRowSelect = true;
            lvShowText.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lvShowText.Location = new System.Drawing.Point(12, 45);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new System.Drawing.Size(330, 185);
            lvShowText.TabIndex = 1;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = System.Windows.Forms.View.Details;
            // 
            // colText
            // 
            colText.Text = "Text";
            colText.Width = 305;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(352, 45);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(78, 28);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new System.Drawing.Point(352, 79);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(78, 28);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new System.Drawing.Point(352, 113);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new System.Drawing.Size(78, 28);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(440, 245);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(lvShowText);
            Controls.Add(lblTitle);
            Name = "FrmStudentRecord";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.ColumnHeader colText;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
