namespace Csharp_Project.Staff
{
    partial class ucCategoryManager
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCategoryManager));
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            btnCancel = new Button();
            lblNewId = new Label();
            txtNewId = new TextBox();
            btnSave = new Button();
            lblNewName = new Label();
            txtNewName = new TextBox();
            ptbLogo = new PictureBox();
            lblName = new Label();
            lblId = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            txtName = new TextBox();
            btnAdd = new Button();
            txtId = new TextBox();
            panel6 = new Panel();
            dgCategory = new DataGridView();
            cl1 = new DataGridViewTextBoxColumn();
            cl2 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategory).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 876);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1208, 0);
            panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1208, 0);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Cornsilk;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1208, 876);
            dataGridView2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.41441F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5855865F));
            tableLayoutPanel3.Controls.Add(panel5, 1, 0);
            tableLayoutPanel3.Controls.Add(panel6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1208, 876);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(lblNewId);
            panel5.Controls.Add(txtNewId);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(lblNewName);
            panel5.Controls.Add(txtNewName);
            panel5.Controls.Add(ptbLogo);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(lblId);
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnEdit);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(txtId);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(781, 4);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(424, 868);
            panel5.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Green;
            btnCancel.Location = new Point(256, 659);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 51);
            btnCancel.TabIndex = 7;
            btnCancel.Tag = "4";
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNewId
            // 
            lblNewId.AutoSize = true;
            lblNewId.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewId.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewId.Location = new Point(3, 529);
            lblNewId.Name = "lblNewId";
            lblNewId.Size = new Size(159, 24);
            lblNewId.TabIndex = 21;
            lblNewId.Text = "Mã danh mục :";
            lblNewId.UseMnemonic = false;
            // 
            // txtNewId
            // 
            txtNewId.BorderStyle = BorderStyle.None;
            txtNewId.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewId.Location = new Point(203, 529);
            txtNewId.Margin = new Padding(3, 4, 3, 4);
            txtNewId.Name = "txtNewId";
            txtNewId.Size = new Size(201, 25);
            txtNewId.TabIndex = 4;
            txtNewId.Tag = "0";
            txtNewId.KeyPress += txtNewId_KeyPress;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(54, 659);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 51);
            btnSave.TabIndex = 6;
            btnSave.Tag = "4";
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewName.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewName.Location = new Point(3, 569);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(166, 24);
            lblNewName.TabIndex = 13;
            lblNewName.Text = "Tên danh mục :";
            // 
            // txtNewName
            // 
            txtNewName.BorderStyle = BorderStyle.None;
            txtNewName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(203, 569);
            txtNewName.Margin = new Padding(3, 4, 3, 4);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(201, 25);
            txtNewName.TabIndex = 5;
            txtNewName.Tag = "1";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(127, 50);
            ptbLogo.Margin = new Padding(3, 4, 3, 4);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(189, 120);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 9;
            ptbLogo.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(0, 64, 0);
            lblName.Location = new Point(3, 299);
            lblName.Name = "lblName";
            lblName.Size = new Size(166, 24);
            lblName.TabIndex = 7;
            lblName.Text = "Tên danh mục :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.FromArgb(0, 64, 0);
            lblId.Location = new Point(3, 259);
            lblId.Name = "lblId";
            lblId.Size = new Size(159, 24);
            lblId.TabIndex = 6;
            lblId.Text = "Mã danh mục :";
            lblId.UseMnemonic = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Green;
            btnDelete.Location = new Point(282, 413);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 51);
            btnDelete.TabIndex = 3;
            btnDelete.Tag = "5";
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(128, 255, 128);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Green;
            btnEdit.Location = new Point(143, 413);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 51);
            btnEdit.TabIndex = 2;
            btnEdit.Tag = "4";
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(203, 299);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(201, 25);
            txtName.TabIndex = 2;
            txtName.Tag = "1";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(3, 413);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 51);
            btnAdd.TabIndex = 1;
            btnAdd.Tag = "3";
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.None;
            txtId.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(203, 259);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(201, 25);
            txtId.TabIndex = 0;
            txtId.Tag = "0";
            // 
            // panel6
            // 
            panel6.Controls.Add(dgCategory);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 4);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(772, 868);
            panel6.TabIndex = 1;
            // 
            // dgCategory
            // 
            dgCategory.AllowUserToAddRows = false;
            dgCategory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgCategory.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgCategory.ColumnHeadersHeight = 35;
            dgCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgCategory.Columns.AddRange(new DataGridViewColumn[] { cl1, cl2 });
            dgCategory.Dock = DockStyle.Fill;
            dgCategory.Location = new Point(0, 0);
            dgCategory.Margin = new Padding(3, 4, 3, 4);
            dgCategory.Name = "dgCategory";
            dgCategory.ReadOnly = true;
            dgCategory.RowHeadersVisible = false;
            dgCategory.RowHeadersWidth = 60;
            dgCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgCategory.RowTemplate.Height = 25;
            dgCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCategory.Size = new Size(772, 868);
            dgCategory.TabIndex = 0;
            dgCategory.CellClick += dgCategory_CellClick;
            // 
            // cl1
            // 
            cl1.DataPropertyName = "id";
            cl1.HeaderText = "Mã danh mục";
            cl1.MinimumWidth = 6;
            cl1.Name = "cl1";
            cl1.ReadOnly = true;
            cl1.Resizable = DataGridViewTriState.False;
            cl1.Width = 185;
            // 
            // cl2
            // 
            cl2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl2.DataPropertyName = "catename";
            cl2.HeaderText = "Tên danh mục";
            cl2.MinimumWidth = 6;
            cl2.Name = "cl2";
            cl2.ReadOnly = true;
            cl2.Resizable = DataGridViewTriState.False;
            cl2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1208, 876);
            panel4.TabIndex = 8;
            // 
            // ucCategoryManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucCategoryManager";
            Size = new Size(1208, 876);
            Load += ucCategoryManage_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgCategory).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Button btnSave;
        private Label lblNewName;
        private TextBox txtNewName;
        private PictureBox ptbLogo;
        private Label lblName;
        private Label lblId;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtName;
        private Button btnAdd;
        private TextBox txtId;
        private Panel panel6;
        private DataGridView dgCategory;
        private Panel panel4;
        private Label lblNewId;
        private TextBox txtNewId;
        private Button btnCancel;
        private DataGridViewTextBoxColumn cl1;
        private DataGridViewTextBoxColumn cl2;
    }
}
