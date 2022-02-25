namespace WindowsFormsAppPart6
{
    partial class CustomerInfoPupup
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.customerInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.closeBtn.Location = new System.Drawing.Point(753, -1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 45);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // customerInfo
            // 
            this.customerInfo.Controls.Add(this.txtAddress);
            this.customerInfo.Controls.Add(this.label8);
            this.customerInfo.Controls.Add(this.txtCity);
            this.customerInfo.Controls.Add(this.label7);
            this.customerInfo.Controls.Add(this.txtCountry);
            this.customerInfo.Controls.Add(this.label6);
            this.customerInfo.Controls.Add(this.txtPhone);
            this.customerInfo.Controls.Add(this.label5);
            this.customerInfo.Controls.Add(this.txtEmail);
            this.customerInfo.Controls.Add(this.label4);
            this.customerInfo.Controls.Add(this.txtSurname);
            this.customerInfo.Controls.Add(this.label3);
            this.customerInfo.Controls.Add(this.txtId);
            this.customerInfo.Controls.Add(this.txtName);
            this.customerInfo.Controls.Add(this.label2);
            this.customerInfo.Controls.Add(this.label9);
            this.customerInfo.Controls.Add(this.label1);
            this.customerInfo.Location = new System.Drawing.Point(12, 12);
            this.customerInfo.Name = "customerInfo";
            this.customerInfo.Size = new System.Drawing.Size(350, 387);
            this.customerInfo.TabIndex = 2;
            this.customerInfo.TabStop = false;
            this.customerInfo.Text = "Müştəri məlumatları";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(53, 214);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(0, 13);
            this.txtAddress.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ünvan";
            // 
            // txtCity
            // 
            this.txtCity.AutoSize = true;
            this.txtCity.Location = new System.Drawing.Point(53, 186);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(0, 13);
            this.txtCity.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şəhər";
            // 
            // txtCountry
            // 
            this.txtCountry.AutoSize = true;
            this.txtCountry.Location = new System.Drawing.Point(53, 158);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(0, 13);
            this.txtCountry.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ölkə";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(53, 132);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(0, 13);
            this.txtPhone.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(53, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(0, 13);
            this.txtEmail.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // txtSurname
            // 
            this.txtSurname.AutoSize = true;
            this.txtSurname.Location = new System.Drawing.Point(53, 79);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(0, 13);
            this.txtSurname.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(53, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 13);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(53, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 13);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // CustomerInfoPupup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerInfo);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerInfoPupup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müştəri haqqında məlumat";
            this.Load += new System.EventHandler(this.CustomerInfoPupup_Load);
            this.customerInfo.ResumeLayout(false);
            this.customerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox customerInfo;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}