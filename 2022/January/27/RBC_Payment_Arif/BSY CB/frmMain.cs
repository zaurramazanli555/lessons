using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.UserSkins;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraSplashScreen;
using FastReport;

namespace CASHBOOK
{
    public partial class frmMain : XtraForm
    {
        private string username;
        private DataTable shortcut_table;
        Font font_def = Properties.Settings.Default.FONT;
        Font font85 = new Font("Tahoma", 8.5F);

        public string user_admin;
        public string user_admin_system;
        public string user_cash;
        public string user_cash_appr;
        public string user_cash_ref;
        public string user_conv;
        public string user_conv_appr;
        public string user_conv_ref;
        public string user_paym;
        public string user_paym_appr;
        public string user_paym_ref;

        public string user_admin_create;
        public string user_admin_amend;
        public string user_admin_delete;
        public string user_cash_create;
        public string user_cash_amend;
        public string user_cash_delete;
        public string user_cash_post;
        public string user_cash_ref_create;
        public string user_cash_ref_amend;
        public string user_cash_ref_delete;
        public string user_conv_create;
        public string user_conv_amend;
        public string user_conv_delete;
        public string user_conv_post;
        public string user_conv_ref_create;
        public string user_conv_ref_amend;
        public string user_conv_ref_delete;
        public string user_paym_create;
        public string user_paym_amend;
        public string user_paym_delete;
        public string user_paym_post;
        public string user_paym_ref_create;
        public string user_paym_ref_amend;
        public string user_paym_ref_delete;

        public frmMain(string user_name)
        {
            InitializeComponent();
            this.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            barManager.ForceInitialize();
            username = user_name;

            DateTime now = DateTime.Now;
            DateTime when = now.AddHours(36);
            timer1.Interval = (int)((when - now).TotalMilliseconds);
            timer1.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                this.MaximumSize = this.Size;
                BarConfiguration();
                UserConfiguration();

                string result = clsUserManager.GetUserInformation(username, this);
                if (result != "success")
                {
                    XtraMessageBox.Show("Security configuration error");
                    this.Close();
                }

                if (user_admin == "False")
                    mAdministrative.Visibility = BarItemVisibility.Never;

                if (user_admin_system == "False")
                {
                    iSecurity.Visibility = BarItemVisibility.Never;
                    iCodesetup.Visibility = BarItemVisibility.Never;
                    iPrintDesigner.Visibility = BarItemVisibility.Never;
                    iDocFormat.Visibility = BarItemVisibility.Never;
                }
                /**/
                if (user_cash == "False")
                {
                    iCash.Visibility = BarItemVisibility.Never;
                    iCashList.Visibility = BarItemVisibility.Never;
                    iCashUpdate.Visibility = BarItemVisibility.Never;
                }

                if (user_cash_create == "False")
                {
                    iCash.Visibility = BarItemVisibility.Never;
                }

                if (user_cash_amend == "False")
                {
                    iCashUpdate.Visibility = BarItemVisibility.Never;
                }
                /**/
                if (user_cash_ref == "False")
                {
                    iBasisCodes.Visibility = BarItemVisibility.Never;
                    iPersonCodes.Visibility = BarItemVisibility.Never;
                    iExpenseAccounts.Visibility = BarItemVisibility.Never;
                }

                /**/
                if (user_conv == "False")
                {
                    iConversion.Visibility = BarItemVisibility.Never;
                    iConversionList.Visibility = BarItemVisibility.Never;
                    iConversionUpdate.Visibility = BarItemVisibility.Never;
                }

                if (user_conv_create == "False")
                {
                    iConversion.Visibility = BarItemVisibility.Never;
                }

                if (user_conv_amend == "False")
                {
                    iConversionUpdate.Visibility = BarItemVisibility.Never;
                }
                /**/

                if (user_paym == "False")
                {
                    iInvoices.Visibility = BarItemVisibility.Never;
                    iPaymentList.Visibility = BarItemVisibility.Never;
                    iPaymentUpdate.Visibility = BarItemVisibility.Never;
                }

                if (user_paym_create == "False")
                {
                    iInvoices.Visibility = BarItemVisibility.Never;
                }

                if (user_paym_amend == "False")
                {
                    iPaymentUpdate.Visibility = BarItemVisibility.Never;
                }

                if (user_paym_ref == "False")
                {
                    iBeneficiaryDetails.Visibility = BarItemVisibility.Never;
                    iLocalBankDetails.Visibility = BarItemVisibility.Never;
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
                this.Close();
            }
        }

