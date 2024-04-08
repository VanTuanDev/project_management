namespace Csharp_Project.Staff
{
    partial class ucCustomerManager
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
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            panel6 = new Panel();
            dgClient = new DataGridView();
            cl1 = new DataGridViewTextBoxColumn();
            cl2 = new DataGridViewTextBoxColumn();
            cl3 = new DataGridViewTextBoxColumn();
            cl4 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            pictureBox3 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            lblNewPhone = new Label();
            txtNewPhone = new TextBox();
            lblNewAddress = new Label();
            txtNewAddress = new TextBox();
            lblNewName = new Label();
            lblNewId = new Label();
            txtNewName = new TextBox();
            txtNewId = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            btnCancel = new Button();
            lblName = new Label();
            lblId = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            txtName = new TextBox();
            btnAdd = new Button();
            txtId = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 876);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1208, 0);
            panel4.TabIndex = 11;
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
            dataGridView2.Size = new Size(1208, 0);
            dataGridView2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgClient);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 4);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(772, 868);
            panel6.TabIndex = 1;
            // 
            // dgClient
            // 
            dgClient.AllowUserToAddRows = false;
            dgClient.BackgroundColor = Color.FromArgb(192, 255, 192);
            dgClient.ColumnHeadersHeight = 35;
            dgClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgClient.Columns.AddRange(new DataGridViewColumn[] { cl1, cl2, cl3, cl4 });
            dgClient.Dock = DockStyle.Fill;
            dgClient.Location = new Point(0, 0);
            dgClient.Margin = new Padding(3, 4, 3, 4);
            dgClient.Name = "dgClient";
            dgClient.ReadOnly = true;
            dgClient.RowHeadersVisible = false;
            dgClient.RowHeadersWidth = 60;
            dgClient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgClient.RowTemplate.Height = 25;
            dgClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgClient.Size = new Size(772, 868);
            dgClient.TabIndex = 0;
            dgClient.CellClick += dgClient_CellClick;
            // 
            // cl1
            // 
            cl1.DataPropertyName = "id";
            cl1.HeaderText = "Mã KH";
            cl1.MinimumWidth = 6;
            cl1.Name = "cl1";
            cl1.ReadOnly = true;
            cl1.Resizable = DataGridViewTriState.False;
            cl1.Width = 130;
            // 
            // cl2
            // 
            cl2.DataPropertyName = "fullname";
            cl2.HeaderText = "Tên khách hàng";
            cl2.MinimumWidth = 6;
            cl2.Name = "cl2";
            cl2.ReadOnly = true;
            cl2.Resizable = DataGridViewTriState.False;
            cl2.Width = 215;
            // 
            // cl3
            // 
            cl3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl3.DataPropertyName = "address";
            cl3.HeaderText = "Địa chỉ";
            cl3.MinimumWidth = 6;
            cl3.Name = "cl3";
            cl3.ReadOnly = true;
            cl3.Resizable = DataGridViewTriState.False;
            cl3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl4
            // 
            cl4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl4.DataPropertyName = "phonenumber";
            cl4.HeaderText = "Số điện thoại";
            cl4.MinimumWidth = 6;
            cl4.Name = "cl4";
            cl4.ReadOnly = true;
            cl4.Resizable = DataGridViewTriState.False;
            cl4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(56, 669);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 51);
            btnSave.TabIndex = 8;
            btnSave.Tag = "4";
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Customer;
            pictureBox3.Location = new Point(120, 50);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
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
            tableLayoutPanel3.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(lblNewPhone);
            panel5.Controls.Add(txtNewPhone);
            panel5.Controls.Add(lblNewAddress);
            panel5.Controls.Add(txtNewAddress);
            panel5.Controls.Add(lblNewName);
            panel5.Controls.Add(lblNewId);
            panel5.Controls.Add(txtNewName);
            panel5.Controls.Add(txtNewId);
            panel5.Controls.Add(lblPhone);
            panel5.Controls.Add(txtPhone);
            panel5.Controls.Add(lblAddress);
            panel5.Controls.Add(txtAddress);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(pictureBox3);
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
            // lblNewPhone
            // 
            lblNewPhone.AutoSize = true;
            lblNewPhone.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewPhone.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewPhone.Location = new Point(3, 601);
            lblNewPhone.Name = "lblNewPhone";
            lblNewPhone.Size = new Size(155, 24);
            lblNewPhone.TabIndex = 34;
            lblNewPhone.Text = "Số điện thoại :";
            // 
            // txtNewPhone
            // 
            txtNewPhone.BorderStyle = BorderStyle.None;
            txtNewPhone.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPhone.Location = new Point(203, 601);
            txtNewPhone.Margin = new Padding(3, 4, 3, 4);
            txtNewPhone.Name = "txtNewPhone";
            txtNewPhone.Size = new Size(201, 25);
            txtNewPhone.TabIndex = 7;
            txtNewPhone.Tag = "1";
            txtNewPhone.KeyPress += txtNewPhone_KeyPress;
            // 
            // lblNewAddress
            // 
            lblNewAddress.AutoSize = true;
            lblNewAddress.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewAddress.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewAddress.Location = new Point(3, 561);
            lblNewAddress.Name = "lblNewAddress";
            lblNewAddress.Size = new Size(92, 24);
            lblNewAddress.TabIndex = 32;
            lblNewAddress.Text = "Địa chỉ :";
            // 
            // txtNewAddress
            // 
            txtNewAddress.BorderStyle = BorderStyle.None;
            txtNewAddress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewAddress.Location = new Point(203, 561);
            txtNewAddress.Margin = new Padding(3, 4, 3, 4);
            txtNewAddress.Name = "txtNewAddress";
            txtNewAddress.Size = new Size(201, 25);
            txtNewAddress.TabIndex = 6;
            txtNewAddress.Tag = "1";
            // 
            // lblNewName
            // 
            lblNewName.AutoSize = true;
            lblNewName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewName.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewName.Location = new Point(3, 521);
            lblNewName.Name = "lblNewName";
            lblNewName.Size = new Size(184, 24);
            lblNewName.TabIndex = 30;
            lblNewName.Text = "Tên khách hàng :";
            // 
            // lblNewId
            // 
            lblNewId.AutoSize = true;
            lblNewId.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewId.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewId.Location = new Point(3, 481);
            lblNewId.Name = "lblNewId";
            lblNewId.Size = new Size(177, 24);
            lblNewId.TabIndex = 29;
            lblNewId.Text = "Mã khách hàng :";
            lblNewId.UseMnemonic = false;
            // 
            // txtNewName
            // 
            txtNewName.BorderStyle = BorderStyle.None;
            txtNewName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(203, 521);
            txtNewName.Margin = new Padding(3, 4, 3, 4);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(201, 25);
            txtNewName.TabIndex = 5;
            txtNewName.Tag = "1";
            // 
            // txtNewId
            // 
            txtNewId.BorderStyle = BorderStyle.None;
            txtNewId.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewId.Location = new Point(203, 481);
            txtNewId.Margin = new Padding(3, 4, 3, 4);
            txtNewId.Name = "txtNewId";
            txtNewId.Size = new Size(201, 25);
            txtNewId.TabIndex = 4;
            txtNewId.Tag = "0";
            txtNewId.KeyPress += txtNewId_KeyPress;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.FromArgb(0, 64, 0);
            lblPhone.Location = new Point(3, 340);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(155, 24);
            lblPhone.TabIndex = 26;
            lblPhone.Text = "Số điện thoại :";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(203, 340);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(201, 25);
            txtPhone.TabIndex = 25;
            txtPhone.Tag = "1";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.FromArgb(0, 64, 0);
            lblAddress.Location = new Point(3, 300);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(92, 24);
            lblAddress.TabIndex = 24;
            lblAddress.Text = "Địa chỉ :";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(203, 300);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(201, 25);
            txtAddress.TabIndex = 23;
            txtAddress.Tag = "1";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Green;
            btnCancel.Location = new Point(225, 669);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 51);
            btnCancel.TabIndex = 9;
            btnCancel.Tag = "4";
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(0, 64, 0);
            lblName.Location = new Point(3, 260);
            lblName.Name = "lblName";
            lblName.Size = new Size(184, 24);
            lblName.TabIndex = 7;
            lblName.Text = "Tên khách hàng :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.FromArgb(0, 64, 0);
            lblId.Location = new Point(3, 220);
            lblId.Name = "lblId";
            lblId.Size = new Size(177, 24);
            lblId.TabIndex = 6;
            lblId.Text = "Mã khách hàng :";
            lblId.UseMnemonic = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 128);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Green;
            btnDelete.Location = new Point(282, 397);
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
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Green;
            btnEdit.Location = new Point(143, 397);
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
            txtName.Location = new Point(203, 260);
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
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(3, 397);
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
            txtId.Location = new Point(203, 220);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(201, 25);
            txtId.TabIndex = 0;
            txtId.Tag = "0";
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
            dataGridView1.Size = new Size(1208, 876);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1208, 876);
            panel2.TabIndex = 12;
            // 
            // ucCustomerManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucCustomerManager";
            Size = new Size(1208, 876);
            Load += ucClientManage_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView dataGridView2;
        private Panel panel6;
        private DataGridView dgClient;
        private Button btnSave;
        private TextBox txtTenmoi;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Label lblName;
        private Label lblId;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtName;
        private Button btnAdd;
        private TextBox txtId;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnCancel;
        private Label lblNewPhone;
        private TextBox txtNewPhone;
        private Label lblNewAddress;
        private TextBox txtNewAddress;
        private Label lblNewName;
        private Label lblNewId;
        private TextBox txtNewName;
        private TextBox txtNewId;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private DataGridViewTextBoxColumn cl1;
        private DataGridViewTextBoxColumn cl2;
        private DataGridViewTextBoxColumn cl3;
        private DataGridViewTextBoxColumn cl4;
    }
}
