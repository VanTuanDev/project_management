using BLL.Manager;
using System.Data;

namespace Csharp_Project.Staff
{
    public partial class ucBillManager : UserControl
    {
        private DataTable dataDSHoaDon = null;
        private BillManager HDmanager = null;
        public ucBillManager()
        {
            dataDSHoaDon = new DataTable();
            HDmanager = new BillManager();
            InitializeComponent();
            dgBill.DefaultCellStyle.Font = new Font("Tahoma", 12);
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
        }
        public void Reset()
        {
            maHoaDonDuocChon = -1;
        }
        private int maHoaDonDuocChon = -1;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (maHoaDonDuocChon != -1)
            {
                try
                {
                    HDmanager.UpdateStatusBill(maHoaDonDuocChon, "Đã thanh toán");
                    MessageBox.Show("Cập nhật trạng thái hóa đơn thành công");
                    HienThiDSHoaDon();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật trạng thái hóa đơn: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để cập nhật trạng thái");
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
                int maHoaDon = Convert.ToInt32(selectedRow.Cells["cl1"].Value);

                maHoaDonDuocChon = maHoaDon;
            }
        }
    }
}
