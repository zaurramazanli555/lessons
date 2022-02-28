namespace EmployeeManagementSystem
{
    partial class Employees
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
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeJobDetails = new System.Windows.Forms.RichTextBox();
            this.uploadCvBtn = new System.Windows.Forms.Button();
            this.uploadImageBtn = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.CheckBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.employeeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.employeeSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.employeesDataGridView.MultiSelect = false;
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(1001, 603);
            this.employeesDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeJobDetails);
            this.groupBox1.Controls.Add(this.uploadCvBtn);
            this.groupBox1.Controls.Add(this.uploadImageBtn);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.employeeBirthDate);
            this.groupBox1.Controls.Add(this.employeeSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.employeeName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1007, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // employeeJobDetails
            // 
            this.employeeJobDetails.Location = new System.Drawing.Point(91, 208);
            this.employeeJobDetails.Name = "employeeJobDetails";
            this.employeeJobDetails.Size = new System.Drawing.Size(289, 167);
            this.employeeJobDetails.TabIndex = 7;
            this.employeeJobDetails.Text = "";
            // 
            // uploadCvBtn
            // 
            this.uploadCvBtn.Location = new System.Drawing.Point(91, 165);
            this.uploadCvBtn.Name = "uploadCvBtn";
            this.uploadCvBtn.Size = new System.Drawing.Size(255, 37);
            this.uploadCvBtn.TabIndex = 6;
            this.uploadCvBtn.Text = "Upload CV";
            this.uploadCvBtn.UseVisualStyleBackColor = true;
            this.uploadCvBtn.Click += new System.EventHandler(this.uploadCvBtn_Click);
            // 
            // uploadImageBtn
            // 
            this.uploadImageBtn.Location = new System.Drawing.Point(91, 122);
            this.uploadImageBtn.Name = "uploadImageBtn";
            this.uploadImageBtn.Size = new System.Drawing.Size(255, 37);
            this.uploadImageBtn.TabIndex = 5;
            this.uploadImageBtn.Text = "Upload Image";
            this.uploadImageBtn.UseVisualStyleBackColor = true;
            this.uploadImageBtn.Click += new System.EventHandler(this.uploadImageBtn_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(151, 99);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(60, 17);
            this.female.TabIndex = 4;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(91, 99);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 17);
            this.male.TabIndex = 4;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Job Dtls.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // employeeBirthDate
            // 
            this.employeeBirthDate.Location = new System.Drawing.Point(91, 73);
            this.employeeBirthDate.Name = "employeeBirthDate";
            this.employeeBirthDate.Size = new System.Drawing.Size(255, 20);
            this.employeeBirthDate.TabIndex = 2;
            // 
            // employeeSurname
            // 
            this.employeeSurname.Location = new System.Drawing.Point(91, 47);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(255, 20);
            this.employeeSurname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // employeeName
            // 
            this.employeeName.Location = new System.Drawing.Point(91, 21);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(255, 20);
            this.employeeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.addEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployeeBtn.Location = new System.Drawing.Point(1007, 401);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(380, 38);
            this.addEmployeeBtn.TabIndex = 8;
            this.addEmployeeBtn.Text = "Add";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.BackColor = System.Drawing.Color.Red;
            this.removeEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployeeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeEmployeeBtn.Location = new System.Drawing.Point(0, 609);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(238, 45);
            this.removeEmployeeBtn.TabIndex = 2;
            this.removeEmployeeBtn.Text = "Delete Selected Employee";
            this.removeEmployeeBtn.UseVisualStyleBackColor = false;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 685);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.removeEmployeeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "Employees";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker employeeBirthDate;
        private System.Windows.Forms.TextBox employeeSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox employeeJobDetails;
        private System.Windows.Forms.Button uploadCvBtn;
        private System.Windows.Forms.Button uploadImageBtn;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button removeEmployeeBtn;
    }
}

