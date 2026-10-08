using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Viscara_OrganizationProfile
{
    public partial class Ryan_OrganizationProfile : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public Ryan_OrganizationProfile()
        {
            InitializeComponent();
        }

        private void Ryan_OrganizationProfile_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        public long StudentNumber(string studNum)
        {
            long parsed;
            if (Regex.IsMatch(studNum, @"^[0-9]+$") && long.TryParse(studNum, out parsed))
            {
                _StudentNo = parsed;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(studNum))
                {
                    throw new ArgumentNullException(null, "Student No. is required.");
                }
                else if (!Regex.IsMatch(studNum, @"^[0-9]+$"))
                {
                    throw new FormatException("Student No. must contain digits only.");
                }
                else
                {
                    throw new OverflowException("Student No. is too large.");
                }
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Contact))
                {
                    throw new ArgumentNullException(null, "Contact No. is required.");
                }
                else if (!Regex.IsMatch(Contact, @"^[0-9]+$"))
                {
                    throw new FormatException("Contact No. must contain digits only.");
                }
                else
                {
                    throw new IndexOutOfRangeException("Contact No. must be 10 to 11 digits long.");
                }
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+( [a-zA-Z]+)*$") && Regex.IsMatch(FirstName, @"^[a-zA-Z]+( [a-zA-Z]+)*$") && Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(MiddleInitial))
                {
                    throw new ArgumentNullException(null, "Last Name, First Name and M.I. are required.");
                }
                else if (!Regex.IsMatch(LastName, @"^[a-zA-Z]+( [a-zA-Z]+)*$") || !Regex.IsMatch(FirstName, @"^[a-zA-Z]+( [a-zA-Z]+)*$") || !Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
                {
                    throw new FormatException("Name fields must contain letters only.");
                }
                else
                {
                    throw new IndexOutOfRangeException("M.I. must be exactly one letter.");
                }
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(age))
                {
                    throw new ArgumentNullException(null, "Age is required.");
                }
                else if (!Regex.IsMatch(age, @"^[0-9]+$"))
                {
                    throw new FormatException("Age must contain digits only.");
                }
                else
                {
                    throw new IndexOutOfRangeException("Age must be 1 to 3 digits long.");
                }
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Valencia_OrganizationProfile.SetFullName = FullName(txtLastName.Text,
                    txtFirstName.Text, txtMiddleInitial.Text);
                Valencia_OrganizationProfile.SetStudentNo = StudentNumber(txtStudentNo.Text);
                Valencia_OrganizationProfile.SetProgram = cbPrograms.Text;
                Valencia_OrganizationProfile.SetGender = cbGender.Text;
                Valencia_OrganizationProfile.SetContactNo = ContactNo(txtContactNo.Text);
                Valencia_OrganizationProfile.SetAge = Age(txtAge.Text);
                Valencia_OrganizationProfile.SetBirthday = datePickerBirtday.Value.ToString("yyyy-MM-dd");

                Ryan_OrganizationProfile2 frm = new Ryan_OrganizationProfile2();
                frm.ShowDialog();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentNullException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "FormatException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "IndexOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Registration validation finished.");
            }
        }
    }
}
