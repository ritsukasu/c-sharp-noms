namespace Viscara_OrganizationProfile
{
    partial class Ryan_OrganizationProfile
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPrograms = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datePickerBirtday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Registration";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Text = "Student No.";
            this.txtStudentNo.Location = new System.Drawing.Point(110, 60);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(275, 23);
            this.txtStudentNo.TabIndex = 0;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 63);
            this.label2.Name = "label2";
            this.label2.Text = "Program";
            this.cbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrograms.DropDownWidth = 420;
            this.cbPrograms.Location = new System.Drawing.Point(470, 60);
            this.cbPrograms.Name = "cbPrograms";
            this.cbPrograms.Size = new System.Drawing.Size(360, 23);
            this.cbPrograms.TabIndex = 1;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Name = "label3";
            this.label3.Text = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(110, 95);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(275, 23);
            this.txtLastName.TabIndex = 2;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 98);
            this.label4.Name = "label4";
            this.label4.Text = "First Name";
            this.txtFirstName.Location = new System.Drawing.Point(470, 95);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 23);
            this.txtFirstName.TabIndex = 3;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 98);
            this.label5.Name = "label5";
            this.label5.Text = "M.I.";
            this.txtMiddleInitial.Location = new System.Drawing.Point(770, 95);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(60, 23);
            this.txtMiddleInitial.TabIndex = 4;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 133);
            this.label6.Name = "label6";
            this.label6.Text = "Age";
            this.txtAge.Location = new System.Drawing.Point(110, 130);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(60, 23);
            this.txtAge.TabIndex = 5;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 133);
            this.label7.Name = "label7";
            this.label7.Text = "Gender";
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Location = new System.Drawing.Point(470, 130);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(110, 23);
            this.cbGender.TabIndex = 6;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 170);
            this.label8.Name = "label8";
            this.label8.Text = "Birthday";
            this.datePickerBirtday.CustomFormat = "dddd, d MMMM yyyy";
            this.datePickerBirtday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerBirtday.Location = new System.Drawing.Point(110, 166);
            this.datePickerBirtday.Name = "datePickerBirtday";
            this.datePickerBirtday.Size = new System.Drawing.Size(275, 23);
            this.datePickerBirtday.TabIndex = 7;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 170);
            this.label9.Name = "label9";
            this.label9.Text = "Contact No.";
            this.txtContactNo.Location = new System.Drawing.Point(470, 167);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(360, 23);
            this.txtContactNo.TabIndex = 8;
            this.btnRegister.Location = new System.Drawing.Point(380, 215);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 270);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ryan_OrganizationProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organization Profile";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPrograms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePickerBirtday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.btnRegister);
            this.Load += new System.EventHandler(this.Ryan_OrganizationProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPrograms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePickerBirtday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnRegister;
    }
}
