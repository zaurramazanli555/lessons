namespace CASHBOOK
{
    partial class frmLocalBankDetails
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
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.corrbox = new DevExpress.XtraEditors.TextEdit();
            this.bankbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.swiftbox = new DevExpress.XtraEditors.TextEdit();
            this.banktaxbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.statuslkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corrbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banktaxbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuslkp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 174);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(604, 37);
            this.panel.TabIndex = 5;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(495, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(93, 22);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(386, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(93, 22);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl15.Location = new System.Drawing.Point(11, 15);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(69, 16);
            this.labelControl15.TabIndex = 110;
            this.labelControl15.Text = "Bank Name:";
            // 
            // corrbox
            // 
            this.corrbox.Location = new System.Drawing.Point(88, 72);
            this.corrbox.Name = "corrbox";
            this.corrbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.corrbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.corrbox.Properties.Appearance.Options.UseFont = true;
            this.corrbox.Properties.Appearance.Options.UseForeColor = true;
            this.corrbox.Properties.MaxLength = 100;
            this.corrbox.Size = new System.Drawing.Size(500, 22);
            this.corrbox.TabIndex = 2;
            // 
            // bankbox
            // 
            this.bankbox.Location = new System.Drawing.Point(88, 12);
            this.bankbox.Name = "bankbox";
            this.bankbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.bankbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.bankbox.Properties.Appearance.Options.UseFont = true;
            this.bankbox.Properties.Appearance.Options.UseForeColor = true;
            this.bankbox.Properties.MaxLength = 100;
            this.bankbox.Size = new System.Drawing.Size(500, 22);
            this.bankbox.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl10.Location = new System.Drawing.Point(12, 75);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(58, 16);
            this.labelControl10.TabIndex = 106;
            this.labelControl10.Text = "Corr. Acc:";
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl14.Location = new System.Drawing.Point(12, 45);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(42, 16);
            this.labelControl14.TabIndex = 109;
            this.labelControl14.Text = "Tax ID:";
            // 
            // swiftbox
            // 
            this.swiftbox.Location = new System.Drawing.Point(88, 102);
            this.swiftbox.Name = "swiftbox";
            this.swiftbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.swiftbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.swiftbox.Properties.Appearance.Options.UseFont = true;
            this.swiftbox.Properties.Appearance.Options.UseForeColor = true;
            this.swiftbox.Properties.MaxLength = 30;
            this.swiftbox.Size = new System.Drawing.Size(220, 22);
            this.swiftbox.TabIndex = 3;
            // 
            // banktaxbox
            // 
            this.banktaxbox.Location = new System.Drawing.Point(88, 42);
            this.banktaxbox.Name = "banktaxbox";
            this.banktaxbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.banktaxbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.banktaxbox.Properties.Appearance.Options.UseFont = true;
            this.banktaxbox.Properties.Appearance.Options.UseForeColor = true;
            this.banktaxbox.Properties.MaxLength = 50;
            this.banktaxbox.Size = new System.Drawing.Size(220, 22);
            this.banktaxbox.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl11.Location = new System.Drawing.Point(11, 105);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(44, 16);
            this.labelControl11.TabIndex = 107;
            this.labelControl11.Text = "SWIFT:";
            // 
            // statuslkp
            // 
            this.statuslkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statuslkp.Location = new System.Drawing.Point(88, 132);
            this.statuslkp.Name = "statuslkp";
            this.statuslkp.Properties.AccessibleDescription = "";
            this.statuslkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.statuslkp.Properties.Appearance.Options.UseFont = true;
            this.statuslkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.statuslkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.statuslkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.statuslkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statuslkp.Properties.DropDownRows = 3;
            this.statuslkp.Properties.NullText = "";
            this.statuslkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.statuslkp.Properties.PopupSizeable = false;
            this.statuslkp.Properties.PopupWidth = 40;
            this.statuslkp.Properties.ShowFooter = false;
            this.statuslkp.Properties.ShowHeader = false;
            this.statuslkp.Size = new System.Drawing.Size(130, 22);
            this.statuslkp.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(11, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 16);
            this.labelControl2.TabIndex = 112;
            this.labelControl2.Text = "Status:";
            // 
            // frmLocalBankDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 211);
            this.Controls.Add(this.statuslkp);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.corrbox);
            this.Controls.Add(this.bankbox);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.swiftbox);
            this.Controls.Add(this.banktaxbox);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 250);
            this.MinimumSize = new System.Drawing.Size(620, 250);
            this.Name = "frmLocalBankDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.corrbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banktaxbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuslkp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit corrbox;
        private DevExpress.XtraEditors.TextEdit bankbox;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit swiftbox;
        private DevExpress.XtraEditors.TextEdit banktaxbox;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        public DevExpress.XtraEditors.LookUpEdit statuslkp;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}