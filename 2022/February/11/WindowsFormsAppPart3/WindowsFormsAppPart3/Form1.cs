using System;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bir MessageBox'dur!", "Basliq", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hə, Yox və ya İmtina seçin!", "Hə/Yox/İmtina Sualı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Programdan çıxmaq istədiyinizə əminsiniz?", "Exit App", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
        /*
            //Aşağıdakılara da baxın...
            //Digər istifadə edə biləcəyiniz MessageBoxIcon member'ləri:
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Asterisk);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Error);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Exclamation);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Hand);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.None);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Question);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Stop);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Warning);

            //Digər istifadə edə biləcəyiniz MessageBoxButtons member'ləri:
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.Ok, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            DialogResult result = MessageBox.Show("", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
         */
    }
}
