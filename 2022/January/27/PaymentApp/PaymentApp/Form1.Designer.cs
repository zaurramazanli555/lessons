namespace PaymentApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analitikalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sirketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teyinatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentsToolStripMenuItem,
            this.analitikalarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // analitikalarToolStripMenuItem
            // 
            this.analitikalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorToolStripMenuItem,
            this.sirketToolStripMenuItem,
            this.teyinatToolStripMenuItem,
            this.departamentToolStripMenuItem});
            this.analitikalarToolStripMenuItem.Name = "analitikalarToolStripMenuItem";
            this.analitikalarToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.analitikalarToolStripMenuItem.Text = "Analitikalar";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vendorToolStripMenuItem.Text = "Vendor";
            // 
            // sirketToolStripMenuItem
            // 
            this.sirketToolStripMenuItem.Name = "sirketToolStripMenuItem";
            this.sirketToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sirketToolStripMenuItem.Text = "Sirket";
            // 
            // teyinatToolStripMenuItem
            // 
            this.teyinatToolStripMenuItem.Name = "teyinatToolStripMenuItem";
            this.teyinatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.teyinatToolStripMenuItem.Text = "Teyinat";
            // 
            // departamentToolStripMenuItem
            // 
            this.departamentToolStripMenuItem.Name = "departamentToolStripMenuItem";
            this.departamentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.departamentToolStripMenuItem.Text = "Departament";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 515);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analitikalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sirketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teyinatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentToolStripMenuItem;
    }
}

