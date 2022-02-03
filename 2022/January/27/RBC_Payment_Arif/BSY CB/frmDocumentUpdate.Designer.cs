namespace CASHBOOK
{
    partial class frmDocumentUpdate
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
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            this.openbtn = new DevExpress.XtraEditors.SimpleButton();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.typelkp = new DevExpress.XtraEditors.LookUpEdit();
            this.print1box = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.docbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.datebox = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.periodbox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.print1box.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Controls.Add(this.openbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 196);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(701, 37);
            this.panel.TabIndex = 5;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(587, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(100, 22);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Exit";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // openbtn
            // 
            this.openbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.openbtn.Appearance.Options.UseFont = true;
            this.openbtn.Location = new System.Drawing.Point(365, 8);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(100, 22);
            this.openbtn.TabIndex = 5;
            this.openbtn.Text = "Open";
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(476, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(100, 22);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "Update";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(420, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 16);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Document Type:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(10, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 16);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Document:";
            // 
            // typelkp
            // 
            this.typelkp.Location = new System.Drawing.Point(529, 14);
            this.typelkp.Name = "typelkp";
            this.typelkp.Properties.AccessibleDescription = "";
            this.typelkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.typelkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.typelkp.Properties.Appearance.Options.UseFont = true;
            this.typelkp.Properties.Appearance.Options.UseForeColor = true;
            this.typelkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.typelkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.typelkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typelkp.Properties.DropDownRows = 3;
            this.typelkp.Properties.NullText = "";
            this.typelkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.typelkp.Properties.PopupSizeable = false;
            this.typelkp.Properties.PopupWidth = 40;
            this.typelkp.Properties.ShowFooter = false;
            this.typelkp.Properties.ShowHeader = false;
            this.typelkp.Size = new System.Drawing.Size(158, 22);
            this.typelkp.TabIndex = 1;
            // 
            // print1box
            // 
            this.print1box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.print1box.Location = new System.Drawing.Point(103, 104);
            this.print1box.Name = "print1box";
            this.print1box.Properties.AllowMouseWheel = false;
            this.print1box.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.print1box.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.print1box.Properties.Appearance.Options.UseFont = true;
            this.print1box.Properties.Appearance.Options.UseForeColor = true;
            this.print1box.Properties.MaxLength = 1000;
            this.print1box.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.print1box.Size = new System.Drawing.Size(584, 70);
            this.print1box.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(10, 107);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 16);
            this.labelControl5.TabIndex = 70;
            this.labelControl5.Text = "Description:";
            this.labelControl5.ToolTip = "D1";
            // 
            // docbox
            // 
            this.docbox.Enabled = false;
            this.docbox.Location = new System.Drawing.Point(103, 14);
            this.docbox.Name = "docbox";
            this.docbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.docbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.docbox.Properties.Appearance.Options.UseFont = true;
            this.docbox.Properties.Appearance.Options.UseForeColor = true;
            this.docbox.Properties.MaxLength = 15;
            this.docbox.Properties.ReadOnly = true;
            this.docbox.Size = new System.Drawing.Size(165, 22);
            this.docbox.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(10, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 75;
            this.labelControl3.Text = "Date:";
            // 
            // datebox
            // 
            this.datebox.EditValue = null;
            this.datebox.Location = new System.Drawing.Point(103, 44);
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
            this.datebox.Size = new System.Drawing.Size(165, 22);
            this.datebox.TabIndex = 2;
            this.datebox.EditValueChanged += new System.EventHandler(this.datebox_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(10, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 16);
            this.labelControl4.TabIndex = 74;
            this.labelControl4.Text = "Period:";
            // 
            // periodbox
            // 
            this.periodbox.Enabled = false;
            this.periodbox.Location = new System.Drawing.Point(103, 74);
            this.periodbox.Name = "periodbox";
            this.periodbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.periodbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.periodbox.Properties.Appearance.Options.UseFont = true;
            this.periodbox.Properties.Appearance.Options.UseForeColor = true;
            this.periodbox.Properties.MaxLength = 12;
            this.periodbox.Properties.ReadOnly = true;
            this.periodbox.Size = new System.Drawing.Size(165, 22);
            this.periodbox.TabIndex = 3;
            // 
            // frmDocumentUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 233);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.datebox);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.periodbox);
            this.Controls.Add(this.docbox);
            this.Controls.Add(this.print1box);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.typelkp);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(717, 272);
            this.MinimumSize = new System.Drawing.Size(717, 272);
            this.Name = "frmDocumentUpdate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocumentUpdate_FormClosing);
            this.Load += new System.EventHandler(this.frmDocumentUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.print1box.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodbox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton openbtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit typelkp;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.MemoEdit print1box;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit docbox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit datebox;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit periodbox;
    }
}