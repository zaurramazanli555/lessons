namespace CASHBOOK
{
    partial class frmDocumentFormat
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.namebox = new DevExpress.XtraEditors.TextEdit();
            this.codebox = new DevExpress.XtraEditors.TextEdit();
            this.typelkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pathbox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codebox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cancelbtn);
            this.panel.Controls.Add(this.savebtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 160);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(569, 37);
            this.panel.TabIndex = 7;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cancelbtn.Appearance.Options.UseFont = true;
            this.cancelbtn.Location = new System.Drawing.Point(460, 8);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(93, 22);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Location = new System.Drawing.Point(351, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(93, 22);
            this.savebtn.TabIndex = 7;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(323, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 16);
            this.labelControl2.TabIndex = 56;
            this.labelControl2.Text = "Type: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl1.Location = new System.Drawing.Point(11, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 16);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Code:";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(11, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 16);
            this.labelControl5.TabIndex = 56;
            this.labelControl5.Text = "Name:    ";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(76, 42);
            this.namebox.Name = "namebox";
            this.namebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.namebox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.namebox.Properties.Appearance.Options.UseFont = true;
            this.namebox.Properties.Appearance.Options.UseForeColor = true;
            this.namebox.Properties.MaxLength = 50;
            this.namebox.Size = new System.Drawing.Size(480, 22);
            this.namebox.TabIndex = 2;
            // 
            // codebox
            // 
            this.codebox.Location = new System.Drawing.Point(76, 12);
            this.codebox.Name = "codebox";
            this.codebox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.codebox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.codebox.Properties.Appearance.Options.UseFont = true;
            this.codebox.Properties.Appearance.Options.UseForeColor = true;
            this.codebox.Properties.MaxLength = 15;
            this.codebox.Size = new System.Drawing.Size(175, 22);
            this.codebox.TabIndex = 0;
            // 
            // typelkp
            // 
            this.typelkp.Location = new System.Drawing.Point(381, 12);
            this.typelkp.Name = "typelkp";
            this.typelkp.Properties.AccessibleDescription = "lookup";
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
            this.typelkp.Size = new System.Drawing.Size(175, 22);
            this.typelkp.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(11, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 16);
            this.labelControl3.TabIndex = 56;
            this.labelControl3.Text = "File path:";
            // 
            // pathbox
            // 
            this.pathbox.Location = new System.Drawing.Point(76, 72);
            this.pathbox.Name = "pathbox";
            this.pathbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.pathbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.pathbox.Properties.Appearance.Options.UseFont = true;
            this.pathbox.Properties.Appearance.Options.UseForeColor = true;
            this.pathbox.Properties.MaxLength = 260;
            this.pathbox.Size = new System.Drawing.Size(480, 22);
            this.pathbox.TabIndex = 3;
            // 
            // frmDocumentFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 197);
            this.Controls.Add(this.typelkp);
            this.Controls.Add(this.codebox);
            this.Controls.Add(this.pathbox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(585, 236);
            this.MinimumSize = new System.Drawing.Size(585, 236);
            this.Name = "frmDocumentFormat";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocumentFormat_FormClosing);
            this.Load += new System.EventHandler(this.frmDocumentFormat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.namebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codebox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typelkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathbox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit namebox;
        private DevExpress.XtraEditors.TextEdit codebox;
        private DevExpress.XtraEditors.LookUpEdit typelkp;
        private DevExpress.XtraEditors.SimpleButton cancelbtn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit pathbox;
    }
}