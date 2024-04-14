using BLL.Manager;
using System.Data;

namespace Csharp_Project.Staff
{
    public partial class ucSelling : UserControl
    {
        private DataTable dataDSSanPham = null;
        private ProductManager manager = null;
        //private BillManager HDmanager = null;
        public ucSelling()
        {
            dataDSSanPham = new DataTable();
            manager = new ProductManager();
            //HDmanager = new BillManager();
            InitializeComponent();

            dgSanPham.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgSanPham.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgSanPham.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgSanPham.DefaultCellStyle.SelectionForeColor = Color.White;

            dgSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgSanPham.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgSanPham.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSanPham.AllowUserToResizeRows = false;
            dgSanPham.AllowUserToResizeColumns = false;

            dgSanPham.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgSPDuocChon.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgSPDuocChon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgSPDuocChon.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgSPDuocChon.DefaultCellStyle.SelectionForeColor = Color.White;

            dgSPDuocChon.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dgSPDuocChon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgSPDuocChon.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgSPDuocChon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgSPDuocChon.AllowUserToResizeRows = false;
            dgSPDuocChon.AllowUserToResizeColumns = false;

            dgSPDuocChon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgSPDuocChon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void HienThiDanhSachSanPham()
        {
            string error = string.Empty;
            dataDSSanPham = manager.GetFoods();
            if (dataDSSanPham != null)
            {
                dgSanPham.DataSource = dataDSSanPham;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void Reset()
        {
            txtKhachHang.Text = string.Empty;
            txtSanPham.Text = string.Empty;
            txtSoLuong.Text = "1";
            currentValue = 1;
        }
        private void btnChonKH_Click(object sender, EventArgs e)
        {
            SelectCustomer frm = new SelectCustomer();
            frm.ShowDialog();

            if (frm.SelectedKhachHang != null)
            {
                string tenKhachHang = frm.SelectedKhachHang.fullname;
                txtKhachHang.Text = tenKhachHang;
            }
        }

        private void ucSelling_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            dgSanPham.ClearSelection();
            dgSPDuocChon.ClearSelection();
        }

        private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgSanPham.Rows[e.RowIndex];

                string column2Value = selectedRow.Cells["cl2"].Value.ToString();
                string column4Value = selectedRow.Cells["cl4"].Value.ToString();

                txtSanPham.Text = column2Value;
                txtDonGia.Text = column4Value;
            }
        }

        private int currentValue = 1;

        private void btnCong_Click(object sender, EventArgs e)
        {
            currentValue++;
            txtSoLuong.Text = currentValue.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            currentValue--;
            txtSoLuong.Text = currentValue.ToString();
        }
        private void CapNhatTongTien()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgSPDuocChon.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[3].Value != null)
                    {
                        total += Convert.ToDecimal(row.Cells[3].Value);
                    }
                }
            }

            lblTongTien.Text = total.ToString("#,##0.##") + " VNĐ";
        }

        private void dgSPDuocChon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CapNhatTongTien();
        }

        private void Them()
        {
            string SoLuong = txtSoLuong.Text;
            if (!string.IsNullOrEmpty(txtSanPham.Text))
            {
                string tenSanPham = txtSanPham.Text;
                int soLuong = int.Parse(txtSoLuong.Text);
                decimal donGia = decimal.Parse(txtDonGia.Text);
                decimal thanhTien = soLuong * donGia;

                bool daTonTai = false;
                foreach (DataGridViewRow existingRow in dgSPDuocChon.Rows)
                {
                    string tenSanPhamHienTai = existingRow.Cells[0].Value.ToString();
                    int soLuongHienTai = int.Parse(existingRow.Cells[1].Value.ToString());
                    decimal donGiaHienTai = decimal.Parse(existingRow.Cells[2].Value.ToString());

                    if (tenSanPham == tenSanPhamHienTai)
                    {
                        soLuongHienTai += soLuong;
                        decimal thanhTienHienTai = soLuongHienTai * donGiaHienTai;
                        existingRow.Cells[1].Value = soLuongHienTai;
                        existingRow.Cells[3].Value = thanhTienHienTai;

                        daTonTai = true;
                        break;
                    }
                }

                if (!daTonTai)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgSPDuocChon);
                    row.Cells[0].Value = tenSanPham;
                    row.Cells[1].Value = soLuong;
                    row.Cells[2].Value = donGia;
                    row.Cells[3].Value = thanhTien;

                    dgSPDuocChon.Rows.Add(row);
                }
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm muốn mua.");
            }
            Reset();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            Them();
        }
        private void Xoa()
        {
            if (dgSPDuocChon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgSPDuocChon.SelectedRows[0];
                dgSPDuocChon.Rows.Remove(selectedRow);
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }
    }
}
