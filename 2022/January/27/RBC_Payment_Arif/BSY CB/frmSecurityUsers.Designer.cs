namespace CASHBOOK
{
    partial class frmSecurityUsers
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
            this.resetpassbtn = new DevExpress.XtraEditors.SimpleButton();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.userbox = new DevExpress.XtraEditors.TextEdit();
            this.accesslkp = new DevExpress.XtraEditors.LookUpEdit();
            this.resetpassbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.usernamebox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grouplkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesslkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetpassbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouplkp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Controls.Add(this.resetpassbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 174);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(581, 37);
            this.panel.TabIndex = 3;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(472, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(93, 22);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // resetpassbtn
            // 
            this.resetpassbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.resetpassbtn.Appearance.Options.UseFont = true;
            this.resetpassbtn.Location = new System.Drawing.Point(230, 8);
            this.resetpassbtn.Name = "resetpassbtn";
            this.resetpassbtn.Size = new System.Drawing.Size(117, 22);
            this.resetpassbtn.TabIndex = 8;
            this.resetpassbtn.Text = "Reset Password";
            this.resetpassbtn.Click += new System.EventHandler(this.resetpassbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(363, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(93, 22);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(369, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Access:    ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(11, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 16);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "User Name:";
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(109, 14);
            this.userbox.Name = "userbox";
            this.userbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.userbox.Properties.Appearance.Options.UseFont = true;
            this.userbox.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userbox.Properties.MaxLength = 3;
            this.userbox.Size = new System.Drawing.Size(200, 22);
            this.userbox.TabIndex = 0;
            this.userbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userbox_KeyPress);
            // 
            // accesslkp
            // 
            this.accesslkp.Location = new System.Drawing.Point(435, 14);
            this.accesslkp.Name = "accesslkp";
            this.accesslkp.Properties.AccessibleDescription = "";
            this.accesslkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.accesslkp.Properties.Appearance.Options.UseFont = true;
            this.accesslkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.accesslkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.accesslkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accesslkp.Properties.DropDownRows = 2;
            this.accesslkp.Properties.NullText = "";
            this.accesslkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.accesslkp.Properties.PopupSizeable = false;
            this.accesslkp.Properties.PopupWidth = 40;
            this.accesslkp.Properties.ShowFooter = false;
            this.accesslkp.Properties.ShowHeader = false;
            this.accesslkp.Size = new System.Drawing.Size(130, 22);
            this.accesslkp.TabIndex = 1;
            // 
            // resetpassbox
            // 
            this.resetpassbox.Location = new System.Drawing.Point(109, 74);
            this.resetpassbox.Name = "resetpassbox";
            this.resetpassbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.resetpassbox.Properties.Appearance.Options.UseFont = true;
            this.resetpassbox.Properties.MaxLength = 15;
            this.resetpassbox.Properties.PasswordChar = '*';
            this.resetpassbox.Size = new System.Drawing.Size(200, 22);
            this.resetpassbox.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl6.Location = new System.Drawing.Point(12, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(89, 16);
            this.labelControl6.TabIndex = 62;
            this.labelControl6.Text = "New Password:";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(109, 44);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.usernamebox.Properties.Appearance.Options.UseFont = true;
            this.usernamebox.Properties.MaxLength = 50;
            this.usernamebox.Size = new System.Drawing.Size(456, 22);
            this.usernamebox.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(12, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 16);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "Full Name:    ";
            // 
            // grouplkp
            // 
            this.grouplkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grouplkp.Location = new System.Drawing.Point(109, 104);
            this.grouplkp.Name = "grouplkp";
            this.grouplkp.Properties.AccessibleDescription = "";
            this.grouplkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.grouplkp.Properties.Appearance.Options.UseFont = true;
            this.grouplkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.grouplkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.grouplkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.grouplkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grouplkp.Properties.DropDownRows = 3;
            this.grouplkp.Properties.NullText = "";
            this.grouplkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.grouplkp.Properties.PopupSizeable = false;
            this.grouplkp.Properties.PopupWidth = 40;
            this.grouplkp.Properties.ShowFooter = false;
            this.grouplkp.Properties.ShowHeader = false;
            this.grouplkp.Size = new System.Drawing.Size(200, 22);
            this.grouplkp.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(11, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "Group Code:";
            // 
            // frmSecurityUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 211);
            this.Controls.Add(this.grouplkp);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.resetpassbox);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.accesslkp);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 250);
            this.MinimumSize = new System.Drawing.Size(597, 250);
            this.Name = "frmSecurityUsers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSecurityUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmSecurityUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesslkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetpassbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouplkp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton resetpassbtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit userbox;
        private DevExpress.XtraEditors.LookUpEdit accesslkp;
        private DevExpress.XtraEditors.TextEdit resetpassbox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit usernamebox;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LookUpEdit grouplkp;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
    }
}