using System;
using System.Windows.Forms;

namespace Valencia_BasicThreading
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmBasicThread());
        }
    }
}
