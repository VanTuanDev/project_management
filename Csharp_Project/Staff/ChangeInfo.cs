
using BLL.Manager;
using static  BLL.Manager.AccountManager;

namespace Csharp_Project.Staff
{
    public partial class ChangeInfo : Form
    {
        private AccountManager accountBLL = new AccountManager();
        public ChangeInfo()
        {
            InitializeComponent();
        }

        private void ChangeInfo_Load(object sender, EventArgs e)
        {
            txtUser.Text = SaveAccount.username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string fullname = txtNewname.Text;
            string oldpwd = textToMd5.converText(txtOldpass.Text);
            string newpwd = textToMd5.converText(txtNewpass.Text);
            bool checkpwd = accountBLL.checkpwd(username, oldpwd);
            if (txtAcceptPass.Text != txtNewpass.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới không trùng ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkpwd)
            {
                bool updateSuccess = accountBLL.UpdateInfo(username, fullname, newpwd);

                if (updateSuccess)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
