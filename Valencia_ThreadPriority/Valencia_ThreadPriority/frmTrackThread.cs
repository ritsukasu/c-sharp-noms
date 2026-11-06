using System;
using System.Threading;
using System.Windows.Forms;

namespace Valencia_ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
            MyThreadClass.Log = AppendOutput;
        }

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
            lblStatus.Text = "-Thread Starts -";
            AppendOutput("-Thread Starts-");

            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";
            threadA.Priority = ThreadPriority.Highest;

            Thread threadB = new Thread(MyThreadClass.Thread2);
            threadB.Name = "Thread B";
            threadB.Priority = ThreadPriority.Normal;

            Thread threadC = new Thread(MyThreadClass.Thread1);
            threadC.Name = "Thread C";
            threadC.Priority = ThreadPriority.AboveNormal;

            Thread threadD = new Thread(MyThreadClass.Thread2);
            threadD.Name = "Thread D";
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            Thread waiter = new Thread(() =>
            {
                threadA.Join();
                threadB.Join();
                threadC.Join();
                threadD.Join();

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
