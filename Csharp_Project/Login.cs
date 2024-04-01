using BLL.Manager;
using System.Data;

namespace Csharp_Project
{
    public partial class Login : Form
    {

        AccountManager accountBLL = new AccountManager();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtTaikhoan.Text;
            string pwd = txtMatkhau.Text;
            bool loginSuccess = accountBLL.LoginAccount(username, pwd);
            if (loginSuccess)
            {
                this.Close();
                SaveAccount.username = username;
            }
            else { MessageBox.Show("Sai tài khoản mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '⬤')
            {
                txtMatkhau.PasswordChar = '\0'; 
            }
            else
            {
                txtMatkhau.PasswordChar = '⬤'; 
            }
        }
    }
}
