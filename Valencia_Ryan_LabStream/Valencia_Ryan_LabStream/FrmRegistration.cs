using System;
using System.IO;
using System.Windows.Forms;

namespace Valencia_Ryan_LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsComplete())
            {
                MessageBox.Show("Please fill in all the fields.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text.Trim(), out age) || age <= 0)
            {
                MessageBox.Show("Age must be a valid number.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            string studentNo = txtStudentNo.Text.Trim();
            string fullName = txtLastName.Text.Trim() + ", " + txtFirstName.Text.Trim();
            string middleInitial = txtMI.Text.Trim();
            if (middleInitial.Length > 0)
            {
                if (!middleInitial.EndsWith("."))
                {
                    middleInitial += ".";
                }
                fullName += ", " + middleInitial;
            }

            string[] details =
            {
                "Student No.:" + studentNo,
                "Full Name:" + fullName,
                "Program: " + cboProgram.Text,
                "Gender: " + cboGender.Text,
                "Age: " + age,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No." + txtContactNo.Text.Trim()
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, studentNo + ".txt")))
                {
                    foreach (string line in details)
                    {
                        outputFile.WriteLine(line);
                        Console.WriteLine(line);
                    }
                }

                MessageBox.Show("Saved to " + Path.Combine(docPath, studentNo + ".txt"), "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.FormClosed += (s, args) => Show();
            Hide();
            frmStudentRecord.Show();
        }

        private bool IsComplete()
        {
            return !string.IsNullOrWhiteSpace(txtStudentNo.Text)
                && !string.IsNullOrWhiteSpace(txtLastName.Text)
                && !string.IsNullOrWhiteSpace(txtFirstName.Text)
                && !string.IsNullOrWhiteSpace(txtAge.Text)
                && !string.IsNullOrWhiteSpace(txtContactNo.Text)
                && cboProgram.SelectedIndex >= 0
                && cboGender.SelectedIndex >= 0;
        }

        private void ClearFields()
        {
            txtStudentNo.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMI.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
            cboProgram.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            dtpBirthday.Value = DateTime.Today;
            txtStudentNo.Focus();
        }
    }
}