        public void statuscaption(string text)
        {
            statustext.Caption = text;
        }

        public void fullnamecaption(string text)
        {
            usertext.Caption = text;
        }

        private void BarConfiguration()
        {
            barManager.AllowCustomization = false;
            barManager.AllowQuickCustomization = false;
            barManager.AllowShowToolbarsPopup = false;
            barManager.AllowMoveBarOnToolbar = false;
            menubar.OptionsBar.DisableCustomization = true;
            menubar.OptionsBar.DrawDragBorder = false;
            menubar.OptionsBar.DrawBorder = false;
            toolbar.OptionsBar.DisableCustomization = true;
            toolbar.OptionsBar.DrawDragBorder = false;
            toolbar.OptionsBar.DrawBorder = false;
            statusbar.OptionsBar.DisableCustomization = true;
            statusbar.OptionsBar.DrawDragBorder = false;
            statusbar.OptionsBar.DrawBorder = false;

            foreach (BarItem item in barManager.Items)
            {
                (item).ItemAppearance.Hovered.Font = font_def;
                (item).ItemAppearance.Normal.Font = font_def;
                (item).ItemAppearance.Pressed.Font = font_def;
                (item).ItemAppearance.Disabled.Font = font_def;
            }
            iAbout.Caption = "About " + Application.ProductName;
        }

        private void UserConfiguration()
        {
            iStatusbar.Checked = UserSettings.Default.Statusbar;
            statusbar_options();
            iToolbar.Checked = UserSettings.Default.Toolbar;
            toolbar_options();
            shortcut_options();
        }

