namespace Csharp_Project.Staff
{
    partial class ChangeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInfo));
            lblNewname = new Label();
            txtNewName = new TextBox();
            lblOldpass = new Label();
            txtOldPassword = new TextBox();
            lblSelectuser = new Label();
            txtUser = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblNewpass = new Label();
            txtNewPassword = new TextBox();
            label1 = new Label();
            txtSubmitPassword = new TextBox();
            ptbLogo = new PictureBox();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblNewname
            // 
            lblNewname.AutoSize = true;
            lblNewname.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewname.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewname.Location = new Point(55, 235);
            lblNewname.Name = "lblNewname";
            lblNewname.Size = new Size(271, 36);
            lblNewname.TabIndex = 55;
            lblNewname.Text = "Tên người dùng :";
            lblNewname.UseMnemonic = false;
            // 
            // txtNewName
            // 
            txtNewName.BorderStyle = BorderStyle.None;
            txtNewName.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(383, 235);
            txtNewName.Margin = new Padding(3, 4, 3, 4);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(282, 37);
            txtNewName.TabIndex = 1;
            txtNewName.Tag = "0";
            // 
            // lblOldpass
            // 
            lblOldpass.AutoSize = true;
            lblOldpass.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOldpass.ForeColor = Color.FromArgb(0, 64, 0);
            lblOldpass.Location = new Point(55, 295);
            lblOldpass.Name = "lblOldpass";
            lblOldpass.Size = new Size(219, 36);
            lblOldpass.TabIndex = 54;
            lblOldpass.Text = "Mật khẩu cũ :";
            // 
            // txtOldPassword
            // 
            txtOldPassword.BorderStyle = BorderStyle.None;
            txtOldPassword.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPassword.Location = new Point(383, 295);
            txtOldPassword.Margin = new Padding(3, 4, 3, 4);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '⬤';
            txtOldPassword.Size = new Size(283, 37);
            txtOldPassword.TabIndex = 2;
            txtOldPassword.Tag = "7";
            txtOldPassword.KeyPress += txtOldpass_KeyPress;
            // 
            // lblSelectuser
            // 
            lblSelectuser.AutoSize = true;
            lblSelectuser.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectuser.ForeColor = Color.FromArgb(0, 64, 0);
            lblSelectuser.Location = new Point(55, 175);
            lblSelectuser.Name = "lblSelectuser";
            lblSelectuser.Size = new Size(182, 36);
            lblSelectuser.TabIndex = 53;
            lblSelectuser.Text = "Tài khoản :";
            lblSelectuser.UseMnemonic = false;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(382, 175);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new Size(283, 37);
            txtUser.TabIndex = 0;
            txtUser.Tag = "0";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Green;
            btnCancel.Location = new Point(532, 476);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 51);
            btnCancel.TabIndex = 6;
            btnCancel.Tag = "10";
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(293, 476);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 51);
            btnSave.TabIndex = 5;
            btnSave.Tag = "9";
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblNewpass
            // 
            lblNewpass.AutoSize = true;
            lblNewpass.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewpass.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewpass.Location = new Point(55, 355);
            lblNewpass.Name = "lblNewpass";
            lblNewpass.Size = new Size(241, 36);
            lblNewpass.TabIndex = 49;
            lblNewpass.Text = "Mật khẩu mới :";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(383, 355);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '⬤';
            txtNewPassword.Size = new Size(283, 37);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.Tag = "7";
            txtNewPassword.KeyPress += txtNewpass_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(55, 415);
            label1.Name = "label1";
            label1.Size = new Size(301, 36);
            label1.TabIndex = 57;
            label1.Text = "Nhập lại mật khẩu:";
            // 
            // txtSubmitPassword
            // 
            txtSubmitPassword.BorderStyle = BorderStyle.None;
            txtSubmitPassword.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubmitPassword.Location = new Point(383, 415);
            txtSubmitPassword.Margin = new Padding(3, 4, 3, 4);
            txtSubmitPassword.Name = "txtSubmitPassword";
            txtSubmitPassword.PasswordChar = '⬤';
            txtSubmitPassword.Size = new Size(283, 37);
            txtSubmitPassword.TabIndex = 4;
            txtSubmitPassword.Tag = "7";
            txtSubmitPassword.KeyPress += txtAcceptPass_KeyPress;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(36, 25);
            ptbLogo.Margin = new Padding(3, 4, 3, 4);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(133, 120);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 58;
            ptbLogo.TabStop = false;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(0, 64, 0);
            lblHeader.Location = new Point(230, 63);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(435, 45);
            lblHeader.TabIndex = 59;
            lblHeader.Text = "THAY ĐỔI THÔNG TIN";
            lblHeader.UseMnemonic = false;
            // 
            // ChangeInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(715, 548);
            Controls.Add(lblHeader);
            Controls.Add(ptbLogo);
            Controls.Add(label1);
            Controls.Add(txtSubmitPassword);
            Controls.Add(lblNewname);
            Controls.Add(txtNewName);
            Controls.Add(lblOldpass);
            Controls.Add(txtOldPassword);
            Controls.Add(lblSelectuser);
            Controls.Add(txtUser);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblNewpass);
            Controls.Add(txtNewPassword);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangeInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeInfo";
            Load += ChangeInfo_Load;
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewname;
        private TextBox txtNewName;
        private Label lblOldpass;
        private TextBox txtOldPassword;
        private Label lblSelectuser;
        private TextBox txtUser;
        private Button btnCancel;
        private Button btnSave;
        private Label lblNewpass;
        private TextBox txtNewPassword;
        private Label label1;
        private TextBox txtSubmitPassword;
        private PictureBox ptbLogo;
        private Label lblHeader;
    }
}