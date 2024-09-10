namespace Cashier.Pages
{
    partial class BerandaPetugas
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
            logout_bt = new Button();
            profile_bt = new Button();
            dataGridView1 = new DataGridView();
            saleBindingSource = new BindingSource(components);
            panel3 = new Panel();
            label4 = new Label();
            Tb_Kembalian = new TextBox();
            label3 = new Label();
            Tb_Diskon = new TextBox();
            label2 = new Label();
            Tb_JumlahUang = new TextBox();
            label1 = new Label();
            Tb_TotalHarga = new TextBox();
            bayar_bt = new Button();
            pilihproduk_bt = new Button();
            hapusbarang_bt = new Button();
            produk = new DataGridViewTextBoxColumn();
            jumlah = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(logout_bt);
            panel1.Controls.Add(profile_bt);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 612);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 39);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // logout_bt
            // 
            logout_bt.BackColor = Color.Honeydew;
            logout_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout_bt.Location = new Point(26, 482);
            logout_bt.Name = "logout_bt";
            logout_bt.Size = new Size(126, 48);
            logout_bt.TabIndex = 5;
            logout_bt.Text = "Logout";
            logout_bt.UseVisualStyleBackColor = false;
            logout_bt.Click += logout_bt_Click;
            // 
            // profile_bt
            // 
            profile_bt.BackColor = Color.Honeydew;
            profile_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profile_bt.Location = new Point(26, 183);
            profile_bt.Name = "profile_bt";
            profile_bt.Size = new Size(126, 48);
            profile_bt.TabIndex = 5;
            profile_bt.Text = "Profile";
            profile_bt.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { produk, jumlah, harga });
            dataGridView1.Location = new Point(207, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(488, 415);
            dataGridView1.TabIndex = 2;
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(Model.Sale);
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(Tb_Kembalian);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Tb_Diskon);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(Tb_JumlahUang);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(Tb_TotalHarga);
            panel3.Controls.Add(bayar_bt);
            panel3.Location = new Point(718, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 472);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(3, 269);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 14;
            label4.Text = "Kembalian";
            // 
            // Tb_Kembalian
            // 
            Tb_Kembalian.Location = new Point(120, 269);
            Tb_Kembalian.Multiline = true;
            Tb_Kembalian.Name = "Tb_Kembalian";
            Tb_Kembalian.Size = new Size(137, 39);
            Tb_Kembalian.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(3, 200);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 12;
            label3.Text = "Diskon";
            label3.Click += label3_Click;
            // 
            // Tb_Diskon
            // 
            Tb_Diskon.Location = new Point(120, 199);
            Tb_Diskon.Multiline = true;
            Tb_Diskon.Name = "Tb_Diskon";
            Tb_Diskon.Size = new Size(137, 39);
            Tb_Diskon.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(3, 127);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 10;
            label2.Text = "Jumlah Uang";
            // 
            // Tb_JumlahUang
            // 
            Tb_JumlahUang.Location = new Point(120, 127);
            Tb_JumlahUang.Multiline = true;
            Tb_JumlahUang.Name = "Tb_JumlahUang";
            Tb_JumlahUang.Size = new Size(137, 39);
            Tb_JumlahUang.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 8;
            label1.Text = "Total Harga";
            label1.Click += label1_Click;
            // 
            // Tb_TotalHarga
            // 
            Tb_TotalHarga.Location = new Point(120, 56);
            Tb_TotalHarga.Multiline = true;
            Tb_TotalHarga.Name = "Tb_TotalHarga";
            Tb_TotalHarga.Size = new Size(137, 39);
            Tb_TotalHarga.TabIndex = 7;
            // 
            // bayar_bt
            // 
            bayar_bt.BackColor = Color.Honeydew;
            bayar_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bayar_bt.Location = new Point(19, 408);
            bayar_bt.Name = "bayar_bt";
            bayar_bt.Size = new Size(238, 48);
            bayar_bt.TabIndex = 6;
            bayar_bt.Text = "Bayar";
            bayar_bt.UseVisualStyleBackColor = false;
            // 
            // pilihproduk_bt
            // 
            pilihproduk_bt.BackColor = Color.Honeydew;
            pilihproduk_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pilihproduk_bt.Location = new Point(207, 31);
            pilihproduk_bt.Name = "pilihproduk_bt";
            pilihproduk_bt.Size = new Size(131, 48);
            pilihproduk_bt.TabIndex = 6;
            pilihproduk_bt.Text = "Pilih Produk";
            pilihproduk_bt.UseVisualStyleBackColor = false;
            pilihproduk_bt.Click += pilihproduk_bt_Click;
            // 
            // hapusbarang_bt
            // 
            hapusbarang_bt.BackColor = Color.Honeydew;
            hapusbarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hapusbarang_bt.Location = new Point(344, 31);
            hapusbarang_bt.Name = "hapusbarang_bt";
            hapusbarang_bt.Size = new Size(142, 48);
            hapusbarang_bt.TabIndex = 7;
            hapusbarang_bt.Text = "Hapus Produk";
            hapusbarang_bt.UseVisualStyleBackColor = false;
            hapusbarang_bt.Click += hapusbarang_bt_Click;
            // 
            // produk
            // 
            produk.HeaderText = "Produk";
            produk.MinimumWidth = 6;
            produk.Name = "produk";
            produk.ReadOnly = true;
            // 
            // jumlah
            // 
            jumlah.HeaderText = "Jumlah";
            jumlah.MinimumWidth = 6;
            jumlah.Name = "jumlah";
            jumlah.ReadOnly = true;
            // 
            // harga
            // 
            harga.HeaderText = "Harga";
            harga.MinimumWidth = 6;
            harga.Name = "harga";
            harga.ReadOnly = true;
            // 
            // BerandaPetugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1007, 560);
            Controls.Add(hapusbarang_bt);
            Controls.Add(pilihproduk_bt);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "BerandaPetugas";
            Text = "BerandaPetugas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button logout_bt;
        private Button profile_bt;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label1;
        private TextBox Tb_TotalHarga;
        private Button bayar_bt;
        private Label label3;
        private TextBox Tb_Diskon;
        private Label label2;
        private TextBox Tb_JumlahUang;
        private Label label4;
        private TextBox Tb_Kembalian;
        private Button pilihproduk_bt;
        private Button hapusbarang_bt;
        private BindingSource saleBindingSource;
        private DataGridViewTextBoxColumn produk;
        private DataGridViewTextBoxColumn jumlah;
        private DataGridViewTextBoxColumn harga;
    }
}