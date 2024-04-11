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
            dgCustomer = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.AllowUserToAddRows = false;
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Columns.AddRange(new DataGridViewColumn[] { id, fullname, address, phone });
            dgCustomer.Dock = DockStyle.Fill;
            dgCustomer.Location = new Point(0, 0);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersVisible = false;
            dgCustomer.RowTemplate.Height = 25;
            dgCustomer.Size = new Size(800, 450);
            dgCustomer.TabIndex = 0;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.DataPropertyName = "id";
            id.HeaderText = "Mã khách hàng";
            id.Name = "id";
            // 
            // fullname
            // 
            fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullname.DataPropertyName = "fullname";
            fullname.HeaderText = "Tên khách hàng";
            fullname.Name = "fullname";
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.DataPropertyName = "address";
            address.HeaderText = "Địa chỉ";
            address.Name = "address";
            // 
            // phone
            // 
            phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone.DataPropertyName = "phonenumber";
            phone.HeaderText = "Số điện thoại";
            phone.Name = "phone";
            // 
            // SelectCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SelectCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectCustomer";
            Load += SelectCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgCustomer;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
    }
}