using BLL.Manager;
using DAL.Entity;
using System.Data;

namespace Csharp_Project.Staff
{
    public partial class BillDetail : Form
    {
        public int MaHoaDon { get; set; }
        private BillManager HDmanager = null;
        private DataTable dataCTHoaDon = null;
        public BillDetail()
        {
            dataCTHoaDon = new DataTable();
            InitializeComponent();
            HDmanager = new BillManager();
            dgChiTiet.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgChiTiet.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgChiTiet.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgChiTiet.DefaultCellStyle.SelectionForeColor = Color.White;

            dgChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgChiTiet.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgChiTiet.AllowUserToResizeRows = false;
            dgChiTiet.AllowUserToResizeColumns = false;
        }

        private void HienThiChiTietHoaDon()
        {
            BillDetailEntity billdetail = new BillDetailEntity();
            billdetail.billid = MaHoaDon;

            DataTable dt = HDmanager.GetBillDetail(billdetail);
            if (dt != null)
            {
                dgChiTiet.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết hóa đơn");
            }
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {
            int maHoaDon = MaHoaDon;

            BillEntity bill = new BillEntity();
            bill.id = maHoaDon;

            DataTable dt = HDmanager.GetInfomation(bill);

            if (dt.Rows.Count > 0)
            {
                lblTenKhachHangND.Text = dt.Rows[0]["fullname"].ToString();
                lblDiaChiND.Text = dt.Rows[0]["address"].ToString();

                DateTime ngayMuaHang = Convert.ToDateTime(dt.Rows[0]["time"]);
                lblNgayMuaHangND.Text = ngayMuaHang.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn");
            }
            HienThiChiTietHoaDon();
            CapNhatTongTien();
        }
        private void CapNhatTongTien()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgChiTiet.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[3].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells[4].Value);
                    }
                }
            }

            lblTongTienND.Text = total.ToString("#,##0.##") + " VNĐ";
        }
    }
}
