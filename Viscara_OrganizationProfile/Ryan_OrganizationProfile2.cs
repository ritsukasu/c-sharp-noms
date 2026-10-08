using System;
using System.Windows.Forms;

namespace Viscara_OrganizationProfile
{
    public partial class Ryan_OrganizationProfile2 : Form
    {
        public Ryan_OrganizationProfile2()
        {
            InitializeComponent();
        }

        private void Ryan_OrganizationProfile2_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = Valencia_OrganizationProfile.SetStudentNo.ToString();
            lblName.Text = Valencia_OrganizationProfile.SetFullName;
            lblProgram.Text = Valencia_OrganizationProfile.SetProgram;
            lblBirthday.Text = Valencia_OrganizationProfile.SetBirthday;
            lblGender.Text = Valencia_OrganizationProfile.SetGender;
            lblContactNo.Text = "+63" + Valencia_OrganizationProfile.SetContactNo.ToString();
            lblAge.Text = Valencia_OrganizationProfile.SetAge.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
