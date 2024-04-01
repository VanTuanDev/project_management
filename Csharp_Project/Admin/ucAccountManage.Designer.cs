namespace Csharp_Project.Admin
{
    partial class ucAccountManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAccountManage));
            panel6 = new Panel();
            dgAccount = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            pwd = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            btnLuu = new Button();
            lblquyenmoi = new Label();
            lblmkmoi = new Label();
            panel5 = new Panel();
            cbbQuyenmoi = new ComboBox();
            lbltksua = new Label();
            txttksua = new TextBox();
            cbbQuyen = new ComboBox();
            lblTinhTrang = new Label();
            txtTinhTrang = new TextBox();
            btnHuy = new Button();
            txtmkmoi = new TextBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            txtMatkhau = new TextBox();
            btnThem = new Button();
            txtTaikhoan = new TextBox();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAccount).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            dgAccount.Columns.AddRange(new DataGridViewColumn[] { username, pwd, role, status });
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
            username.HeaderText = "Tài khoản";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // pwd
            // 
            pwd.DataPropertyName = "pwd";
            pwd.HeaderText = "Mật khẩu";
            pwd.Name = "pwd";
            pwd.ReadOnly = true;
            // 
            // role
            // 
            role.DataPropertyName = "rolename";
            role.HeaderText = "Quyền";
            role.Name = "role";
            role.ReadOnly = true;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Tình Trạng";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(128, 255, 128);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.Green;
            btnLuu.Location = new Point(61, 535);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 38);
            btnLuu.TabIndex = 18;
            btnLuu.Tag = "9";
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // lblquyenmoi
            // 
            lblquyenmoi.AutoSize = true;
            lblquyenmoi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblquyenmoi.ForeColor = Color.FromArgb(0, 64, 0);
            lblquyenmoi.Location = new Point(3, 470);
            lblquyenmoi.Name = "lblquyenmoi";
            lblquyenmoi.Size = new Size(106, 19);
            lblquyenmoi.TabIndex = 17;
            lblquyenmoi.Text = "Quyền mới :";
            // 
            // lblmkmoi
            // 
            lblmkmoi.AutoSize = true;
            lblmkmoi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblmkmoi.ForeColor = Color.FromArgb(0, 64, 0);
            lblmkmoi.Location = new Point(3, 440);
            lblmkmoi.Name = "lblmkmoi";
            lblmkmoi.Size = new Size(131, 19);
            lblmkmoi.TabIndex = 15;
            lblmkmoi.Text = "Mật khẩu mới :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(cbbQuyenmoi);
            panel5.Controls.Add(lbltksua);
            panel5.Controls.Add(txttksua);
            panel5.Controls.Add(cbbQuyen);
            panel5.Controls.Add(lblTinhTrang);
            panel5.Controls.Add(txtTinhTrang);
            panel5.Controls.Add(btnHuy);
            panel5.Controls.Add(btnLuu);
            panel5.Controls.Add(lblquyenmoi);
            panel5.Controls.Add(lblmkmoi);
            panel5.Controls.Add(txtmkmoi);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(btnXoa);
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(txtMatkhau);
            panel5.Controls.Add(btnThem);
            panel5.Controls.Add(txtTaikhoan);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(683, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 651);
            panel5.TabIndex = 0;
            // 
            // cbbQuyenmoi
            // 
            cbbQuyenmoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbQuyenmoi.FormattingEnabled = true;
            cbbQuyenmoi.Location = new Point(139, 470);
            cbbQuyenmoi.Margin = new Padding(3, 2, 3, 2);
            cbbQuyenmoi.Name = "cbbQuyenmoi";
            cbbQuyenmoi.Size = new Size(215, 27);
            cbbQuyenmoi.TabIndex = 35;
            cbbQuyenmoi.Tag = "8";
            // 
            // lbltksua
            // 
            lbltksua.AutoSize = true;
            lbltksua.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltksua.ForeColor = Color.FromArgb(0, 64, 0);
            lbltksua.Location = new Point(3, 377);
            lbltksua.Name = "lbltksua";
            lbltksua.Size = new Size(101, 19);
            lbltksua.TabIndex = 34;
            lbltksua.Text = "Tài khoản :";
            lbltksua.UseMnemonic = false;
            // 
            // txttksua
            // 
            txttksua.BorderStyle = BorderStyle.None;
            txttksua.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttksua.Location = new Point(139, 377);
            txttksua.Name = "txttksua";
            txttksua.ReadOnly = true;
            txttksua.Size = new Size(215, 20);
            txttksua.TabIndex = 33;
            txttksua.Tag = "0";
            // 
            // cbbQuyen
            // 
            cbbQuyen.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbQuyen.FormattingEnabled = true;
            cbbQuyen.Location = new Point(136, 253);
            cbbQuyen.Margin = new Padding(3, 2, 3, 2);
            cbbQuyen.Name = "cbbQuyen";
            cbbQuyen.Size = new Size(218, 27);
            cbbQuyen.TabIndex = 32;
            cbbQuyen.Tag = "8";
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTinhTrang.ForeColor = Color.FromArgb(0, 64, 0);
            lblTinhTrang.Location = new Point(3, 409);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(110, 19);
            lblTinhTrang.TabIndex = 21;
            lblTinhTrang.Text = "Tình trạng : ";
            // 
            // txtTinhTrang
            // 
            txtTinhTrang.BorderStyle = BorderStyle.None;
            txtTinhTrang.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTinhTrang.Location = new Point(139, 409);
            txtTinhTrang.Name = "txtTinhTrang";
            txtTinhTrang.Size = new Size(215, 20);
            txtTinhTrang.TabIndex = 20;
            txtTinhTrang.Tag = "6";
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(128, 255, 128);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Green;
            btnHuy.Location = new Point(207, 535);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(116, 38);
            btnHuy.TabIndex = 19;
            btnHuy.Tag = "10";
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtmkmoi
            // 
            txtmkmoi.BorderStyle = BorderStyle.None;
            txtmkmoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmkmoi.Location = new Point(139, 440);
            txtmkmoi.Name = "txtmkmoi";
            txtmkmoi.Size = new Size(215, 20);
            txtmkmoi.TabIndex = 13;
            txtmkmoi.Tag = "7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(3, 253);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 11;
            label1.Text = "Quyền :";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(105, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(3, 223);
            label8.Name = "label8";
            label8.Size = new Size(96, 19);
            label8.TabIndex = 7;
            label8.Text = "Mật khẩu :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(3, 194);
            label9.Name = "label9";
            label9.Size = new Size(101, 19);
            label9.TabIndex = 6;
            label9.Text = "Tài khoản :";
            label9.UseMnemonic = false;
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
            btnXoa.TabIndex = 5;
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
            btnSua.TabIndex = 4;
            btnSua.Tag = "4";
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtMatkhau
            // 
            txtMatkhau.BorderStyle = BorderStyle.None;
            txtMatkhau.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatkhau.Location = new Point(136, 223);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(218, 20);
            txtMatkhau.TabIndex = 2;
            txtMatkhau.Tag = "1";
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
            btnThem.TabIndex = 1;
            btnThem.Tag = "3";
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.BorderStyle = BorderStyle.None;
            txtTaikhoan.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaikhoan.Location = new Point(136, 194);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(218, 20);
            txtTaikhoan.TabIndex = 0;
            txtTaikhoan.Tag = "0";
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
            // ucAccountManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Name = "ucAccountManage";
            Size = new Size(1057, 657);
            Load += ucAccountManage_Load;
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgAccount).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label lblquyenmoi;
        private Label lblmkmoi;
        private Panel panel5;
        private TextBox txtmkmoi;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label8;
        private Label label9;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtMatkhau;
        private Button btnThem;
        private TextBox txtTaikhoan;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnHuy;
        private Label lblTinhTrang;
        private TextBox txtTinhTrang;
        private ComboBox cbbQuyen;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn pwd;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn status;
        private Label lbltksua;
        private TextBox txttksua;
        private ComboBox cbbQuyenmoi;
    }
}
