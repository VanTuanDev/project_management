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
            btnChitiet = new Button();
            dgBill = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            id = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgBill).BeginInit();
            SuspendLayout();
            // 
            // btnChitiet
            // 
            btnChitiet.BackColor = Color.FromArgb(128, 255, 128);
            btnChitiet.FlatStyle = FlatStyle.Flat;
            btnChitiet.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnChitiet.ForeColor = Color.Green;
            btnChitiet.Location = new Point(831, 5);
            btnChitiet.Name = "btnChitiet";
            btnChitiet.Size = new Size(214, 38);
            btnChitiet.TabIndex = 8;
            btnChitiet.Tag = "4";
            btnChitiet.Text = "Chi tiết hoá đơn";
            btnChitiet.UseVisualStyleBackColor = false;
            // 
            // dgBill
            // 
            dgBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBill.BackgroundColor = Color.Honeydew;
            dgBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBill.Columns.AddRange(new DataGridViewColumn[] { id, customer, status });
            dgBill.Location = new Point(0, 51);
            dgBill.Name = "dgBill";
            dgBill.ReadOnly = true;
            dgBill.RowHeadersVisible = false;
            dgBill.RowTemplate.Height = 25;
            dgBill.Size = new Size(1057, 606);
            dgBill.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.DataPropertyName = "id";
            id.FillWeight = 20F;
            id.HeaderText = "Mã hóa đơn";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // customer
            // 
            customer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customer.DataPropertyName = "fullname";
            customer.FillWeight = 50F;
            customer.HeaderText = "Khách hàng";
            customer.Name = "customer";
            customer.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.DataPropertyName = "status";
            status.FillWeight = 30F;
            status.HeaderText = "Tình trạng";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // ucBillManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(btnChitiet);
            Controls.Add(dgBill);
            Controls.Add(dateTimePicker1);
            Name = "ucBillManager";
            Size = new Size(1057, 657);
            Load += ucBillManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgBill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChitiet;
        private DataGridView dgBill;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn status;
    }
}
