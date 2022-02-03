namespace CASHBOOK
{
    partial class frmPassword
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
            this.userbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.oldpassbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.newpassbox = new DevExpress.XtraEditors.TextEdit();
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.userbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldpassbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newpassbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(105, 14);
            this.userbox.Name = "userbox";
            this.userbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.userbox.Properties.Appearance.Options.UseFont = true;
            this.userbox.Properties.MaxLength = 15;
            this.userbox.Properties.ReadOnly = true;
            this.userbox.Size = new System.Drawing.Size(166, 22);
            this.userbox.TabIndex = 0;
            this.userbox.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl8.Location = new System.Drawing.Point(11, 17);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 16);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "User Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(11, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 16);
            this.labelControl1.TabIndex = 65;
            this.labelControl1.Text = "Old password:";
            // 
            // oldpassbox
            // 
            this.oldpassbox.Location = new System.Drawing.Point(105, 44);
            this.oldpassbox.Name = "oldpassbox";
            this.oldpassbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.oldpassbox.Properties.Appearance.Options.UseFont = true;
            this.oldpassbox.Properties.MaxLength = 15;
            this.oldpassbox.Properties.PasswordChar = '*';
            this.oldpassbox.Size = new System.Drawing.Size(166, 22);
            this.oldpassbox.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(11, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 16);
            this.labelControl2.TabIndex = 65;
            this.labelControl2.Text = "New password:";
            // 
            // newpassbox
            // 
            this.newpassbox.Location = new System.Drawing.Point(105, 74);
            this.newpassbox.Name = "newpassbox";
            this.newpassbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.newpassbox.Properties.Appearance.Options.UseFont = true;
            this.newpassbox.Properties.MaxLength = 15;
            this.newpassbox.Properties.PasswordChar = '*';
            this.newpassbox.Size = new System.Drawing.Size(166, 22);
            this.newpassbox.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 117);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(284, 37);
            this.panel.TabIndex = 66;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(152, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(119, 22);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Exit";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(11, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(116, 22);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Change";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.newpassbox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.oldpassbox);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.labelControl8);
            this.MaximizeBox = false;
            this.Name = "frmPassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPassword_FormClosing);
            this.Load += new System.EventHandler(this.frmPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldpassbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newpassbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit userbox;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit oldpassbox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit newpassbox;
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.SimpleButton savebtn;
    }
}