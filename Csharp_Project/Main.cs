using Csharp_Project.Admin;
using Csharp_Project.Staff;
using BLL.Manager;
using DAL.Entity;

namespace Csharp_Project
{
    public partial class Main : Form
    {
        AccountEntity entity = new AccountEntity();
        public Main()
        {
            InitializeComponent();

        }
        Font vietnameseFont = new Font("Arial", 10, FontStyle.Regular);
        private ucAccountManager AccountManage;
        private ucCategoryManager CategoryManage;
        private ucCustomerManager ClientManage;
        private ucProductManager FoodManage;
        private ucBillManager BillManage;
        private ucSelling Selling;
        private void ResetBackColorBtn()
        {
            btnAccount.BackColor = Color.Cornsilk;
            btnCustomer.BackColor = Color.Cornsilk;
            btnProduct.BackColor = Color.Cornsilk;
            btnCategory.BackColor = Color.Cornsilk;
            btnBill.BackColor = Color.Cornsilk;
            btnSelling.BackColor = Color.Cornsilk;
        }
        private void Reset()
        {
            if (pnlInfo.Controls.Contains(AccountManage))
            {
                pnlInfo.Controls.Remove(AccountManage);
            }
            if (pnlInfo.Controls.Contains(CategoryManage))
            {
                pnlInfo.Controls.Remove(CategoryManage);
            }
            if (pnlInfo.Controls.Contains(ClientManage))
            {
                pnlInfo.Controls.Remove(ClientManage);
            }
            if (pnlInfo.Controls.Contains(FoodManage))
            {
                pnlInfo.Controls.Remove(FoodManage);
            }
            if (pnlInfo.Controls.Contains(BillManage))
            {
                pnlInfo.Controls.Remove(BillManage);
            }
        }
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnAccount.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(AccountManage) == false)
            {
                AccountManage = new ucAccountManager();
                AccountManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(AccountManage);
                AccountManage.BringToFront();
                pnlInfo.Controls.Remove(CategoryManage);
                pnlInfo.Controls.Remove(ClientManage);
                pnlInfo.Controls.Remove(FoodManage);
                pnlInfo.Controls.Remove(BillManage);
            }
            else
            {
                AccountManage.BringToFront();
            }
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnCustomer.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(ClientManage) == false)
            {
                ClientManage = new ucCustomerManager();
                ClientManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(ClientManage);
                ClientManage.BringToFront();
                pnlInfo.Controls.Remove(CategoryManage);
                pnlInfo.Controls.Remove(AccountManage);
                pnlInfo.Controls.Remove(FoodManage);
                pnlInfo.Controls.Remove(BillManage);
            }
            else
            {
                ClientManage.BringToFront();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnProduct.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(FoodManage) == false)
            {
                FoodManage = new ucProductManager();
                FoodManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(FoodManage);
                FoodManage.BringToFront();
                pnlInfo.Controls.Remove(CategoryManage);
                pnlInfo.Controls.Remove(ClientManage);
                pnlInfo.Controls.Remove(AccountManage);
                pnlInfo.Controls.Remove(BillManage);
            }
            else
            {
                FoodManage.BringToFront();
            }
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnCategory.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(CategoryManage) == false)
            {
                CategoryManage = new ucCategoryManager();
                CategoryManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(CategoryManage);
                CategoryManage.BringToFront();
                pnlInfo.Controls.Remove(AccountManage);
                pnlInfo.Controls.Remove(ClientManage);
                pnlInfo.Controls.Remove(FoodManage);
                pnlInfo.Controls.Remove(BillManage);
            }
            else
            {
                CategoryManage.BringToFront();
            }
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnBill.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(BillManage) == false)
            {
                BillManage = new ucBillManager();
                BillManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(BillManage);
                BillManage.BringToFront();
                pnlInfo.Controls.Remove(AccountManage);
                pnlInfo.Controls.Remove(ClientManage);
                pnlInfo.Controls.Remove(FoodManage);
                pnlInfo.Controls.Remove(CategoryManage);
                pnlInfo.Controls.Remove(Selling);
            }
            else
            {
                BillManage.BringToFront();
            }
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnSelling.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(Selling) == false)
            {
                Selling = new ucSelling();
                Selling.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(Selling);
                Selling.BringToFront();
                pnlInfo.Controls.Remove(AccountManage);
                pnlInfo.Controls.Remove(ClientManage);
                pnlInfo.Controls.Remove(FoodManage);
                pnlInfo.Controls.Remove(CategoryManage);
                pnlInfo.Controls.Remove(BillManage);
            }
            else
            {
                Selling.BringToFront();
            }
        }
        AccountManager accountBLL = new AccountManager();
        private void Main_Load(object sender, EventArgs e)
        {
            btnAccount.Visible = false;
            pbxAccount.Visible = false;
            this.Hide();

            Login f = new Login();
            f.ShowDialog();

            entity.username = SaveAccount.username;
            if (string.IsNullOrEmpty(entity.username))
            {
                Application.Exit();
            }
            bool checkAdmin = accountBLL.checkAdmin(entity);

            if (checkAdmin)
            {
                btnAccount.Visible = true;
                pbxAccount.Visible = true;
            }
            this.Show();
            btnBanhang_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Main_Load(sender, e);
                Reset();
            }
        }

        private void btnChangeinfo_Click(object sender, EventArgs e)
        {
            ChangeInfo f = new ChangeInfo();
            f.ShowDialog();
        }
    }
}