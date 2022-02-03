namespace CASHBOOK
{
    partial class frmReferenceNumber
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
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.amendbtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.operationlkp = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.amtbox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.operationlkp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.savebtn.Appearance.Options.UseFont = true;
            this.savebtn.Enabled = false;
            this.savebtn.Location = new System.Drawing.Point(222, 82);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(100, 22);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // amendbtn
            // 
            this.amendbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.amendbtn.Appearance.Options.UseFont = true;
            this.amendbtn.Enabled = false;
            this.amendbtn.Location = new System.Drawing.Point(111, 82);
            this.amendbtn.Name = "amendbtn";
            this.amendbtn.Size = new System.Drawing.Size(100, 22);
            this.amendbtn.TabIndex = 2;
            this.amendbtn.Text = "Change";
            this.amendbtn.Click += new System.EventHandler(this.amendbtn_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl8.Location = new System.Drawing.Point(10, 47);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 16);
            this.labelControl8.TabIndex = 63;
            this.labelControl8.Text = "Next Number:";
            // 
            // operationlkp
            // 
            this.operationlkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.operationlkp.Location = new System.Drawing.Point(111, 14);
            this.operationlkp.Name = "operationlkp";
            this.operationlkp.Properties.AccessibleDescription = "";
            this.operationlkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.operationlkp.Properties.Appearance.Options.UseFont = true;
            this.operationlkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.operationlkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.operationlkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.operationlkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.operationlkp.Properties.DropDownRows = 3;
            this.operationlkp.Properties.NullText = "";
            this.operationlkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.operationlkp.Properties.PopupSizeable = false;
            this.operationlkp.Properties.PopupWidth = 40;
            this.operationlkp.Properties.ShowFooter = false;
            this.operationlkp.Properties.ShowHeader = false;
            this.operationlkp.Size = new System.Drawing.Size(211, 22);
            this.operationlkp.TabIndex = 0;
            this.operationlkp.EditValueChanged += new System.EventHandler(this.operationlkp_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl9.Location = new System.Drawing.Point(10, 17);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(93, 16);
            this.labelControl9.TabIndex = 63;
            this.labelControl9.Text = "Operation Type:";
            // 
            // amtbox
            // 
            this.amtbox.Location = new System.Drawing.Point(111, 44);
            this.amtbox.Name = "amtbox";
            this.amtbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.amtbox.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.amtbox.Properties.Appearance.Options.UseFont = true;
            this.amtbox.Properties.Appearance.Options.UseForeColor = true;
            this.amtbox.Properties.MaxLength = 12;
            this.amtbox.Properties.ReadOnly = true;
            this.amtbox.Size = new System.Drawing.Size(211, 22);
            this.amtbox.TabIndex = 1;
            this.amtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amtbox_KeyPress);
            // 
            // frmReferenceNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 113);
            this.Controls.Add(this.amtbox);
            this.Controls.Add(this.operationlkp);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.amendbtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 152);
            this.MinimumSize = new System.Drawing.Size(350, 152);
            this.Name = "frmReferenceNumber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Next Reference Number";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReferenceNumber_FormClosing);
            this.Load += new System.EventHandler(this.frmReferenceNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operationlkp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amtbox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.SimpleButton amendbtn;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        public DevExpress.XtraEditors.LookUpEdit operationlkp;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit amtbox;
    }
}