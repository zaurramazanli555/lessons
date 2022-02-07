using AppPayment.DBModel;
using AppPayment.ModelCLass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPayment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (PaymentContext context = new PaymentContext())
            {
                string username = txtUsername.Text;
                string pass = txtpassword.Text;
                User user= context.Users.FirstOrDefault(x => x.UserName == username && x.Password == pass);
                if (user != null)
                {
                    this.Hide();
                    frmMain frmmain = new frmMain();
                    frmmain.Show();
                    
                }
                    
                else
                    MessageBox.Show("Duzgun daxil etmemisiniz");
                //User user = new User();
                //user.UserName = username;
                //user.Password = pass;
                //context.Users.Add(user);
                //context.SaveChanges();
                //MessageBox.Show("Successfully");
            }
        }
    }
}
