namespace Csharp_Project
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtTaikhoan = new TextBox();
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtMatkhau = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.BackColor = Color.Honeydew;
            txtTaikhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaikhoan.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTaikhoan.ForeColor = Color.Green;
            txtTaikhoan.Location = new Point(176, 202);
            txtTaikhoan.Margin = new Padding(3, 4, 3, 4);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(401, 44);
            txtTaikhoan.TabIndex = 0;
            txtTaikhoan.Tag = "0";
            txtTaikhoan.Text = "levantuan";
            txtTaikhoan.KeyPress += txtTaikhoan_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Green;
            btnLogin.Location = new Point(176, 346);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 56);
            btnLogin.TabIndex = 2;
            btnLogin.Tag = "2";
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Honeydew;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(521, 274);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Honeydew;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(522, 203);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // txtMatkhau
            // 
            txtMatkhau.BackColor = Color.Honeydew;
            txtMatkhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatkhau.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtMatkhau.ForeColor = Color.Green;
            txtMatkhau.Location = new Point(176, 272);
            txtMatkhau.Margin = new Padding(3, 4, 3, 4);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.PasswordChar = '⬤';
            txtMatkhau.Size = new Size(401, 44);
            txtMatkhau.TabIndex = 1;
            txtMatkhau.Tag = "1";
            txtMatkhau.Text = "123";
            txtMatkhau.KeyPress += txtMatkhau_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(115, 137);
            label1.Name = "label1";
            label1.Size = new Size(491, 36);
            label1.TabIndex = 7;
            label1.Text = "CỬA HÀNG TIỆN LỢI XIN CHÀO";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 128);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Green;
            btnExit.Location = new Point(430, 346);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(147, 56);
            btnExit.TabIndex = 8;
            btnExit.Tag = "2";
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(725, 439);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogin);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTaikhoan;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtMatkhau;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnExit;
    }
}