namespace CASHBOOK
{
    partial class frmPaymentGenerate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.datebox = new DevExpress.XtraEditors.DateEdit();
            this.periodbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.pobox = new DevExpress.XtraEditors.TextEdit();
            this.ownbanklkp = new DevExpress.XtraEditors.LookUpEdit();
            this.currbox = new DevExpress.XtraEditors.TextEdit();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.sblbl = new DevExpress.XtraEditors.LabelControl();
            this.oblbl = new DevExpress.XtraEditors.LabelControl();
            this.prepaymentchk = new DevExpress.XtraEditors.CheckEdit();
            this.printbtn = new DevExpress.XtraEditors.SimpleButton();
            this.postbtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            this.preplbl = new DevExpress.XtraEditors.LabelControl();
            this.replbl = new DevExpress.XtraEditors.LabelControl();
            this.supplbl = new DevExpress.XtraEditors.LabelControl();
            this.banklbl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.prepaymentlkp = new DevExpress.XtraEditors.LookUpEdit();
            this.doclkp = new DevExpress.XtraEditors.LookUpEdit();
            this.supplkp = new DevExpress.XtraEditors.LookUpEdit();
            this.trbox = new DevExpress.XtraEditors.TextEdit();
            this.suppbox = new DevExpress.XtraEditors.TextEdit();
            this.basebox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new DevExpress.XtraEditors.PanelControl();
            this.print1box = new DevExpress.XtraEditors.MemoEdit();
            this.budlevlbl = new DevExpress.XtraEditors.LabelControl();
            this.print4box = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.print3box = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.budcatlbl = new DevExpress.XtraEditors.LabelControl();
            this.print2box = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pobox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownbanklkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentchk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentlkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doclkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.print1box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print4box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print3box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print2box.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            gridLevelNode1.RelationName = "Level1";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 250);
            this.grid.MainView = this.gridview;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1249, 257);
            this.grid.TabIndex = 18;
            this.grid.TabStop = false;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridview});
            // 
            // gridview
            // 
            this.gridview.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridview.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridview.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.gridview.Appearance.Row.Options.UseFont = true;
            this.gridview.GridControl = this.grid;
            this.gridview.Name = "gridview";
            this.gridview.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridview.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridview.OptionsBehavior.Editable = false;
            this.gridview.OptionsLayout.Columns.AddNewColumns = false;
            this.gridview.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridview.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gridview.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridview.OptionsPrint.PrintDetails = true;
            this.gridview.OptionsPrint.PrintFilterInfo = true;
            this.gridview.OptionsView.ColumnAutoWidth = false;
            this.gridview.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridview.OptionsView.RowAutoHeight = true;
            this.gridview.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // datebox
            // 
            this.datebox.EditValue = null;
            this.datebox.Location = new System.Drawing.Point(115, 71);
            this.datebox.Name = "datebox";
            this.datebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.datebox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.datebox.Properties.Appearance.Options.UseFont = true;
            this.datebox.Properties.Appearance.Options.UseForeColor = true;
            this.datebox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datebox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datebox.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.datebox.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.datebox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.datebox.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.datebox.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.datebox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.datebox.Size = new System.Drawing.Size(164, 22);
            this.datebox.TabIndex = 2;
            this.datebox.EditValueChanged += new System.EventHandler(this.datebox_EditValueChanged);
            // 
            // periodbox
            // 
            this.periodbox.Enabled = false;
            this.periodbox.Location = new System.Drawing.Point(115, 101);
            this.periodbox.Name = "periodbox";
            this.periodbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.periodbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.periodbox.Properties.Appearance.Options.UseFont = true;
            this.periodbox.Properties.Appearance.Options.UseForeColor = true;
            this.periodbox.Properties.MaxLength = 12;
            this.periodbox.Properties.ReadOnly = true;
            this.periodbox.Size = new System.Drawing.Size(164, 22);
            this.periodbox.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(12, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 16);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "Payment Period:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(12, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 16);
            this.labelControl2.TabIndex = 59;
            this.labelControl2.Text = "Payment Date:";
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(1118, 11);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(119, 21);
            this.savebtn.TabIndex = 16;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // pobox
            // 
            this.pobox.Enabled = false;
            this.pobox.Location = new System.Drawing.Point(115, 11);
            this.pobox.Name = "pobox";
            this.pobox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.pobox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.pobox.Properties.Appearance.Options.UseFont = true;
            this.pobox.Properties.Appearance.Options.UseForeColor = true;
            this.pobox.Properties.MaxLength = 15;
            this.pobox.Properties.ReadOnly = true;
            this.pobox.Size = new System.Drawing.Size(164, 22);
            this.pobox.TabIndex = 0;
            // 
            // ownbanklkp
            // 
            this.ownbanklkp.Location = new System.Drawing.Point(896, 11);
            this.ownbanklkp.Name = "ownbanklkp";
            this.ownbanklkp.Properties.AccessibleDescription = "";
            this.ownbanklkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ownbanklkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ownbanklkp.Properties.Appearance.Options.UseFont = true;
            this.ownbanklkp.Properties.Appearance.Options.UseForeColor = true;
            this.ownbanklkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ownbanklkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.ownbanklkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.ownbanklkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ownbanklkp.Properties.DropDownRows = 3;
            this.ownbanklkp.Properties.NullText = "";
            this.ownbanklkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.ownbanklkp.Properties.PopupSizeable = false;
            this.ownbanklkp.Properties.PopupWidth = 40;
            this.ownbanklkp.Properties.ShowFooter = false;
            this.ownbanklkp.Properties.ShowHeader = false;
            this.ownbanklkp.Size = new System.Drawing.Size(186, 22);
            this.ownbanklkp.TabIndex = 7;
            this.ownbanklkp.EditValueChanged += new System.EventHandler(this.ownbanklkp_EditValueChanged);
            // 
            // currbox
            // 
            this.currbox.Enabled = false;
            this.currbox.Location = new System.Drawing.Point(534, 71);
            this.currbox.Name = "currbox";
            this.currbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.currbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.currbox.Properties.Appearance.Options.UseFont = true;
            this.currbox.Properties.Appearance.Options.UseForeColor = true;
            this.currbox.Properties.MaxLength = 12;
            this.currbox.Properties.ReadOnly = true;
            this.currbox.Size = new System.Drawing.Size(164, 22);
            this.currbox.TabIndex = 6;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.sblbl);
            this.panel.Controls.Add(this.oblbl);
            this.panel.Controls.Add(this.prepaymentchk);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Controls.Add(this.printbtn);
            this.panel.Controls.Add(this.postbtn);
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Controls.Add(this.preplbl);
            this.panel.Controls.Add(this.replbl);
            this.panel.Controls.Add(this.supplbl);
            this.panel.Controls.Add(this.banklbl);
            this.panel.Controls.Add(this.labelControl14);
            this.panel.Controls.Add(this.labelControl2);
            this.panel.Controls.Add(this.prepaymentlkp);
            this.panel.Controls.Add(this.doclkp);
            this.panel.Controls.Add(this.supplkp);
            this.panel.Controls.Add(this.ownbanklkp);
            this.panel.Controls.Add(this.datebox);
            this.panel.Controls.Add(this.pobox);
            this.panel.Controls.Add(this.trbox);
            this.panel.Controls.Add(this.suppbox);
            this.panel.Controls.Add(this.basebox);
            this.panel.Controls.Add(this.currbox);
            this.panel.Controls.Add(this.labelControl13);
            this.panel.Controls.Add(this.labelControl3);
            this.panel.Controls.Add(this.labelControl12);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Controls.Add(this.labelControl4);
            this.panel.Controls.Add(this.periodbox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1249, 135);
            this.panel.TabIndex = 63;
            // 
            // sblbl
            // 
            this.sblbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.sblbl.Location = new System.Drawing.Point(1088, 44);
            this.sblbl.Name = "sblbl";
            this.sblbl.Size = new System.Drawing.Size(0, 16);
            this.sblbl.TabIndex = 60;
            // 
            // oblbl
            // 
            this.oblbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.oblbl.Location = new System.Drawing.Point(1088, 14);
            this.oblbl.Name = "oblbl";
            this.oblbl.Size = new System.Drawing.Size(0, 16);
            this.oblbl.TabIndex = 60;
            // 
            // prepaymentchk
            // 
            this.prepaymentchk.Location = new System.Drawing.Point(1090, 73);
            this.prepaymentchk.Name = "prepaymentchk";
            this.prepaymentchk.Properties.Caption = "";
            this.prepaymentchk.Size = new System.Drawing.Size(18, 19);
            this.prepaymentchk.TabIndex = 10;
            this.prepaymentchk.ToolTip = "Check for prepayment";
            this.prepaymentchk.CheckedChanged += new System.EventHandler(this.prepaymentchk_CheckedChanged);
            // 
            // printbtn
            // 
            this.printbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.printbtn.Appearance.Options.UseFont = true;
            this.printbtn.Enabled = false;
            this.printbtn.Location = new System.Drawing.Point(1118, 41);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(119, 22);
            this.printbtn.TabIndex = 17;
            this.printbtn.Text = "Print";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // postbtn
            // 
            this.postbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.postbtn.Appearance.Options.UseFont = true;
            this.postbtn.Enabled = false;
            this.postbtn.Location = new System.Drawing.Point(1118, 71);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(119, 22);
            this.postbtn.TabIndex = 18;
            this.postbtn.Text = "Post";
            this.postbtn.Click += new System.EventHandler(this.postbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(1118, 101);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(119, 22);
            this.cancelbtn.TabIndex = 19;
            this.cancelbtn.Text = "Exit";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            this.cancelbtn.Leave += new System.EventHandler(this.cancelbtn_Leave);
            // 
            // preplbl
            // 
            this.preplbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.preplbl.Location = new System.Drawing.Point(777, 74);
            this.preplbl.Name = "preplbl";
            this.preplbl.Size = new System.Drawing.Size(101, 16);
            this.preplbl.TabIndex = 59;
            this.preplbl.Text = "Prepayment Acc.:";
            // 
            // replbl
            // 
            this.replbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.replbl.Location = new System.Drawing.Point(777, 104);
            this.replbl.Name = "replbl";
            this.replbl.Size = new System.Drawing.Size(88, 16);
            this.replbl.TabIndex = 59;
            this.replbl.Text = "Report Format:";
            // 
            // supplbl
            // 
            this.supplbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.supplbl.Location = new System.Drawing.Point(777, 44);
            this.supplbl.Name = "supplbl";
            this.supplbl.Size = new System.Drawing.Size(92, 16);
            this.supplbl.TabIndex = 59;
            this.supplbl.Text = "Supplier\'s Bank:";
            // 
            // banklbl
            // 
            this.banklbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.banklbl.Location = new System.Drawing.Point(777, 14);
            this.banklbl.Name = "banklbl";
            this.banklbl.Size = new System.Drawing.Size(98, 16);
            this.banklbl.TabIndex = 59;
            this.banklbl.Text = "Company\'s Bank:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl14.Location = new System.Drawing.Point(406, 74);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(56, 16);
            this.labelControl14.TabIndex = 59;
            this.labelControl14.Text = "Currency:";
            // 
            // prepaymentlkp
            // 
            this.prepaymentlkp.Location = new System.Drawing.Point(896, 71);
            this.prepaymentlkp.Name = "prepaymentlkp";
            this.prepaymentlkp.Properties.AccessibleDescription = "";
            this.prepaymentlkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.prepaymentlkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.prepaymentlkp.Properties.Appearance.Options.UseFont = true;
            this.prepaymentlkp.Properties.Appearance.Options.UseForeColor = true;
            this.prepaymentlkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.prepaymentlkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.prepaymentlkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.prepaymentlkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.prepaymentlkp.Properties.DropDownRows = 3;
            this.prepaymentlkp.Properties.NullText = "";
            this.prepaymentlkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.prepaymentlkp.Properties.PopupSizeable = false;
            this.prepaymentlkp.Properties.PopupWidth = 40;
            this.prepaymentlkp.Properties.ShowFooter = false;
            this.prepaymentlkp.Properties.ShowHeader = false;
            this.prepaymentlkp.Size = new System.Drawing.Size(186, 22);
            this.prepaymentlkp.TabIndex = 9;
            // 
            // doclkp
            // 
            this.doclkp.Location = new System.Drawing.Point(896, 101);
            this.doclkp.Name = "doclkp";
            this.doclkp.Properties.AccessibleDescription = "";
            this.doclkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.doclkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.doclkp.Properties.Appearance.Options.UseFont = true;
            this.doclkp.Properties.Appearance.Options.UseForeColor = true;
            this.doclkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.doclkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.doclkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.doclkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.doclkp.Properties.DropDownRows = 3;
            this.doclkp.Properties.NullText = "";
            this.doclkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.doclkp.Properties.PopupSizeable = false;
            this.doclkp.Properties.PopupWidth = 40;
            this.doclkp.Properties.ShowFooter = false;
            this.doclkp.Properties.ShowHeader = false;
            this.doclkp.Size = new System.Drawing.Size(186, 22);
            this.doclkp.TabIndex = 11;
            this.doclkp.Leave += new System.EventHandler(this.doclkp_Leave);
            // 
            // supplkp
            // 
            this.supplkp.Location = new System.Drawing.Point(896, 41);
            this.supplkp.Name = "supplkp";
            this.supplkp.Properties.AccessibleDescription = "";
            this.supplkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.supplkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.supplkp.Properties.Appearance.Options.UseFont = true;
            this.supplkp.Properties.Appearance.Options.UseForeColor = true;
            this.supplkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.supplkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.supplkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.supplkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.supplkp.Properties.DropDownRows = 3;
            this.supplkp.Properties.NullText = "";
            this.supplkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.supplkp.Properties.PopupSizeable = false;
            this.supplkp.Properties.PopupWidth = 40;
            this.supplkp.Properties.ShowFooter = false;
            this.supplkp.Properties.ShowHeader = false;
            this.supplkp.Size = new System.Drawing.Size(186, 22);
            this.supplkp.TabIndex = 8;
            this.supplkp.EditValueChanged += new System.EventHandler(this.supplkp_EditValueChanged);
            // 
            // trbox
            // 
            this.trbox.Enabled = false;
            this.trbox.Location = new System.Drawing.Point(534, 41);
            this.trbox.Name = "trbox";
            this.trbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.trbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.trbox.Properties.Appearance.Options.UseFont = true;
            this.trbox.Properties.Appearance.Options.UseForeColor = true;
            this.trbox.Properties.MaxLength = 12;
            this.trbox.Properties.ReadOnly = true;
            this.trbox.Size = new System.Drawing.Size(164, 22);
            this.trbox.TabIndex = 5;
            // 
            // suppbox
            // 
            this.suppbox.Enabled = false;
            this.suppbox.Location = new System.Drawing.Point(115, 41);
            this.suppbox.Name = "suppbox";
            this.suppbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.suppbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.suppbox.Properties.Appearance.Options.UseFont = true;
            this.suppbox.Properties.Appearance.Options.UseForeColor = true;
            this.suppbox.Properties.MaxLength = 12;
            this.suppbox.Properties.ReadOnly = true;
            this.suppbox.Size = new System.Drawing.Size(164, 22);
            this.suppbox.TabIndex = 1;
            // 
            // basebox
            // 
            this.basebox.Enabled = false;
            this.basebox.Location = new System.Drawing.Point(534, 11);
            this.basebox.Name = "basebox";
            this.basebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.basebox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.basebox.Properties.Appearance.Options.UseFont = true;
            this.basebox.Properties.Appearance.Options.UseForeColor = true;
            this.basebox.Properties.MaxLength = 12;
            this.basebox.Properties.ReadOnly = true;
            this.basebox.Size = new System.Drawing.Size(164, 22);
            this.basebox.TabIndex = 4;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl13.Location = new System.Drawing.Point(406, 44);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(120, 16);
            this.labelControl13.TabIndex = 58;
            this.labelControl13.Text = "Transaction Amount:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(12, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 16);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Supplier Code:";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl12.Location = new System.Drawing.Point(406, 14);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(80, 16);
            this.labelControl12.TabIndex = 58;
            this.labelControl12.Text = "Base Amount:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 16);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Payment No:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.print1box);
            this.panel2.Controls.Add(this.budlevlbl);
            this.panel2.Controls.Add(this.print4box);
            this.panel2.Controls.Add(this.labelControl5);
            this.panel2.Controls.Add(this.print3box);
            this.panel2.Controls.Add(this.labelControl6);
            this.panel2.Controls.Add(this.budcatlbl);
            this.panel2.Controls.Add(this.print2box);
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1249, 117);
            this.panel2.TabIndex = 12;
            // 
            // print1box
            // 
            this.print1box.Location = new System.Drawing.Point(114, 12);
            this.print1box.Name = "print1box";
            this.print1box.Properties.AllowMouseWheel = false;
            this.print1box.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.print1box.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.print1box.Properties.Appearance.Options.UseFont = true;
            this.print1box.Properties.Appearance.Options.UseForeColor = true;
            this.print1box.Properties.MaxLength = 1000;
            this.print1box.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.print1box.Size = new System.Drawing.Size(584, 58);
            this.print1box.TabIndex = 12;
            // 
            // budlevlbl
            // 
            this.budlevlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.budlevlbl.Location = new System.Drawing.Point(775, 45);
            this.budlevlbl.Name = "budlevlbl";
            this.budlevlbl.Size = new System.Drawing.Size(110, 16);
            this.budlevlbl.TabIndex = 63;
            this.budlevlbl.Text = "Budget Level Code:";
            this.budlevlbl.ToolTip = "D4";
            // 
            // print4box
            // 
            this.print4box.Location = new System.Drawing.Point(895, 42);
            this.print4box.Name = "print4box";
            this.print4box.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.print4box.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.print4box.Properties.Appearance.Options.UseFont = true;
            this.print4box.Properties.Appearance.Options.UseForeColor = true;
            this.print4box.Properties.MaxLength = 50;
            this.print4box.Size = new System.Drawing.Size(186, 22);
            this.print4box.TabIndex = 15;
            this.print4box.Leave += new System.EventHandler(this.print4box_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(11, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 16);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "Payment Descr.:";
            this.labelControl5.ToolTip = "D1";
            // 
            // print3box
            // 
            this.print3box.Location = new System.Drawing.Point(895, 12);
            this.print3box.Name = "print3box";
            this.print3box.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.print3box.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.print3box.Properties.Appearance.Options.UseFont = true;
            this.print3box.Properties.Appearance.Options.UseForeColor = true;
            this.print3box.Properties.MaxLength = 50;
            this.print3box.Size = new System.Drawing.Size(186, 22);
            this.print3box.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(11, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 16);
            this.labelControl6.TabIndex = 59;
            this.labelControl6.Text = "Additional Inf.:";
            this.labelControl6.ToolTip = "D2";
            // 
            // budcatlbl
            // 
            this.budcatlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.budcatlbl.Location = new System.Drawing.Point(776, 15);
            this.budcatlbl.Name = "budcatlbl";
            this.budcatlbl.Size = new System.Drawing.Size(104, 16);
            this.budcatlbl.TabIndex = 62;
            this.budcatlbl.Text = "Budget Cat. Code:";
            this.budcatlbl.ToolTip = "D3";
            // 
            // print2box
            // 
            this.print2box.Location = new System.Drawing.Point(114, 78);
            this.print2box.Name = "print2box";
            this.print2box.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.print2box.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.print2box.Properties.Appearance.Options.UseFont = true;
            this.print2box.Properties.Appearance.Options.UseForeColor = true;
            this.print2box.Properties.MaxLength = 1000;
            this.print2box.Size = new System.Drawing.Size(583, 22);
            this.print2box.TabIndex = 13;
            // 
            // frmPaymentGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1249, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.grid);
            this.Name = "frmPaymentGenerate";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPaymentGenerate_FormClosing);
            this.Load += new System.EventHandler(this.frmPaymentGenerate_Load);
            this.Resize += new System.EventHandler(this.frmPaymentGenerate_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pobox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownbanklkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentchk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepaymentlkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doclkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.print1box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print4box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print3box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print2box.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit datebox;
        private DevExpress.XtraEditors.TextEdit periodbox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.TextEdit pobox;
        private DevExpress.XtraEditors.LookUpEdit ownbanklkp;
        private DevExpress.XtraEditors.TextEdit currbox;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit suppbox;
        private DevExpress.XtraEditors.LookUpEdit doclkp;
        private DevExpress.XtraEditors.LookUpEdit supplkp;
        private DevExpress.XtraEditors.TextEdit basebox;
        private DevExpress.XtraEditors.TextEdit trbox;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.LabelControl replbl;
        private DevExpress.XtraEditors.LabelControl supplbl;
        private DevExpress.XtraEditors.LabelControl banklbl;
        private DevExpress.XtraEditors.SimpleButton printbtn;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit print2box;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl preplbl;
        private DevExpress.XtraEditors.LookUpEdit prepaymentlkp;
        private DevExpress.XtraEditors.CheckEdit prepaymentchk;
        private DevExpress.XtraEditors.SimpleButton postbtn;
        private DevExpress.XtraEditors.TextEdit print4box;
        private DevExpress.XtraEditors.TextEdit print3box;
        private DevExpress.XtraEditors.LabelControl budlevlbl;
        private DevExpress.XtraEditors.LabelControl budcatlbl;
        private DevExpress.XtraEditors.PanelControl panel2;
        private DevExpress.XtraEditors.MemoEdit print1box;
        private DevExpress.XtraEditors.LabelControl sblbl;
        private DevExpress.XtraEditors.LabelControl oblbl;




    }
}