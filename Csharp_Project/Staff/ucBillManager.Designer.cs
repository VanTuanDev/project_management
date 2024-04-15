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
            btnChiTiet = new Button();
            dgHoaDon = new DataGridView();
            dtpThoiGian = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).BeginInit();
            SuspendLayout();
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.FromArgb(128, 255, 128);
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChiTiet.ForeColor = Color.Green;
            btnChiTiet.Location = new Point(950, 7);
            btnChiTiet.Margin = new Padding(3, 4, 3, 4);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(245, 51);
            btnChiTiet.TabIndex = 8;
            btnChiTiet.Tag = "4";
            btnChiTiet.Text = "Chi tiết hoá đơn";
            btnChiTiet.UseVisualStyleBackColor = false;
            // 
            // dgHoaDon
            // 
            dgHoaDon.BackgroundColor = Color.Honeydew;
            dgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHoaDon.Dock = DockStyle.Bottom;
            dgHoaDon.Location = new Point(0, 68);
            dgHoaDon.Margin = new Padding(3, 4, 3, 4);
            dgHoaDon.Name = "dgHoaDon";
            dgHoaDon.ReadOnly = true;
            dgHoaDon.RowHeadersWidth = 51;
            dgHoaDon.RowTemplate.Height = 25;
            dgHoaDon.Size = new Size(1208, 808);
            dgHoaDon.TabIndex = 7;
            // 
            // dtpThoiGian
            // 
            dtpThoiGian.Location = new Point(14, 12);
            dtpThoiGian.Margin = new Padding(3, 4, 3, 4);
            dtpThoiGian.Name = "dtpThoiGian";
            dtpThoiGian.Size = new Size(242, 27);
            dtpThoiGian.TabIndex = 6;
            // 
            // ucBillManager
            // 
            Name = "ucBillManager";
            Size = new Size(787, 584);
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChiTiet;
        private DataGridView dgHoaDon;
        private DateTimePicker dtpThoiGian;

    }
}
