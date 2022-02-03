namespace CASHBOOK
{
    partial class frmConversion
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
            this.lblfrom = new DevExpress.XtraEditors.LabelControl();
            this.amtbox = new DevExpress.XtraEditors.TextEdit();
            this.ownbanklkp = new DevExpress.XtraEditors.LookUpEdit();
            this.ownbank2lkp = new DevExpress.XtraEditors.LookUpEdit();
            this.orderbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.typelbl = new DevExpress.XtraEditors.LabelControl();
            this.typelkp = new DevExpress.XtraEditors.LookUpEdit();
            this.lblto = new DevExpress.XtraEditors.LabelControl();
            this.periodbox = new DevExpress.XtraEditors.TextEdit();
            this.datebox = new DevExpress.XtraEditors.DateEdit();
            this.descbox = new DevExpress.XtraEditors.MemoEdit();
            this.validdatebox = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amtbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownbanklkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownbank2lkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validdatebox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validdatebox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.postbtn);
            this.panel.Controls.Add(this.printbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 278);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(606, 37);
            this.panel.TabIndex = 8;
            // 
            // postbtn
            // 
            this.postbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.postbtn.Appearance.Options.UseFont = true;
            this.postbtn.Enabled = false;
            this.postbtn.Location = new System.Drawing.Point(386, 8);
            this.postbtn.Name = "postbtn";
            this.postbtn.Size = new System.Drawing.Size(94, 22);
            this.postbtn.TabIndex = 10;
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
            this.printbtn.TabIndex = 9;
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
            this.savebtn.TabIndex = 8;
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
            this.cancelbtn.TabIndex = 11;
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
            // lblfrom
            // 
            this.lblfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfrom.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblfrom.Location = new System.Drawing.Point(11, 142);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(0, 16);
            this.lblfrom.TabIndex = 56;
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
            // ownbanklkp
            // 
            this.ownbanklkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ownbanklkp.Location = new System.Drawing.Point(109, 139);
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
            this.ownbanklkp.Properties.DropDownRows = 1;
            this.ownbanklkp.Properties.NullText = "";
            this.ownbanklkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.ownbanklkp.Properties.PopupSizeable = false;
            this.ownbanklkp.Properties.PopupWidth = 40;
            this.ownbanklkp.Properties.ShowFooter = false;
            this.ownbanklkp.Properties.ShowHeader = false;
            this.ownbanklkp.Size = new System.Drawing.Size(171, 22);
            this.ownbanklkp.TabIndex = 5;
            this.ownbanklkp.EditValueChanged += new System.EventHandler(this.ownbanklkp_EditValueChanged);
            // 
            // ownbank2lkp
            // 
            this.ownbank2lkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ownbank2lkp.Location = new System.Drawing.Point(109, 169);
            this.ownbank2lkp.Name = "ownbank2lkp";
            this.ownbank2lkp.Properties.AccessibleDescription = "";
            this.ownbank2lkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ownbank2lkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ownbank2lkp.Properties.Appearance.Options.UseFont = true;
            this.ownbank2lkp.Properties.Appearance.Options.UseForeColor = true;
            this.ownbank2lkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ownbank2lkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.ownbank2lkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.ownbank2lkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ownbank2lkp.Properties.DropDownRows = 1;
            this.ownbank2lkp.Properties.NullText = "";
            this.ownbank2lkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.ownbank2lkp.Properties.PopupSizeable = false;
            this.ownbank2lkp.Properties.PopupWidth = 40;
            this.ownbank2lkp.Properties.ShowFooter = false;
            this.ownbank2lkp.Properties.ShowHeader = false;
            this.ownbank2lkp.Size = new System.Drawing.Size(171, 22);
            this.ownbank2lkp.TabIndex = 6;
            // 
            // orderbox
            // 
            this.orderbox.Enabled = false;
            this.orderbox.Location = new System.Drawing.Point(110, 19);
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
            this.labelControl5.Location = new System.Drawing.Point(11, 202);
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
            this.labelControl6.Location = new System.Drawing.Point(11, 22);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 16);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Conversion No:";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl7.Location = new System.Drawing.Point(11, 112);
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
            this.typelbl.Location = new System.Drawing.Point(11, 52);
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
            // lblto
            // 
            this.lblto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblto.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblto.Location = new System.Drawing.Point(11, 172);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(0, 16);
            this.lblto.TabIndex = 56;
            // 
            // periodbox
            // 
            this.periodbox.Enabled = false;
            this.periodbox.Location = new System.Drawing.Point(418, 19);
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
            this.descbox.Location = new System.Drawing.Point(109, 199);
            this.descbox.Name = "descbox";
            this.descbox.Properties.AllowMouseWheel = false;
            this.descbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.descbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.descbox.Properties.Appearance.Options.UseFont = true;
            this.descbox.Properties.Appearance.Options.UseForeColor = true;
            this.descbox.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descbox.Size = new System.Drawing.Size(480, 57);
            this.descbox.TabIndex = 7;
            // 
            // validdatebox
            // 
            this.validdatebox.EditValue = null;
            this.validdatebox.Location = new System.Drawing.Point(418, 79);
            this.validdatebox.Name = "validdatebox";
            this.validdatebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.validdatebox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.validdatebox.Properties.Appearance.Options.UseFont = true;
            this.validdatebox.Properties.Appearance.Options.UseForeColor = true;
            this.validdatebox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.validdatebox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.validdatebox.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.validdatebox.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.validdatebox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.validdatebox.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.validdatebox.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.validdatebox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.validdatebox.Size = new System.Drawing.Size(171, 22);
            this.validdatebox.TabIndex = 3;
            this.validdatebox.EditValueChanged += new System.EventHandler(this.validdatebox_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(342, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 16);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Valid Date:  ";
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 315);
            this.Controls.Add(this.validdatebox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.periodbox);
            this.Controls.Add(this.typelkp);
            this.Controls.Add(this.ownbank2lkp);
            this.Controls.Add(this.ownbanklkp);
            this.Controls.Add(this.orderbox);
            this.Controls.Add(this.amtbox);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lblto);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 358);
            this.MinimumSize = new System.Drawing.Size(626, 358);
            this.Name = "frmConversion";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConversion_FormClosing);
            this.Load += new System.EventHandler(this.frmConversion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amtbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownbanklkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownbank2lkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validdatebox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validdatebox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblfrom;
        private DevExpress.XtraEditors.TextEdit amtbox;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.TextEdit orderbox;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit ownbanklkp;
        private DevExpress.XtraEditors.LookUpEdit ownbank2lkp;
        private DevExpress.XtraEditors.LabelControl typelbl;
        private DevExpress.XtraEditors.LookUpEdit typelkp;
        private DevExpress.XtraEditors.LabelControl lblto;
        private DevExpress.XtraEditors.SimpleButton printbtn;
        private DevExpress.XtraEditors.TextEdit periodbox;
        private DevExpress.XtraEditors.DateEdit datebox;
        private DevExpress.XtraEditors.MemoEdit descbox;
        private DevExpress.XtraEditors.SimpleButton postbtn;
        private DevExpress.XtraEditors.DateEdit validdatebox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}