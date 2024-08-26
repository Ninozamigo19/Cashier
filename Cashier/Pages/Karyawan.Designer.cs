namespace Cashier.Pages
{
    partial class Karyawan
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
            hapusbarang_bt = new Button();
            carikaryawan_bt = new Button();
            ubahkaryawan_bt = new Button();
            Tb_Namakaryawan = new TextBox();
            dataGridView1 = new DataGridView();
            userBindingSource = new BindingSource(components);
            tambahkaryawan_bt = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            kembali_bt = new Button();
            label1 = new Label();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            levelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noTelpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alamatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // hapusbarang_bt
            // 
            hapusbarang_bt.BackColor = Color.Honeydew;
            hapusbarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hapusbarang_bt.Location = new Point(464, 112);
            hapusbarang_bt.Name = "hapusbarang_bt";
            hapusbarang_bt.Size = new Size(125, 33);
            hapusbarang_bt.TabIndex = 15;
            hapusbarang_bt.Text = "Hapus";
            hapusbarang_bt.UseVisualStyleBackColor = false;
            hapusbarang_bt.Click += hapusbarang_bt_Click;
            // 
            // carikaryawan_bt
            // 
            carikaryawan_bt.BackColor = Color.Honeydew;
            carikaryawan_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carikaryawan_bt.Location = new Point(887, 112);
            carikaryawan_bt.Name = "carikaryawan_bt";
            carikaryawan_bt.Size = new Size(108, 33);
            carikaryawan_bt.TabIndex = 14;
            carikaryawan_bt.Text = "Cari";
            carikaryawan_bt.UseVisualStyleBackColor = false;
            carikaryawan_bt.Click += carikaryawan_bt_Click;
            // 
            // ubahkaryawan_bt
            // 
            ubahkaryawan_bt.BackColor = Color.Honeydew;
            ubahkaryawan_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ubahkaryawan_bt.Location = new Point(333, 112);
            ubahkaryawan_bt.Name = "ubahkaryawan_bt";
            ubahkaryawan_bt.Size = new Size(125, 33);
            ubahkaryawan_bt.TabIndex = 13;
            ubahkaryawan_bt.Text = "Ubah";
            ubahkaryawan_bt.UseVisualStyleBackColor = false;
            ubahkaryawan_bt.Click += ubahkaryawan_bt_Click;
            // 
            // Tb_Namakaryawan
            // 
            Tb_Namakaryawan.Location = new Point(595, 112);
            Tb_Namakaryawan.Multiline = true;
            Tb_Namakaryawan.Name = "Tb_Namakaryawan";
            Tb_Namakaryawan.PlaceholderText = "Cari nama Karyawan";
            Tb_Namakaryawan.ScrollBars = ScrollBars.Horizontal;
            Tb_Namakaryawan.Size = new Size(286, 33);
            Tb_Namakaryawan.TabIndex = 11;
            Tb_Namakaryawan.KeyUp += Tb_namakaryawan_KeyUp;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, namaDataGridViewTextBoxColumn, levelDataGridViewTextBoxColumn, noTelpDataGridViewTextBoxColumn, alamatDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(202, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(793, 397);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Model.User);
            // 
            // tambahkaryawan_bt
            // 
            tambahkaryawan_bt.BackColor = Color.Honeydew;
            tambahkaryawan_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tambahkaryawan_bt.Location = new Point(202, 112);
            tambahkaryawan_bt.Name = "tambahkaryawan_bt";
            tambahkaryawan_bt.Size = new Size(125, 33);
            tambahkaryawan_bt.TabIndex = 12;
            tambahkaryawan_bt.Text = "Tambah Data";
            tambahkaryawan_bt.UseVisualStyleBackColor = false;
            tambahkaryawan_bt.Click += tambahkaryawan_bt_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(kembali_bt);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 612);
            panel1.TabIndex = 9;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 1);
            label1.Name = "label1";
            label1.Size = new Size(312, 54);
            label1.TabIndex = 16;
            label1.Text = "Data Karyawan";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 41.17647F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            namaDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            levelDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            levelDataGridViewTextBoxColumn.HeaderText = "Level";
            levelDataGridViewTextBoxColumn.MinimumWidth = 6;
            levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            noTelpDataGridViewTextBoxColumn.DataPropertyName = "No_Telp";
            noTelpDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            noTelpDataGridViewTextBoxColumn.HeaderText = "No_Telp";
            noTelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            noTelpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            alamatDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Karyawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1007, 560);
            Controls.Add(label1);
            Controls.Add(hapusbarang_bt);
            Controls.Add(carikaryawan_bt);
            Controls.Add(ubahkaryawan_bt);
            Controls.Add(Tb_Namakaryawan);
            Controls.Add(dataGridView1);
            Controls.Add(tambahkaryawan_bt);
            Controls.Add(panel1);
            Name = "Karyawan";
            Text = "Karyawan";
            Load += Karyawan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hapusbarang_bt;
        private Button carikaryawan_bt;
        private Button ubahkaryawan_bt;
        private TextBox Tb_Namakaryawan;
        private DataGridView dataGridView1;
        private Button tambahkaryawan_bt;
        private Panel panel1;
        private Panel panel2;
        private Button kembali_bt;
        private BindingSource userBindingSource;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}