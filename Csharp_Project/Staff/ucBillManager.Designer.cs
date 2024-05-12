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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBillManager));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblSLHD = new Label();
            lblSoLuongHoaDon = new Label();
            lblDenNgay = new Label();
            lblTuNgay = new Label();
            btnLoc = new Button();
            dpDenNgay = new DateTimePicker();
            dpTuNgay = new DateTimePicker();
            ptbLogo = new PictureBox();
            btnXemChiTiet = new Button();
            btnXacNhan = new Button();
            panel2 = new Panel();
            dgBill = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBill).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(lblSLHD);
            panel1.Controls.Add(lblSoLuongHoaDon);
            panel1.Controls.Add(lblDenNgay);
            panel1.Controls.Add(lblTuNgay);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(dpDenNgay);
            panel1.Controls.Add(dpTuNgay);
            panel1.Controls.Add(ptbLogo);
            panel1.Controls.Add(btnXemChiTiet);
            panel1.Controls.Add(btnXacNhan);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 167);
            panel1.TabIndex = 0;
            // 
            // lblSLHD
            // 
            lblSLHD.AutoSize = true;
            lblSLHD.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSLHD.ForeColor = SystemColors.ActiveCaptionText;
            lblSLHD.Location = new Point(420, 113);
            lblSLHD.Name = "lblSLHD";
            lblSLHD.Size = new Size(0, 28);
            lblSLHD.TabIndex = 17;
            // 
            // lblSoLuongHoaDon
            // 
            lblSoLuongHoaDon.AutoSize = true;
            lblSoLuongHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoLuongHoaDon.ForeColor = SystemColors.ActiveCaptionText;
            lblSoLuongHoaDon.Location = new Point(221, 112);
            lblSoLuongHoaDon.Name = "lblSoLuongHoaDon";
            lblSoLuongHoaDon.Size = new Size(193, 28);
            lblSoLuongHoaDon.TabIndex = 16;
            lblSoLuongHoaDon.Text = "Số lượng hóa đơn :";
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDenNgay.ForeColor = SystemColors.ActiveCaptionText;
            lblDenNgay.Location = new Point(548, 46);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(113, 28);
            lblDenNgay.TabIndex = 15;
            lblDenNgay.Text = "Đến ngày :";
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTuNgay.ForeColor = SystemColors.ActiveCaptionText;
            lblTuNgay.Location = new Point(220, 46);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(100, 28);
            lblTuNgay.TabIndex = 14;
            lblTuNgay.Text = "Từ ngày :";
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.FromArgb(128, 255, 128);
            btnLoc.Cursor = Cursors.Hand;
            btnLoc.FlatStyle = FlatStyle.Flat;
            btnLoc.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoc.ForeColor = Color.Green;
            btnLoc.Location = new Point(940, 44);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(107, 34);
            btnLoc.TabIndex = 13;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += btnLoc_Click;
            // 
            // dpDenNgay
            // 
            dpDenNgay.CalendarForeColor = Color.Green;
            dpDenNgay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dpDenNgay.Format = DateTimePickerFormat.Short;
            dpDenNgay.Location = new Point(682, 44);
            dpDenNgay.Name = "dpDenNgay";
            dpDenNgay.Size = new Size(161, 34);
            dpDenNgay.TabIndex = 12;
            dpDenNgay.ValueChanged += dpDenNgay_ValueChanged;
            // 
            // dpTuNgay
            // 
            dpTuNgay.CalendarForeColor = Color.Green;
            dpTuNgay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dpTuNgay.Format = DateTimePickerFormat.Short;
            dpTuNgay.Location = new Point(327, 44);
            dpTuNgay.Name = "dpTuNgay";
            dpTuNgay.Size = new Size(161, 34);
            dpTuNgay.TabIndex = 11;
            dpTuNgay.ValueChanged += dpTuNgay_ValueChanged;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(17, 24);
            ptbLogo.Margin = new Padding(3, 4, 3, 4);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(189, 120);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 10;
            ptbLogo.TabStop = false;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.BackColor = Color.FromArgb(128, 255, 128);
            btnXemChiTiet.Cursor = Cursors.Hand;
            btnXemChiTiet.FlatStyle = FlatStyle.Flat;
            btnXemChiTiet.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemChiTiet.ForeColor = Color.Green;
            btnXemChiTiet.Location = new Point(903, 110);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(145, 34);
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
            btnXacNhan.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan.ForeColor = Color.Green;
            btnXacNhan.Location = new Point(637, 110);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(230, 34);
            btnXacNhan.TabIndex = 0;
            btnXacNhan.Text = "Xác nhận thanh toán";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgBill);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(1210, 703);
            panel2.TabIndex = 1;
            // 
            // dgBill
            // 
            dgBill.AllowUserToAddRows = false;
            dgBill.AllowUserToDeleteRows = false;
            dgBill.AllowUserToResizeColumns = false;
            dgBill.AllowUserToResizeRows = false;
            dgBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBill.Columns.AddRange(new DataGridViewColumn[] { id, fullname, time, status });
            dgBill.Dock = DockStyle.Fill;
            dgBill.Location = new Point(0, 0);
            dgBill.Name = "dgBill";
            dgBill.ReadOnly = true;
            dgBill.RowHeadersVisible = false;
            dgBill.RowHeadersWidth = 51;
            dgBill.RowTemplate.Height = 29;
            dgBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBill.Size = new Size(1210, 703);
            dgBill.TabIndex = 0;
            dgBill.CellClick += dgBill_CellClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Mã hóa đơn";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            id.Width = 250;
            // 
            // fullname
            // 
            fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullname.DataPropertyName = "fullname";
            fullname.HeaderText = "Tên khách hàng";
            fullname.MinimumWidth = 6;
            fullname.Name = "fullname";
            fullname.ReadOnly = true;
            fullname.Resizable = DataGridViewTriState.False;
            fullname.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // time
            // 
            time.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            time.DataPropertyName = "time";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            time.DefaultCellStyle = dataGridViewCellStyle1;
            time.HeaderText = "Ngày mua hàng";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            time.Resizable = DataGridViewTriState.False;
            time.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.DataPropertyName = "status";
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.False;
            status.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ucBillManager
            // 
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1210, 876);
            MinimumSize = new Size(1210, 876);
            Name = "ucBillManager";
            Size = new Size(1210, 876);
            Load += ucBillManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChiTiet;
        private DataGridView dgHoaDon;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgBill;
        private Button btnXemChiTiet;
        private Button btnXacNhan;
        private PictureBox ptbLogo;
        private DateTimePicker dpDenNgay;
        private DateTimePicker dpTuNgay;
        private Button btnLoc;
        private Label lblDenNgay;
        private Label lblTuNgay;
        private Label lblSoLuongHoaDon;
        private Label lblSLHD;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn status;
    }
}
