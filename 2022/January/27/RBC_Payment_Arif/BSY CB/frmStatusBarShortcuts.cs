using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CASHBOOK
{
    public partial class frmStatusBarShortcuts : DevExpress.XtraEditors.XtraForm
    {
        private string f_user;
        private frmMain f_mainform;

        public frmStatusBarShortcuts(string USER, frmMain f_mainform)
        {
            InitializeComponent();
            f_user = USER;
            this.f_mainform = f_mainform;
            this.Text = "Shortcuts Maintenance";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            f_mainform.statuscaption("");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void StatusBarItems_Load(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;
            get_shortcut();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcommand = @"DELETE FROM UserShortcuts WHERE [USER] = N'" + f_user + "'";
                clsConnection.singleExecute(sqlcommand);

                int position = 0;

                if (file1box.Text.Length > 0)
                    add_shortcut(++position, file1box.Text, desc1box.Text.Trim());

                if (file2box.Text.Length > 0)
                    add_shortcut(++position, file2box.Text, desc2box.Text.Trim());

                if (file3box.Text.Length > 0)
                    add_shortcut(++position, file3box.Text, desc3box.Text.Trim());

                if (file4box.Text.Length > 0)
                    add_shortcut(++position, file4box.Text, desc4box.Text.Trim());

                if (file5box.Text.Length > 0)
                    add_shortcut(++position, file5box.Text, desc5box.Text.Trim());

                if (file6box.Text.Length > 0)
                    add_shortcut(++position, file6box.Text, desc6box.Text.Trim());

                if (file7box.Text.Length > 0)
                    add_shortcut(++position, file7box.Text, desc7box.Text.Trim());

                if (file8box.Text.Length > 0)
                    add_shortcut(++position, file8box.Text, desc8box.Text.Trim());

                if (file9box.Text.Length > 0)
                    add_shortcut(++position, file9box.Text, desc9box.Text.Trim());

                if (file10box.Text.Length > 0)
                    add_shortcut(++position, file10box.Text, desc10box.Text.Trim());

                savebtn.Enabled = false;
                file1box.Enabled = false; desc1box.Enabled = false; c1btn.Enabled = false;
                file2box.Enabled = false; desc2box.Enabled = false; c2btn.Enabled = false;
                file3box.Enabled = false; desc3box.Enabled = false; c3btn.Enabled = false;
                file4box.Enabled = false; desc4box.Enabled = false; c4btn.Enabled = false;
                file5box.Enabled = false; desc5box.Enabled = false; c5btn.Enabled = false;
                file6box.Enabled = false; desc6box.Enabled = false; c6btn.Enabled = false;
                file7box.Enabled = false; desc7box.Enabled = false; c7btn.Enabled = false;
                file8box.Enabled = false; desc8box.Enabled = false; c8btn.Enabled = false;
                file9box.Enabled = false; desc9box.Enabled = false; c9btn.Enabled = false;
                file10box.Enabled = false; desc10box.Enabled = false; c10btn.Enabled = false;
                f_mainform.statuscaption("Shortcuts were updated");


                string confirmation = "In order to see new shortcuts Cashbook must be restarted. Do you want to restart Cashbook now?";
                DialogResult result = XtraMessageBox.Show(confirmation, "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Program.KeepRunning = true;
                    f_mainform.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n" + ex.ToString());
            }
        }

        private void add_shortcut(int position, string file_path, string file_descr)
        {
            file_path = clsHash.url_hash_e(file_path);
            file_path = file_path.Replace("'", "''");
            file_descr = clsHash.url_hash_e(file_descr);
            file_descr = file_descr.Replace("'", "''");

            string sqlcommand = @"INSERT INTO UserShortcuts (POSITION, SHORTCUT_NAME, PATH, [USER]) 
VALUES (" + position + ", N'" + file_descr + "', N'" + file_path + "', N'" + f_user + "')";
            clsConnection.singleExecute(sqlcommand);
        }

        private void get_shortcut()
        {
            try
            {
                string sqlcommand = "SELECT SHORTCUT_NAME, PATH FROM UserShortcuts WHERE [USER] = N'" + f_user + "' ORDER BY POSITION";
                DataTable dt = new DataTable();
                dt = clsConnection.reader(sqlcommand);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int x;
                    x = i + 1;
                    string path = dt.Rows[i]["PATH"].ToString();
                    string caption = dt.Rows[i]["SHORTCUT_NAME"].ToString();
                    ButtonEdit fb = this.Controls["file" + x + "box"] as ButtonEdit;
                    TextEdit db = this.Controls["desc" + x + "box"] as TextEdit;
                    fb.Text = clsHash.url_hash_d(path);
                    db.Text = clsHash.url_hash_d(caption);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n" + ex.ToString());
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filebox_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select File";
            dlg.Filter = "All Files|*.*";
            dlg.DereferenceLinks = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ButtonEdit btn = (ButtonEdit)sender;
                btn.Text = dlg.FileName;
            }
            else
            {
                ButtonEdit btn = (ButtonEdit)sender;
                btn.Text = "";
            }
        }

        private void filebox_TextChanged(object sender, EventArgs e)
        {
            ButtonEdit fb = (ButtonEdit)sender;
            string i = fb.Name.Substring(4, 1);
            TextEdit db = this.Controls["desc" + i + "box"] as TextEdit;
            db.Text = Path.GetFileName(fb.Text);
        }

        private void StatusBarShortcuts_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            SimpleButton cl = (SimpleButton)sender;
            string i = cl.Name.Substring(1, 1);
            ButtonEdit fb = this.Controls["file" + i + "box"] as ButtonEdit;
            TextEdit db = this.Controls["desc" + i + "box"] as TextEdit;
            fb.Text = "";
            db.Text = "";
        }
    }
}