using System;
using System.Windows.Forms;

namespace WindowsFormsAppPart6
{
    public partial class CustomerInfoPupup : Form
    {
        Customer customer;
        Form form;
        public CustomerInfoPupup(Customer customer, Form form)
        {
            InitializeComponent();
            this.customer = customer;
            this.form = form;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Close();
        }

        private void CustomerInfoPupup_Load(object sender, EventArgs e)
        {
            txtId.Text = customer.Id.ToString();
            txtName.Text = customer.Name;
            txtSurname.Text = customer.Surname;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtCountry.Text = customer.Country;
            txtCity.Text = customer.City;
            txtAddress.Text = customer.Address;
        }
    }
}