        private void iToolbar_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            toolbar_options();
        }
        private void iStatusbar_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            statusbar_options();
        }
        private void toolbar_options()
        {
            if (iToolbar.Checked == true)
            {
                toolbar.Visible = true;
            }
            else
            {
                toolbar.Visible = false;
            }
            UserSettings.Default.Toolbar = iToolbar.Checked;
            UserSettings.Default.Save();
        }

        private void statusbar_options()
        {
            if (iStatusbar.Checked == true)
            {
                statusbar.Visible = true;
            }
            else
            {
                statusbar.Visible = false;
            }
            UserSettings.Default.Statusbar = iStatusbar.Checked;
            UserSettings.Default.Save();
        }

        private void shortcut_options()
        {
            try
            {
                string sqlcommand = "SELECT 'i' + cast(POSITION as varchar(2)) POSITION, SHORTCUT_NAME, PATH FROM UserShortcuts WHERE [USER] = N'" + username + "' ORDER BY POSITION";
                DataTable dt = new DataTable();
                dt = clsConnection.reader(sqlcommand);
                shortcut_table = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string shortcut = dt.Rows[i]["POSITION"].ToString();
                    BarButtonItem button = new DevExpress.XtraBars.BarButtonItem();
                    button.Name = shortcut;
                    button.Caption = clsHash.url_hash_d(dt.Rows[i]["SHORTCUT_NAME"].ToString());
                    button.Enabled = true;
                    button.Alignment = BarItemLinkAlignment.Left;
                    button.Glyph = System.Drawing.Icon.ExtractAssociatedIcon(clsHash.url_hash_d(dt.Rows[i]["PATH"].ToString())).ToBitmap();
                    statusbar.AddItem(button).BeginGroup = true;
                    button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(shortcut_ItemClick);
                }
            }
            catch
            {
                XtraMessageBox.Show("Please check shortcuts");
            }
        }

        private void shortcut_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BarItem button = e.Item;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                string file_url = (from DataRow dr in shortcut_table.Rows where (string)dr["POSITION"] == button.Name select (string)dr["PATH"]).FirstOrDefault().ToString();
                file_url = clsHash.url_hash_d(file_url);
                startInfo.FileName = Environment.ExpandEnvironmentVariables(file_url);
                process.StartInfo = startInfo;
                process.Start();

            }
            catch
            {
            }
        }

        #region menu_window

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void iMinimize_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void iCascade_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void iVertical_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void iHorizontal_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        #endregion

        private void iPassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPassword form = new frmPassword(this, username);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void iStatusBarShortcuts_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmStatusBarShortcuts form = new frmStatusBarShortcuts(username, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void LookAndFeel_StyleChanged(object sender, EventArgs e)
        {
            UserSettings.Default.Skin = UserLookAndFeel.Default.ActiveSkinName;
            UserSettings.Default.Save();
        }

        private void iBeneficiaryDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_BeneficiaryDetails ORDER BY 2";
            frmGrid form = new frmGrid("Beneficiary Details", sqlstring, "BeneficiaryDetails", "BD_CODE", "Beneficiary Code", "", font_def, username, user_paym_ref_create, user_paym_ref_amend, user_paym_ref_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iLocalBankDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_LocalBankDetails ORDER BY 2";
            frmGrid form = new frmGrid("Local Bank Details", sqlstring, "LocalBankDetails", "BA_CODE", "Bank Name", "", font_def, username, user_paym_ref_create, user_paym_ref_amend, user_paym_ref_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();

        }

        private void iBasisCodes_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_CashAnalysisCategory ORDER BY 2";
            frmGrid form = new frmGrid(e.Item.Caption, sqlstring, "CashAnalysis", "ANL_CODE", "Category", "C", font_def, username, user_cash_ref_create, user_cash_ref_amend, user_cash_ref_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iPersonCodes_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_CashAnalysisPerson ORDER BY 2";
            frmGrid form = new frmGrid(e.Item.Caption, sqlstring, "CashAnalysis", "ANL_CODE", "Name", "P", font_def, username, user_cash_ref_create, user_cash_ref_amend, user_cash_ref_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iExpenseAccounts_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_CashAccount ORDER BY 1";
            frmGrid form = new frmGrid(e.Item.Caption, sqlstring, "CashAccount", "CA_CODE", "Account Code", "", font_def, username, user_cash_ref_create, user_cash_ref_amend, user_cash_ref_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iDocFormat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_DocumentFormat ORDER BY 1";
            frmGrid form = new frmGrid("Document Format", sqlstring, "DocumentFormat", "DF_CODE", "Document Format Code", "", font_def, username, user_admin_create, user_admin_amend, user_admin_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iPaymentProfiles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_PaymentProfiles ORDER BY 2";
            frmGrid form = new frmGrid("Payment Profiles", sqlstring, "BeneficiaryDetails", "BD_CODE", "Profile Code", "", font_def, username, user_admin_create, user_admin_amend, user_admin_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_SecurityUsers ORDER BY 2";
            frmGrid form = new frmGrid("Security Users", sqlstring, "SecurityUsers", "USERNAME", "User Name", "", font_def, username, user_admin_create, user_admin_amend, user_admin_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iGroups_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SELECT * FROM V_SecurityGroups ORDER BY 2";
            frmGrid form = new frmGrid("Security Groups", sqlstring, "SecurityGroups", "GROUP_CODE", "Group Code", "", font_def, username, user_admin_create, user_admin_amend, user_admin_delete, this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MdiParent = this;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iCodesetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTransactionFormat form = new frmTransactionFormat(this, username);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void iExportExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Form child = this.ActiveMdiChild;
                if (this.ActiveMdiChild == null)
                    return;
                GridControl grid = FindGrid(child);
                if (grid.FocusedView.RowCount > 0)
                {
                    string selection = (child.Text).Replace("/", "_");
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "*.xlsx|*.xlsx";
                    dlg.FileName = selection;

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            DevExpress.XtraPrinting.PrintingSystemBase ps = new DevExpress.XtraPrinting.PrintingSystemBase();
                            DevExpress.XtraPrintingLinks.PrintableComponentLinkBase link = new DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps);
                            link.Component = grid;
                            link.CreateDocument();
                            link.PrintingSystemBase.ExportToXlsx(dlg.FileName, new XlsxExportOptions(TextExportMode.Value));

                            System.Diagnostics.Process.Start(dlg.FileName);
                            statustext.Caption = "Export was completed";

                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show("File is in use" + ex.ToString());
                            return;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void iExportPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Form child = this.ActiveMdiChild;
                if (this.ActiveMdiChild == null)
                    return;
                GridControl grid = FindGrid(child);
                if (grid.FocusedView.RowCount > 0)
                {
                    string selection = (child.Text).Replace("/", "_");
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "*.pdf|*.pdf";
                    dlg.FileName = selection;

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            DevExpress.XtraPrinting.PrintingSystemBase ps = new DevExpress.XtraPrinting.PrintingSystemBase();
                            DevExpress.XtraPrintingLinks.PrintableComponentLinkBase link = new DevExpress.XtraPrintingLinks.PrintableComponentLinkBase(ps);
                            link.Component = grid;
                            link.Landscape = true;
                            link.CreateDocument();
                            link.PrintingSystemBase.ExportToPdf(dlg.FileName, new PdfExportOptions());
                            System.Diagnostics.Process.Start(dlg.FileName);
                            statustext.Caption = "Export was completed";
                        }
                        catch
                        {
                            XtraMessageBox.Show("File is in use");
                            return;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private GridControl FindGrid(Control ParentControl)
        {
            foreach (Control c in ParentControl.Controls)
            {
                if (c is GridControl)
                    return c as GridControl;
                else
                {
                    GridControl g = FindGrid(c);
                    if (g != null)
                        return g;
                }
            }
            return null;
        }

        private void iRefreshGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Form child = this.ActiveMdiChild;
                if (this.ActiveMdiChild == null)
                    return;

                if (child.Name == "frmGrid")
                {
                    ((frmGrid)(child)).LoadData();
                }

                if (child.Name == "frmOperationGrid")
                {
                    ((frmOperationGrid)(child)).LoadData();
                }

                if (child.Name == "frmInvoices")
                {
                    ((frmInvoices)(child)).acnt_lkp("SELECT * FROM V_ChartOfAccounts_Invoices ORDER BY 1");
                    ((frmInvoices)(child)).LoadData();
                }

                if (child.Name == "frmPaymentGenerate")
                {
                    ((frmPaymentGenerate)(child)).LoadData();
                }
            }
            catch
            {
            }
        }

        private void iPrintDesigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPrintDesigner form = new frmPrintDesigner(this);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void iInvoices_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            string sqlstring = @"SET DATEFORMAT DMY SELECT * FROM [V_Invoices] WHERE 1 = 1 ORDER BY 1, 3, 11, 12";
            frmInvoices form = new frmInvoices("Invoice List", sqlstring, "Period", font85, username, user_paym_create, user_paym_amend, user_paym_post, this);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iPaymentList_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            frmOperationGrid form = new frmOperationGrid("PAYM", e.Item.Caption.ToString().Trim(), font85, font_def, username, user_paym_create, user_paym_amend, user_paym_delete, user_paym_post, this);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iConversion_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.WindowState == FormWindowState.Maximized)
                    childForm.WindowState = FormWindowState.Normal;
            }
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            frmConversion form = new frmConversion("", "Conversion", font_def, username, user_conv_post, this);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iConversionList_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            frmOperationGrid form = new frmOperationGrid("CONV", e.Item.Caption.ToString().Trim(), font85, font_def, username, user_conv_create, user_conv_amend, user_conv_delete, user_conv_post, this);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iCash_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            frmCash form = new frmCash("", "Cash Voucher", font_def, username, user_cash_post, this);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iCashList_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmWaitForm));
            frmOperationGrid form = new frmOperationGrid("CASH", e.Item.Caption.ToString().Trim(), font85, font_def, username, user_cash_create, user_cash_amend, user_cash_delete, user_cash_post, this);
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            SplashScreenManager.CloseForm();
        }

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
        }

        private void iPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Form child = this.ActiveMdiChild;
                if (this.ActiveMdiChild == null)
                    return;

                GridControl grid = FindGrid(child);
                if (grid.FocusedView.RowCount > 0)
                {
                    SplashScreenManager.ShowForm(typeof(frmWaitForm));
                    grid.ShowPrintPreview();
                    SplashScreenManager.CloseForm();
                }
            }
            catch
            {
            }
        }

        public bool confirm_close()
        {
            bool confirm_result = true;

            if (this.MdiChildren.Length > 0)
            {
                string confirmation = "All unsaved information will be lost. Do you want to continue?";
                DialogResult result = XtraMessageBox.Show(confirmation, "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    confirm_result = false;
            }

            return confirm_result;
        }

        private void iNextNumber_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReferenceNumber form = new frmReferenceNumber(this, username);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirm_close())
                e.Cancel = true;
            else
                clsUserManager.Logoff(username);
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            C.Caption = "";
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            XtraMessageBox.Show("You have been logged out");
            this.Close();
        }

        private void iPaymentUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDocumentUpdate form = new frmDocumentUpdate("PAYM", e.Item.Caption.ToString().Trim(), this, username);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void iConversionUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDocumentUpdate form = new frmDocumentUpdate("CONV", e.Item.Caption.ToString().Trim(), this, username);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void iCashUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDocumentUpdate form = new frmDocumentUpdate("CASH", e.Item.Caption.ToString().Trim(), this, username);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }
    }
}