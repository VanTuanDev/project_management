using BLL.Manager;
using System.Data;
using static BLL.Manager.AccountManager;
using DAL.Entity;

namespace Csharp_Project.Admin
{
    public partial class ucAccountManager : UserControl
    {
        AccountEntity entity = new AccountEntity();
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
            cbbNewrole.Text = string.Empty;

            lblSelectuser.Visible = false;
            txtSelectuser.Visible = false;
            lblNewname.Visible = false;
            txtNewname.Visible = false;
            lblNewstatus.Visible = false;
            txtNewstatus.Visible = false;
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
            entity.username = txtUser.Text.Trim();
            entity.fullname = txtName.Text;
            entity.pwd = textToMd5.converText(txtPass.Text);
            entity.rolename = cbbRole.Text;
            entity.role = accountBLL.GetRoleIdByName(entity);
            bool insertSuccess = accountBLL.InsertAccount(entity);
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

            entity.username = selectedRow.Cells["username"].Value.ToString();


            bool deleteSuccess = accountBLL.DeleteAccount(entity);

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

            entity.username = txtSelectuser.Text;
            entity.fullname = txtNewname.Text;
            entity.status = txtNewstatus.Text;
            entity.rolename = cbbNewrole.Text;
            entity.role = accountBLL.GetRoleIdByName(entity);
            
                bool updateSuccess = accountBLL.UpdateAccount(entity);

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
    }
}
