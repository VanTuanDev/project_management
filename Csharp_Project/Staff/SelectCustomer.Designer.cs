namespace Csharp_Project.Staff
{
    partial class SelectCustomer
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
            dgKhachHang = new DataGridView();
            cl1 = new DataGridViewTextBoxColumn();
            cl2 = new DataGridViewTextBoxColumn();
            cl3 = new DataGridViewTextBoxColumn();
            cl4 = new DataGridViewTextBoxColumn();
            cl5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).BeginInit();
            SuspendLayout();
            // 
            // dgKhachHang
            // 
            dgKhachHang.AllowUserToAddRows = false;
            dgKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKhachHang.Columns.AddRange(new DataGridViewColumn[] { cl1, cl2, cl3, cl4, cl5 });
            dgKhachHang.Dock = DockStyle.Fill;
            dgKhachHang.Location = new Point(0, 0);
            dgKhachHang.Margin = new Padding(3, 4, 3, 4);
            dgKhachHang.Name = "dgKhachHang";
            dgKhachHang.RowHeadersVisible = false;
            dgKhachHang.RowHeadersWidth = 51;
            dgKhachHang.RowTemplate.Height = 25;
            dgKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKhachHang.Size = new Size(921, 618);
            dgKhachHang.TabIndex = 0;
            dgKhachHang.DoubleClick += dgKhachHang_DoubleClick;
            // 
            // cl1
            // 
            cl1.DataPropertyName = "id";
            cl1.HeaderText = "Mã KH";
            cl1.MinimumWidth = 6;
            cl1.Name = "cl1";
            cl1.Resizable = DataGridViewTriState.False;
            cl1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl2
            // 
            cl2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl2.DataPropertyName = "fullname";
            cl2.HeaderText = "Tên KH";
            cl2.MinimumWidth = 6;
            cl2.Name = "cl2";
            cl2.Resizable = DataGridViewTriState.False;
            cl2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl3
            // 
            cl3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl3.DataPropertyName = "address";
            cl3.HeaderText = "Địa chỉ";
            cl3.MinimumWidth = 6;
            cl3.Name = "cl3";
            cl3.Resizable = DataGridViewTriState.False;
            cl3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl4
            // 
            cl4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl4.DataPropertyName = "phonenumber";
            cl4.HeaderText = "Số điện thoại";
            cl4.MinimumWidth = 6;
            cl4.Name = "cl4";
            cl4.Resizable = DataGridViewTriState.False;
            cl4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl5
            // 
            cl5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl5.DataPropertyName = "status";
            cl5.HeaderText = "Trạng thái";
            cl5.MinimumWidth = 6;
            cl5.Name = "cl5";
            cl5.Resizable = DataGridViewTriState.False;
            cl5.SortMode = DataGridViewColumnSortMode.NotSortable;
            cl5.Visible = false;
            // 
            // SelectCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 618);
            Controls.Add(dgKhachHang);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(939, 665);
            MinimizeBox = false;
            MinimumSize = new Size(939, 665);
            Name = "SelectCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chọn khách hàng";
            Load += SelectCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgKhachHang;
        private DataGridViewTextBoxColumn cl1;
        private DataGridViewTextBoxColumn cl2;
        private DataGridViewTextBoxColumn cl3;
        private DataGridViewTextBoxColumn cl4;
        private DataGridViewTextBoxColumn cl5;
    }
}