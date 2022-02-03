namespace CASHBOOK
{
    partial class frmOperationGrid
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridview = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.newbtn = new DevExpress.XtraEditors.SimpleButton();
            this.deletebtn = new DevExpress.XtraEditors.SimpleButton();
            this.postbtn = new DevExpress.XtraEditors.SimpleButton();
            this.printbtn = new DevExpress.XtraEditors.SimpleButton();
            this.repostbtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
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
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridview;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(969, 451);
            this.grid.TabIndex = 5;
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
            this.gridview.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridview_MasterRowExpanded);
            this.gridview.DoubleClick += new System.EventHandler(this.gridview_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.newbtn);
            this.panel.Controls.Add(this.deletebtn);
            this.panel.Controls.Add(this.postbtn);
            this.panel.Controls.Add(this.printbtn);
            this.panel.Controls.Add(this.repostbtn);
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 453);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(969, 37);
            this.panel.TabIndex = 5;
            // 
            // newbtn
            // 
            this.newbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.newbtn.Appearance.Options.UseFont = true;
            this.newbtn.Location = new System.Drawing.Point(12, 8);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(100, 22);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "New";
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.deletebtn.Appearance.Options.UseFont = true;
            this.deletebtn.Location = new System.Drawing.Point(127, 8);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 22);
            this.deletebtn.TabIndex = 0;
            this.deletebtn.Text = "Delete";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // postbtn
            // 
            this.postbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.postbtn.Appearance.Options.UseFont = true;
            this.postbtn.Location = new System.Drawing.Point(242, 8);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(100, 22);
            this.postbtn.TabIndex = 1;
            this.postbtn.Text = "Post";
            this.postbtn.Click += new System.EventHandler(this.postbtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.printbtn.Appearance.Options.UseFont = true;
            this.printbtn.Location = new System.Drawing.Point(472, 8);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(100, 22);
            this.printbtn.TabIndex = 3;
            this.printbtn.Text = "Print";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // repostbtn
            // 
            this.repostbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.repostbtn.Appearance.Options.UseFont = true;
            this.repostbtn.Location = new System.Drawing.Point(357, 8);
            this.repostbtn.Name = "repostbtn";
            this.repostbtn.Size = new System.Drawing.Size(100, 22);
            this.repostbtn.TabIndex = 2;
            this.repostbtn.Text = "Repost";
            this.repostbtn.Click += new System.EventHandler(this.repostbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(587, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(100, 22);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "Exit";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // frmOperationGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 490);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.grid);
            this.Name = "frmOperationGrid";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOperationGrid_FormClosing);
            this.Load += new System.EventHandler(this.frmOperationGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton deletebtn;
        private DevExpress.XtraEditors.SimpleButton postbtn;
        private DevExpress.XtraEditors.SimpleButton printbtn;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.SimpleButton repostbtn;
        private DevExpress.XtraEditors.SimpleButton newbtn;




    }
}