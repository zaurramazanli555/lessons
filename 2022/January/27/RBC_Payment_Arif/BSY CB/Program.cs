using System;
using System.Globalization;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace CASHBOOK
{
    static class Program
    {
        public static bool KeepRunning { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                string s_version = "";
                string c_version = Application.ProductVersion.Substring(0, 3);
                string sqlcommand = "SELECT DESCR FROM CashBookData WHERE FILENAME = 'CashBook'";

                try
                {
                    s_version = clsConnection.singleReader(sqlcommand);
                }
                catch
                {
                    MessageBox.Show("Please run Cashbook Launcher");
                    Application.Exit();
                    return;
                }
                if (c_version != s_version)
                {
                    MessageBox.Show("Please run Cashbook Launcher");
                    Application.Exit();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error code: \r\n" + ex.ToString());
                Application.Exit();
                return;
            }

            string skin = UserSettings.Default.Skin;
            UserLookAndFeel.Default.SetSkinStyle(skin);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();

            frmLoginForm fLogin = new frmLoginForm();
            KeepRunning = true;
            while (KeepRunning)
            {
                KeepRunning = false;
                if (fLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMain(fLogin.username));
                }
                else
                {
                    Application.Exit();
                    return;
                }
            }
        }
    }
}