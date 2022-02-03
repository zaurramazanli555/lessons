namespace CASHBOOK
{
    partial class frmInvoices
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
            this.pobtn = new DevExpress.XtraEditors.SimpleButton();
            this.splitbtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitter = new DevExpress.XtraEditors.SplitContainerControl();
            this.group = new DevExpress.XtraEditors.GroupControl();
            this.acntlkp = new DevExpress.XtraEditors.LookUpEdit();
            this.currbox = new DevExpress.XtraEditors.TextEdit();
            this.trbox = new DevExpress.XtraEditors.TextEdit();
            this.invbox = new DevExpress.XtraEditors.TextEdit();
            this.basebox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.clearbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group)).BeginInit();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acntlkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basebox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pobtn
            // 
            this.pobtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.pobtn.Appearance.Options.UseFont = true;
            this.pobtn.Location = new System.Drawing.Point(5, 374);
            this.pobtn.Name = "pobtn";
            this.pobtn.Size = new System.Drawing.Size(136, 22);
            this.pobtn.TabIndex = 6;
            this.pobtn.Text = "Transfer to PO";
            this.pobtn.Click += new System.EventHandler(this.pobtn_Click);
            // 
            // splitbtn
            // 
            this.splitbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.splitbtn.Appearance.Options.UseFont = true;
            this.splitbtn.Location = new System.Drawing.Point(5, 340);
            this.splitbtn.Name = "splitbtn";
            this.splitbtn.Size = new System.Drawing.Size(136, 22);
            this.splitbtn.TabIndex = 5;
            this.splitbtn.Text = "Split Amount";
            this.splitbtn.Click += new System.EventHandler(this.splitbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(5, 442);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(136, 22);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Exit";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridview;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(946, 504);
            this.grid.TabIndex = 0;
            this.grid.TabStop = false;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridview,
            this.gridView1});
            this.grid.Click += new System.EventHandler(this.grid_Click);
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
            this.gridview.OptionsCustomization.AllowGroup = false;
            this.gridview.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridview.OptionsDetail.AutoZoomDetail = true;
            this.gridview.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gridview.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gridview.OptionsLayout.Columns.AddNewColumns = false;
            this.gridview.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridview.OptionsMenu.EnableColumnMenu = false;
            this.gridview.OptionsMenu.EnableFooterMenu = false;
            this.gridview.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridview.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gridview.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridview.OptionsPrint.PrintFilterInfo = true;
            this.gridview.OptionsSelection.MultiSelect = true;
            this.gridview.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gridview.OptionsView.ColumnAutoWidth = false;
            this.gridview.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridview.OptionsView.RowAutoHeight = true;
            this.gridview.OptionsView.ShowAutoFilterRow = true;
            this.gridview.OptionsView.ShowFooter = true;
            this.gridview.OptionsView.ShowGroupPanel = false;
            this.gridview.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridview_SelectionChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.IsSplitterFixed = true;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            this.splitter.Panel1.Controls.Add(this.group);
            this.splitter.Panel1.Text = "Panel1";
            this.splitter.Panel2.Controls.Add(this.grid);
            this.splitter.Panel2.Text = "Panel2";
            this.splitter.Size = new System.Drawing.Size(1097, 504);
            this.splitter.SplitterPosition = 146;
            this.splitter.TabIndex = 1;
            // 
            // group
            // 
            this.group.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.group.Controls.Add(this.acntlkp);
            this.group.Controls.Add(this.currbox);
            this.group.Controls.Add(this.trbox);
            this.group.Controls.Add(this.invbox);
            this.group.Controls.Add(this.basebox);
            this.group.Controls.Add(this.labelControl3);
            this.group.Controls.Add(this.labelControl5);
            this.group.Controls.Add(this.labelControl1);
            this.group.Controls.Add(this.labelControl2);
            this.group.Controls.Add(this.labelControl7);
            this.group.Controls.Add(this.clearbtn);
            this.group.Controls.Add(this.cancelbtn);
            this.group.Controls.Add(this.pobtn);
            this.group.Controls.Add(this.splitbtn);
            this.group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group.Location = new System.Drawing.Point(0, 0);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(146, 504);
            this.group.TabIndex = 0;
            this.group.Text = "Selection Totals";
            // 
            // acntlkp
            // 
            this.acntlkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.acntlkp.Location = new System.Drawing.Point(5, 60);
            this.acntlkp.Name = "acntlkp";
            this.acntlkp.Properties.AccessibleDescription = "";
            this.acntlkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.acntlkp.Properties.Appearance.Options.UseFont = true;
            this.acntlkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.acntlkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.acntlkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.acntlkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.acntlkp.Properties.DropDownRows = 3;
            this.acntlkp.Properties.NullText = "";
            this.acntlkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.acntlkp.Properties.PopupSizeable = false;
            this.acntlkp.Properties.PopupWidth = 40;
            this.acntlkp.Properties.ShowFooter = false;
            this.acntlkp.Properties.ShowHeader = false;
            this.acntlkp.Size = new System.Drawing.Size(136, 22);
            this.acntlkp.TabIndex = 0;
            this.acntlkp.EditValueChanged += new System.EventHandler(this.acntlkp_EditValueChanged);
            // 
            // currbox
            // 
            this.currbox.Location = new System.Drawing.Point(5, 252);
            this.currbox.Name = "currbox";
            this.currbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.currbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.currbox.Properties.Appearance.Options.UseFont = true;
            this.currbox.Properties.Appearance.Options.UseForeColor = true;
            this.currbox.Properties.MaxLength = 12;
            this.currbox.Size = new System.Drawing.Size(136, 22);
            this.currbox.TabIndex = 4;
            // 
            // trbox
            // 
            this.trbox.Location = new System.Drawing.Point(5, 204);
            this.trbox.Name = "trbox";
            this.trbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.trbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.trbox.Properties.Appearance.Options.UseFont = true;
            this.trbox.Properties.Appearance.Options.UseForeColor = true;
            this.trbox.Properties.MaxLength = 12;
            this.trbox.Size = new System.Drawing.Size(136, 22);
            this.trbox.TabIndex = 3;
            // 
            // invbox
            // 
            this.invbox.Location = new System.Drawing.Point(5, 108);
            this.invbox.Name = "invbox";
            this.invbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.invbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.invbox.Properties.Appearance.Options.UseFont = true;
            this.invbox.Properties.Appearance.Options.UseForeColor = true;
            this.invbox.Properties.MaxLength = 12;
            this.invbox.Size = new System.Drawing.Size(136, 22);
            this.invbox.TabIndex = 1;
            // 
            // basebox
            // 
            this.basebox.Location = new System.Drawing.Point(5, 156);
            this.basebox.Name = "basebox";
            this.basebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.basebox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.basebox.Properties.Appearance.Options.UseFont = true;
            this.basebox.Properties.Appearance.Options.UseForeColor = true;
            this.basebox.Properties.MaxLength = 12;
            this.basebox.Size = new System.Drawing.Size(136, 22);
            this.basebox.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(5, 233);
            this.labelControl3.MinimumSize = new System.Drawing.Size(136, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(136, 16);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Currency";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Location = new System.Drawing.Point(5, 185);
            this.labelControl5.MinimumSize = new System.Drawing.Size(136, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(136, 16);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "Transaction";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(5, 89);
            this.labelControl1.MinimumSize = new System.Drawing.Size(136, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 16);
            this.labelControl1.TabIndex = 58;
            this.labelControl1.Text = "Selected invoices";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Location = new System.Drawing.Point(5, 137);
            this.labelControl2.MinimumSize = new System.Drawing.Size(136, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 16);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Base";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Location = new System.Drawing.Point(5, 41);
            this.labelControl7.MinimumSize = new System.Drawing.Size(136, 16);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(136, 16);
            this.labelControl7.TabIndex = 58;
            this.labelControl7.Text = "Supplier";
            // 
            // clearbtn
            // 
            this.clearbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.clearbtn.Appearance.Options.UseFont = true;
            this.clearbtn.Location = new System.Drawing.Point(5, 408);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(136, 22);
            this.clearbtn.TabIndex = 7;
            this.clearbtn.Text = "Clear";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 504);
            this.Controls.Add(this.splitter);
            this.Name = "frmInvoices";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvoices_FormClosing);
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group)).EndInit();
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acntlkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basebox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton pobtn;
        private DevExpress.XtraEditors.SimpleButton splitbtn;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitter;
        private DevExpress.XtraEditors.GroupControl group;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton clearbtn;
        private DevExpress.XtraEditors.TextEdit invbox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit trbox;
        private DevExpress.XtraEditors.TextEdit basebox;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit currbox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit acntlkp;
    }
}