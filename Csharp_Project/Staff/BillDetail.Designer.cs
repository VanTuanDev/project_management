namespace Csharp_Project.Staff
{
    partial class BillDetail
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
            lblTenKhachHang = new Label();
            lblTongTien = new Label();
            lblTenKhachHangND = new Label();
            lblTongTienND = new Label();
            dgChiTiet = new DataGridView();
            cl1 = new DataGridViewTextBoxColumn();
            cl2 = new DataGridViewTextBoxColumn();
            cl3 = new DataGridViewTextBoxColumn();
            cl4 = new DataGridViewTextBoxColumn();
            cl5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgChiTiet).BeginInit();
            SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenKhachHang.Location = new Point(24, 32);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(184, 24);
            lblTenKhachHang.TabIndex = 0;
            lblTenKhachHang.Text = "Tên khách hàng :";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTongTien.Location = new Point(24, 66);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(118, 24);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền :";
            // 
            // lblTenKhachHangND
            // 
            lblTenKhachHangND.AutoSize = true;
            lblTenKhachHangND.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKhachHangND.Location = new Point(300, 32);
            lblTenKhachHangND.Name = "lblTenKhachHangND";
            lblTenKhachHangND.Size = new Size(0, 24);
            lblTenKhachHangND.TabIndex = 2;
            // 
            // lblTongTienND
            // 
            lblTongTienND.AutoSize = true;
            lblTongTienND.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTongTienND.Location = new Point(300, 66);
            lblTongTienND.Name = "lblTongTienND";
            lblTongTienND.Size = new Size(0, 24);
            lblTongTienND.TabIndex = 3;
            // 
            // dgChiTiet
            // 
            dgChiTiet.AllowUserToAddRows = false;
            dgChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgChiTiet.Columns.AddRange(new DataGridViewColumn[] { cl1, cl2, cl3, cl4, cl5 });
            dgChiTiet.Dock = DockStyle.Bottom;
            dgChiTiet.Location = new Point(0, 116);
            dgChiTiet.Name = "dgChiTiet";
            dgChiTiet.ReadOnly = true;
            dgChiTiet.RowHeadersVisible = false;
            dgChiTiet.RowHeadersWidth = 51;
            dgChiTiet.RowTemplate.Height = 29;
            dgChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgChiTiet.Size = new Size(798, 268);
            dgChiTiet.TabIndex = 4;
            // 
            // cl1
            // 
            cl1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl1.DataPropertyName = "billid";
            cl1.HeaderText = "Mã hóa đơn";
            cl1.MinimumWidth = 6;
            cl1.Name = "cl1";
            cl1.ReadOnly = true;
            cl1.Resizable = DataGridViewTriState.False;
            cl1.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            cl3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl3.DataPropertyName = "quantity";
            cl3.HeaderText = "Số lượng";
            cl3.MinimumWidth = 6;
            cl3.Name = "cl3";
            cl3.ReadOnly = true;
            cl3.Resizable = DataGridViewTriState.False;
            cl3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl4
            // 
            cl4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl4.DataPropertyName = "price";
            cl4.HeaderText = "Đơn giá";
            cl4.MinimumWidth = 6;
            cl4.Name = "cl4";
            cl4.ReadOnly = true;
            cl4.Resizable = DataGridViewTriState.False;
            cl4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl5
            // 
            cl5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl5.DataPropertyName = "total";
            cl5.HeaderText = "Thành tiền";
            cl5.MinimumWidth = 6;
            cl5.Name = "cl5";
            cl5.ReadOnly = true;
            cl5.Resizable = DataGridViewTriState.False;
            cl5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // BillDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(798, 384);
            Controls.Add(dgChiTiet);
            Controls.Add(lblTongTienND);
            Controls.Add(lblTenKhachHangND);
            Controls.Add(lblTongTien);
            Controls.Add(lblTenKhachHang);
            MaximizeBox = false;
            MaximumSize = new Size(816, 431);
            MinimizeBox = false;
            MinimumSize = new Size(816, 431);
            Name = "BillDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết hóa đơn";
            Load += BillDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhachHang;
        private Label lblTongTien;
        private Label lblTenKhachHangND;
        private Label lblTongTienND;
        private DataGridView dgChiTiet;
        private DataGridViewTextBoxColumn cl1;
        private DataGridViewTextBoxColumn cl2;
        private DataGridViewTextBoxColumn cl3;
        private DataGridViewTextBoxColumn cl4;
        private DataGridViewTextBoxColumn cl5;
    }
}