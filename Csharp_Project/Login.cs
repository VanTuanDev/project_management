using BLL.Manager;
using System.Data;
using static BLL.Manager.AccountManager;

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
            string pwd = textToMd5.converText(txtMatkhau.Text);
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

        private void txtTaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string username = "";
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveAccount.username = username;
                this.Close();
            }
        }
    }
}
