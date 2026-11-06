namespace Valencia_Ryan_LabStream
{
    partial class FrmRegistration
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
            lblStudentNo = new System.Windows.Forms.Label();
            txtStudentNo = new System.Windows.Forms.TextBox();
            lblProgram = new System.Windows.Forms.Label();
            cboProgram = new System.Windows.Forms.ComboBox();
            lblLastName = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            lblFirstName = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            lblMI = new System.Windows.Forms.Label();
            txtMI = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            txtAge = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            cboGender = new System.Windows.Forms.ComboBox();
            lblBirthday = new System.Windows.Forms.Label();
            dtpBirthday = new System.Windows.Forms.DateTimePicker();
            lblContactNo = new System.Windows.Forms.Label();
            txtContactNo = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            btnRecords = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
            lblTitle.Location = new System.Drawing.Point(15, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(170, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Registration";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new System.Drawing.Point(30, 68);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new System.Drawing.Size(67, 15);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new System.Drawing.Point(115, 65);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new System.Drawing.Size(130, 23);
            txtStudentNo.TabIndex = 2;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new System.Drawing.Point(305, 68);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new System.Drawing.Size(51, 15);
            lblProgram.TabIndex = 3;
            lblProgram.Text = "Program";
            // 
            // cboProgram
            // 
            cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboProgram.FormattingEnabled = true;
            cboProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Computer Engineering", "BS Business Administration", "BS Accountancy", "BS Hospitality Management", "BS Tourism Management" });
            cboProgram.Location = new System.Drawing.Point(365, 65);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new System.Drawing.Size(230, 23);
            cboProgram.TabIndex = 4;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(36, 108);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(61, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(115, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(130, 23);
            txtLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(295, 108);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(61, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(365, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(150, 23);
            txtFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            lblMI.AutoSize = true;
            lblMI.Location = new System.Drawing.Point(525, 108);
            lblMI.Name = "lblMI";
            lblMI.Size = new System.Drawing.Size(26, 15);
            lblMI.TabIndex = 9;
            lblMI.Text = "M.I.";
            // 
            // txtMI
            // 
            txtMI.Location = new System.Drawing.Point(555, 105);
            txtMI.MaxLength = 4;
            txtMI.Name = "txtMI";
            txtMI.Size = new System.Drawing.Size(40, 23);
            txtMI.TabIndex = 10;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new System.Drawing.Point(80, 148);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(25, 15);
            lblAge.TabIndex = 11;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new System.Drawing.Point(115, 145);
            txtAge.MaxLength = 3;
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(60, 23);
            txtAge.TabIndex = 12;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(310, 148);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(46, 15);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new System.Drawing.Point(365, 145);
            cboGender.Name = "cboGender";
            cboGender.Size = new System.Drawing.Size(120, 23);
            cboGender.TabIndex = 14;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new System.Drawing.Point(50, 193);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new System.Drawing.Size(47, 15);
            lblBirthday.TabIndex = 15;
            lblBirthday.Text = "Birthday";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            dtpBirthday.Location = new System.Drawing.Point(115, 190);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new System.Drawing.Size(260, 23);
            dtpBirthday.TabIndex = 16;
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new System.Drawing.Point(385, 193);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new System.Drawing.Size(66, 15);
            lblContactNo.TabIndex = 17;
            lblContactNo.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new System.Drawing.Point(455, 190);
            txtContactNo.MaxLength = 15;
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new System.Drawing.Size(140, 23);
            txtContactNo.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(255, 250);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(110, 32);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnRecords
            // 
            btnRecords.Location = new System.Drawing.Point(485, 250);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new System.Drawing.Size(110, 32);
            btnRecords.TabIndex = 20;
            btnRecords.Text = "Records";
            btnRecords.UseVisualStyleBackColor = true;
            btnRecords.Click += btnRecords_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(620, 310);
            Controls.Add(btnRecords);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(lblContactNo);
            Controls.Add(dtpBirthday);
            Controls.Add(lblBirthday);
            Controls.Add(cboGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMI);
            Controls.Add(lblMI);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cboProgram);
            Controls.Add(lblProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(lblStudentNo);
            Controls.Add(lblTitle);
            Name = "FrmRegistration";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRecords;
    }
}
