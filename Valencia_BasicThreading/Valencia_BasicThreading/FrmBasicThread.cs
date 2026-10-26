using System;
using System.Threading;
using System.Windows.Forms;

namespace Valencia_BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
            MyThreadClass.Log = AppendOutput;
        }

        // Safe to call from any thread: marshals the update to the UI thread.
        private void AppendOutput(string message)
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.BeginInvoke(new Action<string>(AppendOutput), message);
                return;
            }
            txtOutput.AppendText(message + Environment.NewLine);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            txtOutput.Clear();
            lblStatus.Text = "-Before starting thread-";
            AppendOutput("-Before starting thread-");

            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";

            Thread threadB = new Thread(MyThreadClass.Thread1);
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            // Join() blocks the calling thread, so do it on a helper thread
            // to keep the form responsive and avoid freezing the UI.
            Thread waiter = new Thread(() =>
            {
                threadA.Join();
                threadB.Join();

                BeginInvoke(new Action(() =>
                {
                    AppendOutput("-End of Thread-");
                    lblStatus.Text = "-End of Thread-";
                    btnRun.Enabled = true;
                }));
            });
            waiter.IsBackground = true;
            waiter.Start();
        }
    }
}
