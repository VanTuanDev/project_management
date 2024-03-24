using BLL.Manager;
using System.Data;

namespace Csharp_Project.Staff
{
    public partial class ucFoodManage : UserControl
    {
        private FoodManager foodBLL;
        private bool isAdd = false;
        private bool isEdit = false;
        public ucFoodManage()
        {
            foodBLL = new FoodManager();
            InitializeComponent();
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
            txtNewCategory.Text = "";
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
            txtNewCategory.Visible = false;

            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;

            isAdd = false;
            isEdit = false;
        }

        private void ucFoodManage_Load(object sender, EventArgs e)
        {
            LoadFoods();
            Reset();
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
                txtCategory.Text = row.Cells["cl4"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgFood.CurrentRow;

            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int foodID = Convert.ToInt32(selectedRow.Cells["cl1"].Value);


            bool deleteSuccess = foodBLL.DeleteFood(foodID);

            if (deleteSuccess)
            {
                MessageBox.Show("Xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFoods();
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

            lblNewId.Visible = true;
            txtNewId.Visible = true;
            lblNewName.Visible = true;
            txtNewName.Visible = true;
            lblNewUnit.Visible = true;
            txtNewUnit.Visible = true;
            lblNewPrice.Visible = true;
            txtNewPrice.Visible = true;
            lblNewCategory.Visible = true;
            txtNewCategory.Visible = true;

            btnSave.Visible = true;
            btnCancel.Visible = true;

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

            lblNewId.Visible = true;
            txtNewId.Visible = true;
            lblNewName.Visible = true;
            txtNewName.Visible = true;
            lblNewUnit.Visible = true;
            txtNewUnit.Visible = true;
            lblNewPrice.Visible = true;
            txtNewPrice.Visible = true;
            lblNewCategory.Visible = true;
            txtNewCategory.Visible = true;

            btnSave.Visible = true;
            btnCancel.Visible = true;

            btnAdd.Enabled = false;
            txtNewId.ReadOnly = true;

            txtNewId.Text = txtId.Text;
            txtNewName.Text = txtName.Text;
            txtNewUnit.Text = txtUnit.Text;
            txtNewPrice.Text = txtPrice.Text;
            txtNewCategory.Text = txtCategory.Text; //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (string.IsNullOrEmpty(txtNewId.Text) || string.IsNullOrEmpty(txtNewName.Text) || string.IsNullOrEmpty(txtNewUnit.Text) || string.IsNullOrEmpty(txtNewPrice.Text) || string.IsNullOrEmpty(txtNewCategory.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int newId = Convert.ToInt32(txtNewId.Text);
                string newName = txtNewName.Text;
                string newUnit = txtNewUnit.Text;
                string newPrice = txtNewPrice.Text;
                int newCategory = Convert.ToInt32(txtNewCategory.Text);

                bool insertSuccess = foodBLL.InsertFood(newId, newName, newUnit, newPrice, newCategory);

                if (insertSuccess)
                {
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    LoadFoods();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (isEdit)
            {
                int id = Convert.ToInt32(txtNewId.Text);
                string newName = txtNewName.Text;
                string newUnit = txtNewUnit.Text;
                string newPrice = txtNewPrice.Text;
                int newCategory = Convert.ToInt32(txtNewCategory.Text);

                bool updateSuccess = foodBLL.UpdateFood(id, newName, newUnit, newPrice, newCategory);

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
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNewPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNewCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
