namespace Csharp_Project.Admin
{
    partial class ucAccountManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccountManager));
            panel6 = new Panel();
            dgAccount = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            cl4 = new DataGridViewTextBoxColumn();
            btnLuu = new Button();
            lblQuyenMoi = new Label();
            lblMatKhauMoi = new Label();
            panel5 = new Panel();
            lbltenmoi = new Label();
            txtTenmoi = new TextBox();
            lblten = new Label();
            txtTen = new TextBox();
            lblmkcu = new Label();
            txtmkcu = new TextBox();
            cbbQuyenMoi = new ComboBox();
            lblTaiKhoanMoi = new Label();
            txtTaiKhoanMoi = new TextBox();
            cbbQuyen = new ComboBox();
            lblTinhTrangMoi = new Label();
            txtTinhTrangMoi = new TextBox();
            btnHuy = new Button();
            txtMatKhauMoi = new TextBox();
            lblQuyen = new Label();
            ptbLogo = new PictureBox();
            lblTaiKhoan = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTaiKhoan = new TextBox();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAccount).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(dgAccount);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(674, 651);
            panel6.TabIndex = 1;
            // 
            // dgAccount
            // 
            dgAccount.AllowUserToAddRows = false;
            dgAccount.BackgroundColor = Color.Honeydew;
            dgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAccount.Columns.AddRange(new DataGridViewColumn[] { username, fullname, role, cl4 });
            dgAccount.Dock = DockStyle.Fill;
            dgAccount.Location = new Point(0, 0);
            dgAccount.Name = "dgAccount";
            dgAccount.ReadOnly = true;
            dgAccount.RowHeadersVisible = false;
            dgAccount.RowHeadersWidth = 51;
            dgAccount.RowTemplate.Height = 25;
            dgAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAccount.Size = new Size(674, 651);
            dgAccount.TabIndex = 0;
            dgAccount.CellClick += dgAccount_CellClick;
            // 
            // username
            // 
            username.DataPropertyName = "username";
            username.HeaderText = "Tên tài khoản";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.ReadOnly = true;
            username.Resizable = DataGridViewTriState.False;
            username.SortMode = DataGridViewColumnSortMode.NotSortable;
            username.Width = 200;
            // 
            // fullname
            // 
            fullname.DataPropertyName = "fullname";
            fullname.HeaderText = "Tên người dùng";
            fullname.MinimumWidth = 6;
            fullname.Name = "fullname";
            fullname.ReadOnly = true;
            fullname.Resizable = DataGridViewTriState.False;
            fullname.SortMode = DataGridViewColumnSortMode.NotSortable;
            fullname.Width = 230;
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.DataPropertyName = "rolename";
            role.HeaderText = "Quyền";
            role.MinimumWidth = 6;
            role.Name = "role";
            role.ReadOnly = true;
            role.Resizable = DataGridViewTriState.False;
            role.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl4
            // 
            cl4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl4.DataPropertyName = "status";
            cl4.HeaderText = "Trạng thái";
            cl4.MinimumWidth = 6;
            cl4.Name = "cl4";
            cl4.ReadOnly = true;
            cl4.Resizable = DataGridViewTriState.False;
            cl4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(128, 255, 128);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.Green;
            btnLuu.Location = new Point(54, 574);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 38);
            btnLuu.TabIndex = 12;
            btnLuu.Tag = "9";
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // lblQuyenMoi
            // 
            lblQuyenMoi.AutoSize = true;
            lblQuyenMoi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuyenMoi.ForeColor = Color.FromArgb(0, 64, 0);
            lblQuyenMoi.Location = new Point(3, 523);
            lblQuyenMoi.Name = "lblQuyenMoi";
            lblQuyenMoi.Size = new Size(106, 19);
            lblQuyenMoi.TabIndex = 17;
            lblQuyenMoi.Text = "Quyền mới :";
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhauMoi.ForeColor = Color.FromArgb(0, 64, 0);
            lblMatKhauMoi.Location = new Point(3, 493);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(131, 19);
            lblMatKhauMoi.TabIndex = 15;
            lblMatKhauMoi.Text = "Mật khẩu mới :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(lbltenmoi);
            panel5.Controls.Add(txtTenmoi);
            panel5.Controls.Add(lblten);
            panel5.Controls.Add(txtTen);
            panel5.Controls.Add(lblmkcu);
            panel5.Controls.Add(txtmkcu);
            panel5.Controls.Add(cbbQuyenMoi);
            panel5.Controls.Add(lblTaiKhoanMoi);
            panel5.Controls.Add(txtTaiKhoanMoi);
            panel5.Controls.Add(cbbQuyen);
            panel5.Controls.Add(lblTinhTrangMoi);
            panel5.Controls.Add(txtTinhTrangMoi);
            panel5.Controls.Add(btnHuy);
            panel5.Controls.Add(btnLuu);
            panel5.Controls.Add(lblQuyenMoi);
            panel5.Controls.Add(lblMatKhauMoi);
            panel5.Controls.Add(txtMatKhauMoi);
            panel5.Controls.Add(lblQuyen);
            panel5.Controls.Add(ptbLogo);
            panel5.Controls.Add(lblMatKhau);
            panel5.Controls.Add(lblTaiKhoan);
            panel5.Controls.Add(btnXoa);
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(txtMatKhau);
            panel5.Controls.Add(btnThem);
            panel5.Controls.Add(txtTaiKhoan);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(683, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 651);
            panel5.TabIndex = 0;
            // 
            // lbltenmoi
            // 
            lbltenmoi.AutoSize = true;
            lbltenmoi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltenmoi.ForeColor = Color.FromArgb(0, 64, 0);
            lbltenmoi.Location = new Point(3, 402);
            lbltenmoi.Name = "lbltenmoi";
            lbltenmoi.Size = new Size(147, 19);
            lbltenmoi.TabIndex = 41;
            lbltenmoi.Text = "Tên người dùng :";
            lbltenmoi.UseMnemonic = false;
            // 
            // txtTenmoi
            // 
            txtTenmoi.BorderStyle = BorderStyle.None;
            txtTenmoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenmoi.Location = new Point(156, 402);
            txtTenmoi.Name = "txtTenmoi";
            txtTenmoi.Size = new Size(198, 20);
            txtTenmoi.TabIndex = 7;
            txtTenmoi.Tag = "0";
            // 
            // lblten
            // 
            lblten.AutoSize = true;
            lblten.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblten.ForeColor = Color.FromArgb(0, 64, 0);
            lblten.Location = new Point(3, 208);
            lblten.Name = "lblten";
            lblten.Size = new Size(147, 19);
            lblten.TabIndex = 1;
            lblten.Text = "Tên người dùng :";
            lblten.UseMnemonic = false;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(156, 208);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(198, 20);
            txtTen.TabIndex = 1;
            txtTen.Tag = "0";
            // 
            // lblmkcu
            // 
            lblmkcu.AutoSize = true;
            lblmkcu.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblmkcu.ForeColor = Color.FromArgb(0, 64, 0);
            lblmkcu.Location = new Point(3, 461);
            lblmkcu.Name = "lblmkcu";
            lblmkcu.Size = new Size(119, 19);
            lblmkcu.TabIndex = 37;
            lblmkcu.Text = "Mật khẩu cũ :";
            // 
            // txtmkcu
            // 
            txtmkcu.BorderStyle = BorderStyle.None;
            txtmkcu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmkcu.Location = new Point(156, 461);
            txtmkcu.Name = "txtmkcu";
            txtmkcu.Size = new Size(199, 20);
            txtmkcu.TabIndex = 9;
            txtmkcu.Tag = "7";
            // 
            // cbbQuyenMoi
            // 
            cbbQuyenMoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbQuyenMoi.FormattingEnabled = true;
            cbbQuyenMoi.Location = new Point(156, 523);
            cbbQuyenMoi.Margin = new Padding(3, 2, 3, 2);
            cbbQuyenMoi.Name = "cbbQuyenMoi";
            cbbQuyenMoi.Size = new Size(198, 27);
            cbbQuyenMoi.TabIndex = 11;
            cbbQuyenMoi.Tag = "8";
            // 
            // lblTaiKhoanMoi
            // 
            lblTaiKhoanMoi.AutoSize = true;
            lblTaiKhoanMoi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaiKhoanMoi.ForeColor = Color.FromArgb(0, 64, 0);
            lblTaiKhoanMoi.Location = new Point(3, 374);
            lblTaiKhoanMoi.Name = "lblTaiKhoanMoi";
            lblTaiKhoanMoi.Size = new Size(101, 19);
            lblTaiKhoanMoi.TabIndex = 34;
            lblTaiKhoanMoi.Text = "Tài khoản :";
            lblTaiKhoanMoi.UseMnemonic = false;
            // 
            // txtTaiKhoanMoi
            // 
            txtTaiKhoanMoi.BorderStyle = BorderStyle.None;
            txtTaiKhoanMoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoanMoi.Location = new Point(156, 374);
            txtTaiKhoanMoi.Name = "txtTaiKhoanMoi";
            txtTaiKhoanMoi.ReadOnly = true;
            txtTaiKhoanMoi.Size = new Size(199, 20);
            txtTaiKhoanMoi.TabIndex = 33;
            txtTaiKhoanMoi.Tag = "0";
            // 
            // cbbQuyen
            // 
            cbbQuyen.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbQuyen.FormattingEnabled = true;
            cbbQuyen.Location = new Point(156, 268);
            cbbQuyen.Margin = new Padding(3, 2, 3, 2);
            cbbQuyen.Name = "cbbQuyen";
            cbbQuyen.Size = new Size(198, 27);
            cbbQuyen.TabIndex = 3;
            cbbQuyen.Tag = "8";
            // 
            // lblTinhTrangMoi
            // 
            lblTinhTrangMoi.AutoSize = true;
            lblTinhTrangMoi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTinhTrangMoi.ForeColor = Color.FromArgb(0, 64, 0);
            lblTinhTrangMoi.Location = new Point(3, 430);
            lblTinhTrangMoi.Name = "lblTinhTrangMoi";
            lblTinhTrangMoi.Size = new Size(110, 19);
            lblTinhTrangMoi.TabIndex = 21;
            lblTinhTrangMoi.Text = "Tình trạng : ";
            // 
            // txtTinhTrangMoi
            // 
            txtTinhTrangMoi.BorderStyle = BorderStyle.None;
            txtTinhTrangMoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTinhTrangMoi.Location = new Point(156, 430);
            txtTinhTrangMoi.Name = "txtTinhTrangMoi";
            txtTinhTrangMoi.Size = new Size(199, 20);
            txtTinhTrangMoi.TabIndex = 8;
            txtTinhTrangMoi.Tag = "6";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(128, 255, 128);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Green;
            btnHuy.Location = new Point(200, 574);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(116, 38);
            btnHuy.TabIndex = 13;
            btnHuy.Tag = "10";
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.BorderStyle = BorderStyle.None;
            txtMatKhauMoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauMoi.Location = new Point(156, 493);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(199, 20);
            txtMatKhauMoi.TabIndex = 10;
            txtMatKhauMoi.Tag = "7";
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuyen.ForeColor = Color.FromArgb(0, 64, 0);
            lblQuyen.Location = new Point(3, 268);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(71, 19);
            lblQuyen.TabIndex = 11;
            lblQuyen.Text = "Quyền :";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(105, 65);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(165, 90);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 9;
            ptbLogo.TabStop = false;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTaiKhoan.ForeColor = Color.FromArgb(0, 64, 0);
            lblTaiKhoan.Location = new Point(3, 178);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(101, 19);
            lblTaiKhoan.TabIndex = 6;
            lblTaiKhoan.Text = "Tài khoản :";
            lblTaiKhoan.UseMnemonic = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(128, 255, 128);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Green;
            btnXoa.Location = new Point(247, 316);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(116, 38);
            btnXoa.TabIndex = 6;
            btnXoa.Tag = "5";
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Green;
            btnSua.Location = new Point(125, 316);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 38);
            btnSua.TabIndex = 5;
            btnSua.Tag = "4";
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 255, 128);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(3, 316);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 38);
            btnThem.TabIndex = 4;
            btnThem.Tag = "3";
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.Location = new Point(156, 178);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(198, 20);
            txtTaiKhoan.TabIndex = 0;
            txtTaiKhoan.Tag = "0";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 657);
            panel4.Name = "panel4";
            panel4.Size = new Size(1057, 0);
            panel4.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Cornsilk;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1057, 0);
            dataGridView2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1057, 0);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 657);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 0);
            panel2.TabIndex = 9;
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
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1057, 657);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(156, 238);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(198, 20);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.Tag = "1";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatKhau.ForeColor = Color.FromArgb(0, 64, 0);
            lblMatKhau.Location = new Point(3, 238);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(96, 19);
            lblMatKhau.TabIndex = 7;
            lblMatKhau.Text = "Mật khẩu :";
            // 
            // ucAccountManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Name = "ucAccountManager";
            Size = new Size(1057, 657);
            Load += ucAccountManage_Load;
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgAccount).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private DataGridView dgAccount;
        private Button btnLuu;
        private Label lblQuyenMoi;
        private Label lblMatKhauMoi;
        private Panel panel5;
        private TextBox txtMatKhauMoi;
        private Label lblQuyen;
        private PictureBox ptbLogo;
        private Label lblTaiKhoan;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTaiKhoan;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnHuy;
        private Label lblTinhTrangMoi;
        private TextBox txtTinhTrangMoi;
        private ComboBox cbbQuyen;
        private Label lblTaiKhoanMoi;
        private TextBox txtTaiKhoanMoi;
        private ComboBox cbbQuyenMoi;
        private DataGridViewTextBoxColumn status;
        private Label lblmkcu;
        private TextBox txtmkcu;
        private Label lbltenmoi;
        private TextBox txtTenmoi;
        private Label lblten;
        private TextBox txtTen;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn cl4;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
    }
}
