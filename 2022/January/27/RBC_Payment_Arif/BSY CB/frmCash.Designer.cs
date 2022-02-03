namespace CASHBOOK
{
    partial class frmCash
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
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.postbtn = new DevExpress.XtraEditors.SimpleButton();
            this.printbtn = new DevExpress.XtraEditors.SimpleButton();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.acntlbl = new DevExpress.XtraEditors.LabelControl();
            this.acntlkp = new DevExpress.XtraEditors.LookUpEdit();
            this.orderbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.typelbl = new DevExpress.XtraEditors.LabelControl();
            this.typelkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.personlbl = new DevExpress.XtraEditors.LabelControl();
            this.periodbox = new DevExpress.XtraEditors.TextEdit();
            this.datebox = new DevExpress.XtraEditors.DateEdit();
            this.descbox = new DevExpress.XtraEditors.MemoEdit();
            this.personlkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.docbox = new DevExpress.XtraEditors.TextEdit();
            this.amtbox = new DevExpress.XtraEditors.TextEdit();
            this.catlkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.currlbl = new DevExpress.XtraEditors.LabelControl();
            this.internalchk = new DevExpress.XtraEditors.CheckEdit();
            this.expacntlbl = new DevExpress.XtraEditors.LabelControl();
            this.expacntlkp = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acntlkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personlkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catlkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalchk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expacntlkp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.postbtn);
            this.panel.Controls.Add(this.printbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 338);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(606, 37);
            this.panel.TabIndex = 10;
            // 
            // postbtn
            // 
            this.postbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.postbtn.Appearance.Options.UseFont = true;
            this.postbtn.Enabled = false;
            this.postbtn.Location = new System.Drawing.Point(386, 8);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(94, 22);
            this.postbtn.TabIndex = 12;
            this.postbtn.Text = "Post";
            this.postbtn.Click += new System.EventHandler(this.postbtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.printbtn.Appearance.Options.UseFont = true;
            this.printbtn.Enabled = false;
            this.printbtn.Location = new System.Drawing.Point(277, 8);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(94, 22);
            this.printbtn.TabIndex = 11;
            this.printbtn.Text = "Print";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(168, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(94, 22);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(495, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(94, 22);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "Exit";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(12, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 16);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Date:    ";
            // 
            // acntlbl
            // 
            this.acntlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acntlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.acntlbl.Location = new System.Drawing.Point(11, 142);
            this.acntlbl.Name = "acntlbl";
            this.acntlbl.Size = new System.Drawing.Size(82, 16);
            this.acntlbl.TabIndex = 56;
            this.acntlbl.Text = "Cash Account:";
            // 
            // acntlkp
            // 
            this.acntlkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.acntlkp.Location = new System.Drawing.Point(109, 139);
            this.acntlkp.Name = "acntlkp";
            this.acntlkp.Properties.AccessibleDescription = "";
            this.acntlkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.acntlkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.acntlkp.Properties.Appearance.Options.UseFont = true;
            this.acntlkp.Properties.Appearance.Options.UseForeColor = true;
            this.acntlkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.acntlkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.acntlkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.acntlkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.acntlkp.Properties.DropDownRows = 1;
            this.acntlkp.Properties.NullText = "";
            this.acntlkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.acntlkp.Properties.PopupSizeable = false;
            this.acntlkp.Properties.PopupWidth = 40;
            this.acntlkp.Properties.ShowFooter = false;
            this.acntlkp.Properties.ShowHeader = false;
            this.acntlkp.Size = new System.Drawing.Size(171, 22);
            this.acntlkp.TabIndex = 5;
            this.acntlkp.EditValueChanged += new System.EventHandler(this.acntlkp_EditValueChanged);
            // 
            // orderbox
            // 
            this.orderbox.Enabled = false;
            this.orderbox.Location = new System.Drawing.Point(109, 19);
            this.orderbox.Name = "orderbox";
            this.orderbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.orderbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.orderbox.Properties.Appearance.Options.UseFont = true;
            this.orderbox.Properties.Appearance.Options.UseForeColor = true;
            this.orderbox.Properties.MaxLength = 15;
            this.orderbox.Size = new System.Drawing.Size(170, 22);
            this.orderbox.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(12, 232);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 16);
            this.labelControl5.TabIndex = 56;
            this.labelControl5.Text = "Description:";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(12, 22);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 16);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Voucher No:";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl7.Location = new System.Drawing.Point(12, 112);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 16);
            this.labelControl7.TabIndex = 56;
            this.labelControl7.Text = "Amount:    ";
            // 
            // typelbl
            // 
            this.typelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typelbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.typelbl.Location = new System.Drawing.Point(12, 52);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(61, 16);
            this.typelbl.TabIndex = 56;
            this.typelbl.Text = "Operation:";
            // 
            // typelkp
            // 
            this.typelkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.typelkp.Location = new System.Drawing.Point(109, 49);
            this.typelkp.Name = "typelkp";
            this.typelkp.Properties.AccessibleDescription = "";
            this.typelkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.typelkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.typelkp.Properties.Appearance.Options.UseFont = true;
            this.typelkp.Properties.Appearance.Options.UseForeColor = true;
            this.typelkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.typelkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.typelkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.typelkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typelkp.Properties.DropDownRows = 2;
            this.typelkp.Properties.NullText = "";
            this.typelkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.typelkp.Properties.PopupSizeable = false;
            this.typelkp.Properties.PopupWidth = 40;
            this.typelkp.Properties.ShowFooter = false;
            this.typelkp.Properties.ShowHeader = false;
            this.typelkp.Size = new System.Drawing.Size(171, 22);
            this.typelkp.TabIndex = 1;
            this.typelkp.EditValueChanged += new System.EventHandler(this.typelkp_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(302, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 16);
            this.labelControl1.TabIndex = 60;
            this.labelControl1.Text = "Period:";
            this.labelControl1.Visible = false;
            // 
            // personlbl
            // 
            this.personlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.personlbl.Location = new System.Drawing.Point(11, 172);
            this.personlbl.Name = "personlbl";
            this.personlbl.Size = new System.Drawing.Size(0, 16);
            this.personlbl.TabIndex = 56;
            // 
            // periodbox
            // 
            this.periodbox.Enabled = false;
            this.periodbox.Location = new System.Drawing.Point(399, 79);
            this.periodbox.Name = "periodbox";
            this.periodbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.periodbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.periodbox.Properties.Appearance.Options.UseFont = true;
            this.periodbox.Properties.Appearance.Options.UseForeColor = true;
            this.periodbox.Properties.MaxLength = 12;
            this.periodbox.Properties.ReadOnly = true;
            this.periodbox.Size = new System.Drawing.Size(171, 22);
            this.periodbox.TabIndex = 3;
            this.periodbox.TabStop = false;
            this.periodbox.Visible = false;
            // 
            // datebox
            // 
            this.datebox.EditValue = null;
            this.datebox.Location = new System.Drawing.Point(109, 79);
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
            this.datebox.Size = new System.Drawing.Size(171, 22);
            this.datebox.TabIndex = 2;
            this.datebox.EditValueChanged += new System.EventHandler(this.datebox_EditValueChanged);
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(109, 229);
            this.descbox.Name = "descbox";
            this.descbox.Properties.AllowMouseWheel = false;
            this.descbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.descbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.descbox.Properties.Appearance.Options.UseFont = true;
            this.descbox.Properties.Appearance.Options.UseForeColor = true;
            this.descbox.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descbox.Size = new System.Drawing.Size(480, 57);
            this.descbox.TabIndex = 8;
            // 
            // personlkp
            // 
            this.personlkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.personlkp.Location = new System.Drawing.Point(109, 169);
            this.personlkp.Name = "personlkp";
            this.personlkp.Properties.AccessibleDescription = "";
            this.personlkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.personlkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.personlkp.Properties.Appearance.Options.UseFont = true;
            this.personlkp.Properties.Appearance.Options.UseForeColor = true;
            this.personlkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.personlkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.personlkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.personlkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.personlkp.Properties.DropDownRows = 1;
            this.personlkp.Properties.NullText = "";
            this.personlkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.personlkp.Properties.PopupSizeable = false;
            this.personlkp.Properties.PopupWidth = 40;
            this.personlkp.Properties.ShowFooter = false;
            this.personlkp.Properties.ShowHeader = false;
            this.personlkp.Size = new System.Drawing.Size(171, 22);
            this.personlkp.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(12, 297);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 16);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "Document:";
            // 
            // docbox
            // 
            this.docbox.Location = new System.Drawing.Point(109, 294);
            this.docbox.Name = "docbox";
            this.docbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.docbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.docbox.Properties.Appearance.Options.UseFont = true;
            this.docbox.Properties.Appearance.Options.UseForeColor = true;
            this.docbox.Properties.MaxLength = 100;
            this.docbox.Size = new System.Drawing.Size(480, 22);
            this.docbox.TabIndex = 9;
            // 
            // amtbox
            // 
            this.amtbox.Location = new System.Drawing.Point(109, 109);
            this.amtbox.Name = "amtbox";
            this.amtbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.amtbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.amtbox.Properties.Appearance.Options.UseFont = true;
            this.amtbox.Properties.Appearance.Options.UseForeColor = true;
            this.amtbox.Properties.Appearance.Options.UseTextOptions = true;
            this.amtbox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.amtbox.Properties.MaxLength = 12;
            this.amtbox.Size = new System.Drawing.Size(171, 22);
            this.amtbox.TabIndex = 4;
            this.amtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amtbox_KeyPress);
            // 
            // catlkp
            // 
            this.catlkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.catlkp.Location = new System.Drawing.Point(109, 199);
            this.catlkp.Name = "catlkp";
            this.catlkp.Properties.AccessibleDescription = "";
            this.catlkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.catlkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.catlkp.Properties.Appearance.Options.UseFont = true;
            this.catlkp.Properties.Appearance.Options.UseForeColor = true;
            this.catlkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.catlkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.catlkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.catlkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.catlkp.Properties.DropDownRows = 1;
            this.catlkp.Properties.NullText = "";
            this.catlkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.catlkp.Properties.PopupSizeable = false;
            this.catlkp.Properties.PopupWidth = 40;
            this.catlkp.Properties.ShowFooter = false;
            this.catlkp.Properties.ShowHeader = false;
            this.catlkp.Size = new System.Drawing.Size(480, 22);
            this.catlkp.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(12, 202);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 63;
            this.labelControl4.Text = "Category:";
            // 
            // currlbl
            // 
            this.currlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.currlbl.Location = new System.Drawing.Point(287, 112);
            this.currlbl.Name = "currlbl";
            this.currlbl.Size = new System.Drawing.Size(0, 16);
            this.currlbl.TabIndex = 60;
            this.currlbl.TextChanged += new System.EventHandler(this.currlbl_TextChanged);
            // 
            // internalchk
            // 
            this.internalchk.Location = new System.Drawing.Point(287, 51);
            this.internalchk.Name = "internalchk";
            this.internalchk.Properties.Caption = "";
            this.internalchk.Size = new System.Drawing.Size(18, 19);
            this.internalchk.TabIndex = 2;
            this.internalchk.TabStop = false;
            this.internalchk.ToolTip = "Check for bank transfer operation";
            this.internalchk.Visible = false;
            this.internalchk.CheckedChanged += new System.EventHandler(this.internalchk_CheckedChanged);
            // 
            // expacntlbl
            // 
            this.expacntlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expacntlbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.expacntlbl.Location = new System.Drawing.Point(302, 142);
            this.expacntlbl.Name = "expacntlbl";
            this.expacntlbl.Size = new System.Drawing.Size(101, 16);
            this.expacntlbl.TabIndex = 65;
            this.expacntlbl.Text = "Expense Account:";
            // 
            // expacntlkp
            // 
            this.expacntlkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.expacntlkp.Location = new System.Drawing.Point(412, 139);
            this.expacntlkp.Name = "expacntlkp";
            this.expacntlkp.Properties.AccessibleDescription = "";
            this.expacntlkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.expacntlkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.expacntlkp.Properties.Appearance.Options.UseFont = true;
            this.expacntlkp.Properties.Appearance.Options.UseForeColor = true;
            this.expacntlkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.expacntlkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.expacntlkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.expacntlkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.expacntlkp.Properties.DropDownRows = 1;
            this.expacntlkp.Properties.NullText = "";
            this.expacntlkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.expacntlkp.Properties.PopupSizeable = false;
            this.expacntlkp.Properties.PopupWidth = 40;
            this.expacntlkp.Properties.ShowFooter = false;
            this.expacntlkp.Properties.ShowHeader = false;
            this.expacntlkp.Size = new System.Drawing.Size(177, 22);
            this.expacntlkp.TabIndex = 66;
            // 
            // frmCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 375);
            this.Controls.Add(this.expacntlkp);
            this.Controls.Add(this.expacntlbl);
            this.Controls.Add(this.internalchk);
            this.Controls.Add(this.catlkp);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.amtbox);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.currlbl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.periodbox);
            this.Controls.Add(this.typelkp);
            this.Controls.Add(this.personlkp);
            this.Controls.Add(this.acntlkp);
            this.Controls.Add(this.docbox);
            this.Controls.Add(this.orderbox);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.personlbl);
            this.Controls.Add(this.acntlbl);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 418);
            this.MinimumSize = new System.Drawing.Size(626, 418);
            this.Name = "frmCash";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCash_FormClosing);
            this.Load += new System.EventHandler(this.frmCash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acntlkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personlkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catlkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internalchk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expacntlkp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl acntlbl;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.TextEdit orderbox;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit acntlkp;
        private DevExpress.XtraEditors.LabelControl typelbl;
        private DevExpress.XtraEditors.LookUpEdit typelkp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl personlbl;
        private DevExpress.XtraEditors.SimpleButton printbtn;
        private DevExpress.XtraEditors.TextEdit periodbox;
        private DevExpress.XtraEditors.DateEdit datebox;
        private DevExpress.XtraEditors.MemoEdit descbox;
        private DevExpress.XtraEditors.SimpleButton postbtn;
        private DevExpress.XtraEditors.LookUpEdit personlkp;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit docbox;
        private DevExpress.XtraEditors.TextEdit amtbox;
        private DevExpress.XtraEditors.LookUpEdit catlkp;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl currlbl;
        private DevExpress.XtraEditors.CheckEdit internalchk;
        private DevExpress.XtraEditors.LabelControl expacntlbl;
        private DevExpress.XtraEditors.LookUpEdit expacntlkp;
    }
}