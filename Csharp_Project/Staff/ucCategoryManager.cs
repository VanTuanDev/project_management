using BLL.Manager;
using System.Data;
using System.Data.SqlClient;
using DAL.Entity;

namespace Csharp_Project.Staff
{
    public partial class ucCategoryManager : UserControl
    {
        CategoryEntity entity = new CategoryEntity();
        private CategoryManager categoryBLL;
        private bool isAdd = false;
        private bool isEdit = false;
        public ucCategoryManager()
        {
            categoryBLL = new CategoryManager();
            InitializeComponent();
            dgCategory.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgCategory.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgCategory.DefaultCellStyle.SelectionForeColor = Color.White;

            dgCategory.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dgCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgCategory.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgCategory.AllowUserToResizeRows = false;
            dgCategory.AllowUserToResizeColumns = false;

            dgCategory.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgCategory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void LoadCategories()
        {
            DataTable categories = categoryBLL.GetCategories();
            dgCategory.DataSource = categories;
        }
        private void Reset()
        {
            txtNewId.Text = string.Empty;
            txtNewName.Text = string.Empty;
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;

            lblNewId.Visible = false;
            txtNewId.Visible = false;
            lblNewName.Visible = false;
            txtNewName.Visible = false;

            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;

            isAdd = false;
            isEdit = false;
        }
        private void Display()
        {
            lblNewId.Visible = true;
            txtNewId.Visible = true;
            lblNewName.Visible = true;
            txtNewName.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
        private void ucCategoryManage_Load(object sender, EventArgs e)
        {
            LoadCategories();
            Reset();
        }

        private void dgCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgCategory.Rows.Count)
            {
                DataGridViewRow row = dgCategory.Rows[e.RowIndex];
                txtId.Text = row.Cells["cl1"].Value.ToString();
                txtName.Text = row.Cells["cl2"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                DataGridViewRow selectedRow = dgCategory.CurrentRow;

                entity.id = Convert.ToInt32(selectedRow.Cells["cl1"].Value);

                try
                {
                    bool deleteSuccess = categoryBLL.DeleteCategory(entity);

                    if (deleteSuccess)
                    {
                        MessageBox.Show("Xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategories();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa dòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa danh mục vì có các mục liên quan trong bảng Item!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa dòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            isAdd = false;
            isEdit = true;

            Display();

            btnAdd.Enabled = false;
            txtNewId.ReadOnly = true;

            txtNewId.Text = txtId.Text;
            txtNewName.Text = txtName.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (string.IsNullOrEmpty(txtNewId.Text) || string.IsNullOrEmpty(txtNewName.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                entity.id = Convert.ToInt32(txtNewId.Text);
                entity.catename = txtNewName.Text;

                bool insertSuccess = categoryBLL.InsertCategory(entity);

                if (insertSuccess)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (isEdit)
            {
                entity.id = Convert.ToInt32(txtNewId.Text);
                entity.catename = txtNewName.Text;

                bool updateSuccess = categoryBLL.UpdateCategory(entity);

                if (updateSuccess)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadCategories();
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

        private void txtNewId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
