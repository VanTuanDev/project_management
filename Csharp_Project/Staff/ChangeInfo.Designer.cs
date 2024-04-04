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
            txtNewname = new TextBox();
            lblOldpass = new Label();
            txtOldpass = new TextBox();
            lblSelectuser = new Label();
            txtUser = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblNewpass = new Label();
            txtNewpass = new TextBox();
            label1 = new Label();
            txtAcceptPass = new TextBox();
            ptbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblNewname
            // 
            lblNewname.AutoSize = true;
            lblNewname.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewname.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewname.Location = new Point(89, 150);
            lblNewname.Name = "lblNewname";
            lblNewname.Size = new Size(216, 29);
            lblNewname.TabIndex = 55;
            lblNewname.Text = "Tên người dùng :";
            lblNewname.UseMnemonic = false;
            // 
            // txtNewname
            // 
            txtNewname.BorderStyle = BorderStyle.None;
            txtNewname.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewname.Location = new Point(334, 150);
            txtNewname.Name = "txtNewname";
            txtNewname.Size = new Size(248, 29);
            txtNewname.TabIndex = 1;
            txtNewname.Tag = "0";
            // 
            // lblOldpass
            // 
            lblOldpass.AutoSize = true;
            lblOldpass.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOldpass.ForeColor = Color.FromArgb(0, 64, 0);
            lblOldpass.Location = new Point(89, 199);
            lblOldpass.Name = "lblOldpass";
            lblOldpass.Size = new Size(174, 29);
            lblOldpass.TabIndex = 54;
            lblOldpass.Text = "Mật khẩu cũ :";
            // 
            // txtOldpass
            // 
            txtOldpass.BorderStyle = BorderStyle.None;
            txtOldpass.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldpass.Location = new Point(334, 199);
            txtOldpass.Name = "txtOldpass";
            txtOldpass.Size = new Size(249, 29);
            txtOldpass.TabIndex = 2;
            txtOldpass.Tag = "7";
            // 
            // lblSelectuser
            // 
            lblSelectuser.AutoSize = true;
            lblSelectuser.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectuser.ForeColor = Color.FromArgb(0, 64, 0);
            lblSelectuser.Location = new Point(89, 105);
            lblSelectuser.Name = "lblSelectuser";
            lblSelectuser.Size = new Size(145, 29);
            lblSelectuser.TabIndex = 53;
            lblSelectuser.Text = "Tài khoản :";
            lblSelectuser.UseMnemonic = false;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(333, 105);
            txtUser.Name = "txtUser";
            txtUser.ReadOnly = true;
            txtUser.Size = new Size(249, 29);
            txtUser.TabIndex = 0;
            txtUser.Tag = "0";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Green;
            btnCancel.Location = new Point(335, 357);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 38);
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
            btnSave.Location = new Point(189, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 38);
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
            lblNewpass.Location = new Point(89, 247);
            lblNewpass.Name = "lblNewpass";
            lblNewpass.Size = new Size(191, 29);
            lblNewpass.TabIndex = 49;
            lblNewpass.Text = "Mật khẩu mới :";
            // 
            // txtNewpass
            // 
            txtNewpass.BorderStyle = BorderStyle.None;
            txtNewpass.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewpass.Location = new Point(334, 247);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(249, 29);
            txtNewpass.TabIndex = 3;
            txtNewpass.Tag = "7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(89, 296);
            label1.Name = "label1";
            label1.Size = new Size(239, 29);
            label1.TabIndex = 57;
            label1.Text = "Nhập lại mật khẩu:";
            // 
            // txtAcceptPass
            // 
            txtAcceptPass.BorderStyle = BorderStyle.None;
            txtAcceptPass.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAcceptPass.Location = new Point(334, 296);
            txtAcceptPass.Name = "txtAcceptPass";
            txtAcceptPass.Size = new Size(249, 29);
            txtAcceptPass.TabIndex = 4;
            txtAcceptPass.Tag = "7";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(-3, 0);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(116, 90);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 58;
            ptbLogo.TabStop = false;
            // 
            // ChangeInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(626, 411);
            Controls.Add(ptbLogo);
            Controls.Add(label1);
            Controls.Add(txtAcceptPass);
            Controls.Add(lblNewname);
            Controls.Add(txtNewname);
            Controls.Add(lblOldpass);
            Controls.Add(txtOldpass);
            Controls.Add(lblSelectuser);
            Controls.Add(txtUser);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblNewpass);
            Controls.Add(txtNewpass);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txtNewname;
        private Label lblOldpass;
        private TextBox txtOldpass;
        private Label lblSelectuser;
        private TextBox txtUser;
        private Button btnCancel;
        private Button btnSave;
        private Label lblNewpass;
        private TextBox txtNewpass;
        private Label label1;
        private TextBox txtAcceptPass;
        private PictureBox ptbLogo;
    }
}