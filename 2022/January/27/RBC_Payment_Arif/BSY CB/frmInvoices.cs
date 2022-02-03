using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace CASHBOOK
{
    public partial class frmInvoices : DevExpress.XtraEditors.XtraForm
    {
        private string F_ACNT;
        private string F_ACNT_NAME;
        private string F_SQLSTRING;
        private string F_GRID_COL;
        private string f_user;
        private string f_user_create;
        private string f_user_amend;
        private string f_user_post;
        private frmMain f_mainform;
        private Font F_FONT;

        public frmInvoices(string formtext, string sqlstring, string grid_col, Font font, string user, string user_create, string user_amend, string user_post, frmMain f_mainform)
        {
            InitializeComponent();

            F_FONT = font;
            this.Text = formtext;
            F_SQLSTRING = sqlstring;
            F_GRID_COL = grid_col;
            f_user = user;
            f_user_create = user_create;
            f_user_amend = user_amend;
            f_user_post = user_post;
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

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            acnt_lkp("SELECT * FROM V_ChartOfAccounts_Invoices ORDER BY 1");
            acntlkp.Properties.ShowHeader = true;

            invbox.ReadOnly = true;
            invbox.Enabled = false;
            invbox.ForeColor = Color.Black;
            basebox.ReadOnly = true;
            basebox.Enabled = false;
            basebox.ForeColor = Color.Black;
            trbox.ReadOnly = true;
            trbox.Enabled = false;
            trbox.ForeColor = Color.Black;
            currbox.ReadOnly = true;
            currbox.Enabled = false;
            currbox.ForeColor = Color.Black;

            acntlkp.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            acntlkp.Properties.Appearance.Options.UseTextOptions = true;
            invbox.Font = new Font(invbox.Font, FontStyle.Bold);
            invbox.Text = "0";
            invbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            invbox.Properties.Appearance.Options.UseTextOptions = true;
            basebox.Font = new Font(basebox.Font, FontStyle.Bold);
            basebox.Text = ".00";
            basebox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            basebox.Properties.Appearance.Options.UseTextOptions = true;
            trbox.Font = new Font(trbox.Font, FontStyle.Bold);
            trbox.Text = ".00";
            trbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            trbox.Properties.Appearance.Options.UseTextOptions = true;
            currbox.Font = new Font(currbox.Font, FontStyle.Bold);
            currbox.Text = "";
            currbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
            currbox.Properties.Appearance.Options.UseTextOptions = true;
        }

        public void LoadData()
        {
            try
            {
                if (acntlkp.Text == "" | acntlkp.EditValue == null)
                {
                    acntlkp.Focus();
                    grid.DataSource = null;
                    gridview.Columns.Clear();
                    return;
                }

                gridview.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
                gridview.OptionsSelection.MultiSelect = true;

                DataRowView row = acntlkp.Properties.GetDataSourceRowByKeyValue(acntlkp.EditValue) as DataRowView;
                string ACNT = clsConnection.trimSql(row["Account Code"].ToString());
                string sqlselect = F_SQLSTRING.Replace("1 = 1", "[Account Code] = N'" + ACNT + "'");

                DeletePrevLines();
                double num1 = 0.0;
                double num2 = 0.0;
                basebox.Text = num1.ToString("#,###,###,###.00");
                trbox.Text = num2.ToString("#,###,###,###.00");
                grid.DataSource = null;
                gridview.Columns.Clear();
                grid.DataSource = clsConnection.reader(sqlselect);

                gridview.Columns[F_GRID_COL].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
                gridview.Columns[F_GRID_COL].SummaryItem.DisplayFormat = "{0}";

                gridview.BestFitColumns();
                DeselectValues();
                f_mainform.C.Caption = row["Account Name"].ToString();
                gridview.Columns["Account Name"].Visible = false;
                splitbtn.Enabled = true;
                pobtn.Enabled = true;

                if (f_user_create == "False")
                    pobtn.Enabled = false;

                if (f_user_amend == "False")
                    splitbtn.Enabled = false;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                pobtn.Enabled = false;
                splitbtn.Enabled = false;
                f_mainform.C.Caption = "";
            }
        }

        public void acnt_lkp(string sqlcommand)
        {
            DataTable dt = clsConnection.reader(sqlcommand);
            acntlkp.Properties.DataSource = dt;
            acntlkp.Properties.DisplayMember = "Account Code";
            acntlkp.Properties.ValueMember = "Account Code";
            acntlkp.Properties.PopulateColumns();
            acntlkp.Properties.DropDownRows = 20;
        }

        private void pobtn_Click(object sender, EventArgs e)
        {
            if (basebox.Text.Trim() == ".00")
            {
                f_mainform.statuscaption("You must select invoice to continue");
            }
            else
            {
                string str = "";
                try
                {
                    DeletePrevLines();
                    int[] selectedRows = gridview.GetSelectedRows();
                    int index = 0;
                    while (index < selectedRows.Length)
                    {
                        int rowHandle = selectedRows[index];
                        string JRNAL_NO = Convert.ToString(gridview.GetRowCellValue(rowHandle, gridview.Columns[10]));
                        string JRNAL_LINE = Convert.ToString(gridview.GetRowCellValue(rowHandle, gridview.Columns[11]));
                        F_ACNT_NAME = Convert.ToString(gridview.GetRowCellValue(rowHandle, gridview.Columns[3]));
                        F_ACNT = Convert.ToString(gridview.GetRowCellValue(rowHandle, gridview.Columns[2]));
                        str = Convert.ToString(gridview.GetRowCellValue(rowHandle, gridview.Columns[3]));
                        CopyInvoices(JRNAL_NO, JRNAL_LINE);
                        checked { ++index; }
                    }
                    splitbtn.Enabled = false;
                    pobtn.Enabled = false;
                    f_mainform.statuscaption("Payment order details were successfully created");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                    return;
                }

                string sqlstring = @"SELECT * FROM V_PaymentOrderDetails2 WHERE REMARK = '" + f_user + "' ORDER BY 4, 5";
                frmPaymentGenerate form = new frmPaymentGenerate(F_ACNT_NAME, F_ACNT, sqlstring, "Invoice No", "Payment Order Generate Form - " + F_ACNT_NAME, F_FONT, f_user, f_user_post, f_mainform);
                form.StartPosition = FormStartPosition.CenterParent;
                form.MinimizeBox = false;
                form.WindowState = FormWindowState.Maximized;
                form.MdiParent = f_mainform;
                form.Show();
                DeselectValues();
            }
        }

        private void splitbtn_Click(object sender, EventArgs e)
        {
            SplitAmount();
        }

        private void grid_Click(object sender, EventArgs e)
        {
            SelectValues();
        }

        public void SplitAmount()
        {
            if (invbox.Text.Trim() == "0")
            {
                f_mainform.statuscaption("Invoice wasn't selected");
                return;
            }

            if (gridview.SelectedRowsCount > 1)
            {
                f_mainform.statuscaption("You can select only one invoice to split");
                return;
            }

            gridview.FocusedRowHandle = gridview.GetSelectedRows()[0];
            var rowHandle = gridview.FocusedRowHandle;

            string JRNAL_NO = gridview.GetRowCellValue(rowHandle, gridview.Columns[10]).ToString().Trim();
            string JRNAL_LINE = gridview.GetRowCellValue(rowHandle, gridview.Columns[11]).ToString().Trim();
            double AMOUNT = Convert.ToDouble(gridview.GetRowCellValue(rowHandle, gridview.Columns[6]).ToString().Trim());
            string CURRENCY = gridview.GetRowCellValue(rowHandle, gridview.Columns[7]).ToString().Trim();
            string TREFERENCE = gridview.GetRowCellValue(rowHandle, gridview.Columns[4]).ToString().Trim();

            frmSplitAmount form = new frmSplitAmount(JRNAL_NO, JRNAL_LINE, TREFERENCE, AMOUNT, CURRENCY, f_user, f_mainform);
            form.ShowDialog();

            if (form.cancellation == "0")
            {
                LoadData();
                f_mainform.statuscaption("Invoice amount was splitted successfully");
            }
        }

        public void CopyInvoices(string JRNAL_NO, string JRNAL_LINE)
        {
            try
            {
                string query = "EXECUTE dbo.PaymentCopyInvoices N'" + f_user + "', " + JRNAL_NO + ", " + JRNAL_LINE;
                clsConnection.singleExecute(query);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
        }

        public void DeletePrevLines()
        {
            try
            {
                string query = "EXECUTE dbo.PaymentDeletePreview N'" + f_user + "'";
                clsConnection.singleExecute(query);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
        }

        public void DeselectValues()
        {
            double num1 = 0.0;
            double num2 = 0.0;
            gridview.ClearSelection();
            basebox.Text = num1.ToString("#,###,###,###.00");
            trbox.Text = num2.ToString("#,###,###,###.00");
            invbox.Text = gridview.SelectedRowsCount.ToString();
            currbox.Text = "";
        }

        private void SelectValues()
        {
            //bool multi = false;
            double num1 = 0.0;
            double num2 = 0.0;
            string str = "";
            currbox.Text = "";
            if (gridview.SelectedRowsCount > 0)
            {
                int[] selectedRows = gridview.GetSelectedRows();
                int index = 0;
                while (index < selectedRows.Length)
                {
                    int rowHandle = selectedRows[index];
                    if (!gridview.IsGroupRow(rowHandle))
                    {
                        f_mainform.statuscaption("");
                        string Right2 = gridview.GetRowCellValue(rowHandle, gridview.Columns[7]).ToString().Trim();

                        str = gridview.GetRowCellValue(rowHandle, gridview.Columns[4]).ToString().Trim();
                        if ((currbox.Text.Trim() != "") && (currbox.Text.Trim() != Right2))
                        {
                            Right2 = "-";
                            //multi = true;
                            //f_mainform.statuscaption("You must select invoices with one currency");
                            //DeselectValues();
                            //return;
                        }
                        currbox.Text = Right2;
                        num1 += Convert.ToDouble(gridview.GetRowCellValue(rowHandle, gridview.Columns[9]));
                        num2 += Convert.ToDouble(gridview.GetRowCellValue(rowHandle, gridview.Columns[6]));
                        // if(multi == true)
                        //     num2 = num1;
                    }
                    checked { ++index; }
                }
            }
            else
                DeselectValues();

            basebox.Text = num1.ToString("#,###,###,###.00");
            trbox.Text = num2.ToString("#,###,###,###.00");
            invbox.Text = gridview.SelectedRowsCount.ToString();

            foreach (int i in gridview.GetSelectedRows())
            {
                DataRow row = gridview.GetDataRow(i);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            DeselectValues();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvoices_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeletePrevLines();
            f_mainform.statuscaption("");
        }

        private void acntlkp_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridview_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridview.SelectedRowsCount == 0)
                DeselectValues();
            else
                SelectValues();
        }
    }
}
