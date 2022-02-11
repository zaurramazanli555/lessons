using System;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
        }

        private void FormControls_Load(object sender, EventArgs e)
        {
            
        }

        private void resetForm_Click(object sender, EventArgs e)
        {
            //1. variant
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    //1.1 variant
                    ((TextBox)item).Text = string.Empty;

                    //1.2 variant
                    //TextBox textbox = (TextBox)item;
                    //textbox.Text = string.Empty;
                }
            }

            //2. variant (istifade oluna biler ancaq null referance ex. riski var!)

            //nameText.Text = "test";

            //((TextBox)this.Controls["nameText"]).Text = string.Empty;
            //((TextBox)this.Controls["surnameText"]).Text = string.Empty;
            //((TextBox)this.Controls["fatherNameText"]).Text = string.Empty;
            //((TextBox)this.Controls["emailText"]).Text = string.Empty;
            //((TextBox)this.Controls["phoneNumberText"]).Text = string.Empty;
        }
    }
}
