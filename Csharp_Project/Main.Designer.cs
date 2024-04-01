namespace Csharp_Project
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlMenu = new Panel();
            btnThoat = new Button();
            pbxKhachhang = new PictureBox();
            btnKhachhang = new Button();
            pbxBanhang = new PictureBox();
            pbxHoadon = new PictureBox();
            pbxDanhmuc = new PictureBox();
            pbxSanpham = new PictureBox();
            pbxTaikhoan = new PictureBox();
            btnDoithongtin = new Button();
            btnBanhang = new Button();
            btnHoadon = new Button();
            btnDanhmuc = new Button();
            btnSanPham = new Button();
            btnTaikhoan = new Button();
            btnDangXuat = new Button();
            pictureBox1 = new PictureBox();
            pnlInfo = new Panel();
            tableLayoutPanel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxKhachhang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBanhang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxHoadon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxDanhmuc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSanpham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxTaikhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.606432F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.39357F));
            tableLayoutPanel1.Controls.Add(pnlMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlInfo, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1306, 663);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(192, 255, 192);
            pnlMenu.Controls.Add(btnThoat);
            pnlMenu.Controls.Add(pbxKhachhang);
            pnlMenu.Controls.Add(btnKhachhang);
            pnlMenu.Controls.Add(pbxBanhang);
            pnlMenu.Controls.Add(pbxHoadon);
            pnlMenu.Controls.Add(pbxDanhmuc);
            pnlMenu.Controls.Add(pbxSanpham);
            pnlMenu.Controls.Add(pbxTaikhoan);
            pnlMenu.Controls.Add(btnDoithongtin);
            pnlMenu.Controls.Add(btnBanhang);
            pnlMenu.Controls.Add(btnHoadon);
            pnlMenu.Controls.Add(btnDanhmuc);
            pnlMenu.Controls.Add(btnSanPham);
            pnlMenu.Controls.Add(btnTaikhoan);
            pnlMenu.Controls.Add(btnDangXuat);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(3, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(237, 657);
            pnlMenu.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Honeydew;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Green;
            btnThoat.Location = new Point(9, 610);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(214, 44);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pbxKhachhang
            // 
            pbxKhachhang.Image = (Image)resources.GetObject("pbxKhachhang.Image");
            pbxKhachhang.Location = new Point(9, 185);
            pbxKhachhang.Name = "pbxKhachhang";
            pbxKhachhang.Size = new Size(49, 44);
            pbxKhachhang.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKhachhang.TabIndex = 14;
            pbxKhachhang.TabStop = false;
            // 
            // btnKhachhang
            // 
            btnKhachhang.BackColor = Color.Cornsilk;
            btnKhachhang.FlatStyle = FlatStyle.Flat;
            btnKhachhang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhachhang.ForeColor = Color.Green;
            btnKhachhang.Location = new Point(62, 185);
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.Size = new Size(161, 44);
            btnKhachhang.TabIndex = 1;
            btnKhachhang.Tag = "";
            btnKhachhang.Text = "Khách hàng";
            btnKhachhang.UseVisualStyleBackColor = false;
            btnKhachhang.Click += btnKhachhang_Click;
            // 
            // pbxBanhang
            // 
            pbxBanhang.Image = (Image)resources.GetObject("pbxBanhang.Image");
            pbxBanhang.Location = new Point(9, 436);
            pbxBanhang.Name = "pbxBanhang";
            pbxBanhang.Size = new Size(49, 44);
            pbxBanhang.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBanhang.TabIndex = 12;
            pbxBanhang.TabStop = false;
            // 
            // pbxHoadon
            // 
            pbxHoadon.Image = (Image)resources.GetObject("pbxHoadon.Image");
            pbxHoadon.Location = new Point(9, 373);
            pbxHoadon.Name = "pbxHoadon";
            pbxHoadon.Size = new Size(49, 44);
            pbxHoadon.SizeMode = PictureBoxSizeMode.Zoom;
            pbxHoadon.TabIndex = 11;
            pbxHoadon.TabStop = false;
            // 
            // pbxDanhmuc
            // 
            pbxDanhmuc.Image = (Image)resources.GetObject("pbxDanhmuc.Image");
            pbxDanhmuc.Location = new Point(9, 308);
            pbxDanhmuc.Name = "pbxDanhmuc";
            pbxDanhmuc.Size = new Size(49, 44);
            pbxDanhmuc.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDanhmuc.TabIndex = 10;
            pbxDanhmuc.TabStop = false;
            // 
            // pbxSanpham
            // 
            pbxSanpham.Image = (Image)resources.GetObject("pbxSanpham.Image");
            pbxSanpham.Location = new Point(9, 245);
            pbxSanpham.Name = "pbxSanpham";
            pbxSanpham.Size = new Size(49, 44);
            pbxSanpham.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSanpham.TabIndex = 9;
            pbxSanpham.TabStop = false;
            // 
            // pbxTaikhoan
            // 
            pbxTaikhoan.Image = (Image)resources.GetObject("pbxTaikhoan.Image");
            pbxTaikhoan.Location = new Point(9, 124);
            pbxTaikhoan.Name = "pbxTaikhoan";
            pbxTaikhoan.Size = new Size(49, 44);
            pbxTaikhoan.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTaikhoan.TabIndex = 8;
            pbxTaikhoan.TabStop = false;
            // 
            // btnDoithongtin
            // 
            btnDoithongtin.BackColor = Color.Honeydew;
            btnDoithongtin.FlatStyle = FlatStyle.Flat;
            btnDoithongtin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoithongtin.ForeColor = Color.Green;
            btnDoithongtin.Location = new Point(9, 499);
            btnDoithongtin.Name = "btnDoithongtin";
            btnDoithongtin.Size = new Size(214, 44);
            btnDoithongtin.TabIndex = 6;
            btnDoithongtin.Tag = "";
            btnDoithongtin.Text = "Đổi mật khẩu";
            btnDoithongtin.UseVisualStyleBackColor = false;
            // 
            // btnBanhang
            // 
            btnBanhang.BackColor = Color.Cornsilk;
            btnBanhang.FlatStyle = FlatStyle.Flat;
            btnBanhang.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBanhang.ForeColor = Color.Green;
            btnBanhang.Location = new Point(62, 436);
            btnBanhang.Name = "btnBanhang";
            btnBanhang.Size = new Size(161, 44);
            btnBanhang.TabIndex = 5;
            btnBanhang.Tag = "";
            btnBanhang.Text = "Bán hàng";
            btnBanhang.UseVisualStyleBackColor = false;
            btnBanhang.Click += btnBanhang_Click;
            // 
            // btnHoadon
            // 
            btnHoadon.BackColor = Color.Cornsilk;
            btnHoadon.FlatStyle = FlatStyle.Flat;
            btnHoadon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHoadon.ForeColor = Color.Green;
            btnHoadon.Location = new Point(62, 373);
            btnHoadon.Name = "btnHoadon";
            btnHoadon.Size = new Size(161, 44);
            btnHoadon.TabIndex = 4;
            btnHoadon.Tag = "";
            btnHoadon.Text = "Hoá đơn";
            btnHoadon.UseVisualStyleBackColor = false;
            btnHoadon.Click += btnHoadon_Click;
            // 
            // btnDanhmuc
            // 
            btnDanhmuc.BackColor = Color.Cornsilk;
            btnDanhmuc.FlatStyle = FlatStyle.Flat;
            btnDanhmuc.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDanhmuc.ForeColor = Color.Green;
            btnDanhmuc.Location = new Point(62, 308);
            btnDanhmuc.Name = "btnDanhmuc";
            btnDanhmuc.Size = new Size(161, 44);
            btnDanhmuc.TabIndex = 3;
            btnDanhmuc.Tag = "";
            btnDanhmuc.Text = "Danh mục";
            btnDanhmuc.UseMnemonic = false;
            btnDanhmuc.UseVisualStyleBackColor = false;
            btnDanhmuc.Click += btnDanhmuc_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Cornsilk;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSanPham.ForeColor = Color.Green;
            btnSanPham.Location = new Point(62, 245);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(161, 44);
            btnSanPham.TabIndex = 2;
            btnSanPham.Tag = "";
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnTaikhoan
            // 
            btnTaikhoan.BackColor = Color.Cornsilk;
            btnTaikhoan.FlatStyle = FlatStyle.Flat;
            btnTaikhoan.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaikhoan.ForeColor = Color.Green;
            btnTaikhoan.Location = new Point(62, 124);
            btnTaikhoan.Name = "btnTaikhoan";
            btnTaikhoan.Size = new Size(161, 44);
            btnTaikhoan.TabIndex = 0;
            btnTaikhoan.Tag = "";
            btnTaikhoan.Text = "Tài khoản";
            btnTaikhoan.UseVisualStyleBackColor = false;
            btnTaikhoan.Click += btnTaikhoan_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Honeydew;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Green;
            btnDangXuat.Location = new Point(9, 555);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(214, 44);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Tag = "";
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.Honeydew;
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(246, 3);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(1057, 657);
            pnlInfo.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 663);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            tableLayoutPanel1.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxKhachhang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBanhang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxHoadon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxDanhmuc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSanpham).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxTaikhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlMenu;
        private Panel pnlInfo;
        private PictureBox pictureBox1;
        private Button btnDangXuat;
        private Button btnTaikhoan;
        private Button btnDoithongtin;
        private Button btnBanhang;
        private Button btnHoadon;
        private Button btnDanhmuc;
        private Button btnSanPham;
        private PictureBox pbxBanhang;
        private PictureBox pbxHoadon;
        private PictureBox pbxDanhmuc;
        private PictureBox pbxSanpham;
        private PictureBox pbxTaikhoan;
        private PictureBox pbxKhachhang;
        private Button btnKhachhang;
        private Button btnThoat;
    }
}