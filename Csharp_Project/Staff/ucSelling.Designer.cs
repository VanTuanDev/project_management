namespace Csharp_Project.Staff
{
    partial class ucSelling
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
            dgSanPham = new DataGridView();
            cl1 = new DataGridViewTextBoxColumn();
            cl2 = new DataGridViewTextBoxColumn();
            cl3 = new DataGridViewTextBoxColumn();
            cl4 = new DataGridViewTextBoxColumn();
            cl5 = new DataGridViewTextBoxColumn();
            cl6 = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            cbbDanhMuc = new ComboBox();
            panel5 = new Panel();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            lblTongTien = new Label();
            s = new Button();
            dgSPDuocChon = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            column2 = new DataGridViewTextBoxColumn();
            column3 = new DataGridViewTextBoxColumn();
            column4 = new DataGridViewTextBoxColumn();
            btnChonKH = new Button();
            txtKhachHang = new TextBox();
            lblKhachHang = new Label();
            txtSanPham = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            lblDanhMuc = new Label();
            lblDanhSachDuocChon = new Label();
            lblSoLuong = new Label();
            lblSanPham = new Label();
            btnThanhToan = new Button();
            btnDatHang = new Button();
            txtSoLuong = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSanPham).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSPDuocChon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 876);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1381, 292);
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
            dataGridView2.Size = new Size(1381, 292);
            dataGridView2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgSanPham);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 4);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(822, 868);
            panel6.TabIndex = 1;
            // 
            // dgSanPham
            // 
            dgSanPham.AllowUserToAddRows = false;
            dgSanPham.BackgroundColor = Color.Honeydew;
            dgSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSanPham.Columns.AddRange(new DataGridViewColumn[] { cl1, cl2, cl3, cl4, cl5, cl6 });
            dgSanPham.Dock = DockStyle.Fill;
            dgSanPham.Location = new Point(0, 0);
            dgSanPham.Margin = new Padding(3, 5, 3, 5);
            dgSanPham.Name = "dgSanPham";
            dgSanPham.ReadOnly = true;
            dgSanPham.RowHeadersVisible = false;
            dgSanPham.RowHeadersWidth = 51;
            dgSanPham.RowTemplate.Height = 25;
            dgSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSanPham.Size = new Size(822, 868);
            dgSanPham.TabIndex = 0;
            dgSanPham.CellClick += dgSanPham_CellClick;
            // 
            // cl1
            // 
            cl1.DataPropertyName = "id";
            cl1.HeaderText = "Mã SP";
            cl1.MinimumWidth = 6;
            cl1.Name = "cl1";
            cl1.ReadOnly = true;
            cl1.Resizable = DataGridViewTriState.False;
            cl1.SortMode = DataGridViewColumnSortMode.NotSortable;
            cl1.Width = 80;
            // 
            // cl2
            // 
            cl2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl2.DataPropertyName = "name";
            cl2.HeaderText = "Tên sản phẩm";
            cl2.MinimumWidth = 6;
            cl2.Name = "cl2";
            cl2.ReadOnly = true;
            cl2.Resizable = DataGridViewTriState.False;
            cl2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl3
            // 
            cl3.DataPropertyName = "unit";
            cl3.HeaderText = "ĐVT";
            cl3.MinimumWidth = 6;
            cl3.Name = "cl3";
            cl3.ReadOnly = true;
            cl3.Resizable = DataGridViewTriState.False;
            cl3.SortMode = DataGridViewColumnSortMode.NotSortable;
            cl3.Width = 125;
            // 
            // cl4
            // 
            cl4.DataPropertyName = "price";
            cl4.HeaderText = "Đơn giá";
            cl4.MinimumWidth = 6;
            cl4.Name = "cl4";
            cl4.ReadOnly = true;
            cl4.Resizable = DataGridViewTriState.False;
            cl4.SortMode = DataGridViewColumnSortMode.NotSortable;
            cl4.Width = 130;
            // 
            // cl5
            // 
            cl5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl5.DataPropertyName = "catename";
            cl5.HeaderText = "Danh mục";
            cl5.MinimumWidth = 6;
            cl5.Name = "cl5";
            cl5.ReadOnly = true;
            cl5.Resizable = DataGridViewTriState.False;
            cl5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl6
            // 
            cl6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl6.DataPropertyName = "status";
            cl6.HeaderText = "Trạng thái";
            cl6.MinimumWidth = 6;
            cl6.Name = "cl6";
            cl6.ReadOnly = true;
            cl6.Resizable = DataGridViewTriState.False;
            cl6.SortMode = DataGridViewColumnSortMode.NotSortable;
            cl6.Visible = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(128, 255, 128);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Green;
            btnXoa.Location = new Point(186, 294);
            btnXoa.Margin = new Padding(3, 5, 3, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(122, 44);
            btnXoa.TabIndex = 13;
            btnXoa.Tag = "3";
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // cbbDanhMuc
            // 
            cbbDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDanhMuc.FlatStyle = FlatStyle.Flat;
            cbbDanhMuc.FormattingEnabled = true;
            cbbDanhMuc.Location = new Point(152, 77);
            cbbDanhMuc.Margin = new Padding(3, 5, 3, 5);
            cbbDanhMuc.Name = "cbbDanhMuc";
            cbbDanhMuc.Size = new Size(196, 28);
            cbbDanhMuc.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(txtDonGia);
            panel5.Controls.Add(lblDonGia);
            panel5.Controls.Add(lblTongTien);
            panel5.Controls.Add(s);
            panel5.Controls.Add(dgSPDuocChon);
            panel5.Controls.Add(btnChonKH);
            panel5.Controls.Add(txtKhachHang);
            panel5.Controls.Add(lblKhachHang);
            panel5.Controls.Add(txtSanPham);
            panel5.Controls.Add(btnCong);
            panel5.Controls.Add(btnTru);
            panel5.Controls.Add(btnXoa);
            panel5.Controls.Add(cbbDanhMuc);
            panel5.Controls.Add(lblDanhMuc);
            panel5.Controls.Add(lblDanhSachDuocChon);
            panel5.Controls.Add(lblSoLuong);
            panel5.Controls.Add(lblSanPham);
            panel5.Controls.Add(btnThanhToan);
            panel5.Controls.Add(btnDatHang);
            panel5.Controls.Add(txtSoLuong);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(831, 4);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(547, 868);
            panel5.TabIndex = 0;
            // 
            // txtDonGia
            // 
            txtDonGia.BorderStyle = BorderStyle.None;
            txtDonGia.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDonGia.Location = new Point(152, 179);
            txtDonGia.Margin = new Padding(3, 5, 3, 5);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(289, 25);
            txtDonGia.TabIndex = 25;
            txtDonGia.Tag = "0";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonGia.ForeColor = Color.FromArgb(0, 64, 0);
            lblDonGia.Location = new Point(3, 179);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(100, 24);
            lblDonGia.TabIndex = 24;
            lblDonGia.Text = "Đơn giá :";
            lblDonGia.UseMnemonic = false;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.ForeColor = Color.FromArgb(0, 64, 0);
            lblTongTien.Location = new Point(37, 355);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(0, 28);
            lblTongTien.TabIndex = 23;
            // 
            // s
            // 
            s.BackColor = Color.FromArgb(128, 255, 128);
            s.Cursor = Cursors.Hand;
            s.FlatStyle = FlatStyle.Flat;
            s.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            s.ForeColor = Color.Green;
            s.Location = new Point(368, 72);
            s.Margin = new Padding(3, 5, 3, 5);
            s.Name = "s";
            s.Size = new Size(72, 33);
            s.TabIndex = 22;
            s.Tag = "3";
            s.Text = "Lọc";
            s.UseVisualStyleBackColor = false;
            // 
            // dgSPDuocChon
            // 
            dgSPDuocChon.AllowUserToAddRows = false;
            dgSPDuocChon.BackgroundColor = Color.Honeydew;
            dgSPDuocChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSPDuocChon.Columns.AddRange(new DataGridViewColumn[] { column1, column2, column3, column4 });
            dgSPDuocChon.Dock = DockStyle.Bottom;
            dgSPDuocChon.Location = new Point(0, 415);
            dgSPDuocChon.Margin = new Padding(3, 4, 3, 4);
            dgSPDuocChon.Name = "dgSPDuocChon";
            dgSPDuocChon.ReadOnly = true;
            dgSPDuocChon.RowHeadersVisible = false;
            dgSPDuocChon.RowHeadersWidth = 51;
            dgSPDuocChon.RowTemplate.Height = 29;
            dgSPDuocChon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSPDuocChon.Size = new Size(547, 453);
            dgSPDuocChon.TabIndex = 20;
            dgSPDuocChon.RowsAdded += dgSPDuocChon_RowsAdded;
            // 
            // column1
            // 
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column1.DataPropertyName = "name";
            column1.HeaderText = "Tên sản phẩm";
            column1.MinimumWidth = 6;
            column1.Name = "column1";
            column1.ReadOnly = true;
            column1.Resizable = DataGridViewTriState.False;
            column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // column2
            // 
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column2.DataPropertyName = "quantity";
            column2.HeaderText = "SL";
            column2.MinimumWidth = 6;
            column2.Name = "column2";
            column2.ReadOnly = true;
            column2.Resizable = DataGridViewTriState.False;
            column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // column3
            // 
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column3.DataPropertyName = "price";
            column3.HeaderText = "Đơn giá";
            column3.MinimumWidth = 6;
            column3.Name = "column3";
            column3.ReadOnly = true;
            column3.Resizable = DataGridViewTriState.False;
            column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // column4
            // 
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column4.DataPropertyName = "total";
            column4.HeaderText = "Thành tiền";
            column4.MinimumWidth = 6;
            column4.Name = "column4";
            column4.ReadOnly = true;
            column4.Resizable = DataGridViewTriState.False;
            column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnChonKH
            // 
            btnChonKH.BackColor = Color.FromArgb(128, 255, 128);
            btnChonKH.Cursor = Cursors.Hand;
            btnChonKH.FlatStyle = FlatStyle.Flat;
            btnChonKH.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChonKH.ForeColor = Color.Green;
            btnChonKH.Location = new Point(369, 16);
            btnChonKH.Margin = new Padding(3, 5, 3, 5);
            btnChonKH.Name = "btnChonKH";
            btnChonKH.Size = new Size(72, 26);
            btnChonKH.TabIndex = 19;
            btnChonKH.Tag = "3";
            btnChonKH.Text = ". . .";
            btnChonKH.UseVisualStyleBackColor = false;
            btnChonKH.Click += btnChonKH_Click;
            // 
            // txtKhachHang
            // 
            txtKhachHang.BorderStyle = BorderStyle.None;
            txtKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKhachHang.Location = new Point(152, 17);
            txtKhachHang.Margin = new Padding(3, 5, 3, 5);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.ReadOnly = true;
            txtKhachHang.Size = new Size(196, 25);
            txtKhachHang.TabIndex = 18;
            txtKhachHang.Tag = "0";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKhachHang.ForeColor = Color.FromArgb(0, 64, 0);
            lblKhachHang.Location = new Point(3, 17);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(143, 24);
            lblKhachHang.TabIndex = 17;
            lblKhachHang.Text = "Khách hàng :";
            lblKhachHang.UseMnemonic = false;
            // 
            // txtSanPham
            // 
            txtSanPham.BorderStyle = BorderStyle.None;
            txtSanPham.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSanPham.Location = new Point(152, 133);
            txtSanPham.Margin = new Padding(3, 5, 3, 5);
            txtSanPham.Name = "txtSanPham";
            txtSanPham.ReadOnly = true;
            txtSanPham.Size = new Size(289, 25);
            txtSanPham.TabIndex = 16;
            txtSanPham.Tag = "0";
            // 
            // btnCong
            // 
            btnCong.BackColor = Color.FromArgb(128, 255, 128);
            btnCong.Cursor = Cursors.Hand;
            btnCong.FlatStyle = FlatStyle.Flat;
            btnCong.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCong.ForeColor = Color.Green;
            btnCong.Location = new Point(335, 227);
            btnCong.Margin = new Padding(3, 5, 3, 5);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(51, 47);
            btnCong.TabIndex = 15;
            btnCong.Tag = "3";
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = false;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.BackColor = Color.FromArgb(128, 255, 128);
            btnTru.Cursor = Cursors.Hand;
            btnTru.FlatStyle = FlatStyle.Flat;
            btnTru.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTru.ForeColor = Color.Green;
            btnTru.Location = new Point(136, 227);
            btnTru.Margin = new Padding(3, 5, 3, 5);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(51, 47);
            btnTru.TabIndex = 14;
            btnTru.Tag = "3";
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = false;
            btnTru.Click += btnTru_Click;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanhMuc.ForeColor = Color.FromArgb(0, 64, 0);
            lblDanhMuc.Location = new Point(3, 77);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(125, 24);
            lblDanhMuc.TabIndex = 11;
            lblDanhMuc.Text = "Danh mục :";
            // 
            // lblDanhSachDuocChon
            // 
            lblDanhSachDuocChon.AutoSize = true;
            lblDanhSachDuocChon.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanhSachDuocChon.ForeColor = Color.FromArgb(0, 64, 0);
            lblDanhSachDuocChon.Location = new Point(183, 387);
            lblDanhSachDuocChon.Name = "lblDanhSachDuocChon";
            lblDanhSachDuocChon.Size = new Size(113, 24);
            lblDanhSachDuocChon.TabIndex = 9;
            lblDanhSachDuocChon.Text = "Giỏ hàng :";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoLuong.ForeColor = Color.FromArgb(0, 64, 0);
            lblSoLuong.Location = new Point(3, 229);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(112, 24);
            lblSoLuong.TabIndex = 7;
            lblSoLuong.Text = "Số lượng :";
            // 
            // lblSanPham
            // 
            lblSanPham.AutoSize = true;
            lblSanPham.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSanPham.ForeColor = Color.FromArgb(0, 64, 0);
            lblSanPham.Location = new Point(3, 133);
            lblSanPham.Name = "lblSanPham";
            lblSanPham.Size = new Size(124, 24);
            lblSanPham.TabIndex = 6;
            lblSanPham.Text = "Sản phẩm :";
            lblSanPham.UseMnemonic = false;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(128, 255, 128);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.ForeColor = Color.Green;
            btnThanhToan.Location = new Point(341, 294);
            btnThanhToan.Margin = new Padding(3, 5, 3, 5);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(129, 88);
            btnThanhToan.TabIndex = 5;
            btnThanhToan.Tag = "5";
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnDatHang
            // 
            btnDatHang.BackColor = Color.FromArgb(128, 255, 128);
            btnDatHang.Cursor = Cursors.Hand;
            btnDatHang.FlatStyle = FlatStyle.Flat;
            btnDatHang.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatHang.ForeColor = Color.Green;
            btnDatHang.Location = new Point(27, 294);
            btnDatHang.Margin = new Padding(3, 5, 3, 5);
            btnDatHang.Name = "btnDatHang";
            btnDatHang.Size = new Size(122, 44);
            btnDatHang.TabIndex = 1;
            btnDatHang.Tag = "3";
            btnDatHang.Text = "Thêm";
            btnDatHang.UseVisualStyleBackColor = false;
            btnDatHang.Click += btnDatHang_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.None;
            txtSoLuong.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(203, 233);
            txtSoLuong.Margin = new Padding(3, 5, 3, 5);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.ReadOnly = true;
            txtSoLuong.Size = new Size(118, 25);
            txtSoLuong.TabIndex = 0;
            txtSoLuong.Tag = "0";
            txtSoLuong.Text = "1";
            txtSoLuong.TextAlign = HorizontalAlignment.Center;
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
            dataGridView1.Size = new Size(1381, 292);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 876);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1381, 292);
            panel2.TabIndex = 12;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(panel5, 1, 0);
            tableLayoutPanel3.Controls.Add(panel6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1381, 876);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // ucSelling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucSelling";
            Size = new Size(1381, 1168);
            Load += ucSelling_Load;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgSanPham).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSPDuocChon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView dataGridView2;
        private Panel panel6;
        private DataGridView dgSanPham;
        private Button btnXoa;
        private ComboBox cbbDanhMuc;
        private Panel panel5;
        private Label lblDanhMuc;
        private Label lblDanhSachDuocChon;
        private Label lblSoLuong;
        private Label lblSanPham;
        private Button btnThanhToan;
        private Button btnDatHang;
        private TextBox txtSoLuong;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCong;
        private Button btnTru;
        private Button btnChonKH;
        private TextBox txtKhachHang;
        private Label lblKhachHang;
        private TextBox txtSanPham;
        private DataGridView dgSPDuocChon;
        private Button s;
        private Label lblTongTien;
        private DataGridViewTextBoxColumn cl1;
        private DataGridViewTextBoxColumn cl2;
        private DataGridViewTextBoxColumn cl3;
        private DataGridViewTextBoxColumn cl4;
        private DataGridViewTextBoxColumn cl5;
        private DataGridViewTextBoxColumn cl6;
        private TextBox txtDonGia;
        private Label lblDonGia;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn column2;
        private DataGridViewTextBoxColumn column3;
        private DataGridViewTextBoxColumn column4;
    }
}
