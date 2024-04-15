using BLL.Manager;
using System.Data;
using DAL.Entity;

namespace Csharp_Project.Staff
{
    public partial class ucProductManager : UserControl
    {

        ProductEntity entity = new ProductEntity();
        CategoryEntity entity2 = new CategoryEntity();
        private ProductManager foodBLL;
        private bool isAdd = false;
        private bool isEdit = false;
        public ucProductManager()
        {
            foodBLL = new ProductManager();
            InitializeComponent();
            dgFood.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgFood.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgFood.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgFood.DefaultCellStyle.SelectionForeColor = Color.White;

            dgFood.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12 , FontStyle.Bold);
            dgFood.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgFood.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;

            dgFood.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgFood.AllowUserToResizeRows = false;
            dgFood.AllowUserToResizeColumns = false;

            dgFood.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgFood.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void LoadFoods()
        {
            DataTable categories = foodBLL.GetFoods();
            dgFood.DataSource = categories;
        }
        private void Reset()
        {
            txtNewId.Text = "";
            txtNewName.Text = "";
            txtNewUnit.Text = "";
            txtNewPrice.Text = "";
            cbbCategory.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "";
            txtCategory.Text = "";

            lblNewId.Visible = false;
            txtNewId.Visible = false;
            lblNewName.Visible = false;
            txtNewName.Visible = false;
            lblNewUnit.Visible = false;
            txtNewUnit.Visible = false;
            lblNewPrice.Visible = false;
            txtNewPrice.Visible = false;
            lblNewCategory.Visible = false;
            cbbCategory.Visible = false;

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
            lblNewUnit.Visible = true;
            txtNewUnit.Visible = true;
            lblNewPrice.Visible = true;
            txtNewPrice.Visible = true;
            lblNewCategory.Visible = true;
            cbbCategory.Visible = true;
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }
        private void ucFoodManage_Load(object sender, EventArgs e)
        {
            LoadFoods();
            Reset();
            DataTable categoriesTable = foodBLL.GetCategories();

            cbbCategory.DataSource = categoriesTable;
            cbbCategory.DisplayMember = "catename";
            cbbCategory.ValueMember = "catename";
            cbbCategory.SelectedIndex = -1;
        }

        private void dgFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgFood.Rows.Count)
            {
                DataGridViewRow row = dgFood.Rows[e.RowIndex];
                txtId.Text = row.Cells["cl1"].Value.ToString();
                txtName.Text = row.Cells["cl2"].Value.ToString();
                txtUnit.Text = row.Cells["cl3"].Value.ToString();
                txtPrice.Text = row.Cells["cl4"].Value.ToString();
                txtCategory.Text = row.Cells["cl5"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                DataGridViewRow selectedRow = dgFood.CurrentRow;

                entity.id = Convert.ToInt32(selectedRow.Cells["cl1"].Value);

                bool deleteSuccess = foodBLL.DeleteFood(entity);

                if (deleteSuccess)
                {
                    MessageBox.Show("Xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFoods();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Không thể xóa dòng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtUnit.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtCategory.Text))
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
            txtNewUnit.Text = txtUnit.Text;
            txtNewPrice.Text = txtPrice.Text;
            cbbCategory.Text = txtCategory.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (string.IsNullOrEmpty(txtNewId.Text) || string.IsNullOrEmpty(txtNewName.Text) || string.IsNullOrEmpty(txtNewUnit.Text) || string.IsNullOrEmpty(txtNewPrice.Text) || string.IsNullOrEmpty(cbbCategory.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                entity.id = Convert.ToInt32(txtNewId.Text);
                entity.name = txtNewName.Text;
                entity.unit = txtNewUnit.Text;
                entity.price = Convert.ToInt32(txtNewPrice.Text);
                entity2.catename = cbbCategory.Text;
                entity.cateid = foodBLL.GetCategoryIdByName(entity2);
                string error = string.Empty;
                bool insertSuccess = foodBLL.InsertFood(entity, ref error);

                if (insertSuccess)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadFoods();
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (isEdit)
            {
                entity.id = Convert.ToInt32(txtNewId.Text);
                entity.name = txtNewName.Text;
                entity.unit = txtNewUnit.Text;
                entity.price = Convert.ToInt32(txtNewPrice.Text);
                entity2.catename = cbbCategory.Text;
                entity.cateid = foodBLL.GetCategoryIdByName(entity2);

                bool updateSuccess = foodBLL.UpdateFood(entity);

                if (updateSuccess)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadFoods();
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
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNewPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
