using System;
using System.Windows.Forms;

namespace Valencia_Ryan_LabStream
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
            {
                MessageBox.Show("Please enter a file name.", "FrmFileName", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFileName.Focus();
                return;
            }

            SetFileName = txtFileName.Text.Trim() + ".txt";
            Close();
        }
    }
}
