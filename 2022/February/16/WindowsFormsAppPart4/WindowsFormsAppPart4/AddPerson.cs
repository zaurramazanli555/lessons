using System;
using System.Windows.Forms;

namespace WindowsFormsAppPart4
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void saveFormBtn_Click(object sender, EventArgs e)
        {
            VerifyPersonData form = new VerifyPersonData();
            ((TextBox)form.Controls["nameDisabled"]).Text = nameTextBox.Text;
            ((TextBox)form.Controls["surnameDisabled"]).Text = surnameTextBox.Text;
            ((TextBox)form.Controls["docSerialDisabled"]).Text = docSerialTextBox.Text;
            ((TextBox)form.Controls["docNumberDisabled"]).Text = docNumberTextBox.Text;
            form.ShowDialog();
        }
    }
}
