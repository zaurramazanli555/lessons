namespace AppPayment
{
    partial class frmCreateAnalitika
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
            this.txtanalitikakod = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblanalitikadesc = new System.Windows.Forms.Label();
            this.lblanalitikaname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtanalitikakod
            // 
            this.txtanalitikakod.Location = new System.Drawing.Point(109, 12);
            this.txtanalitikakod.Name = "txtanalitikakod";
            this.txtanalitikakod.Size = new System.Drawing.Size(196, 22);
            this.txtanalitikakod.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(131, 157);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 30);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(109, 62);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // lblanalitikadesc
            // 
            this.lblanalitikadesc.AutoSize = true;
            this.lblanalitikadesc.Location = new System.Drawing.Point(12, 59);
            this.lblanalitikadesc.Name = "lblanalitikadesc";
            this.lblanalitikadesc.Size = new System.Drawing.Size(45, 16);
            this.lblanalitikadesc.TabIndex = 15;
            this.lblanalitikadesc.Text = "Desc :";
            // 
            // lblanalitikaname
            // 
            this.lblanalitikaname.AutoSize = true;
            this.lblanalitikaname.Location = new System.Drawing.Point(12, 18);
            this.lblanalitikaname.Name = "lblanalitikaname";
            this.lblanalitikaname.Size = new System.Drawing.Size(50, 16);
            this.lblanalitikaname.TabIndex = 14;
            this.lblanalitikaname.Text = "Name :";
            // 
            // frmCreateAnalitika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblanalitikadesc);
            this.Controls.Add(this.lblanalitikaname);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtanalitikakod);
            this.Name = "frmCreateAnalitika";
            this.Text = "frmCreateAnalitika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtanalitikakod;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblanalitikadesc;
        private System.Windows.Forms.Label lblanalitikaname;
    }
}