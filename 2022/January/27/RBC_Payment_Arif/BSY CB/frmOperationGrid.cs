using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using FastReport;

namespace CASHBOOK
{
    public partial class frmOperationGrid : DevExpress.XtraEditors.XtraForm
    {
        private string F_TYPE;
        private string F_TEXT = "";
        private string F_TABLE = "";
        private string F_TABLE2 = "";
        private string F_COLUMN = "";
        private string F_VIEW = "";
        private string F_VIEW_COLUMN = "";
        private string F_DEL_PROC = "";
        private string f_user;
        private frmMain f_mainform;
        private string f_user_create;
        private string f_user_amend;
        private string f_user_delete;
        private string f_user_post;
        private Font F_FONT85;
        private Font F_FONT_DEF;
        GridView detailview;

        public frmOperationGrid(string type, string text, Font font85, Font font_def, string user, string user_create, string user_amend, string user_delete, string user_post, frmMain f_mainform)
        {
            InitializeComponent();
            F_TYPE = type;
            f_user = user;
            f_user_create = user_create;
            f_user_amend = user_amend;
            f_user_delete = user_delete;
            f_user_post = user_post;
            F_FONT85 = font85;
            F_FONT_DEF = font_def;
            this.Text = text;
            this.f_mainform = f_mainform;

            if (F_TYPE == "PAYM")
            {
                F_TEXT = "Payment Order";
                F_TABLE = "PaymentOrder";
                F_TABLE2 = "Payment";
                F_COLUMN = "PAYM_TXN_REF";
                F_VIEW_COLUMN = "Payment No";
                F_DEL_PROC = "PaymentDelete";
            }
            else if (F_TYPE == "CONV")
            {
                F_TEXT = "Conversion";
                F_TABLE = "Conversion";
                F_TABLE2 = F_TABLE;
                F_COLUMN = "CONV_TXN_REF";
                F_VIEW_COLUMN = "Conversion No";
                F_DEL_PROC = "ConversionDelete";
            }
            else if (F_TYPE == "CASH")
            {
                F_TEXT = "Cash";
                F_TABLE = "Cash";
                F_TABLE2 = F_TABLE;
                F_COLUMN = "CASH_TXN_REF";
                F_VIEW_COLUMN = "Voucher No";
                F_DEL_PROC = "CashDelete";
            }
            F_VIEW = "V_" + F_TABLE;

            LoadData();
        }
        private void frmOperationGrid_Load(object sender, EventArgs e)
        {
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

        public void LoadData()
        {
            try
            {
                string sqlselect = "";
                grid.DataSource = null;
                gridview.Columns.Clear();
                f_mainform.statuscaption("");
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                sqlselect = "SET DATEFORMAT DMY SELECT * FROM " + F_VIEW + " ORDER BY [" + F_VIEW_COLUMN + "] DESC";
                dt = clsConnection.reader(sqlselect);

                if (F_TYPE == "PAYM")
                {
                    dt.TableName = "MASTER";
                    ds.Tables.Add(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    printbtn.Enabled = false;
                    deletebtn.Enabled = false;
                    postbtn.Enabled = false;
                    repostbtn.Enabled = false;
                    return;
                }
                else
                {
                    printbtn.Enabled = true;
                    deletebtn.Enabled = true;
                    postbtn.Enabled = true;
                    repostbtn.Enabled = true;
                }

                if (F_TYPE == "PAYM")
                {
                    sqlselect = "SET DATEFORMAT DMY SELECT * from V_PaymentOrderDetails ORDER BY [Payment No], [Jn. No]";
                    dt = clsConnection.reader(sqlselect);
                    dt.TableName = "CHILD";
                    ds.Tables.Add(dt);

                    DataTableCollection tables = ds.Tables;
                    detailview = new GridView(grid);
                    ds.Relations.Add("Payment Details", tables["MASTER"].Columns["Payment No"], tables["CHILD"].Columns["Payment No"], true);
                    grid.DataSource = ds;

                    grid.DataMember = "MASTER";
                    grid.LevelTree.Nodes.Add("CHILD", detailview);
                }
                else
                    grid.DataSource = dt;

                grid.Font = F_FONT85;
                gridview.Appearance.FilterPanel.Font = F_FONT85;
                gridview.Appearance.FilterPanel.Options.UseFont = true;
                gridview.Appearance.HeaderPanel.Font = F_FONT85;
                gridview.Appearance.HeaderPanel.Options.UseFont = true;
                gridview.Appearance.Row.Font = F_FONT85;
                gridview.Appearance.Row.Options.UseFont = true;
                gridview.OptionsView.GroupFooterShowMode = GroupFooterShowMode.Hidden;
                gridview.OptionsView.ShowFooter = true;

                if (F_TYPE == "PAYM")
                {
                    detailview.OptionsView.GroupFooterShowMode = GroupFooterShowMode.Hidden;
                    detailview.OptionsView.ShowFooter = true;
                }

                if (F_TYPE == "CONV")
                {
                    gridview.Columns["Amount2"].Visible = false;
                    gridview.Columns["Currency2"].Visible = false;
                }

                gridview.Columns["PATH"].Visible = false;
                gridview.BestFitColumns();
                gridview.Columns[F_VIEW_COLUMN].Width = 110;

                /*if (F_TYPE == "PAYM")
                    gridview.SetMasterRowExpanded(gridview.FocusedRowHandle, true);*/

                if (f_user_create == "False")
                    newbtn.Enabled = false;

                if (f_user_delete == "False")
                    deletebtn.Enabled = false;

                if (f_user_post == "False")
                {
                    postbtn.Enabled = false;
                    repostbtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                newbtn.Enabled = false;
                postbtn.Enabled = false;
                repostbtn.Enabled = false;
                printbtn.Enabled = false;
                deletebtn.Enabled = false;
            }
        }

        private void gridview_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            if (F_TYPE == "PAYM")
            {
                GridView view = sender as GridView;
                GridView detailview = view.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
                detailview.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                detailview.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
                detailview.Appearance.Row.Font = Font;
                detailview.Appearance.Row.Options.UseFont = true;
                detailview.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.CellFocus;
                detailview.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
                detailview.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
                detailview.OptionsLayout.Columns.RemoveOldColumns = false;
                detailview.OptionsBehavior.Editable = false;
                detailview.OptionsDetail.AutoZoomDetail = true;
                detailview.OptionsLayout.Columns.AddNewColumns = false;
                detailview.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
                detailview.OptionsMenu.ShowGroupSummaryEditorItem = false;
                detailview.OptionsPrint.PrintFilterInfo = true;
                detailview.OptionsView.ColumnAutoWidth = false;
                detailview.OptionsView.GroupFooterShowMode = GroupFooterShowMode.Hidden;
                detailview.OptionsView.RowAutoHeight = true;
                detailview.OptionsView.ShowAutoFilterRow = false;
                detailview.OptionsView.ShowFooter = true;
                detailview.Appearance.FilterPanel.Font = F_FONT85;
                detailview.Appearance.FilterPanel.Options.UseFont = true;
                detailview.Appearance.HeaderPanel.Font = F_FONT85;
                detailview.Appearance.HeaderPanel.Options.UseFont = true;
                detailview.Appearance.Row.Font = F_FONT85;
                detailview.Appearance.Row.Options.UseFont = true;
                if (detailview.Columns.Count > 0)
                    detailview.Columns["Payment No"].Visible = false;

                detailview.Columns["Payment No"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                detailview.Columns["Base Amount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                detailview.Columns["Tr. Amount"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
                detailview.BestFitColumns();
            }
            gridview.BestFitColumns();
        }

        private void gridview_DoubleClick(object sender, EventArgs e)
        {
            if (F_TYPE == "PAYM")
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (!view.GetMasterRowExpanded(view.FocusedRowHandle))
                    view.ExpandMasterRow(view.FocusedRowHandle);
                else
                    view.CollapseMasterRow(view.FocusedRowHandle);
            }
            else
            {
                if (f_user_amend != "False")
                {
                    if (F_TYPE == "CONV")
                    {
                        GridView view = (GridView)sender;
                        Point pt = view.GridControl.PointToClient(Control.MousePosition);
                        GridHitInfo info = view.CalcHitInfo(pt);
                        if (info.InRowCell)
                        {
                            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
                            var rowHandle = gridview.FocusedRowHandle;
                            var DOC_NO = gridview.GetRowCellValue(rowHandle, "Conversion No").ToString();

                            string conv_txn_ref = clsConnection.trimSql(DOC_NO);
                            string sqlcommand = "SELECT TOP 1 POST_STATUS FROM Conversion WHERE CONV_TXN_REF = N'" + conv_txn_ref + "'";
                            string status = clsConnection.singleReader(sqlcommand);

                            if (status == "0")
                            {
                                frmConversion form = new frmConversion(DOC_NO, "Conversion", F_FONT_DEF, f_user, f_user_post, f_mainform);
                                form.StartPosition = FormStartPosition.CenterParent;
                                form.ShowDialog();
                                if (form.cancellation == "0")
                                {
                                    LoadData();
                                }
                                else
                                {
                                    gridview.ClearSelection();
                                }
                            }
                        }
                    }
                    else if (F_TYPE == "CASH")
                    {
                        GridView view = (GridView)sender;
                        Point pt = view.GridControl.PointToClient(Control.MousePosition);
                        GridHitInfo info = view.CalcHitInfo(pt);
                        if (info.InRowCell)
                        {
                            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
                            var rowHandle = gridview.FocusedRowHandle;
                            var DOC_NO = gridview.GetRowCellValue(rowHandle, "Voucher No").ToString();

                            string cash_txn_ref = clsConnection.trimSql(DOC_NO);
                            string sqlcommand = "SELECT TOP 1 POST_STATUS FROM Cash WHERE CASH_TXN_REF = N'" + cash_txn_ref + "'";
                            string status = clsConnection.singleReader(sqlcommand);

                            if (status == "0")
                            {
                                frmCash form = new frmCash(DOC_NO, "Cash Voucher", F_FONT_DEF, f_user, f_user_post, f_mainform);
                                form.StartPosition = FormStartPosition.CenterParent;
                                form.ShowDialog();
                                if (form.cancellation == "0")
                                {
                                    LoadData();
                                }
                                else
                                {
                                    gridview.ClearSelection();
                                }
                            }
                        }
                    }
                }
            }
        }

        private string TXN_REF()
        {
            string x = "";
            try
            {
                gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
                var rowHandle = gridview.FocusedRowHandle;
                x = gridview.GetRowCellValue(rowHandle, F_VIEW_COLUMN).ToString();
            }
            catch
            {
            }
            return x;
        }

        private string PATH()
        {
            string x = "";
            try
            {
                gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
                var rowHandle = gridview.FocusedRowHandle;
                x = gridview.GetRowCellValue(rowHandle, "PATH").ToString();
            }
            catch
            {
            }
            return x;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (TXN_REF() != "")
            {
                try
                {
                    string doc_no = clsConnection.trimSql(TXN_REF());
                    string confirmation = "Selected " + F_TEXT + " will be deleted/rejected. Do you want to continue?";
                    DialogResult result = XtraMessageBox.Show(confirmation, "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sqlcommand = "EXECUTE [dbo].[" + F_DEL_PROC + "] N'" + doc_no + "', N'" + f_user + "'";
                        clsConnection.singleExecute(sqlcommand);
                        f_mainform.statuscaption(F_TEXT + " was deleted/rejected");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                    return;
                }
            }
        }

        private void postbtn_Click(object sender, EventArgs e)
        {
            if (TXN_REF() != "")
            {
                try
                {
                    string doc_no = clsConnection.trimSql(TXN_REF());
                    bool result = false;

                    if (F_TYPE == "PAYM")
                        result = clsPost.postPayment(doc_no);
                    else if (F_TYPE == "CONV")
                        result = clsPost.postConversion(doc_no);
                    else if (F_TYPE == "CASH")
                        result = clsPost.postCash(doc_no);

                    if (result == true)
                    {
                        frmPost form = new frmPost(false, doc_no, F_TYPE, F_TEXT + " Post - " + doc_no, F_FONT85, f_user, f_user_post, f_mainform);
                        form.MdiParent = f_mainform;
                        form.StartPosition = FormStartPosition.CenterParent;
                        form.Show();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                    return;
                }
            }
        }

        private void repostbtn_Click(object sender, EventArgs e)
        {
            if (TXN_REF() != "")
            {
                try
                {
                    string doc_no = clsConnection.trimSql(TXN_REF());
                    bool result = false;

                    if (F_TYPE == "PAYM")
                        result = clsPost.repostPayment(doc_no);
                    else if (F_TYPE == "CONV")
                        result = clsPost.repostConversion(doc_no);
                    else if (F_TYPE == "CASH")
                        result = clsPost.repostCash(doc_no);

                    if (result == true)
                    {
                        frmPost form = new frmPost(true, doc_no, F_TYPE, F_TEXT + " Repost - " + doc_no, F_FONT85, f_user, f_user_post, f_mainform);
                        form.MdiParent = f_mainform;
                        form.StartPosition = FormStartPosition.CenterParent;
                        form.Show();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                    return;
                }
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (TXN_REF() != "")
            {
                try
                {
                    string doc_no = clsConnection.trimSql(TXN_REF());
                    Report report = null;

                    if (F_TYPE == "PAYM")
                        report = clsPrint.printPayment(doc_no);
                    else if (F_TYPE == "CONV")
                        report = clsPrint.printConversion(doc_no);
                    else if (F_TYPE == "CASH")
                        report = clsPrint.printCash(doc_no);

                    if (report != null)
                    {
                        clsPrint.updateStatus(F_TABLE, F_COLUMN, doc_no);
                        frmPrintPreview form1 = new frmPrintPreview(report, F_FONT85, f_user);
                        form1.StartPosition = FormStartPosition.CenterScreen;
                        form1.MdiParent = f_mainform;
                        form1.Show();
                        f_mainform.statuscaption(F_TEXT + " was printed");
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                    return;
                }
            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            if (F_TYPE == "PAYM")
            {
                SplashScreenManager.ShowForm(typeof(frmWaitForm));
                string sqlstring = @"SET DATEFORMAT DMY SELECT * FROM [V_Invoices] WHERE 1 = 1 ORDER BY 1, 3, 11, 12";
                frmInvoices form = new frmInvoices("Invoice List", sqlstring, "Period", F_FONT85, f_user, f_user_create, f_user_amend, f_user_post, f_mainform);
                form.MdiParent = f_mainform;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
                SplashScreenManager.CloseForm();
            }
            else if (F_TYPE == "CONV")
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.WindowState == FormWindowState.Maximized)
                        childForm.WindowState = FormWindowState.Normal;
                }
                SplashScreenManager.ShowForm(typeof(frmWaitForm));
                frmConversion form = new frmConversion("", "Conversion", F_FONT_DEF, f_user, f_user_post, f_mainform);
                form.MdiParent = f_mainform;
                form.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Normal;
                form.Show();
                SplashScreenManager.CloseForm();
            }
            else if (F_TYPE == "CASH")
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.WindowState == FormWindowState.Maximized)
                        childForm.WindowState = FormWindowState.Normal;
                }
                SplashScreenManager.ShowForm(typeof(frmWaitForm));
                frmCash form = new frmCash("", "Cash Voucher", F_FONT_DEF, f_user, f_user_post, f_mainform);
                form.MdiParent = f_mainform;
                form.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Normal;
                form.Show();
                SplashScreenManager.CloseForm();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOperationGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }
    }
}