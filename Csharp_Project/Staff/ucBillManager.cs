using BLL.Manager;
using System.Data;
using System.Windows.Forms;

namespace Csharp_Project.Staff
{
    public partial class ucBillManager : UserControl
    {
        private BindingSource bindingSource;
        private DataTable dataDSHoaDon = null;
        private BillManager HDmanager = null;
        public ucBillManager()
        {
            dataDSHoaDon = new DataTable();
            HDmanager = new BillManager();
            InitializeComponent();
            dgBill.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgBill.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgBill.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgBill.DefaultCellStyle.SelectionForeColor = Color.White;

            dgBill.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgBill.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgBill.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgBill.AllowUserToResizeRows = false;
            dgBill.AllowUserToResizeColumns = false;

            dgBill.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public void HienThiDSHoaDon()
        {
            string error = string.Empty;
            if (HDmanager != null)
            {
                dataDSHoaDon = HDmanager.GetListBills();
                if (dataDSHoaDon != null)
                {
                    dgBill.DataSource = dataDSHoaDon;
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
            else
            {
                MessageBox.Show("HDmanager is null");
            }
        }

        private void ucBillManager_Load(object sender, EventArgs e)
        {
            HienThiDSHoaDon();
            dpTuNgay.Format = DateTimePickerFormat.Custom;
            dpTuNgay.CustomFormat = "dd/MM/yyyy";

            dpDenNgay.Format = DateTimePickerFormat.Custom;
            dpDenNgay.CustomFormat = "dd/MM/yyyy";
            bindingSource = new BindingSource();
            bindingSource.DataSource = dgBill.DataSource;
            dgBill.DataSource = bindingSource;
        }
        public void Reset()
        {
            maHoaDonDuocChon = -1;
        }
        private int maHoaDonDuocChon = -1;
        private string trangThaiHoaDon = "";

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (trangThaiHoaDon == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn đã được thanh toán.");
                return;
            }
            if (maHoaDonDuocChon != -1)
            {
                try
                {
                    HDmanager.UpdateStatusBill(maHoaDonDuocChon, "Đã thanh toán");
                    MessageBox.Show("Hóa đơn được thanh toán thành công");
                    HienThiDSHoaDon();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thanh toán hóa đơn: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán");
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (maHoaDonDuocChon != -1)
            {
                BillDetail formChiTietHoaDon = new BillDetail();

                formChiTietHoaDon.MaHoaDon = maHoaDonDuocChon;

                formChiTietHoaDon.ShowDialog();

                HienThiDSHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết");
            }
        }

        private void dgBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgBill.Rows[e.RowIndex];
                int maHoaDon = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string trangThai = selectedRow.Cells["status"].Value.ToString();

                maHoaDonDuocChon = maHoaDon;
                trangThaiHoaDon = trangThai;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (maHoaDonDuocChon != -1)
            {
                PrintBill formPrintBill = new PrintBill();

                formPrintBill.MaHoaDon = maHoaDonDuocChon;

                formPrintBill.ShowDialog();

                HienThiDSHoaDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dpTuNgay.Value.Date;
            DateTime toDate = dpDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

            bindingSource.Filter = string.Format("time >= #{0}# AND time <= #{1}#", fromDate.ToString("MM/dd/yyyy"), toDate.ToString("MM/dd/yyyy"));
        }

        private void dpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromDate = dpTuNgay.Value.Date;
            DateTime toDate = dpDenNgay.Value.Date;

            if (fromDate > toDate)
            {
                dpDenNgay.Value = fromDate;
            }
        }

        private void dpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromDate = dpTuNgay.Value.Date;
            DateTime toDate = dpDenNgay.Value.Date;

            if (toDate < fromDate)
            {
                dpTuNgay.Value = toDate;
            }
        }
    }
}
