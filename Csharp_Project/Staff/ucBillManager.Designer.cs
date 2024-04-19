namespace Csharp_Project.Staff
{
    partial class ucBillManager
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
            panel1 = new Panel();
            btnXemChiTiet = new Button();
            btnXacNhan = new Button();
            panel2 = new Panel();
            dgBill = new DataGridView();
            cl1 = new DataGridViewTextBoxColumn();
            cl2 = new DataGridViewTextBoxColumn();
            cl3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBill).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(btnXemChiTiet);
            panel1.Controls.Add(btnXacNhan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 87);
            panel1.TabIndex = 0;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.BackColor = Color.FromArgb(128, 255, 128);
            btnXemChiTiet.Cursor = Cursors.Hand;
            btnXemChiTiet.FlatStyle = FlatStyle.Flat;
            btnXemChiTiet.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemChiTiet.ForeColor = Color.Green;
            btnXemChiTiet.Location = new Point(953, 18);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(229, 57);
            btnXemChiTiet.TabIndex = 1;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.UseVisualStyleBackColor = false;
            btnXemChiTiet.Click += btnXemChiTiet_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.FromArgb(128, 255, 128);
            btnXacNhan.Cursor = Cursors.Hand;
            btnXacNhan.FlatStyle = FlatStyle.Flat;
            btnXacNhan.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.Green;
            btnXacNhan.Location = new Point(560, 18);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(361, 57);
            btnXacNhan.TabIndex = 0;
            btnXacNhan.Text = "Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgBill);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(1210, 783);
            panel2.TabIndex = 1;
            // 
            // dgBill
            // 
            dgBill.AllowUserToAddRows = false;
            dgBill.AllowUserToDeleteRows = false;
            dgBill.AllowUserToResizeColumns = false;
            dgBill.AllowUserToResizeRows = false;
            dgBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBill.Columns.AddRange(new DataGridViewColumn[] { cl1, cl2, cl3 });
            dgBill.Dock = DockStyle.Fill;
            dgBill.Location = new Point(0, 0);
            dgBill.Name = "dgBill";
            dgBill.ReadOnly = true;
            dgBill.RowHeadersVisible = false;
            dgBill.RowHeadersWidth = 51;
            dgBill.RowTemplate.Height = 29;
            dgBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBill.Size = new Size(1210, 783);
            dgBill.TabIndex = 0;
            dgBill.CellClick += dgBill_CellClick;
            // 
            // cl1
            // 
            cl1.DataPropertyName = "id";
            cl1.HeaderText = "Mã hóa đơn";
            cl1.MinimumWidth = 6;
            cl1.Name = "cl1";
            cl1.ReadOnly = true;
            cl1.Resizable = DataGridViewTriState.False;
            cl1.SortMode = DataGridViewColumnSortMode.NotSortable;
            cl1.Width = 250;
            // 
            // cl2
            // 
            cl2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl2.DataPropertyName = "fullname";
            cl2.HeaderText = "Tên khách hàng";
            cl2.MinimumWidth = 6;
            cl2.Name = "cl2";
            cl2.ReadOnly = true;
            cl2.Resizable = DataGridViewTriState.False;
            cl2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // cl3
            // 
            cl3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cl3.DataPropertyName = "status";
            cl3.HeaderText = "Trạng thái";
            cl3.MinimumWidth = 6;
            cl3.Name = "cl3";
            cl3.ReadOnly = true;
            cl3.Resizable = DataGridViewTriState.False;
            cl3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ucBillManager
            // 
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1210, 876);
            MinimumSize = new Size(1210, 876);
            Name = "ucBillManager";
            Size = new Size(1210, 876);
            Load += ucBillManager_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChiTiet;
        private DataGridView dgHoaDon;
        private DateTimePicker dtpThoiGian;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgBill;
        private Button btnXemChiTiet;
        private Button btnXacNhan;
        private DataGridViewTextBoxColumn cl1;
        private DataGridViewTextBoxColumn cl2;
        private DataGridViewTextBoxColumn cl3;
    }
}
