using System.Data;
using BLL.Manager;

namespace Csharp_Project.Staff
{
    public partial class SelectCustomer : Form
    {
        public KhachHang SelectedKhachHang { get; set; } = null;
        private CustomerManager manager = null;
        private DataTable dataDSKhachHang = null;
        public SelectCustomer()
        {

            dataDSKhachHang = new DataTable();
            manager = new CustomerManager();
            InitializeComponent();
            dgKhachHang.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgKhachHang.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgKhachHang.DefaultCellStyle.SelectionForeColor = Color.White;

            dgKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 14, FontStyle.Bold);
            dgKhachHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgKhachHang.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgKhachHang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgKhachHang.AllowUserToResizeColumns = false;
            dgKhachHang.AllowUserToResizeRows = false;

        }

        private void HienThiDanhSachKhachHang()
        {
            string error = string.Empty;
            dataDSKhachHang = manager.GetClients();
            if (dataDSKhachHang != null)
            {
                dgKhachHang.DataSource = dataDSKhachHang;
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            HienThiDanhSachKhachHang();
        }

        private void dgKhachHang_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];         
                string tenKhachHang = selectedRow.Cells["cl2"].Value.ToString();

                SelectedKhachHang = new KhachHang
                {
                    fullname = tenKhachHang
                };

                this.Close();
            }
        }
    }
}
