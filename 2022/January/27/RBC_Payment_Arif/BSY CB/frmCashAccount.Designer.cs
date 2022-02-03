namespace CASHBOOK
{
    partial class frmCashAccount
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
            this.codelbl = new DevExpress.XtraEditors.LabelControl();
            this.codebox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.statuslkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuslkp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 97);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(305, 37);
            this.panel.TabIndex = 4;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(196, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(93, 22);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(87, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(93, 22);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // codelbl
            // 
            this.codelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codelbl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.codelbl.Location = new System.Drawing.Point(11, 15);
            this.codelbl.Name = "codelbl";
            this.codelbl.Size = new System.Drawing.Size(0, 16);
            this.codelbl.TabIndex = 110;
            // 
            // codebox
            // 
            this.codebox.Location = new System.Drawing.Point(108, 15);
            this.codebox.Name = "codebox";
            this.codebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.codebox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.codebox.Properties.Appearance.Options.UseFont = true;
            this.codebox.Properties.Appearance.Options.UseForeColor = true;
            this.codebox.Properties.MaxLength = 15;
            this.codebox.Size = new System.Drawing.Size(181, 22);
            this.codebox.TabIndex = 0;
            // 
            // labelControl14
            // 
            this.labelControl14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl14.Location = new System.Drawing.Point(12, 18);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(83, 16);
            this.labelControl14.TabIndex = 109;
            this.labelControl14.Text = "Account Code:";
            // 
            // statuslkp
            // 
            this.statuslkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statuslkp.Location = new System.Drawing.Point(108, 45);
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
            this.statuslkp.Size = new System.Drawing.Size(181, 22);
            this.statuslkp.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(12, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 16);
            this.labelControl1.TabIndex = 114;
            this.labelControl1.Text = "Status:";
            // 
            // frmCashAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 134);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.statuslkp);
            this.Controls.Add(this.codelbl);
            this.Controls.Add(this.codebox);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 173);
            this.MinimumSize = new System.Drawing.Size(321, 173);
            this.Name = "frmCashAccount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.frmCashAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statuslkp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.LabelControl codelbl;
        private DevExpress.XtraEditors.TextEdit codebox;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        public DevExpress.XtraEditors.LookUpEdit statuslkp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}