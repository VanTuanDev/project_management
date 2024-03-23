namespace Csharp_Project.Staff
{
    partial class ucClientManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucClientManage));
            panel4 = new Panel();
            dataGridView2 = new DataGridView();
            panel6 = new Panel();
            dataGridView3 = new DataGridView();
            btnLuu = new Button();
            label3 = new Label();
            txtTenmoi = new TextBox();
            pictureBox3 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            btnXoad = new Button();
            btnSua = new Button();
            txtTen = new TextBox();
            btnThem = new Button();
            txtMa = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 657);
            panel4.Name = "panel4";
            panel4.Size = new Size(1057, 0);
            panel4.TabIndex = 11;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Cornsilk;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1057, 0);
            dataGridView2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(dataGridView3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(674, 651);
            panel6.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.Honeydew;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(674, 651);
            dataGridView3.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(128, 255, 128);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.Green;
            btnLuu.Location = new Point(125, 533);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 38);
            btnLuu.TabIndex = 19;
            btnLuu.Tag = "4";
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 64, 0);
            label3.Location = new Point(3, 423);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 15;
            label3.Text = "Tên mới :";
            // 
            // txtTenmoi
            // 
            txtTenmoi.BorderStyle = BorderStyle.None;
            txtTenmoi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenmoi.Location = new Point(105, 423);
            txtTenmoi.Name = "txtTenmoi";
            txtTenmoi.Size = new Size(249, 20);
            txtTenmoi.TabIndex = 13;
            txtTenmoi.Tag = "1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(105, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
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
            tableLayoutPanel3.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Controls.Add(btnLuu);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtTenmoi);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(btnXoad);
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(txtTen);
            panel5.Controls.Add(btnThem);
            panel5.Controls.Add(txtMa);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(683, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 651);
            panel5.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 64, 0);
            label8.Location = new Point(3, 223);
            label8.Name = "label8";
            label8.Size = new Size(149, 19);
            label8.TabIndex = 7;
            label8.Text = "Tên khách hàng :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 64, 0);
            label9.Location = new Point(3, 194);
            label9.Name = "label9";
            label9.Size = new Size(142, 19);
            label9.TabIndex = 6;
            label9.Text = "Mã khách hàng :";
            label9.UseMnemonic = false;
            // 
            // btnXoad
            // 
            btnXoad.BackColor = Color.FromArgb(128, 255, 128);
            btnXoad.FlatStyle = FlatStyle.Flat;
            btnXoad.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoad.ForeColor = Color.Green;
            btnXoad.Location = new Point(247, 310);
            btnXoad.Name = "btnXoad";
            btnXoad.Size = new Size(116, 38);
            btnXoad.TabIndex = 5;
            btnXoad.Tag = "5";
            btnXoad.Text = "Xoá";
            btnXoad.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Green;
            btnSua.Location = new Point(125, 310);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(116, 38);
            btnSua.TabIndex = 4;
            btnSua.Tag = "4";
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.None;
            txtTen.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(158, 223);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(196, 20);
            txtTen.TabIndex = 2;
            txtTen.Tag = "1";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(128, 255, 128);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(3, 310);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(116, 38);
            btnThem.TabIndex = 1;
            btnThem.Tag = "3";
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtMa
            // 
            txtMa.BorderStyle = BorderStyle.None;
            txtMa.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMa.Location = new Point(158, 194);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(196, 20);
            txtMa.TabIndex = 0;
            txtMa.Tag = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Cornsilk;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1057, 657);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 657);
            panel2.TabIndex = 12;
            // 
            // ucClientManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel2);
            Name = "ucClientManage";
            Size = new Size(1057, 657);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DataGridView dataGridView2;
        private Panel panel6;
        private DataGridView dataGridView3;
        private Button btnLuu;
        private Label label3;
        private TextBox txtTenmoi;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel5;
        private Label label8;
        private Label label9;
        private Button btnXoad;
        private Button btnSua;
        private TextBox txtTen;
        private Button btnThem;
        private TextBox txtMa;
        private DataGridView dataGridView1;
        private Panel panel2;
    }
}
