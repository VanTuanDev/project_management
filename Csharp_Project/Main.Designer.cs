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
            btnExit = new Button();
            pbxKhachhang = new PictureBox();
            btnCustomer = new Button();
            pbxBanhang = new PictureBox();
            pbxHoadon = new PictureBox();
            pbxDanhmuc = new PictureBox();
            pbxSanpham = new PictureBox();
            pbxTaikhoan = new PictureBox();
            btnChangeinfo = new Button();
            btnSelling = new Button();
            btnBill = new Button();
            btnCategory = new Button();
            btnProduct = new Button();
            btnAccount = new Button();
            btnLogout = new Button();
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
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1493, 884);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(192, 255, 192);
            pnlMenu.Controls.Add(btnExit);
            pnlMenu.Controls.Add(pbxKhachhang);
            pnlMenu.Controls.Add(btnCustomer);
            pnlMenu.Controls.Add(pbxBanhang);
            pnlMenu.Controls.Add(pbxHoadon);
            pnlMenu.Controls.Add(pbxDanhmuc);
            pnlMenu.Controls.Add(pbxSanpham);
            pnlMenu.Controls.Add(pbxTaikhoan);
            pnlMenu.Controls.Add(btnChangeinfo);
            pnlMenu.Controls.Add(btnSelling);
            pnlMenu.Controls.Add(btnBill);
            pnlMenu.Controls.Add(btnCategory);
            pnlMenu.Controls.Add(btnProduct);
            pnlMenu.Controls.Add(btnAccount);
            pnlMenu.Controls.Add(btnLogout);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(3, 4);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(271, 876);
            pnlMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Honeydew;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Green;
            btnExit.Location = new Point(10, 813);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(245, 59);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnThoat_Click;
            // 
            // pbxKhachhang
            // 
            pbxKhachhang.Image = (Image)resources.GetObject("pbxKhachhang.Image");
            pbxKhachhang.Location = new Point(10, 247);
            pbxKhachhang.Margin = new Padding(3, 4, 3, 4);
            pbxKhachhang.Name = "pbxKhachhang";
            pbxKhachhang.Size = new Size(56, 59);
            pbxKhachhang.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKhachhang.TabIndex = 14;
            pbxKhachhang.TabStop = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Cornsilk;
            btnCustomer.Cursor = Cursors.Hand;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.ForeColor = Color.Green;
            btnCustomer.Location = new Point(71, 247);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(184, 59);
            btnCustomer.TabIndex = 1;
            btnCustomer.Tag = "";
            btnCustomer.Text = "Khách hàng";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnKhachhang_Click;
            // 
            // pbxBanhang
            // 
            pbxBanhang.Image = (Image)resources.GetObject("pbxBanhang.Image");
            pbxBanhang.Location = new Point(10, 581);
            pbxBanhang.Margin = new Padding(3, 4, 3, 4);
            pbxBanhang.Name = "pbxBanhang";
            pbxBanhang.Size = new Size(56, 59);
            pbxBanhang.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBanhang.TabIndex = 12;
            pbxBanhang.TabStop = false;
            // 
            // pbxHoadon
            // 
            pbxHoadon.Image = (Image)resources.GetObject("pbxHoadon.Image");
            pbxHoadon.Location = new Point(10, 497);
            pbxHoadon.Margin = new Padding(3, 4, 3, 4);
            pbxHoadon.Name = "pbxHoadon";
            pbxHoadon.Size = new Size(56, 59);
            pbxHoadon.SizeMode = PictureBoxSizeMode.Zoom;
            pbxHoadon.TabIndex = 11;
            pbxHoadon.TabStop = false;
            // 
            // pbxDanhmuc
            // 
            pbxDanhmuc.Image = (Image)resources.GetObject("pbxDanhmuc.Image");
            pbxDanhmuc.Location = new Point(10, 411);
            pbxDanhmuc.Margin = new Padding(3, 4, 3, 4);
            pbxDanhmuc.Name = "pbxDanhmuc";
            pbxDanhmuc.Size = new Size(56, 59);
            pbxDanhmuc.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDanhmuc.TabIndex = 10;
            pbxDanhmuc.TabStop = false;
            // 
            // pbxSanpham
            // 
            pbxSanpham.Image = (Image)resources.GetObject("pbxSanpham.Image");
            pbxSanpham.Location = new Point(10, 327);
            pbxSanpham.Margin = new Padding(3, 4, 3, 4);
            pbxSanpham.Name = "pbxSanpham";
            pbxSanpham.Size = new Size(56, 59);
            pbxSanpham.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSanpham.TabIndex = 9;
            pbxSanpham.TabStop = false;
            // 
            // pbxTaikhoan
            // 
            pbxTaikhoan.Image = (Image)resources.GetObject("pbxTaikhoan.Image");
            pbxTaikhoan.Location = new Point(10, 165);
            pbxTaikhoan.Margin = new Padding(3, 4, 3, 4);
            pbxTaikhoan.Name = "pbxTaikhoan";
            pbxTaikhoan.Size = new Size(56, 59);
            pbxTaikhoan.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTaikhoan.TabIndex = 8;
            pbxTaikhoan.TabStop = false;
            // 
            // btnChangeinfo
            // 
            btnChangeinfo.BackColor = Color.Honeydew;
            btnChangeinfo.Cursor = Cursors.Hand;
            btnChangeinfo.FlatStyle = FlatStyle.Flat;
            btnChangeinfo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangeinfo.ForeColor = Color.Green;
            btnChangeinfo.Location = new Point(10, 665);
            btnChangeinfo.Margin = new Padding(3, 4, 3, 4);
            btnChangeinfo.Name = "btnChangeinfo";
            btnChangeinfo.Size = new Size(245, 59);
            btnChangeinfo.TabIndex = 6;
            btnChangeinfo.Tag = "";
            btnChangeinfo.Text = "Đổi thông tin";
            btnChangeinfo.UseVisualStyleBackColor = false;
            btnChangeinfo.Click += btnChangeinfo_Click;
            // 
            // btnSelling
            // 
            btnSelling.BackColor = Color.Cornsilk;
            btnSelling.Cursor = Cursors.Hand;
            btnSelling.FlatStyle = FlatStyle.Flat;
            btnSelling.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelling.ForeColor = Color.Green;
            btnSelling.Location = new Point(71, 581);
            btnSelling.Margin = new Padding(3, 4, 3, 4);
            btnSelling.Name = "btnSelling";
            btnSelling.Size = new Size(184, 59);
            btnSelling.TabIndex = 5;
            btnSelling.Tag = "";
            btnSelling.Text = "Bán hàng";
            btnSelling.UseVisualStyleBackColor = false;
            btnSelling.Click += btnBanhang_Click;
            // 
            // btnBill
            // 
            btnBill.BackColor = Color.Cornsilk;
            btnBill.Cursor = Cursors.Hand;
            btnBill.FlatStyle = FlatStyle.Flat;
            btnBill.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBill.ForeColor = Color.Green;
            btnBill.Location = new Point(71, 497);
            btnBill.Margin = new Padding(3, 4, 3, 4);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(184, 59);
            btnBill.TabIndex = 4;
            btnBill.Tag = "";
            btnBill.Text = "Hoá đơn";
            btnBill.UseVisualStyleBackColor = false;
            btnBill.Click += btnHoadon_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Cornsilk;
            btnCategory.Cursor = Cursors.Hand;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategory.ForeColor = Color.Green;
            btnCategory.Location = new Point(71, 411);
            btnCategory.Margin = new Padding(3, 4, 3, 4);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(184, 59);
            btnCategory.TabIndex = 3;
            btnCategory.Tag = "";
            btnCategory.Text = "Danh mục";
            btnCategory.UseMnemonic = false;
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnDanhmuc_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Cornsilk;
            btnProduct.Cursor = Cursors.Hand;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.Green;
            btnProduct.Location = new Point(71, 327);
            btnProduct.Margin = new Padding(3, 4, 3, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(184, 59);
            btnProduct.TabIndex = 2;
            btnProduct.Tag = "";
            btnProduct.Text = "Sản phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnSanPham_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Cornsilk;
            btnAccount.Cursor = Cursors.Hand;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.Green;
            btnAccount.Location = new Point(71, 165);
            btnAccount.Margin = new Padding(3, 4, 3, 4);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(184, 59);
            btnAccount.TabIndex = 0;
            btnAccount.Tag = "";
            btnAccount.Text = "Tài khoản";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnTaikhoan_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Honeydew;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Green;
            btnLogout.Location = new Point(10, 740);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(245, 59);
            btnLogout.TabIndex = 7;
            btnLogout.Tag = "";
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnDangXuat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.Honeydew;
            pnlInfo.Dock = DockStyle.Fill;
            pnlInfo.Location = new Point(280, 4);
            pnlInfo.Margin = new Padding(3, 4, 3, 4);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(1210, 876);
            pnlInfo.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 884);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnLogout;
        private Button btnAccount;
        private Button btnChangeinfo;
        private Button btnSelling;
        private Button btnBill;
        private Button btnCategory;
        private Button btnProduct;
        private PictureBox pbxBanhang;
        private PictureBox pbxHoadon;
        private PictureBox pbxDanhmuc;
        private PictureBox pbxSanpham;
        private PictureBox pbxTaikhoan;
        private PictureBox pbxKhachhang;
        private Button btnCustomer;
        private Button btnExit;
    }
}