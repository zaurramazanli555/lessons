using System;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class ShowAndShowDialog : Form
    {
        public ShowAndShowDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstForm firstForm = new FirstForm();
            firstForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            secondForm.ShowDialog();
        }
    }
}
