namespace PaymentApp
{
    partial class frmPayment
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
            this.txtdocno = new System.Windows.Forms.TextBox();
            this.lbldoc = new System.Windows.Forms.Label();
            this.lblInvno = new System.Windows.Forms.Label();
            this.txtInvNo = new System.Windows.Forms.TextBox();
            this.invDate = new System.Windows.Forms.Label();
            this.datetmInvDate = new System.Windows.Forms.DateTimePicker();
            this.datetmDeadline = new System.Windows.Forms.DateTimePicker();
            this.lbldeadline = new System.Windows.Forms.Label();
            this.txtDifDeadAndInvDate = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblCreatorUser = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblInvValyuta = new System.Windows.Forms.Label();
            this.txtInvValyuta = new System.Windows.Forms.TextBox();
            this.lblInvMebleg = new System.Windows.Forms.Label();
            this.txtInvMebleg = new System.Windows.Forms.TextBox();
            this.lblSirket = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.cmbvendor = new System.Windows.Forms.ComboBox();
            this.cmbsirket = new System.Windows.Forms.ComboBox();
            this.cmbdepartament = new System.Windows.Forms.ComboBox();
            this.cmbteyinat = new System.Windows.Forms.ComboBox();
            this.lblDepartament = new System.Windows.Forms.Label();
            this.lblteyinat = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.lblOdenisStatusu = new System.Windows.Forms.Label();
            this.txtOdenisStatusu = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblQeyd = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdocno
            // 
            this.txtdocno.Location = new System.Drawing.Point(119, 24);
            this.txtdocno.Name = "txtdocno";
            this.txtdocno.Size = new System.Drawing.Size(200, 22);
            this.txtdocno.TabIndex = 0;
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.Location = new System.Drawing.Point(38, 27);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(59, 16);
            this.lbldoc.TabIndex = 1;
            this.lbldoc.Text = "Doc No :";
            // 
            // lblInvno
            // 
            this.lblInvno.AutoSize = true;
            this.lblInvno.Location = new System.Drawing.Point(38, 68);
            this.lblInvno.Name = "lblInvno";
            this.lblInvno.Size = new System.Drawing.Size(51, 16);
            this.lblInvno.TabIndex = 3;
            this.lblInvno.Text = "Inv No :";
            // 
            // txtInvNo
            // 
            this.txtInvNo.Location = new System.Drawing.Point(119, 65);
            this.txtInvNo.Name = "txtInvNo";
            this.txtInvNo.Size = new System.Drawing.Size(200, 22);
            this.txtInvNo.TabIndex = 2;
            // 
            // invDate
            // 
            this.invDate.AutoSize = true;
            this.invDate.Location = new System.Drawing.Point(38, 113);
            this.invDate.Name = "invDate";
            this.invDate.Size = new System.Drawing.Size(62, 16);
            this.invDate.TabIndex = 5;
            this.invDate.Text = "Inv Date :";
            // 
            // datetmInvDate
            // 
            this.datetmInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetmInvDate.Location = new System.Drawing.Point(119, 113);
            this.datetmInvDate.Name = "datetmInvDate";
            this.datetmInvDate.Size = new System.Drawing.Size(200, 22);
            this.datetmInvDate.TabIndex = 6;
            this.datetmInvDate.Value = new System.DateTime(2022, 2, 3, 11, 23, 54, 0);
            // 
            // datetmDeadline
            // 
            this.datetmDeadline.Location = new System.Drawing.Point(119, 165);
            this.datetmDeadline.Name = "datetmDeadline";
            this.datetmDeadline.Size = new System.Drawing.Size(200, 22);
            this.datetmDeadline.TabIndex = 8;
            // 
            // lbldeadline
            // 
            this.lbldeadline.AutoSize = true;
            this.lbldeadline.Location = new System.Drawing.Point(38, 165);
            this.lbldeadline.Name = "lbldeadline";
            this.lbldeadline.Size = new System.Drawing.Size(68, 16);
            this.lbldeadline.TabIndex = 7;
            this.lbldeadline.Text = "Deadline :";
            // 
            // txtDifDeadAndInvDate
            // 
            this.txtDifDeadAndInvDate.Location = new System.Drawing.Point(325, 165);
            this.txtDifDeadAndInvDate.Name = "txtDifDeadAndInvDate";
            this.txtDifDeadAndInvDate.Size = new System.Drawing.Size(66, 22);
            this.txtDifDeadAndInvDate.TabIndex = 9;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(38, 212);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(42, 16);
            this.lblNote.TabIndex = 11;
            this.lblNote.Text = "Note :";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(119, 209);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(200, 22);
            this.txtNote.TabIndex = 10;
            // 
            // lblCreatorUser
            // 
            this.lblCreatorUser.AutoSize = true;
            this.lblCreatorUser.Location = new System.Drawing.Point(360, 30);
            this.lblCreatorUser.Name = "lblCreatorUser";
            this.lblCreatorUser.Size = new System.Drawing.Size(89, 16);
            this.lblCreatorUser.TabIndex = 13;
            this.lblCreatorUser.Text = "Creator User :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(467, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 12;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(713, 33);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(95, 16);
            this.lblCreationDate.TabIndex = 15;
            this.lblCreationDate.Text = "Creation Date :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(814, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 14;
            // 
            // lblInvValyuta
            // 
            this.lblInvValyuta.AutoSize = true;
            this.lblInvValyuta.Location = new System.Drawing.Point(360, 71);
            this.lblInvValyuta.Name = "lblInvValyuta";
            this.lblInvValyuta.Size = new System.Drawing.Size(78, 16);
            this.lblInvValyuta.TabIndex = 17;
            this.lblInvValyuta.Text = "Inv Valyuta :";
            // 
            // txtInvValyuta
            // 
            this.txtInvValyuta.Location = new System.Drawing.Point(467, 71);
            this.txtInvValyuta.Name = "txtInvValyuta";
            this.txtInvValyuta.Size = new System.Drawing.Size(209, 22);
            this.txtInvValyuta.TabIndex = 16;
            // 
            // lblInvMebleg
            // 
            this.lblInvMebleg.AutoSize = true;
            this.lblInvMebleg.Location = new System.Drawing.Point(360, 118);
            this.lblInvMebleg.Name = "lblInvMebleg";
            this.lblInvMebleg.Size = new System.Drawing.Size(82, 16);
            this.lblInvMebleg.TabIndex = 19;
            this.lblInvMebleg.Text = "Inv Meblegi :";
            // 
            // txtInvMebleg
            // 
            this.txtInvMebleg.Location = new System.Drawing.Point(467, 118);
            this.txtInvMebleg.Name = "txtInvMebleg";
            this.txtInvMebleg.Size = new System.Drawing.Size(209, 22);
            this.txtInvMebleg.TabIndex = 18;
            // 
            // lblSirket
            // 
            this.lblSirket.AutoSize = true;
            this.lblSirket.Location = new System.Drawing.Point(719, 118);
            this.lblSirket.Name = "lblSirket";
            this.lblSirket.Size = new System.Drawing.Size(47, 16);
            this.lblSirket.TabIndex = 23;
            this.lblSirket.Text = "Sirket :";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(719, 71);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(57, 16);
            this.lblVendor.TabIndex = 21;
            this.lblVendor.Text = "Vendor :";
            // 
            // cmbvendor
            // 
            this.cmbvendor.FormattingEnabled = true;
            this.cmbvendor.Location = new System.Drawing.Point(814, 66);
            this.cmbvendor.Name = "cmbvendor";
            this.cmbvendor.Size = new System.Drawing.Size(121, 24);
            this.cmbvendor.TabIndex = 24;
            // 
            // cmbsirket
            // 
            this.cmbsirket.FormattingEnabled = true;
            this.cmbsirket.Location = new System.Drawing.Point(814, 116);
            this.cmbsirket.Name = "cmbsirket";
            this.cmbsirket.Size = new System.Drawing.Size(121, 24);
            this.cmbsirket.TabIndex = 25;
            // 
            // cmbdepartament
            // 
            this.cmbdepartament.FormattingEnabled = true;
            this.cmbdepartament.Location = new System.Drawing.Point(1062, 110);
            this.cmbdepartament.Name = "cmbdepartament";
            this.cmbdepartament.Size = new System.Drawing.Size(121, 24);
            this.cmbdepartament.TabIndex = 29;
            // 
            // cmbteyinat
            // 
            this.cmbteyinat.FormattingEnabled = true;
            this.cmbteyinat.Location = new System.Drawing.Point(1062, 60);
            this.cmbteyinat.Name = "cmbteyinat";
            this.cmbteyinat.Size = new System.Drawing.Size(121, 24);
            this.cmbteyinat.TabIndex = 28;
            // 
            // lblDepartament
            // 
            this.lblDepartament.AutoSize = true;
            this.lblDepartament.Location = new System.Drawing.Point(967, 112);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(91, 16);
            this.lblDepartament.TabIndex = 27;
            this.lblDepartament.Text = "Departament :";
            // 
            // lblteyinat
            // 
            this.lblteyinat.AutoSize = true;
            this.lblteyinat.Location = new System.Drawing.Point(967, 65);
            this.lblteyinat.Name = "lblteyinat";
            this.lblteyinat.Size = new System.Drawing.Size(52, 16);
            this.lblteyinat.TabIndex = 26;
            this.lblteyinat.Text = "Teyinat";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(1200, 115);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(82, 16);
            this.lblPaymentType.TabIndex = 35;
            this.lblPaymentType.Text = "Inv Meblegi :";
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Location = new System.Drawing.Point(1324, 115);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(180, 22);
            this.txtPaymentType.TabIndex = 34;
            // 
            // lblOdenisStatusu
            // 
            this.lblOdenisStatusu.AutoSize = true;
            this.lblOdenisStatusu.Location = new System.Drawing.Point(1200, 68);
            this.lblOdenisStatusu.Name = "lblOdenisStatusu";
            this.lblOdenisStatusu.Size = new System.Drawing.Size(103, 16);
            this.lblOdenisStatusu.TabIndex = 33;
            this.lblOdenisStatusu.Text = "Odenis Statusu :";
            // 
            // txtOdenisStatusu
            // 
            this.txtOdenisStatusu.Location = new System.Drawing.Point(1324, 68);
            this.txtOdenisStatusu.Name = "txtOdenisStatusu";
            this.txtOdenisStatusu.Size = new System.Drawing.Size(180, 22);
            this.txtOdenisStatusu.TabIndex = 32;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(1200, 27);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(50, 16);
            this.lblstatus.TabIndex = 31;
            this.lblstatus.Text = "Status :";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(1324, 27);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(180, 22);
            this.txtStatus.TabIndex = 30;
            // 
            // lblQeyd
            // 
            this.lblQeyd.AutoSize = true;
            this.lblQeyd.Location = new System.Drawing.Point(464, 215);
            this.lblQeyd.Name = "lblQeyd";
            this.lblQeyd.Size = new System.Drawing.Size(46, 16);
            this.lblQeyd.TabIndex = 37;
            this.lblQeyd.Text = "Qeyd :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(547, 209);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 44);
            this.textBox3.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(60, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 119);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(60, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 119);
            this.panel2.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(968, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 44);
            this.button1.TabIndex = 40;
            this.button1.Text = "Add FIle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1041, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 44);
            this.button2.TabIndex = 41;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1110, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 44);
            this.button3.TabIndex = 42;
            this.button3.Text = "Bax";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblQeyd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.lblOdenisStatusu);
            this.Controls.Add(this.txtOdenisStatusu);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.cmbdepartament);
            this.Controls.Add(this.cmbteyinat);
            this.Controls.Add(this.lblDepartament);
            this.Controls.Add(this.lblteyinat);
            this.Controls.Add(this.cmbsirket);
            this.Controls.Add(this.cmbvendor);
            this.Controls.Add(this.lblSirket);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblInvMebleg);
            this.Controls.Add(this.txtInvMebleg);
            this.Controls.Add(this.lblInvValyuta);
            this.Controls.Add(this.txtInvValyuta);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCreatorUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtDifDeadAndInvDate);
            this.Controls.Add(this.datetmDeadline);
            this.Controls.Add(this.lbldeadline);
            this.Controls.Add(this.datetmInvDate);
            this.Controls.Add(this.invDate);
            this.Controls.Add(this.lblInvno);
            this.Controls.Add(this.txtInvNo);
            this.Controls.Add(this.lbldoc);
            this.Controls.Add(this.txtdocno);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdocno;
        private System.Windows.Forms.Label lbldoc;
        private System.Windows.Forms.Label lblInvno;
        private System.Windows.Forms.TextBox txtInvNo;
        private System.Windows.Forms.Label invDate;
        private System.Windows.Forms.DateTimePicker datetmInvDate;
        private System.Windows.Forms.DateTimePicker datetmDeadline;
        private System.Windows.Forms.Label lbldeadline;
        private System.Windows.Forms.TextBox txtDifDeadAndInvDate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblCreatorUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInvValyuta;
        private System.Windows.Forms.TextBox txtInvValyuta;
        private System.Windows.Forms.Label lblInvMebleg;
        private System.Windows.Forms.TextBox txtInvMebleg;
        private System.Windows.Forms.Label lblSirket;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.ComboBox cmbvendor;
        private System.Windows.Forms.ComboBox cmbsirket;
        private System.Windows.Forms.ComboBox cmbdepartament;
        private System.Windows.Forms.ComboBox cmbteyinat;
        private System.Windows.Forms.Label lblDepartament;
        private System.Windows.Forms.Label lblteyinat;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.Label lblOdenisStatusu;
        private System.Windows.Forms.TextBox txtOdenisStatusu;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblQeyd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}