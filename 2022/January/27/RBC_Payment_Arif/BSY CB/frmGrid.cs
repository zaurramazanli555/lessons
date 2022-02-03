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
    public partial class frmGrid : DevExpress.XtraEditors.XtraForm
    {
        private string F_SQLSTRING;
        private string F_SQL_TABLE;
        private string F_SQL_COL;
        private string F_GRID_COL;
        private string F_MISC;
        private string f_user;
        private string f_user_create;
        private string f_user_amend;
        private string f_user_delete;
        private frmMain f_mainform;
        private Font F_FONT;

        public frmGrid(string formtext, string sqlstring, string sql_table, string sql_col, string grid_col, string misc, Font font, string user, string user_create, string user_amend, string user_delete, frmMain f_mainform)
        {
            InitializeComponent();

            F_FONT = font;
            this.Text = formtext;
            f_user = user;
            F_SQLSTRING = sqlstring;
            F_SQL_TABLE = sql_table;
            F_SQL_COL = sql_col;
            F_GRID_COL = grid_col;
            F_MISC = misc;
            f_user_create = user_create;
            f_user_amend = user_amend;
            f_user_delete = user_delete;
            this.f_mainform = f_mainform;
            grid.Font = F_FONT;

            gridview.Appearance.FilterPanel.Font = F_FONT;
            gridview.Appearance.FilterPanel.Options.UseFont = true;
            gridview.Appearance.HeaderPanel.Font = F_FONT;
            gridview.Appearance.HeaderPanel.Options.UseFont = true;
            gridview.Appearance.Row.Font = F_FONT;
            gridview.Appearance.Row.Options.UseFont = true;
            gridview.OptionsMenu.EnableColumnMenu = false;
            gridview.OptionsFind.AlwaysVisible = true;
            LoadData();
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

        private void frmGrid_Load(object sender, EventArgs e)
        {
        }

        public void LoadData()
        {
            try
            {
                grid.DataSource = null;
                gridview.Columns.Clear();
                string sqlselect = F_SQLSTRING;
                grid.DataSource = clsConnection.reader(sqlselect);
                gridview.Columns[F_GRID_COL].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridview.Columns[F_GRID_COL].SummaryItem.DisplayFormat = "{0}";

                if (F_SQL_TABLE == "LocalBankDetails" | F_SQL_TABLE == "BeneficiaryDetails" | F_SQL_TABLE == "CashAnalysis" | F_SQL_TABLE == "SecurityUsers" | F_SQL_TABLE == "SecurityGroups")
                    gridview.Columns["UID"].Visible = false;

                if (F_SQL_TABLE == "BeneficiaryDetails")
                {
                    gridview.Columns["Bank Type"].Visible = false;
                    gridview.Columns["Local Bank"].Visible = false;
                    gridview.Columns["Local Branch"].Visible = false;
                    gridview.Columns["Address"].Visible = false;
                    gridview.Columns["Bank Address"].Visible = false;
                }

                if (F_SQL_TABLE == "SecurityUsers")
                {
                    gridview.Columns["Last Login Date"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gridview.Columns["Last Login Date"].DisplayFormat.FormatString = "g";
                }

                gridview.BestFitColumns();
                if (gridview.RowCount == 0)
                {
                    amendbtn.Enabled = false;
                    deletebtn.Enabled = false;
                }
                else
                {
                    amendbtn.Enabled = true;
                    deletebtn.Enabled = true;
                }

                if (f_user_create == "False")
                    newbtn.Enabled = false;

                if (f_user_amend == "False")
                    amendbtn.Enabled = false;

                if (f_user_delete == "False")
                    deletebtn.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                newbtn.Enabled = false;
                amendbtn.Enabled = false;
                deletebtn.Enabled = false;
            }
        }

        private void OPERATION(string select)
        {
            try
            {
                if (select == "NEW")
                {
                    if (F_SQL_TABLE == "SecurityUsers")
                    {
                        Security_Users_New();
                    }
                    else if (F_SQL_TABLE == "SecurityGroups")
                    {
                        Security_Groups_New();
                    }

                    else if (F_SQL_TABLE == "DocumentFormat")
                    {
                        DocumentFormat_New();
                    }

                    else if (F_SQL_TABLE == "CashAnalysis")
                    {
                        CashAnalysis_New();
                    }

                    else if (F_SQL_TABLE == "CashAccount")
                    {
                        CashAccount_New();
                    }

                    else if (F_SQL_TABLE == "LocalBankDetails")
                    {
                        LocalBankDetails_New();
                    }

                    else if (F_GRID_COL == "Profile Code" & F_SQL_TABLE == "BeneficiaryDetails")
                    {
                        PaymentProfiles_New();
                    }

                    else if (F_GRID_COL != "Profile Code" & F_SQL_TABLE == "BeneficiaryDetails")
                    {
                        BeneficiaryDetails_New();
                    }
                }

                if (select == "OLD")
                {
                    if (gridview.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                    {
                        if (F_SQL_TABLE == "SecurityUsers")
                        {
                            Security_Users_Old();
                        }
                        else if (F_SQL_TABLE == "SecurityGroups")
                        {
                            Security_Groups_Old();
                        }

                        else if (F_SQL_TABLE == "DocumentFormat")
                        {
                            DocumentFormat_Old();
                        }

                        else if (F_SQL_TABLE == "CashAnalysis")
                        {
                            CashAnalysis_Old();
                        }

                        else if (F_SQL_TABLE == "CashAccount")
                        {
                            CashAccount_Old();
                        }

                        else if (F_SQL_TABLE == "LocalBankDetails")
                        {
                            LocalBankDetails_Old();
                        }

                        else if (F_GRID_COL == "Profile Code" & F_SQL_TABLE == "BeneficiaryDetails")
                        {
                            PaymentProfiles_Old();
                        }

                        else if (F_SQL_TABLE != "Profile Code" & F_SQL_TABLE == "BeneficiaryDetails")
                        {
                            BeneficiaryDetails_Old();
                        }
                    }
                }
                if (select == "DELETE")
                {
                    if (gridview.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                    {
                        gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
                        var rowHandle = gridview.FocusedRowHandle;

                        string value = clsConnection.trimSql(gridview.GetRowCellValue(rowHandle, F_GRID_COL).ToString());

                        if (F_SQL_TABLE == "BeneficiaryDetails")
                            value = clsConnection.trimSql(gridview.GetRowCellValue(rowHandle, "UID").ToString());

                        if (F_SQL_TABLE == "LocalBankDetails")
                            value = clsConnection.trimSql(gridview.GetRowCellValue(rowHandle, "UID").ToString());

                        if (F_SQL_TABLE == "CashAnalysis")
                            value = clsConnection.trimSql(gridview.GetRowCellValue(rowHandle, "UID").ToString());

                        if (F_SQL_TABLE == "SecurityUsers")
                        {
                            value = clsConnection.trimSql(gridview.GetRowCellValue(rowHandle, "UID").ToString());

                            string USER = gridview.GetRowCellValue(rowHandle, "User Name").ToString();
                            if (f_user == USER)
                            {
                                XtraMessageBox.Show("You cannot delete your own user ID");
                                return;
                            }
                        }

                        string confirmation = "Selected record will be deleted; continue?";
                        DialogResult result = XtraMessageBox.Show(confirmation, "Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            delete(F_SQL_TABLE, value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void Security_Users_New()
        {
            frmSecurityUsers form = new frmSecurityUsers(null, null, null, null, "NEW", f_user, f_mainform);
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

        private void Security_Users_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var CODE = gridview.GetRowCellValue(rowHandle, "User Name").ToString();
            var NAME = gridview.GetRowCellValue(rowHandle, "Full Name").ToString();
            var ACCESS = gridview.GetRowCellValue(rowHandle, "Access").ToString();
            var GROUP = gridview.GetRowCellValue(rowHandle, "Group Code").ToString();
            frmSecurityUsers form = new frmSecurityUsers(CODE, NAME, ACCESS, GROUP, "OLD", f_user, f_mainform);
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

        private void Security_Groups_New()
        {
            frmSecurityGroups form = new frmSecurityGroups(null, "NEW", f_user, f_mainform);
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

        private void Security_Groups_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var UID = gridview.GetRowCellValue(rowHandle, "UID").ToString();

            frmSecurityGroups form = new frmSecurityGroups(UID, "OLD", f_user, f_mainform);
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

        private void DocumentFormat_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var CODE = gridview.GetRowCellValue(rowHandle, "Document Format Code").ToString();
            var NAME = gridview.GetRowCellValue(rowHandle, "Name").ToString();
            var TYPELKP = gridview.GetRowCellValue(rowHandle, "Type").ToString();
            var PATH = gridview.GetRowCellValue(rowHandle, "File Path").ToString();
            frmDocumentFormat form = new frmDocumentFormat(CODE, NAME, TYPELKP, PATH, "OLD", f_user, f_mainform);
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

        private void DocumentFormat_New()
        {
            frmDocumentFormat form = new frmDocumentFormat(null, null, null, null, "NEW", f_user, f_mainform);
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

        private void PaymentProfiles_New()
        {
            frmPaymentProfiles form = new frmPaymentProfiles(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "NEW", f_user, f_mainform);
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

        private void PaymentProfiles_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var UID = gridview.GetRowCellValue(rowHandle, "UID").ToString();
            var CODE = gridview.GetRowCellValue(rowHandle, "Profile Code").ToString();
            var NAME = gridview.GetRowCellValue(rowHandle, "Profile Name").ToString();
            var CURR = gridview.GetRowCellValue(rowHandle, "Currency").ToString();
            var ADDR = gridview.GetRowCellValue(rowHandle, "Address").ToString();
            var TAX = gridview.GetRowCellValue(rowHandle, "Tax ID").ToString();
            var BANK_ACC = gridview.GetRowCellValue(rowHandle, "Bank Account").ToString();

            var BANK = gridview.GetRowCellValue(rowHandle, "Bank Name").ToString();
            var BANK_ADDR = gridview.GetRowCellValue(rowHandle, "Bank Address").ToString();
            var BANK_TAX = gridview.GetRowCellValue(rowHandle, "Bank Tax ID").ToString();
            var SWIFT = gridview.GetRowCellValue(rowHandle, "SWIFT").ToString();
            var CORR = gridview.GetRowCellValue(rowHandle, "Corr. Account").ToString();
            var SORT = gridview.GetRowCellValue(rowHandle, "Sort Code").ToString();

            var BANK_TYPE = gridview.GetRowCellValue(rowHandle, "Bank Type").ToString();
            var LOC_BANK = gridview.GetRowCellValue(rowHandle, "Local Bank").ToString();
            var LOC_BRANCH = gridview.GetRowCellValue(rowHandle, "Local Branch").ToString();
            var STATUS = gridview.GetRowCellValue(rowHandle, "Status").ToString();

            frmPaymentProfiles form = new frmPaymentProfiles(UID, CODE, NAME, STATUS, BANK_TYPE, LOC_BANK, LOC_BRANCH, CURR, ADDR, TAX, BANK_ACC, BANK, BANK_ADDR, BANK_TAX, SWIFT, CORR, SORT, "OLD", f_user, f_mainform);
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

        private void BeneficiaryDetails_New()
        {
            frmBeneficiaryDetails form = new frmBeneficiaryDetails(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, "NEW", "YES", f_user, f_mainform);
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

        private void BeneficiaryDetails_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var UID = gridview.GetRowCellValue(rowHandle, "UID").ToString();
            var CODE = gridview.GetRowCellValue(rowHandle, "Beneficiary Code").ToString();
            var NAME = gridview.GetRowCellValue(rowHandle, "Beneficiary Name").ToString();
            var CURR = gridview.GetRowCellValue(rowHandle, "Currency").ToString();
            var ADDR = gridview.GetRowCellValue(rowHandle, "Address").ToString();
            var TAX = gridview.GetRowCellValue(rowHandle, "Tax ID").ToString();
            var BANK_ACC = gridview.GetRowCellValue(rowHandle, "Bank Account").ToString();

            var BANK = gridview.GetRowCellValue(rowHandle, "Bank Name").ToString();
            var BANK_ADDR = gridview.GetRowCellValue(rowHandle, "Bank Address").ToString();
            var BANK_TAX = gridview.GetRowCellValue(rowHandle, "Bank Tax ID").ToString();
            var SWIFT = gridview.GetRowCellValue(rowHandle, "SWIFT").ToString();
            var CORR = gridview.GetRowCellValue(rowHandle, "Corr. Account").ToString();
            var SORT = gridview.GetRowCellValue(rowHandle, "Sort Code").ToString();

            var BANK_TYPE = gridview.GetRowCellValue(rowHandle, "Bank Type").ToString();
            var LOC_BANK = gridview.GetRowCellValue(rowHandle, "Local Bank").ToString();
            var LOC_BRANCH = gridview.GetRowCellValue(rowHandle, "Local Branch").ToString();
            var STATUS = gridview.GetRowCellValue(rowHandle, "Status").ToString();
            var REASON = gridview.GetRowCellValue(rowHandle, "Reason").ToString();
            var COMMENT = gridview.GetRowCellValue(rowHandle, "Comments").ToString();

            string sqlcommand = "SELECT COUNT(POST_STATUS) FROM PaymentOrder WHERE POST_STATUS = 1 AND BD_UID = '" + UID + "'";
            string cnt = clsConnection.singleReader(sqlcommand);
            if (cnt == "0")
            {
                frmBeneficiaryDetails form = new frmBeneficiaryDetails(UID, CODE, NAME, STATUS, REASON, COMMENT, BANK_TYPE, LOC_BANK, LOC_BRANCH, CURR, ADDR, TAX, BANK_ACC, BANK, BANK_ADDR, BANK_TAX, SWIFT, CORR, SORT, "OLD", "YES", f_user, f_mainform);
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
            else
            {
                frmBeneficiaryDetails form = new frmBeneficiaryDetails(UID, CODE, NAME, STATUS, REASON, COMMENT, BANK_TYPE, LOC_BANK, LOC_BRANCH, CURR, ADDR, TAX, BANK_ACC, BANK, BANK_ADDR, BANK_TAX, SWIFT, CORR, SORT, "OLD", "NO", f_user, f_mainform);
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

        private void LocalBankDetails_New()
        {
            frmLocalBankDetails form = new frmLocalBankDetails(null, null, null, null, null, null, "NEW", f_user, f_mainform);
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

        private void LocalBankDetails_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var UID = gridview.GetRowCellValue(rowHandle, "UID").ToString();
            var BANK = gridview.GetRowCellValue(rowHandle, "Bank Name").ToString();
            var BANK_TAX = gridview.GetRowCellValue(rowHandle, "Tax ID").ToString();
            var SWIFT = gridview.GetRowCellValue(rowHandle, "SWIFT").ToString();
            var CORR = gridview.GetRowCellValue(rowHandle, "Corr. Account").ToString();
            var STATUS = gridview.GetRowCellValue(rowHandle, "Status").ToString();

            frmLocalBankDetails form = new frmLocalBankDetails(UID, BANK, BANK_TAX, SWIFT, CORR, STATUS, "OLD", f_user, f_mainform);
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

        private void CashAnalysis_New()
        {
            frmCashAnalysis form = new frmCashAnalysis(this.Text + " Maintenance", null, F_GRID_COL, F_MISC, null, null, null, null, "NEW", f_user, f_mainform);
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

        private void CashAnalysis_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var UID = gridview.GetRowCellValue(rowHandle, "UID").ToString();
            var CODE = gridview.GetRowCellValue(rowHandle, F_GRID_COL).ToString();
            var DESC = gridview.GetRowCellValue(rowHandle, "Description").ToString();
            var CP_TYPE = gridview.GetRowCellValue(rowHandle, "Use").ToString();
            var STATUS = gridview.GetRowCellValue(rowHandle, "Status").ToString();

            if (F_MISC != "C")
                DESC = gridview.GetRowCellValue(rowHandle, "Description").ToString();

            frmCashAnalysis form = new frmCashAnalysis(this.Text + " Maintenance", UID, F_GRID_COL, F_MISC, CODE, DESC, CP_TYPE, STATUS, "OLD", f_user, f_mainform);
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

        private void CashAccount_New()
        {
            frmCashAccount form = new frmCashAccount(this.Text + " Maintenance", null, null, "NEW", f_user, f_mainform);
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

        private void CashAccount_Old()
        {
            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;
            var CODE = gridview.GetRowCellValue(rowHandle, "Account Code").ToString();
            var STATUS = gridview.GetRowCellValue(rowHandle, "Status").ToString();

            frmCashAccount form = new frmCashAccount(this.Text + " Maintenance", CODE, STATUS, "OLD", f_user, f_mainform);
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


        private void newbtn_Click(object sender, EventArgs e)
        {
            OPERATION("NEW");
        }

        private void amendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OPERATION("OLD");
            }
            catch
            {
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                OPERATION("DELETE");
            }
            catch
            {
            }
        }

        private void gridview_DoubleClick(object sender, EventArgs e)
        {
            if (f_user_amend != "False")
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRowCell)
                {
                    OPERATION("OLD");
                }
            }
        }

        private void delete(string table, string value)
        {
            try
            {
                string QUERY_DEL = "DELETE FROM " + table + " WHERE " + F_SQL_COL + " = N'" + value + "'";

                if (F_SQL_TABLE == "LocalBankDetails" | F_SQL_TABLE == "BeneficiaryDetails" | F_SQL_TABLE == "CashAnalysis" | F_SQL_TABLE == "SecurityUsers")
                    QUERY_DEL = "DELETE FROM " + table + " WHERE UID = N'" + value + "'";

                clsConnection.singleExecuteDelete(QUERY_DEL);
                f_mainform.statuscaption("Record was deleted");
                LoadData();
            }
            catch (SqlException)
            {
                XtraMessageBox.Show("Selected record was not deleted; data exists for this record");
                return;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }
    }
}