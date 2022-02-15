using System;
using System.Windows.Forms;

namespace WindowsFormsAppPart4
{
    public partial class VerifyPersonData : Form
    {
        public VerifyPersonData()
        {
            InitializeComponent();
        }
        
        private void submitFormBtn_Click(object sender, EventArgs e)
        {
            Form currentForm = this;
            foreach (Form item in Application.OpenForms)
            {
                if(item is AddPerson) // və ya if(item.Name == "AddPerson")
                {
                    foreach (var formItem in item.Controls)
                    {
                        if(formItem is TextBox)
                            ((TextBox)formItem).Text = string.Empty;
                    }
                }
            }

            Form addPersonForm = Application.OpenForms["AddPerson"];
            currentForm.Close();
        }

        private void cancelFormBtn_Click(object sender, EventArgs e)
        {
            Form currentForm = this;
            foreach (var formItem in currentForm.Controls)
            {
                if (formItem is TextBox)
                    ((TextBox)formItem).Text = string.Empty;
            }
            currentForm.Close();
        }
    }
}
