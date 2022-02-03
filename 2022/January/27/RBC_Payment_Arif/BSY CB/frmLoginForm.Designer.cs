namespace CASHBOOK
{
    partial class frmLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginForm));
            this.passbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.loginbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.loginbtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.passbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(81, 45);
            this.passbox.Name = "passbox";
            this.passbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.passbox.Properties.Appearance.Options.UseFont = true;
            this.passbox.Properties.MaxLength = 15;
            this.passbox.Properties.PasswordChar = '*';
            this.passbox.Size = new System.Drawing.Size(191, 22);
            this.passbox.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(8, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 16);
            this.labelControl2.TabIndex = 112;
            this.labelControl2.Text = "Password:";
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(81, 14);
            this.loginbox.Name = "loginbox";
            this.loginbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.loginbox.Properties.Appearance.Options.UseFont = true;
            this.loginbox.Properties.MaxLength = 15;
            this.loginbox.Size = new System.Drawing.Size(191, 22);
            this.loginbox.TabIndex = 0;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl17.Location = new System.Drawing.Point(8, 15);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(68, 16);
            this.labelControl17.TabIndex = 111;
            this.labelControl17.Text = "User Name:";
            // 
            // loginbtn
            // 
            this.loginbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.loginbtn.Appearance.Options.UseFont = true;
            this.loginbtn.Image = ((System.Drawing.Image)(resources.GetObject("loginbtn.Image")));
            this.loginbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.loginbtn.Location = new System.Drawing.Point(81, 82);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(90, 23);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "Log On";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelbtn.Image")));
            this.cancelbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.cancelbtn.Location = new System.Drawing.Point(182, 82);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(90, 23);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.labelControl17);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 152);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 152);
            this.Name = "frmLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashBook";
            this.Load += new System.EventHandler(this.frmLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginbox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton loginbtn;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.TextEdit passbox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit loginbox;
        private DevExpress.XtraEditors.LabelControl labelControl17;
    }
}