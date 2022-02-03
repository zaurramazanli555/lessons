namespace CASHBOOK
{
    partial class frmPrintDesigner
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.amendbtn = new DevExpress.XtraEditors.SimpleButton();
            this.replkp = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.replkp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(12, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Printing Form: ";
            // 
            // amendbtn
            // 
            this.amendbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.amendbtn.Appearance.Options.UseFont = true;
            this.amendbtn.Enabled = false;
            this.amendbtn.Location = new System.Drawing.Point(205, 50);
            this.amendbtn.Name = "amendbtn";
            this.amendbtn.Size = new System.Drawing.Size(133, 22);
            this.amendbtn.TabIndex = 1;
            this.amendbtn.Text = "Design";
            this.amendbtn.Click += new System.EventHandler(this.amendbtn_Click);
            // 
            // replkp
            // 
            this.replkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.replkp.Location = new System.Drawing.Point(108, 15);
            this.replkp.Name = "replkp";
            this.replkp.Properties.AccessibleDescription = "";
            this.replkp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.replkp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.replkp.Properties.Appearance.Options.UseFont = true;
            this.replkp.Properties.Appearance.Options.UseForeColor = true;
            this.replkp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.replkp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.replkp.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.replkp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replkp.Properties.DropDownRows = 3;
            this.replkp.Properties.NullText = "";
            this.replkp.Properties.PopupFormMinSize = new System.Drawing.Size(40, 0);
            this.replkp.Properties.PopupSizeable = false;
            this.replkp.Properties.PopupWidth = 40;
            this.replkp.Properties.ShowFooter = false;
            this.replkp.Properties.ShowHeader = false;
            this.replkp.Size = new System.Drawing.Size(230, 22);
            this.replkp.TabIndex = 0;
            // 
            // frmPrintDesigner
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 86);
            this.Controls.Add(this.replkp);
            this.Controls.Add(this.amendbtn);
            this.Controls.Add(this.labelControl2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 125);
            this.MinimumSize = new System.Drawing.Size(370, 125);
            this.Name = "frmPrintDesigner";
            this.ShowIcon = false;
            this.Text = "Printing Forms Designer";
            this.Load += new System.EventHandler(this.frmPrintDesigner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.replkp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton amendbtn;
        private DevExpress.XtraEditors.LookUpEdit replkp;
    }
}