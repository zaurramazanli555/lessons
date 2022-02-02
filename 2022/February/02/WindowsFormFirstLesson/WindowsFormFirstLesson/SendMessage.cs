using System;
using System.Windows.Forms;

namespace WindowsFormFirstLesson
{
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtMessageValue = txtMessage.Text;
            ShowMessage showMessageForm = new ShowMessage(txtMessageValue);
            showMessageForm.Show();
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            TextBox t1 = (TextBox)sender;
            t1.Text = string.Empty;
        }
    }
}
