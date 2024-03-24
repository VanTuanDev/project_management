using BLL.Manager;
using System.Data;

namespace Csharp_Project.Staff
{
    public partial class ucClientManage : UserControl
    {
        private ClientManager clientBLL;
        private bool isAdd = false;
        private bool isEdit = false;
        public ucClientManage()
        {
            clientBLL = new ClientManager();
            InitializeComponent();
            dgClient.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgClient.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgClient.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgClient.DefaultCellStyle.SelectionForeColor = Color.White;

            dgClient.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgClient.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgClient.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgClient.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgClient.AllowUserToResizeRows = false;
            dgClient.AllowUserToResizeColumns = false;
        }
        private void LoadClients()
        {
            DataTable categories = clientBLL.GetClients();
            dgClient.DataSource = categories;
        }
        private void Reset()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtNewId.Text = "";
            txtNewName.Text = "";
            txtNewAddress.Text = "";
            txtNewPhone.Text = "";
            lblNewId.Visible = false;
            txtNewId.Visible = false;
            lblNewName.Visible = false;
            txtNewName.Visible = false;
            lblNewAddress.Visible = false;
            txtNewAddress.Visible = false;
            lblNewPhone.Visible = false;
            txtNewPhone.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            isAdd = false;
            isEdit = false;
        }
        private void Display ()
        {
            lblNewId.Visible = true;
            txtNewId.Visible = true;
            lblNewName.Visible = true;
            txtNewName.Visible = true;
            lblNewAddress.Visible = true;
            txtNewAddress.Visible = true;
            lblNewPhone.Visible = true;
            txtNewPhone.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
        private void ucClientManage_Load(object sender, EventArgs e)
        {
            LoadClients();
            Reset();
        }

        private void dgClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgClient.Rows.Count)
            {
                DataGridViewRow row = dgClient.Rows[e.RowIndex];
                txtId.Text = row.Cells["cl1"].Value.ToString();
                txtName.Text = row.Cells["cl2"].Value.ToString();
                txtAddress.Text = row.Cells["cl3"].Value.ToString();
                txtPhone.Text = row.Cells["cl4"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgClient.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int clientID = Convert.ToInt32(selectedRow.Cells["cl1"].Value);


            bool deleteSuccess = clientBLL.DeleteClient(clientID);

            if (deleteSuccess)
            {
                MessageBox.Show("Xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClients();
            }
            else
            {
                MessageBox.Show("Không thể xóa dòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isEdit = false;

            Display();

            btnEdit.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isAdd = false;
            isEdit = true;
            Display();
            txtNewId.ReadOnly = true;
            btnAdd.Enabled = false;
            txtNewId.Text = txtId.Text;
            txtNewName.Text = txtName.Text;
            txtNewPhone.Text = txtPhone.Text;
            txtNewAddress.Text = txtAddress.Text;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (string.IsNullOrEmpty(txtNewId.Text) || string.IsNullOrEmpty(txtNewName.Text) || string.IsNullOrEmpty(txtNewAddress.Text) || string.IsNullOrEmpty(txtNewPhone.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int newId = Convert.ToInt32(txtNewId.Text);
                string newName = txtNewName.Text;
                string newAddress = txtNewAddress.Text;
                string newPhone = txtNewPhone.Text;

                bool insertSuccess = clientBLL.InsertClient(newId, newName, newAddress, newPhone);

                if (insertSuccess)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadClients();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (isEdit)
            {
                int newId = Convert.ToInt32(txtNewId.Text);
                string newName = txtNewName.Text;
                string newAddress = txtNewAddress.Text;
                string newPhone = txtNewPhone.Text;
                bool updateSuccess = clientBLL.UpdateClient(newId, newName, newAddress, newPhone);

                if (updateSuccess)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadClients();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtNewPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNewId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == ' ') 
            {
                e.Handled = true;
            }
        }
    }
}
