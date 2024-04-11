using BLL.Manager;
using System.Data;
using DAL.Entity;

namespace Csharp_Project.Staff
{
    public partial class SelectCustomer : Form
    {
        CustomerEntity entity = new CustomerEntity();
        private CustomerManager clientBLL;
        public SelectCustomer()
        {
            clientBLL = new CustomerManager();
            InitializeComponent();
            dgCustomer.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgCustomer.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgCustomer.DefaultCellStyle.SelectionForeColor = Color.White;

            dgCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgCustomer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgCustomer.AllowUserToResizeRows = false;
            dgCustomer.AllowUserToResizeColumns = false;

            dgCustomer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            DataTable categories = clientBLL.GetClients();
            dgCustomer.DataSource = categories;
        }
    }
}
