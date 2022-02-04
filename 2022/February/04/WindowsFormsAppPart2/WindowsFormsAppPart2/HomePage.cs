using System.Windows.Forms;

namespace WindowsFormsAppPart2
{
    public partial class HomePage : Form
    {
        public HomePage(User user)
        {
            InitializeComponent();
            nameEdit.Text = user.Name;
            surnameEdit.Text = user.Surname;
            usernameEdit.Text = user.Username;
            passwordEdit.Text = user.Password;
            aboutUserEdit.Text = user.AboutUser;
            saveUserInfoBtn.Tag = user.Id;
        }

        private void saveUserInfoBtn_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            User user = VirtualDatabase.Users.Find(m => m.Id == (int)btn.Tag);
        }
    }
}
