using BLL.Manager;
using static BLL.Manager.AccountManager;
using DAL.Entity;

namespace Csharp_Project.Staff
{
    public partial class ChangeInfo : Form
    {
        private AccountManager accountBLL = new AccountManager();
        AccountEntity entity = new AccountEntity();
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
            if (string.IsNullOrEmpty(txtNewName.Text) ||
                string.IsNullOrEmpty(txtOldPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc nếu muốn thay đổi thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            entity.username = txtUser.Text;
            entity.fullname = txtNewName.Text;
            entity.pwd = textToMd5.converText(txtOldPassword.Text);

            bool checkpwd = accountBLL.LoginAccount(entity);

            if (txtSubmitPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkpwd)
            {
                entity.pwd = textToMd5.converText(txtNewPassword.Text);
                bool updateSuccess = accountBLL.UpdateInfo(entity);

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
                MessageBox.Show("Bạn đã nhập sai mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn không muốn sửa đổi thông tin ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtOldpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNewpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtAcceptPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
