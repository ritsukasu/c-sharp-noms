using System;
using System.IO;
using System.Windows.Forms;

namespace Valencia_Ryan_LabStream
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName.SetFileName = null;
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            if (string.IsNullOrEmpty(FrmFileName.SetFileName))
            {
                return;
            }

            string getInput = txtInput.Text;

            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
                {
                    outputFile.WriteLine(getInput);
                    Console.WriteLine(getInput);
                }

                MessageBox.Show("Saved to " + Path.Combine(docPath, FrmFileName.SetFileName), "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInput.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.FormClosed += (s, args) => Show();
            Hide();
            frmRegistration.Show();
        }
    }
}
