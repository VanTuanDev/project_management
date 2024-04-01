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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, fullname, address, phone });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.HeaderText = "Mã khách hàng";
            id.Name = "id";
            // 
            // fullname
            // 
            fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullname.HeaderText = "Tên khách hàng";
            fullname.Name = "fullname";
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "Địa chỉ";
            address.Name = "address";
            // 
            // phone
            // 
            phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone.HeaderText = "Số điện thoại";
            phone.Name = "phone";
            // 
            // SelectCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectCustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
    }
}