using BLL.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            txtTaikhoan.Text = string.Empty;
            txtMatkhau.Text = string.Empty;
            cbbQuyen.Text = string.Empty;
            txttksua.Text = string.Empty;
            txtTinhTrang.Text = string.Empty;
            txtmkmoi.Text = string.Empty;
            cbbQuyenmoi.Text = string.Empty;

            lbltksua.Visible = false;
            txttksua.Visible = false;
            lblTinhTrang.Visible = false;
            txtTinhTrang.Visible = false;
            lblmkmoi.Visible = false;
            txtmkmoi.Visible = false;
            lblquyenmoi.Visible = false;
            cbbQuyenmoi.Visible = false;

            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
        }
        private void Display()
        {
            lbltksua.Visible = true;
            txttksua.Visible = true;
            lblTinhTrang.Visible = true;
            txtTinhTrang.Visible = true;
            lblmkmoi.Visible = true;
            txtmkmoi.Visible = true;
            lblquyenmoi.Visible = true;
            cbbQuyenmoi.Visible = true;
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
            cbbQuyenmoi.DataSource = roleTable;
            cbbQuyenmoi.DisplayMember = "rolename";
            cbbQuyenmoi.ValueMember = "rolename";
        }

        private void dgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgAccount.Rows.Count)
            {
                DataGridViewRow row = dgAccount.Rows[e.RowIndex];
                txtTaikhoan.Text = row.Cells["username"].Value.ToString();
                txtMatkhau.Text = row.Cells["pwd"].Value.ToString();
                cbbQuyen.Text = row.Cells["role"].Value.ToString();
                txtTinhTrang.Text = row.Cells["status"].Value.ToString();
                txttksua.Text = txtTaikhoan.Text;
                txtmkmoi.Text = txtMatkhau.Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaikhoan.Text) || string.IsNullOrEmpty(txtMatkhau.Text) || string.IsNullOrEmpty(cbbQuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string username = txtTaikhoan.Text;
            string pwd = txtMatkhau.Text;
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
            if (string.IsNullOrEmpty(txtTaikhoan.Text))
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
            string username = txttksua.Text;
            string pwd = txtmkmoi.Text;
            string status = txtTinhTrang.Text;
            string rolename = cbbQuyenmoi.Text;
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
