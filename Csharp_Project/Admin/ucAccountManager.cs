using BLL.Manager;
using System.Data;

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
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            cbbQuyen.Text = string.Empty;
            txtTaiKhoanMoi.Text = string.Empty;
            txtTinhTrangMoi.Text = string.Empty;
            txtMatKhauMoi.Text = string.Empty;
            cbbQuyenMoi.Text = string.Empty;

            lblTaiKhoanMoi.Visible = false;
            txtTaiKhoanMoi.Visible = false;
            lblTinhTrangMoi.Visible = false;
            txtTinhTrangMoi.Visible = false;
            lblMatKhauMoi.Visible = false;
            txtMatKhauMoi.Visible = false;
            lblQuyenMoi.Visible = false;
            cbbQuyenMoi.Visible = false;

            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
        }
        private void Display()
        {
            lblTaiKhoanMoi.Visible = true;
            txtTaiKhoanMoi.Visible = true;
            lblTinhTrangMoi.Visible = true;
            txtTinhTrangMoi.Visible = true;
            lblMatKhauMoi.Visible = true;
            txtMatKhauMoi.Visible = true;
            lblQuyenMoi.Visible = true;
            cbbQuyenMoi.Visible = true;
            btnLuu.Visible = true;
            btnHuy.Visible = true;
        }

        private void ucAccountManage_Load(object sender, EventArgs e)
        {
            LoadAccount();
            Reset();
            DataTable roleTable = accountBLL.GetRoleName();
            cbbQuyen.DataSource = roleTable;
            cbbQuyen.DisplayMember = "rolename";
            cbbQuyen.ValueMember = "rolename";
            cbbQuyenMoi.DataSource = roleTable;
            cbbQuyenMoi.DisplayMember = "rolename";
            cbbQuyenMoi.ValueMember = "rolename";
            cbbQuyen.Text = string.Empty;
        }

        private void dgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgAccount.Rows.Count)
            {
                DataGridViewRow row = dgAccount.Rows[e.RowIndex];
                txtTaiKhoan.Text = row.Cells["username"].Value.ToString();
                txtMatKhau.Text = row.Cells["pwd"].Value.ToString();
                cbbQuyen.Text = row.Cells["role"].Value.ToString();
                txtTinhTrangMoi.Text = row.Cells["cl4"].Value.ToString();
                txtTaiKhoanMoi.Text = txtTaiKhoan.Text;
                txtMatKhauMoi.Text = txtMatKhau.Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(cbbQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string username = txtTaiKhoan.Text;
            string pwd = txtMatKhau.Text;
            string rolename = cbbQuyen.Text;
            int roleid = accountBLL.GetRoleIdByName(rolename);

            bool insertSuccess = accountBLL.InsertAccount(username, pwd, roleid);

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
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Display();
            btnThem.Enabled = false;

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
            string username = txtTaiKhoanMoi.Text;
            string pwd = txtMatKhauMoi.Text;
            string status = txtTinhTrangMoi.Text;
            string rolename = cbbQuyenMoi.Text;
            int roleid = accountBLL.GetRoleIdByName(rolename);

            bool updateSuccess = accountBLL.UpdateAccount(username, pwd, roleid, status);

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
