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
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Honeydew;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1057, 606);
            dataGridView1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // ucBillManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            Controls.Add(btnChitiet);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Name = "ucBillManage";
            Size = new Size(1057, 657);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChitiet;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
    }
}
