using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppPart3
{
    public partial class CustomerApp : Form
    {
        public CustomerApp()
        {
            InitializeComponent();
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                Id = Guid.NewGuid(),
                Name = nameText.Text,
                Surname = surnameText.Text,
                FatherName = fatherNameText.Text,
                Email = emailText.Text,
                PhoneNumber = phoneNumberText.Text
            };

            int result = AddNewCustomer(customer);

            if(result > 0)
            {
                DialogResult answer = MessageBox.Show("Yeni müştəri əlavə olundu! Başqa müştəri əlavə etmək istəyirsiniz?", "Məlumat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(answer == DialogResult.Yes)
                {
                    winNotification = new NotifyIcon();
                    winNotification.BalloonTipText = "Toplam müştəri sayısı:" + VirtualDatabase.Customers.Count.ToString();
                    winNotification.BalloonTipTitle = "Müştəri ədəd məlumatı";
                    winNotification.Visible = true;
                    winNotification.Icon = SystemIcons.Information;
                    winNotification.ShowBalloonTip(4000);
                }
                else
                    FillCustomersList();

                ClearInputs();
            }
            else
                MessageBox.Show("Yeni müştəri əlavə edilə bilmədi!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int AddNewCustomer(Customer customer)
        {
            VirtualDatabase.Customers.Add(customer);
            return 1;
        }

        private void ClearInputs()
        {
            nameText.Text = string.Empty;
            surnameText.Text = string.Empty;
            fatherNameText.Text = string.Empty;
            emailText.Text = string.Empty;
            phoneNumberText.Text = string.Empty;
        }

        private void FillCustomersList()
        {
            customerList.DataSource = VirtualDatabase.Customers;
        }
    }
}
