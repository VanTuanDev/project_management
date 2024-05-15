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
            pnlLeft = new Panel();
            label1 = new Label();
            dgAccount = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            cl4 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            lblNewrole = new Label();
            panel5 = new Panel();
            cbbNewStatus = new ComboBox();
            lblNewname = new Label();
            txtNewName = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            cbbNewRole = new ComboBox();
            lblSelectuser = new Label();
            txtUsername = new TextBox();
            cbbRole = new ComboBox();
            lblNewstatus = new Label();
            btnCancel = new Button();
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
            pnlLeft.SuspendLayout();
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
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(192, 255, 192);
            pnlLeft.Controls.Add(label1);
            pnlLeft.Controls.Add(dgAccount);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(3, 4);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(772, 868);
            pnlLeft.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(0, 50);
            label1.Name = "label1";
            label1.Size = new Size(444, 48);
            label1.TabIndex = 43;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            label1.UseMnemonic = false;
            // 
            // dgAccount
            // 
            dgAccount.AllowUserToAddRows = false;
            dgAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgAccount.BackgroundColor = Color.Honeydew;
            dgAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAccount.Columns.AddRange(new DataGridViewColumn[] { username, fullname, role, cl4 });
            dgAccount.Location = new Point(0, 165);
            dgAccount.Margin = new Padding(3, 4, 3, 4);
            dgAccount.Name = "dgAccount";
            dgAccount.ReadOnly = true;
            dgAccount.RowHeadersVisible = false;
            dgAccount.RowHeadersWidth = 51;
            dgAccount.RowTemplate.Height = 25;
            dgAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAccount.Size = new Size(772, 703);
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
            fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullname.DataPropertyName = "fullname";
            fullname.FillWeight = 85.58559F;
            fullname.HeaderText = "Tên người dùng";
            fullname.MinimumWidth = 6;
            fullname.Name = "fullname";
            fullname.ReadOnly = true;
            fullname.Resizable = DataGridViewTriState.False;
            fullname.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.DataPropertyName = "rolename";
            role.FillWeight = 114.414413F;
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
            cl4.Visible = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Green;
            btnSave.Location = new Point(62, 765);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 51);
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
            lblNewrole.Location = new Point(3, 655);
            lblNewrole.Name = "lblNewrole";
            lblNewrole.Size = new Size(131, 24);
            lblNewrole.TabIndex = 17;
            lblNewrole.Text = "Quyền mới :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(cbbNewStatus);
            panel5.Controls.Add(lblNewname);
            panel5.Controls.Add(txtNewName);
            panel5.Controls.Add(lblName);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(cbbNewRole);
            panel5.Controls.Add(lblSelectuser);
            panel5.Controls.Add(txtUsername);
            panel5.Controls.Add(cbbRole);
            panel5.Controls.Add(lblNewstatus);
            panel5.Controls.Add(btnCancel);
            panel5.Controls.Add(btnSave);
            panel5.Controls.Add(lblNewrole);
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
            panel5.Location = new Point(781, 4);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(424, 868);
            panel5.TabIndex = 0;
            // 
            // cbbNewStatus
            // 
            cbbNewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNewStatus.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbNewStatus.FormattingEnabled = true;
            cbbNewStatus.Items.AddRange(new object[] { "Using", "Unusing" });
            cbbNewStatus.Location = new Point(203, 613);
            cbbNewStatus.Name = "cbbNewStatus";
            cbbNewStatus.Size = new Size(201, 32);
            cbbNewStatus.TabIndex = 42;
            cbbNewStatus.Tag = "8";
            // 
            // lblNewname
            // 
            lblNewname.AutoSize = true;
            lblNewname.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewname.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewname.Location = new Point(3, 576);
            lblNewname.Name = "lblNewname";
            lblNewname.Size = new Size(182, 24);
            lblNewname.TabIndex = 41;
            lblNewname.Text = "Tên người dùng :";
            lblNewname.UseMnemonic = false;
            // 
            // txtNewName
            // 
            txtNewName.BorderStyle = BorderStyle.None;
            txtNewName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewName.Location = new Point(203, 576);
            txtNewName.Margin = new Padding(3, 4, 3, 4);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(201, 25);
            txtNewName.TabIndex = 7;
            txtNewName.Tag = "0";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(0, 64, 0);
            lblName.Location = new Point(3, 277);
            lblName.Name = "lblName";
            lblName.Size = new Size(182, 24);
            lblName.TabIndex = 1;
            lblName.Text = "Tên người dùng :";
            lblName.UseMnemonic = false;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(203, 277);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 25);
            txtName.TabIndex = 1;
            txtName.Tag = "0";
            // 
            // cbbNewRole
            // 
            cbbNewRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbNewRole.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbNewRole.FormattingEnabled = true;
            cbbNewRole.Location = new Point(203, 655);
            cbbNewRole.Name = "cbbNewRole";
            cbbNewRole.Size = new Size(201, 32);
            cbbNewRole.TabIndex = 11;
            cbbNewRole.Tag = "8";
            // 
            // lblSelectuser
            // 
            lblSelectuser.AutoSize = true;
            lblSelectuser.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectuser.ForeColor = Color.FromArgb(0, 64, 0);
            lblSelectuser.Location = new Point(3, 536);
            lblSelectuser.Name = "lblSelectuser";
            lblSelectuser.Size = new Size(121, 24);
            lblSelectuser.TabIndex = 34;
            lblSelectuser.Text = "Tài khoản :";
            lblSelectuser.UseMnemonic = false;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(203, 536);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(202, 25);
            txtUsername.TabIndex = 33;
            txtUsername.Tag = "0";
            // 
            // cbbRole
            // 
            cbbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRole.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(203, 357);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(201, 32);
            cbbRole.TabIndex = 3;
            cbbRole.Tag = "8";
            // 
            // lblNewstatus
            // 
            lblNewstatus.AutoSize = true;
            lblNewstatus.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewstatus.ForeColor = Color.FromArgb(0, 64, 0);
            lblNewstatus.Location = new Point(3, 616);
            lblNewstatus.Name = "lblNewstatus";
            lblNewstatus.Size = new Size(134, 24);
            lblNewstatus.TabIndex = 21;
            lblNewstatus.Text = "Tình trạng : ";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 255, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Green;
            btnCancel.Location = new Point(229, 765);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(133, 51);
            btnCancel.TabIndex = 13;
            btnCancel.Tag = "10";
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnHuy_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblRole.ForeColor = Color.FromArgb(0, 64, 0);
            lblRole.Location = new Point(3, 357);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(88, 24);
            lblRole.TabIndex = 11;
            lblRole.Text = "Quyền :";
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(127, 50);
            ptbLogo.Margin = new Padding(3, 4, 3, 4);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(189, 120);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 9;
            ptbLogo.TabStop = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.ForeColor = Color.FromArgb(0, 64, 0);
            lblPass.Location = new Point(3, 317);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(117, 24);
            lblPass.TabIndex = 7;
            lblPass.Text = "Mật khẩu :";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(0, 64, 0);
            lblUser.Location = new Point(3, 237);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(121, 24);
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
            btnRemove.Location = new Point(282, 421);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(133, 51);
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
            btnEdit.Location = new Point(143, 421);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(133, 51);
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
            txtPass.Location = new Point(203, 317);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(201, 25);
            txtPass.TabIndex = 2;
            txtPass.Tag = "1";
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(3, 421);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 51);
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
            txtUser.Location = new Point(203, 237);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(201, 25);
            txtUser.TabIndex = 0;
            txtUser.Tag = "0";
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 876);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1208, 0);
            panel4.TabIndex = 8;
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
            dataGridView1.Size = new Size(1208, 0);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 876);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1208, 0);
            panel2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.41441F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.5855865F));
            tableLayoutPanel3.Controls.Add(panel5, 1, 0);
            tableLayoutPanel3.Controls.Add(pnlLeft, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1208, 876);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // ucAccountManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucAccountManager";
            Size = new Size(1208, 876);
            Load += ucAccountManage_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
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

        private Panel pnlLeft;
        private DataGridView dgAccount;
        private Button btnSave;
        private Label lblNewrole;
        private Panel panel5;
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
        private ComboBox cbbRole;
        private Label lblSelectuser;
        private TextBox txtUsername;
        private ComboBox cbbNewRole;
        private DataGridViewTextBoxColumn status;
        private Label lblNewname;
        private TextBox txtNewName;
        private Label lblName;
        private TextBox txtName;
        private Label lblPass;
        private TextBox txtPass;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn cl4;
        private ComboBox cbbNewStatus;
        private Label label1;
    }
}
