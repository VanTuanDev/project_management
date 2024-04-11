using BLL.Manager;
using System.Data;
using DAL.Entity;
using System.Security.Principal;

namespace Csharp_Project.Staff
{
    public partial class ucBillManager : UserControl
    {
        private BillManager billBLL;
        public ucBillManager()
        {
            billBLL = new BillManager();
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
        }

        private void ucBillManager_Load(object sender, EventArgs e)
        {
            DataTable Billlist = billBLL.GetBill();
            dgBill.DataSource = Billlist;
        }
    }
}
