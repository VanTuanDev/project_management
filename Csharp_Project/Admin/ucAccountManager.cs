using BLL.Manager;
using System.Data;
using static BLL.Manager.AccountManager;

namespace Csharp_Project.Admin
{
    public partial class ucAccountManager : UserControl
    {
        private AccountManager accountBLL;
        public ucAccountManager()
        {
            accountBLL = new AccountManager();
            InitializeComponent();
            dgAccount.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgAccount.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgAccount.DefaultCellStyle.SelectionForeColor = Color.White;

            dgAccount.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgAccount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgAccount.AllowUserToResizeRows = false;
            dgAccount.AllowUserToResizeColumns = false;
        }
        private void LoadAccount()
        {
            DataTable Accountlist = accountBLL.GetAccount();
            dgAccount.DataSource = Accountlist;
        }
        private void Reset()
        {
            txtUser.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPass.Text = string.Empty;
            cbbRole.Text = string.Empty;
            txtNewname.Text = string.Empty;
            txtSelectuser.Text = string.Empty;
            txtNewstatus.Text = string.Empty;
            txtOldpass.Text = string.Empty;
            txtNewpass.Text = string.Empty;
            cbbNewrole.Text = string.Empty;

            lblSelectuser.Visible = false;
            txtSelectuser.Visible = false;
            lblNewname.Visible = false;
            txtNewname.Visible = false;
            lblNewstatus.Visible = false;
            txtNewstatus.Visible = false;
            lblOldpass.Visible = false;
            txtOldpass.Visible = false;
            lblNewpass.Visible = false;
            txtNewpass.Visible = false;
            lblNewrole.Visible = false;
            cbbNewrole.Visible = false;

            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
        }
        private void Display()
        {
            lblSelectuser.Visible = true;
            txtSelectuser.Visible = true;
            lblNewname.Visible = true;
            txtNewname.Visible = true;
            lblNewstatus.Visible = true;
            txtNewstatus.Visible = true;
            lblOldpass.Visible = true;
            txtOldpass.Visible = true;
            lblNewpass.Visible = true;
            txtNewpass.Visible = true;
            lblNewrole.Visible = true;
            cbbNewrole.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void ucAccountManage_Load(object sender, EventArgs e)
        {
            LoadAccount();
            Reset();
            DataTable roleTable = accountBLL.GetRoleName();
            cbbRole.DataSource = roleTable;
            cbbRole.DisplayMember = "rolename";
            cbbRole.ValueMember = "rolename";
            cbbNewrole.DataSource = roleTable;
            cbbNewrole.DisplayMember = "rolename";
            cbbNewrole.ValueMember = "rolename";
            cbbRole.Text = string.Empty;
        }

        private void dgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgAccount.Rows.Count)
            {
                DataGridViewRow row = dgAccount.Rows[e.RowIndex];
                txtUser.Text = row.Cells["username"].Value.ToString();
                txtName.Text = row.Cells["fullname"].Value.ToString();
                cbbRole.Text = row.Cells["role"].Value.ToString();
                txtNewstatus.Text = row.Cells["cl4"].Value.ToString();
                txtSelectuser.Text = txtUser.Text;
                txtNewname.Text = txtName.Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cbbRole.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string username = txtUser.Text.Trim();
            string fullname = txtName.Text;
            string pwd = textToMd5.converText(txtPass.Text);
            string rolename = cbbRole.Text;
            int roleid = accountBLL.GetRoleIdByName(rolename);
            bool insertSuccess = accountBLL.InsertAccount(username, fullname, pwd, roleid);
            if (insertSuccess)
            {
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Display();
            btnAdd.Enabled = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgAccount.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string username = selectedRow.Cells["username"].Value.ToString();


            bool deleteSuccess = accountBLL.DeleteAccount(username);

            if (deleteSuccess)
            {
                MessageBox.Show("Xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
                Reset();
            }
            else
            {
                MessageBox.Show("Không thể xóa dòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string username = txtSelectuser.Text;
            string fullname = txtNewname.Text;
            string oldpwd = textToMd5.converText(txtOldpass.Text);
            string newpwd = textToMd5.converText(txtNewpass.Text);
            string status = txtNewstatus.Text;
            string rolename = cbbNewrole.Text;
            int roleid = accountBLL.GetRoleIdByName(rolename);
            bool checkpwd = accountBLL.checkpwd(username, oldpwd);
            if (checkpwd)
            {
                bool updateSuccess = accountBLL.UpdateAccount(username, fullname, newpwd, roleid, status);

                if (updateSuccess)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadAccount();
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
    }
}
