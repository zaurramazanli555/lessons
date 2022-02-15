namespace WindowsFormsAppPart4
{
    partial class DynamicFormElements
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
            this.createButtonsBtn = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.createTextBoxesBtn = new System.Windows.Forms.Button();
            this.textboxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // createButtonsBtn
            // 
            this.createButtonsBtn.Location = new System.Drawing.Point(12, 12);
            this.createButtonsBtn.Name = "createButtonsBtn";
            this.createButtonsBtn.Size = new System.Drawing.Size(171, 39);
            this.createButtonsBtn.TabIndex = 0;
            this.createButtonsBtn.Text = "Button\'lar yarat";
            this.createButtonsBtn.UseVisualStyleBackColor = true;
            this.createButtonsBtn.Click += new System.EventHandler(this.createButtonsBtn_Click);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Location = new System.Drawing.Point(12, 57);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(900, 297);
            this.buttonsPanel.TabIndex = 1;
            // 
            // createTextBoxesBtn
            // 
            this.createTextBoxesBtn.Location = new System.Drawing.Point(12, 360);
            this.createTextBoxesBtn.Name = "createTextBoxesBtn";
            this.createTextBoxesBtn.Size = new System.Drawing.Size(171, 39);
            this.createTextBoxesBtn.TabIndex = 0;
            this.createTextBoxesBtn.Text = "TextBox\'lar yarat";
            this.createTextBoxesBtn.UseVisualStyleBackColor = true;
            this.createTextBoxesBtn.Click += new System.EventHandler(this.createTextBoxesBtn_Click);
            // 
            // textboxPanel
            // 
            this.textboxPanel.Location = new System.Drawing.Point(12, 405);
            this.textboxPanel.Name = "textboxPanel";
            this.textboxPanel.Size = new System.Drawing.Size(900, 297);
            this.textboxPanel.TabIndex = 1;
            // 
            // DynamicFormElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 712);
            this.Controls.Add(this.textboxPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.createTextBoxesBtn);
            this.Controls.Add(this.createButtonsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DynamicFormElements";
            this.Text = "Dinamik form elementləri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButtonsBtn;
        private System.Windows.Forms.FlowLayoutPanel buttonsPanel;
        private System.Windows.Forms.Button createTextBoxesBtn;
        private System.Windows.Forms.FlowLayoutPanel textboxPanel;
    }
}