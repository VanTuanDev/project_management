using Csharp_Project.Admin;
using Csharp_Project.Staff;
using System.Windows.Forms;
using BLL.Manager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Csharp_Project
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private ucAccountManager AccountManage;
        private ucCategoryManager CategoryManage;
        private ucCustomerManager ClientManage;
        private ucProductManager FoodManage;
        private ucBillManager BillManage;
        private ucSelling Selling;
        private void ResetBackColorBtn()
        {
            btnTaikhoan.BackColor = Color.Cornsilk;
            btnKhachhang.BackColor = Color.Cornsilk;
            btnSanPham.BackColor = Color.Cornsilk;
            btnDanhmuc.BackColor = Color.Cornsilk;
            btnHoadon.BackColor = Color.Cornsilk;
            btnBanhang.BackColor = Color.Cornsilk;
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
            if (pnlInfo.Controls.Contains(Selling))
            {
                pnlInfo.Controls.Remove(Selling);
            }

        }
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnTaikhoan.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(AccountManage) == false)
            {
                AccountManage = new ucAccountManager();
                AccountManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(AccountManage);
                AccountManage.BringToFront();
            }
            else
            {
                AccountManage.BringToFront();
            }
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnKhachhang.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(ClientManage) == false)
            {
                ClientManage = new ucCustomerManager();
                ClientManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(ClientManage);
                ClientManage.BringToFront();
            }
            else
            {
                ClientManage.BringToFront();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnSanPham.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(FoodManage) == false)
            {
                FoodManage = new ucProductManager();
                FoodManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(FoodManage);
                FoodManage.BringToFront();
            }
            else
            {
                FoodManage.BringToFront();
            }
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnDanhmuc.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(CategoryManage) == false)
            {
                CategoryManage = new ucCategoryManager();
                CategoryManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(CategoryManage);
                CategoryManage.BringToFront();
            }
            else
            {
                CategoryManage.BringToFront();
            }
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnHoadon.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(BillManage) == false)
            {
                BillManage = new ucBillManager();
                BillManage.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(BillManage);
                BillManage.BringToFront();
            }
            else
            {
                BillManage.BringToFront();
            }
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            ResetBackColorBtn();
            btnBanhang.BackColor = Color.FromArgb(128, 255, 128);
            if (pnlInfo.Controls.Contains(Selling) == false)
            {
                Selling = new ucSelling();
                Selling.Dock = DockStyle.Fill;
                pnlInfo.Controls.Add(Selling);
                Selling.BringToFront();
            }
            else
            {
                Selling.BringToFront();
            }
        }
        AccountManager accountBLL = new AccountManager();
        private void Main_Load(object sender, EventArgs e)
        {
            
            btnTaikhoan.Visible = false;
            pbxTaikhoan.Visible = false;
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
            string username = SaveAccount.username;
            bool checkAdmin = accountBLL.checkAdmin(username);
            if (checkAdmin)
            {
                btnTaikhoan.Visible = true;
                pbxTaikhoan.Visible = true;
            }
            else
            {
                btnTaikhoan.Visible = false;
                pbxTaikhoan.Visible = false;
            }
            this.Show();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Main_Load(sender,e);
            Reset();
        }
    }
}