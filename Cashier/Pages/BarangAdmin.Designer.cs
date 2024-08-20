namespace Cashier.Pages
{
    partial class BarangAdmin
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            kembali_bt = new Button();
            tambahbarang_bt = new Button();
            dataGridView1 = new DataGridView();
            productBindingSource = new BindingSource(components);
            Tb_Caribarang = new TextBox();
            ubahbarang_bt = new Button();
            caribarang_bt = new Button();
            hapusbarang_bt = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hargaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jumlahDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(kembali_bt);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 612);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 39);
            panel2.TabIndex = 1;
            // 
            // kembali_bt
            // 
            kembali_bt.BackColor = Color.Honeydew;
            kembali_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kembali_bt.Location = new Point(27, 473);
            kembali_bt.Name = "kembali_bt";
            kembali_bt.Size = new Size(126, 60);
            kembali_bt.TabIndex = 5;
            kembali_bt.Text = "Kembali";
            kembali_bt.UseVisualStyleBackColor = false;
            kembali_bt.Click += kembali_bt_Click;
            // 
            // tambahbarang_bt
            // 
            tambahbarang_bt.BackColor = Color.Honeydew;
            tambahbarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tambahbarang_bt.Location = new Point(203, 112);
            tambahbarang_bt.Name = "tambahbarang_bt";
            tambahbarang_bt.Size = new Size(125, 33);
            tambahbarang_bt.TabIndex = 5;
            tambahbarang_bt.Text = "Tambah";
            tambahbarang_bt.UseVisualStyleBackColor = false;
            tambahbarang_bt.Click += tambahbarang_bt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, namaDataGridViewTextBoxColumn, hargaDataGridViewTextBoxColumn, jumlahDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(203, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(778, 397);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Model.Product);
            // 
            // Tb_Caribarang
            // 
            Tb_Caribarang.Location = new Point(596, 112);
            Tb_Caribarang.Multiline = true;
            Tb_Caribarang.Name = "Tb_Caribarang";
            Tb_Caribarang.PlaceholderText = "Cari nama barang";
            Tb_Caribarang.Size = new Size(286, 33);
            Tb_Caribarang.TabIndex = 3;
            Tb_Caribarang.TextChanged += textBox1_TextChanged;
            // 
            // ubahbarang_bt
            // 
            ubahbarang_bt.BackColor = Color.Honeydew;
            ubahbarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ubahbarang_bt.Location = new Point(334, 112);
            ubahbarang_bt.Name = "ubahbarang_bt";
            ubahbarang_bt.Size = new Size(125, 33);
            ubahbarang_bt.TabIndex = 6;
            ubahbarang_bt.Text = "Ubah";
            ubahbarang_bt.UseVisualStyleBackColor = false;
            ubahbarang_bt.Click += ubahbarang_bt_Click;
            // 
            // caribarang_bt
            // 
            caribarang_bt.BackColor = Color.Honeydew;
            caribarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            caribarang_bt.Location = new Point(886, 112);
            caribarang_bt.Name = "caribarang_bt";
            caribarang_bt.Size = new Size(95, 33);
            caribarang_bt.TabIndex = 7;
            caribarang_bt.Text = "Cari";
            caribarang_bt.UseVisualStyleBackColor = false;
            caribarang_bt.Click += caribarang_bt_Click;
            // 
            // hapusbarang_bt
            // 
            hapusbarang_bt.BackColor = Color.Honeydew;
            hapusbarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hapusbarang_bt.Location = new Point(465, 112);
            hapusbarang_bt.Name = "hapusbarang_bt";
            hapusbarang_bt.Size = new Size(125, 33);
            hapusbarang_bt.TabIndex = 8;
            hapusbarang_bt.Text = "Hapus";
            hapusbarang_bt.UseVisualStyleBackColor = false;
            hapusbarang_bt.Click += hapusbarang_bt_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 170;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            namaDataGridViewTextBoxColumn.ReadOnly = true;
            namaDataGridViewTextBoxColumn.Width = 180;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            hargaDataGridViewTextBoxColumn.ReadOnly = true;
            hargaDataGridViewTextBoxColumn.Width = 200;
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            jumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah";
            jumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            jumlahDataGridViewTextBoxColumn.MinimumWidth = 6;
            jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            jumlahDataGridViewTextBoxColumn.ReadOnly = true;
            jumlahDataGridViewTextBoxColumn.Width = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 1);
            label1.Name = "label1";
            label1.Size = new Size(312, 54);
            label1.TabIndex = 17;
            label1.Text = "Data Karyawan";
            // 
            // BarangAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1007, 560);
            Controls.Add(label1);
            Controls.Add(hapusbarang_bt);
            Controls.Add(caribarang_bt);
            Controls.Add(ubahbarang_bt);
            Controls.Add(Tb_Caribarang);
            Controls.Add(dataGridView1);
            Controls.Add(tambahbarang_bt);
            Controls.Add(panel1);
            Name = "BarangAdmin";
            Text = "BarangAdmin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button logout_bt;
        private Button kembali_bt;
        private Button tambahbarang_bt;
        private DataGridView dataGridView1;
        private TextBox Tb_Caribarang;
        private Button ubahbarang_bt;
        private Button caribarang_bt;
        private Button hapusbarang_bt;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private Label label1;
    }
}