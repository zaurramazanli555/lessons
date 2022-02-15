namespace WindowsFormsAppPart4
{
    partial class VerifyPersonData
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
            this.docNumberDisabled = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.docSerialDisabled = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameDisabled = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameDisabled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitFormBtn = new System.Windows.Forms.Button();
            this.cancelFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // docNumberDisabled
            // 
            this.docNumberDisabled.Location = new System.Drawing.Point(104, 90);
            this.docNumberDisabled.Name = "docNumberDisabled";
            this.docNumberDisabled.ReadOnly = true;
            this.docNumberDisabled.Size = new System.Drawing.Size(155, 20);
            this.docNumberDisabled.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vəsiqənin Nömrəsi";
            // 
            // docSerialDisabled
            // 
            this.docSerialDisabled.Location = new System.Drawing.Point(104, 64);
            this.docSerialDisabled.Name = "docSerialDisabled";
            this.docSerialDisabled.ReadOnly = true;
            this.docSerialDisabled.Size = new System.Drawing.Size(155, 20);
            this.docSerialDisabled.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vəsiqənin Seriyası";
            // 
            // surnameDisabled
            // 
            this.surnameDisabled.Location = new System.Drawing.Point(104, 38);
            this.surnameDisabled.Name = "surnameDisabled";
            this.surnameDisabled.ReadOnly = true;
            this.surnameDisabled.Size = new System.Drawing.Size(155, 20);
            this.surnameDisabled.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // nameDisabled
            // 
            this.nameDisabled.Location = new System.Drawing.Point(104, 12);
            this.nameDisabled.Name = "nameDisabled";
            this.nameDisabled.ReadOnly = true;
            this.nameDisabled.Size = new System.Drawing.Size(155, 20);
            this.nameDisabled.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            // 
            // submitFormBtn
            // 
            this.submitFormBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitFormBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.submitFormBtn.Location = new System.Drawing.Point(104, 116);
            this.submitFormBtn.Name = "submitFormBtn";
            this.submitFormBtn.Size = new System.Drawing.Size(155, 38);
            this.submitFormBtn.TabIndex = 4;
            this.submitFormBtn.Text = "Təsdiqlə";
            this.submitFormBtn.UseVisualStyleBackColor = false;
            this.submitFormBtn.Click += new System.EventHandler(this.submitFormBtn_Click);
            // 
            // cancelFormBtn
            // 
            this.cancelFormBtn.BackColor = System.Drawing.Color.DarkGray;
            this.cancelFormBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelFormBtn.Location = new System.Drawing.Point(104, 160);
            this.cancelFormBtn.Name = "cancelFormBtn";
            this.cancelFormBtn.Size = new System.Drawing.Size(155, 38);
            this.cancelFormBtn.TabIndex = 4;
            this.cancelFormBtn.Text = "İmtina";
            this.cancelFormBtn.UseVisualStyleBackColor = false;
            this.cancelFormBtn.Click += new System.EventHandler(this.cancelFormBtn_Click);
            // 
            // VerifyPersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.cancelFormBtn);
            this.Controls.Add(this.submitFormBtn);
            this.Controls.Add(this.docNumberDisabled);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.docSerialDisabled);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameDisabled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameDisabled);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VerifyPersonData";
            this.Text = "Məlumatlarıı Təsdiqləmə";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox docNumberDisabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox docSerialDisabled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameDisabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameDisabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitFormBtn;
        private System.Windows.Forms.Button cancelFormBtn;
    }
}