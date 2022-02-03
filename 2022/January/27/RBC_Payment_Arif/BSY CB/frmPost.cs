using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmPost : DevExpress.XtraEditors.XtraForm
    {
        private string F_TYPE;
        private string F_DOC_NO;
        private bool F_REPOST;
        private string F_TABLE = "";
        private string F_TABLE2 = "";
        private string F_COLUMN = "";
        private string F_COLUMN_DATE = "";
        private string F_VIEW = "";
        private string F_VIEW_COLUMN = "";
        private string F_POST_PROC = "";
        public string cancellation = "1";
        private string f_user;
        private string f_user_post;
        private frmMain f_mainform;
        private Font F_FONT85;
        GridView detailview;

        public frmPost(bool repost, string doc_no, string type, string text, Font font85, string user, string user_post, frmMain f_mainform)
        {
            InitializeComponent();
            F_TYPE = type;
            F_DOC_NO = doc_no;
            F_REPOST = repost;
            pobox.Text = F_DOC_NO;
            this.Text = text;
            f_user = user;
            f_user_post = user_post;
            F_FONT85 = font85;
            this.f_mainform = f_mainform;

            grp1.Visible = false;
            grp2.Visible = false;
            grp3.Visible = false;
            grp4.Visible = false;
            grp5.Visible = false;
            grp6.Visible = false;

            if (F_TYPE == "PAYM")
            {
                F_TABLE = "PaymentOrder";
                F_TABLE2 = "Payment";
                F_COLUMN = "PAYM_TXN_REF";
                F_COLUMN_DATE = "PAYM_DATE";
                F_VIEW_COLUMN = "Payment No";
                F_POST_PROC = "PaymentPost";
            }
            else if (F_TYPE == "CONV")
            {
                F_TABLE = "Conversion";
                F_TABLE2 = F_TABLE;
                F_COLUMN = "CONV_TXN_REF";
                F_COLUMN_DATE = "CONV_DATE";
                F_VIEW_COLUMN = "Conversion No";
                F_POST_PROC = "ConversionPost";

                other_amtlbl.Visible = true;
                other_amtbox.Visible = true;
                postbtn.Left = other_amtbox.Right + 45;
            }
            else if (F_TYPE == "CASH")
            {
                F_TABLE = "Cash";
                F_TABLE2 = F_TABLE;
                F_COLUMN = "CASH_TXN_REF";
                F_COLUMN_DATE = "CASH_DATE";
                F_VIEW_COLUMN = "Voucher No";
                F_POST_PROC = "CashPost";

                grp1.Visible = true;
                grp2.Visible = true;
                grp3.Visible = true;
                grp4.Visible = true;
                grp5.Visible = true;
                grp6.Visible = true;

                grp2.Left = grp1.Right + 45;
                grp5.Left = grp1.Right + 45;
                grp3.Left = grp2.Right + 45;
                grp6.Left = grp2.Right + 45;

                string query = "SELECT CASE WHEN BANK_PP_UID IS NULL THEN 0 ELSE 1 END AS RESULT FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "'";
                string result = clsConnection.singleReader(query);

                if (result != "1")
                {
                    chargeacntlbl.Enabled = false;
                    chargeamtlbl.Enabled = false;
                    expenselkp.Enabled = false;
                    amtbox.Enabled = false;
                }
                else
                {
                    grp1.Visible = false;
                    grp2.Visible = false;
                    grp3.Visible = false;
                    grp4.Visible = false;
                    grp5.Visible = false;
                    grp6.Visible = false;
                }
            }

            F_VIEW = "V_" + F_TABLE;
            if (F_TYPE == "CASH")
            {
                F_VIEW = "V_" + F_TABLE + "2";
                acnt_lkp_run();
            }

            LoadData();
        }

        private void frmPost_Load(object sender, EventArgs e)
        {
            datebox.Properties.Mask.UseMaskAsDisplayFormat = true;
            DevExpress.XtraEditors.Drawing.MouseWheelHelper.SmartMouseWheelProcessing = false;

            periodbox.ReadOnly = true;
            periodbox.Enabled = false;
            periodbox.ForeColor = Color.Black;

            periodbox.Text = "";
            periodbox.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
            periodbox.Properties.Appearance.Options.UseTextOptions = true;

            expense_lkp();

            if (F_TYPE != "PAYM")
            {
                gridview.OptionsView.ShowGroupPanel = false;
                gridview.OptionsView.ShowFooter = false;
            }

            if (F_REPOST == false)
            {
                string query = @"SELECT CONVERT(VARCHAR(10), " + F_COLUMN_DATE + ", 112) FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                datebox.DateTime = DateTime.ParseExact(clsConnection.singleReader(query), "yyyyMMdd", CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None);

                if (F_TYPE == "CASH")
                {
                    query = @"SELECT LEFT(DESCR,50) FROM CashAnalysis WHERE UID = (SELECT C_ANL_UID FROM Cash WHERE CASH_TXN_REF = N'" + F_DOC_NO + "')";
                    string descr = clsConnection.singleReader(query);
                    descbox1.Text = descr;
                    descbox2.Text = descr;
                    descbox3.Text = descr;
                    descbox4.Text = descr;
                    descbox5.Text = descr;
                    descbox6.Text = descr;
                }
            }
            else
                getPostedDetails();
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

        private void SetFormat(string format)
        {
            datebox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            datebox.Properties.Mask.EditMask = format;
            datebox.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void datebox_EditValueChanged(object sender, EventArgs e)
        {
            if (datebox.Text == "" | datebox.Text == null)
            {
                datebox.DateTime = DateTime.Today;
                periodbox.Text = "";
            }
            else
            {
                periodbox.Text = GetPeriodFromDate(datebox.DateTime);
            }
            string format = @"dd\/MM\/yyyy";
            SetFormat(format);
        }

        public string GetPeriodFromDate(DateTime dt)
        {
            string Expression = dt.Month.ToString();
            string str1 = dt.Year.ToString();
            string str2;
            switch (Expression.Length)
            {
                case 1:
                    str2 = "00" + Expression;
                    break;
                case 2:
                    str2 = "0" + Expression;
                    break;
                default:
                    str2 = "000";
                    break;
            }
            return str1 + str2;
        }

        private void acnt_lkp_run()
        {
            string sqlcommand = "SELECT [Account Code], [Account Name] FROM V_CashAccount WHERE (Status = 'Open') ORDER BY 1";
            DataTable dt = clsConnection.reader(sqlcommand);
            acnt_lkp(dt, acntlkp1);
            acnt_lkp(dt, acntlkp2);
            acnt_lkp(dt, acntlkp3);
            acnt_lkp(dt, acntlkp4);
            acnt_lkp(dt, acntlkp5);
            acnt_lkp(dt, acntlkp6);
        }

        private void acnt_lkp(DataTable dt, LookUpEdit lkp)
        {
            lkp.Properties.DataSource = dt;
            lkp.Properties.DisplayMember = "Account Code";
            lkp.Properties.ValueMember = "Account Code";
            lkp.Properties.PopulateColumns();
            lkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                lkp.EditValue = lkp.ItemIndex = 0;
            lkp.Properties.ShowHeader = true;
        }

        private void expense_lkp()
        {
            string sqlcommand = "SELECT * FROM V_" + F_TABLE2 + "_BankExpense ORDER BY 1";
            DataTable dt = clsConnection.reader(sqlcommand);
            expenselkp.Properties.DataSource = dt;
            expenselkp.Properties.DisplayMember = "Account Code";
            expenselkp.Properties.ValueMember = "Account Code";
            expenselkp.Properties.PopulateColumns();
            expenselkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                expenselkp.EditValue = expenselkp.ItemIndex = 0;

            sqlcommand = "SELECT [dbo].[EXPENSE_CALC_" + F_TYPE + "] (N'" + F_DOC_NO + "', 'BANK_EXP', 0)";
            amtbox.Text = Convert.ToDouble(clsConnection.singleReader(sqlcommand)).ToString("#,###,###,###.00");
        }

        private void rate()
        {
            string sqlcommand = "SELECT * FROM V_" + F_TABLE2 + "_BankExpense ORDER BY 1";
            DataTable dt = clsConnection.reader(sqlcommand);
            expenselkp.Properties.DataSource = dt;
            expenselkp.Properties.DisplayMember = "Account Code";
            expenselkp.Properties.ValueMember = "Account Code";
            expenselkp.Properties.PopulateColumns();
            expenselkp.Properties.DropDownRows = dt.Rows.Count;
            if (dt.Rows.Count == 1)
                expenselkp.EditValue = expenselkp.ItemIndex = 0;

            sqlcommand = "SELECT [dbo].[EXPENSE_CALC_" + F_TYPE + "] (N'" + F_DOC_NO + "', 'BANK_EXP', 0)";
            amtbox.Text = Convert.ToDouble(clsConnection.singleReader(sqlcommand)).ToString("#,###,###,###.00");
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

                sqlselect = "SET DATEFORMAT DMY SELECT * FROM " + F_VIEW + " WHERE [" + F_VIEW_COLUMN + "] = N'" + F_DOC_NO + "'";
                dt = clsConnection.reader(sqlselect);

                if (F_TYPE == "PAYM")
                {
                    dt.TableName = "MASTER";
                    ds.Tables.Add(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    postbtn.Enabled = false;
                    XtraMessageBox.Show("Something went wrong. Please try again");
                    this.Close();
                }
                else
                {
                    postbtn.Enabled = true;

                    if (F_TYPE == "PAYM")
                    {
                        sqlselect = "SET DATEFORMAT DMY SELECT * FROM V_PaymentOrderDetails WHERE [" + F_VIEW_COLUMN + "] = N'" + F_DOC_NO + "' ORDER BY [Jn. No]";
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

                    if (F_TYPE == "CASH")
                    {
                        string type = gridview.GetRowCellValue(0, "Type").ToString();
                        if (type == "Receipt")
                            gridview.Columns["Beneficiary"].Visible = false;
                        else
                            gridview.Columns["Payer"].Visible = false;
                    }

                    if (F_TYPE == "CONV")
                    {
                        string type = gridview.GetDataRow(0)["Type"].ToString();
                        string curr = gridview.GetDataRow(0)["Currency2"].ToString();
                        other_amtlbl.Text = curr + " Amount:";

                        if (type == "Sale")
                        {
                            gridview.Columns[4].Caption = "Sale Amt.";
                            gridview.Columns[5].Caption = "Sale Curr.";
                            gridview.Columns[6].Caption = "Purchase Amt.";
                            gridview.Columns[7].Caption = "Purchase Curr.";
                            gridview.Columns[9].Caption = "Sale Acc.";
                            gridview.Columns[10].Caption = "Purchase Acc.";
                        }
                        else
                        {
                            gridview.Columns[4].Caption = "Purchase Amt.";
                            gridview.Columns[5].Caption = "Purchase Curr.";
                            gridview.Columns[6].Caption = "Sale Amt.";
                            gridview.Columns[7].Caption = "Sale Curr.";
                            gridview.Columns[9].Caption = "Purchase Acc.";
                            gridview.Columns[10].Caption = "Sale Acc.";
                        }
                    }

                    gridview.Columns["PATH"].Visible = false;
                    gridview.BestFitColumns();
                    gridview.Columns[F_VIEW_COLUMN].Width = 110;

                    if (F_TYPE == "PAYM")
                        gridview.SetMasterRowExpanded(gridview.FocusedRowHandle, true);

                    if (f_user_post == "False")
                        postbtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                postbtn.Enabled = false;
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

        private delegate void ExpandNewRowDelegate(GridView view);

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
        }

        private void postbtn_Click(object sender, EventArgs e)
        {
            if (datebox.Text == "" | datebox.Text == null | periodbox.Text.Length < 7)
            {
                XtraMessageBox.Show("Post date wasn't specified");
                datebox.Focus();
                return;
            }

            if (expenselkp.Text == "" | expenselkp.EditValue == null)
            {
                XtraMessageBox.Show("Expense field is mandatory");
                expenselkp.Focus();
                return;
            }

            DataRowView row = expenselkp.Properties.GetDataSourceRowByKeyValue(expenselkp.EditValue) as DataRowView;
            string be_code = clsConnection.trimSql(row["Account Code"].ToString());

            double be_sum = 0;
            double other_amt = 0;

            string amt = amtbox.Text.Replace(",", ".");
            string rate = other_amtbox.Text.Replace(",", ".");

            if (!double.TryParse(amt, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out be_sum))
            {
                XtraMessageBox.Show("Incorrect amount");
                amtbox.Focus();
                return;
            }

            if (!double.TryParse(rate, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out other_amt))
            {
                XtraMessageBox.Show("Incorrect amount");
                other_amtbox.Focus();
                return;
            }

            if (F_TABLE == "Conversion" & other_amt == 0)
            {
                XtraMessageBox.Show("Incorrect amount");
                other_amtbox.Focus();
                return;
            }

            try
            {
                string sqlcommand = @"SELECT CONVERT(VARCHAR(10), " + F_COLUMN_DATE + ", 112) FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                string date = datebox.DateTime.ToString("yyyyMMdd");

                sqlcommand = @"SELECT RTRIM(CU_CODE) FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                string curr = clsConnection.singleReader(sqlcommand);
                if (curr == "-")
                    curr = "AZN";

                if (clsTransaction.checkDate(curr, date, F_TYPE) == false)
                {
                    XtraMessageBox.Show("Future postings are not allowed");
                    return;
                }

                if (clsTransaction.checkRate(F_DOC_NO, curr, date, F_TYPE) == false)
                {
                    XtraMessageBox.Show("Please check currency rate");
                    return;
                }
                else
                {
                    UpdateExpense(be_code, be_sum, other_amt);
                    if (PostAmounts() == false)
                        return;
                    if (Post() == true)
                    {
                        jnbox.Text = getPostedJV();
                        getPostedDetails();
                        UpdateDetails();

                        LoadData();
                        if (F_REPOST == false)
                            f_mainform.statuscaption("Document was posted");
                        else
                            f_mainform.statuscaption("Document was reposted");

                        postbtn.Enabled = false;
                        cancellation = "0";
                    }
                    else
                        postbtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                postbtn.Enabled = false;
                return;
            }
        }

        private void UpdateExpense(string be_code, double be_sum, double other_amt)
        {
            try
            {
                string query = @"SET DATEFORMAT DMY UPDATE " + F_TABLE + " SET BE_CODE = N'" + be_code + "', BE_SUM = " + be_sum + ", [UPDATED_USER] = N'" + f_user + "', [UPDATED_DATE] = GETDATE() WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                clsConnection.singleExecute(query);

                if (F_TYPE == "CONV")
                {
                    query = @"UPDATE Conversion SET OTHER_AMT = " + other_amt + " WHERE CONV_TXN_REF = N'" + F_DOC_NO + "'";
                    clsConnection.singleExecute(query);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                return;
            }
        }

        private bool PostAmounts()
        {
            bool result = false;
            try
            {
                if (F_TYPE == "CASH")
                {
                    if (grp1.Visible == true)
                    {
                        string query = @"SELECT AMT FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                        double amt = 0;
                        if (double.TryParse((clsConnection.singleReader(query).ToString()), System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amt))
                        { }

                        double amt1 = 0;
                        double amt2 = 0;
                        double amt3 = 0;
                        double amt4 = 0;
                        double amt5 = 0;
                        double amt6 = 0;
                        string acnt1 = "";
                        string acnt2 = "";
                        string acnt3 = "";
                        string acnt4 = "";
                        string acnt5 = "";
                        string acnt6 = "";
                        string desc1 = "";
                        string desc2 = "";
                        string desc3 = "";
                        string desc4 = "";
                        string desc5 = "";
                        string desc6 = "";

                        if (acntlkp1.Text != "" | acntlkp1.EditValue != null)
                        {
                            if (double.TryParse(amtbox1.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amt1))
                            {
                                desc1 = clsConnection.trimSql(descbox1.Text);
                                acnt1 = acnt_value(acntlkp1);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Please correct amounts");
                            return result;
                        }


                        if (acntlkp2.Text != "" | acntlkp2.EditValue != null)
                        {
                            if (double.TryParse(amtbox2.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amt2))
                            {
                                desc2 = clsConnection.trimSql(descbox2.Text);
                                acnt2 = acnt_value(acntlkp2);
                            }
                        }

                        if (acntlkp3.Text != "" | acntlkp3.EditValue != null)
                        {
                            if (double.TryParse(amtbox3.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amt3))
                            {
                                desc3 = clsConnection.trimSql(descbox3.Text);
                                acnt3 = acnt_value(acntlkp3);
                            }
                        }

                        if (acntlkp4.Text != "" | acntlkp4.EditValue != null)
                        {
                            if (double.TryParse(amtbox4.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amt4))
                            {
                                desc4 = clsConnection.trimSql(descbox4.Text);
                                acnt4 = acnt_value(acntlkp4);
                            }
                        }

                        if (acntlkp5.Text != "" | acntlkp5.EditValue != null)
                        {
                            if (double.TryParse(amtbox5.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amt5))
                            {
                                desc5 = clsConnection.trimSql(descbox5.Text);
                                acnt5 = acnt_value(acntlkp5);
                            }
                        }

                        if (acntlkp6.Text != "" | acntlkp6.EditValue != null)
                        {
                            if (double.TryParse(amtbox6.Text, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out amt6))
                            {
                                desc6 = clsConnection.trimSql(descbox6.Text);
                                acnt6 = acnt_value(acntlkp6);
                            }
                        }

                        double new_amt = amt1 + amt2 + amt3 + amt4 + amt5 + amt6;
                        if (amt != new_amt)
                            XtraMessageBox.Show("Please correct amounts");
                        else
                        {
                            query = @"UPDATE " + F_TABLE + " SET " +
                                " POST_CA_CODE1 = N'" + acnt1 + "', POST_DESC1 = N'" + desc1 + "', POST_AMT1 = " + amt1 + ", " +
                                " POST_CA_CODE2 = N'" + acnt2 + "', POST_DESC2 = N'" + desc2 + "', POST_AMT2 = " + amt2 + ", " +
                                " POST_CA_CODE3 = N'" + acnt3 + "', POST_DESC3 = N'" + desc3 + "', POST_AMT3 = " + amt3 + ", " +
                                " POST_CA_CODE4 = N'" + acnt4 + "', POST_DESC4 = N'" + desc4 + "', POST_AMT4 = " + amt4 + ", " +
                                " POST_CA_CODE5 = N'" + acnt5 + "', POST_DESC5 = N'" + desc5 + "', POST_AMT5 = " + amt5 + ", " +
                                " POST_CA_CODE6 = N'" + acnt6 + "', POST_DESC6 = N'" + desc6 + "', POST_AMT6 = " + amt6 +
                                " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                            clsConnection.singleExecute(query);
                            result = true;
                        }
                    }
                    else
                        result = true;
                }
                else
                    result = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
            return result;
        }

        private string acnt_value(LookUpEdit lkp)
        {
            return clsConnection.trimSql(lkp.EditValue.ToString());
        }
        private void UpdateDetails()
        {
            try
            {
                if (F_TYPE == "PAYM")
                {
                    string query = @"SELECT COUNT(TXN_REF) FROM PostNotes WHERE TXN_REF = N'" + F_DOC_NO + "' AND OPR_TYPE = '" + F_TYPE + "'";
                    string count = clsConnection.singleReader(query);

                    if (count == "1")
                    {
                        query = @"SELECT CONV_CODE FROM PostNotes WHERE TXN_REF = N'" + F_DOC_NO + "' AND OPR_TYPE = '" + F_TYPE + "'";
                        string currency = clsConnection.singleReader(query);

                        query = @"SELECT AMOUNT FROM PostNotes WHERE TXN_REF = N'" + F_DOC_NO + "' AND OPR_TYPE = '" + F_TYPE + "'";
                        string amount = clsConnection.singleReader(query);

                        query = "SELECT UNIT FROM CurrencyCodes WHERE CU_CODE = '" + currency + "'";
                        string unit = clsConnection.singleReader(query);

                        query = "SELECT SUBUNIT FROM CurrencyCodes WHERE CU_CODE = '" + currency + "'";
                        string subunit = clsConnection.singleReader(query);

                        string amount_word = clsTransaction.amount2Text(amount, unit, subunit);

                        query = @"UPDATE " + F_TABLE + " SET AMOUNT_TEXT = N'" + amount_word + "', OTHER_AMT_TEXT = N'" + amount_word + "' WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                        clsConnection.singleExecute(query);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
                return;
            }
        }

        private bool Post()
        {
            bool result = false;
            try
            {
                string date = datebox.Text.Trim();
                string period = periodbox.Text.Trim();

                string query = @"SET DATEFORMAT DMY EXEC [dbo].[" + F_POST_PROC + "] N'" + F_DOC_NO + "', " + period + ", '" + date + "', " + F_REPOST + ", N'" + f_user + "'";
                clsConnection.singleExecute(query);
                result = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
            return result;
        }

        private string getPostedJV()
        {
            string result = "";
            try
            {
                string query = @"SELECT POST_JV FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                result = clsConnection.singleReader(query);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
            return result;
        }

        private void getPostedDetails()
        {
            try
            {
                string query = "";
                jnbox.Text = getPostedJV();

                query = @"SELECT BE_CODE FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                expenselkp.EditValue = clsConnection.singleReader(query);

                query = @"SELECT BE_SUM FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                amtbox.Text = Convert.ToDouble(clsConnection.singleReader(query)).ToString("#,###,###,###.00");

                query = @"SELECT CONVERT(VARCHAR(10), POST_DATE, 112) FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                datebox.DateTime = DateTime.ParseExact(clsConnection.singleReader(query), "yyyyMMdd", CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None);

                query = @"SELECT POST_PERIOD FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                periodbox.Text = clsConnection.singleReader(query);

                if (F_TYPE == "CONV")
                {
                    query = @"SELECT OTHER_AMT FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                    other_amtbox.Text = clsConnection.singleReader(query);
                }
                if (F_TYPE == "CASH")
                {
                    if (grp1.Visible == true)
                    {
                        int i = 1;
                        while (i < 7)
                        {
                            query = @"SELECT POST_CA_CODE" + i + " FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                            string acnt = clsConnection.singleReader(query);
                            if (acnt.Length > 1)
                            {
                                query = @"SELECT POST_AMT" + i + " FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                                string amt = clsConnection.singleReader(query);

                                query = @"SELECT POST_DESC" + i + " FROM " + F_TABLE + " WHERE " + F_COLUMN + " = N'" + F_DOC_NO + "'";
                                string desc = clsConnection.singleReader(query);

                                getCashDetails(i, acnt, amt, desc);
                            }
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error code: \r\n " + ex.ToString());
            }
        }

        private void getCashDetails(int i, string acnt, string amt, string desc)
        {
            GroupControl gc = this.Controls["grp" + i] as GroupControl;
            TextEdit te = gc.Controls["amtbox" + i] as TextEdit;
            LookUpEdit lkp = gc.Controls["acntlkp" + i] as LookUpEdit;
            MemoEdit me = gc.Controls["descbox" + i] as MemoEdit;

            te.Text = amt;
            lkp.EditValue = acnt;
            me.Text = desc;
        }

        private void amtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void other_amtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPaymentGenerate_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_mainform.statuscaption("");
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            SimpleButton sb = (SimpleButton)sender;
            string i = sb.Name.Substring(sb.Name.Length - 1);
            GroupControl gc = this.Controls["grp" + i] as GroupControl;
            TextEdit te = gc.Controls["amtbox" + i] as TextEdit;
            LookUpEdit lkp = gc.Controls["acntlkp" + i] as LookUpEdit;
            MemoEdit me = gc.Controls["descbox" + i] as MemoEdit;

            te.Text = "";
            lkp.EditValue = null;
            me.Text = "";
        }
    }
}