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
            btnSave = new Button();
            lblNewrole = new Label();
            lblNewpass = new Label();
            panel5 = new Panel();
            lblNewname = new Label();
            txtNewname = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblOldpass = new Label();
            txtOldpass = new TextBox();
            cbbNewrole = new ComboBox();
            lblSelectuser = new Label();
            txtSelectuser = new TextBox();
            cbbRole = new ComboBox();
            lblNewstatus = new Label();
            txtNewstatus = new TextBox();
            btnCancel = new Button();
            txtNewpass = new TextBox();
            lblRole = new Label();
            ptbLogo = new PictureBox();
            lblPass = new Label();
            lblUser = new Label();
            btnRemove = new Button();
            btnEdit = new Button();
            txtPass = new TextBox();
            btnAdd = new Button();
            txtUser = new TextBox();
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
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
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(54, 574);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 38);
            btnSave.TabIndex = 12;
            btnSave.Tag = "9";
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnLuu_Click;
            // 
            // lblNewrole
            // 
            lblNewrole.AutoSize = true;
            lblNewrole.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewrole.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewrole.Location = new Point(3, 523);
            lblNewrole.Name = "lblNewrole";
            lblNewrole.Size = new Size(106, 19);
            lblNewrole.TabIndex = 17;
            lblNewrole.Text = "Quyền mới :";
            // 
            // lblNewpass
            // 
            lblNewpass.AutoSize = true;
            lblNewpass.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewpass.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewpass.Location = new Point(3, 493);
            lblNewpass.Name = "lblNewpass";
            lblNewpass.Size = new Size(131, 19);
            lblNewpass.TabIndex = 15;
            lblNewpass.Text = "Mật khẩu mới :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(lblNewname);
            panel5.Controls.Add(txtNewname);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(lblOldpass);
            panel5.Controls.Add(txtOldpass);
            panel5.Controls.Add(cbbNewrole);
            panel5.Controls.Add(lblSelectuser);
            panel5.Controls.Add(txtSelectuser);
            panel5.Controls.Add(cbbRole);
            panel5.Controls.Add(lblNewstatus);
            panel5.Controls.Add(txtNewstatus);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(lblNewrole);
            panel5.Controls.Add(lblNewpass);
            panel5.Controls.Add(txtNewpass);
            panel5.Controls.Add(lblRole);
            panel5.Controls.Add(ptbLogo);
            panel5.Controls.Add(lblPass);
            panel5.Controls.Add(lblUser);
            panel5.Controls.Add(btnRemove);
            panel5.Controls.Add(btnEdit);
            panel5.Controls.Add(txtPass);
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(txtUser);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(683, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 651);
            panel5.TabIndex = 0;
            // 
            // lblNewname
            // 
            lblNewname.AutoSize = true;
            lblNewname.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewname.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewname.Location = new Point(3, 402);
            lblNewname.Name = "lblNewname";
            lblNewname.Size = new Size(147, 19);
            lblNewname.TabIndex = 41;
            lblNewname.Text = "Tên người dùng :";
            lblNewname.UseMnemonic = false;
            // 
            // txtNewname
            // 
            txtNewname.BorderStyle = BorderStyle.None;
            txtNewname.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewname.Location = new Point(156, 402);
            txtNewname.Name = "txtNewname";
            txtNewname.Size = new Size(198, 20);
            txtNewname.TabIndex = 7;
            txtNewname.Tag = "0";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(0, 64, 0);
            lblName.Location = new Point(3, 208);
            lblName.Name = "lblName";
            lblName.Size = new Size(147, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Tên người dùng :";
            lblName.UseMnemonic = false;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(156, 208);
            txtName.Name = "txtName";
            txtName.Size = new Size(198, 20);
            txtName.TabIndex = 1;
            txtName.Tag = "0";
            // 
            // lblOldpass
            // 
            lblOldpass.AutoSize = true;
            lblOldpass.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOldpass.ForeColor = Color.FromArgb(0, 64, 0);
            lblOldpass.Location = new Point(3, 461);
            lblOldpass.Name = "lblOldpass";
            lblOldpass.Size = new Size(119, 19);
            lblOldpass.TabIndex = 37;
            lblOldpass.Text = "Mật khẩu cũ :";
            // 
            // txtOldpass
            // 
            txtOldpass.BorderStyle = BorderStyle.None;
            txtOldpass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldpass.Location = new Point(156, 461);
            txtOldpass.Name = "txtOldpass";
            txtOldpass.Size = new Size(199, 20);
            txtOldpass.TabIndex = 9;
            txtOldpass.Tag = "7";
            // 
            // cbbNewrole
            // 
            cbbNewrole.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbNewrole.FormattingEnabled = true;
            cbbNewrole.Location = new Point(156, 523);
            cbbNewrole.Margin = new Padding(3, 2, 3, 2);
            cbbNewrole.Name = "cbbNewrole";
            cbbNewrole.Size = new Size(198, 27);
            cbbNewrole.TabIndex = 11;
            cbbNewrole.Tag = "8";
            // 
            // lblSelectuser
            // 
            lblSelectuser.AutoSize = true;
            lblSelectuser.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectuser.ForeColor = Color.FromArgb(0, 64, 0);
            lblSelectuser.Location = new Point(3, 374);
            lblSelectuser.Name = "lblSelectuser";
            lblSelectuser.Size = new Size(101, 19);
            lblSelectuser.TabIndex = 34;
            lblSelectuser.Text = "Tài khoản :";
            lblSelectuser.UseMnemonic = false;
            // 
            // txtSelectuser
            // 
            txtSelectuser.BorderStyle = BorderStyle.None;
            txtSelectuser.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSelectuser.Location = new Point(156, 374);
            txtSelectuser.Name = "txtSelectuser";
            txtSelectuser.ReadOnly = true;
            txtSelectuser.Size = new Size(199, 20);
            txtSelectuser.TabIndex = 33;
            txtSelectuser.Tag = "0";
            // 
            // cbbRole
            // 
            cbbRole.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(156, 268);
            cbbRole.Margin = new Padding(3, 2, 3, 2);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(198, 27);
            cbbRole.TabIndex = 3;
            cbbRole.Tag = "8";
            // 
            // lblNewstatus
            // 
            lblNewstatus.AutoSize = true;
            lblNewstatus.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewstatus.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewstatus.Location = new Point(3, 430);
            lblNewstatus.Name = "lblNewstatus";
            lblNewstatus.Size = new Size(110, 19);
            lblNewstatus.TabIndex = 21;
            lblNewstatus.Text = "Tình trạng : ";
            // 
            // txtNewstatus
            // 
            txtNewstatus.BorderStyle = BorderStyle.None;
            txtNewstatus.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewstatus.Location = new Point(156, 430);
            txtNewstatus.Name = "txtNewstatus";
            txtNewstatus.Size = new Size(199, 20);
            txtNewstatus.TabIndex = 8;
            txtNewstatus.Tag = "6";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Green;
            btnCancel.Location = new Point(200, 574);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Tag = "10";
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnHuy_Click;
            // 
            // txtNewpass
            // 
            txtNewpass.BorderStyle = BorderStyle.None;
            txtNewpass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewpass.Location = new Point(156, 493);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(199, 20);
            txtNewpass.TabIndex = 10;
            txtNewpass.Tag = "7";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.FromArgb(0, 64, 0);
            lblRole.Location = new Point(3, 268);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(71, 19);
            lblRole.TabIndex = 11;
            lblRole.Text = "Quyền :";
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
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.ForeColor = Color.FromArgb(0, 64, 0);
            lblPass.Location = new Point(3, 238);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(96, 19);
            lblPass.TabIndex = 7;
            lblPass.Text = "Mật khẩu :";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(0, 64, 0);
            lblUser.Location = new Point(3, 178);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(101, 19);
            lblUser.TabIndex = 6;
            lblUser.Text = "Tài khoản :";
            lblUser.UseMnemonic = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(128, 255, 128);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.Green;
            btnRemove.Location = new Point(247, 316);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(116, 38);
            btnRemove.TabIndex = 6;
            btnRemove.Tag = "5";
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnXoa_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(128, 255, 128);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Green;
            btnEdit.Location = new Point(125, 316);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(116, 38);
            btnEdit.TabIndex = 5;
            btnEdit.Tag = "4";
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnSua_Click;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(156, 238);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(198, 20);
            txtPass.TabIndex = 2;
            txtPass.Tag = "1";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(3, 316);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 38);
            btnAdd.TabIndex = 4;
            btnAdd.Tag = "3";
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnThem_Click;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(156, 178);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(198, 20);
            txtUser.TabIndex = 0;
            txtUser.Tag = "0";
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
        private Button btnSave;
        private Label lblNewrole;
        private Label lblNewpass;
        private Panel panel5;
        private TextBox txtNewpass;
        private Label lblRole;
        private PictureBox ptbLogo;
        private Label lblUser;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtUser;
        private Panel panel4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCancel;
        private Label lblNewstatus;
        private TextBox txtNewstatus;
        private ComboBox cbbRole;
        private Label lblSelectuser;
        private TextBox txtSelectuser;
        private ComboBox cbbNewrole;
        private DataGridViewTextBoxColumn status;
        private Label lblOldpass;
        private TextBox txtOldpass;
        private Label lblNewname;
        private TextBox txtNewname;
        private Label lblName;
        private TextBox txtName;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn cl4;
        private Label lblPass;
        private TextBox txtPass;
    }
}
