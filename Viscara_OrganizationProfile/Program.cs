using System;
using System.Windows.Forms;

namespace Viscara_OrganizationProfile
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ryan_OrganizationProfile());
        }
    }
}
