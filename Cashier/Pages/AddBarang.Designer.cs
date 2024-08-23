namespace Cashier.Pages
{
    partial class AddBarang
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
            label7 = new Label();
            batal_bt = new Button();
            simpan_bt = new Button();
            TBjumlah = new TextBox();
            label6 = new Label();
            TBharga = new TextBox();
            label5 = new Label();
            TBnama = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(83, 15);
            label7.Name = "label7";
            label7.Size = new Size(225, 41);
            label7.TabIndex = 29;
            label7.Text = "Tambah Produk";
            // 
            // batal_bt
            // 
            batal_bt.BackColor = Color.Honeydew;
            batal_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batal_bt.Location = new Point(270, 279);
            batal_bt.Name = "batal_bt";
            batal_bt.Size = new Size(126, 48);
            batal_bt.TabIndex = 28;
            batal_bt.Text = "Batal";
            batal_bt.UseVisualStyleBackColor = false;
            batal_bt.Click += batal_bt_Click;
            // 
            // simpan_bt
            // 
            simpan_bt.BackColor = Color.Honeydew;
            simpan_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            simpan_bt.Location = new Point(23, 279);
            simpan_bt.Name = "simpan_bt";
            simpan_bt.Size = new Size(126, 48);
            simpan_bt.TabIndex = 27;
            simpan_bt.Text = "Simpan";
            simpan_bt.UseVisualStyleBackColor = false;
            simpan_bt.Click += simpan_bt_Click;
            // 
            // TBjumlah
            // 
            TBjumlah.Location = new Point(133, 210);
            TBjumlah.Multiline = true;
            TBjumlah.Name = "TBjumlah";
            TBjumlah.PlaceholderText = "Masukan Jumlah Produk";
            TBjumlah.Size = new Size(263, 34);
            TBjumlah.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(23, 213);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 25;
            label6.Text = "Jumlah";
            // 
            // TBharga
            // 
            TBharga.Location = new Point(133, 154);
            TBharga.Multiline = true;
            TBharga.Name = "TBharga";
            TBharga.PlaceholderText = "Masukan Harga Produk";
            TBharga.Size = new Size(263, 34);
            TBharga.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(23, 157);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 23;
            label5.Text = "Harga";
            // 
            // TBnama
            // 
            TBnama.Location = new Point(133, 102);
            TBnama.Multiline = true;
            TBnama.Name = "TBnama";
            TBnama.PlaceholderText = "Masukan Nama Produk";
            TBnama.Size = new Size(263, 34);
            TBnama.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(23, 105);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 16;
            label1.Text = "Nama";
            // 
            // AddBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(419, 350);
            Controls.Add(label7);
            Controls.Add(batal_bt);
            Controls.Add(simpan_bt);
            Controls.Add(TBjumlah);
            Controls.Add(label6);
            Controls.Add(TBharga);
            Controls.Add(label5);
            Controls.Add(TBnama);
            Controls.Add(label1);
            Name = "AddBarang";
            Text = "AddBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Button batal_bt;
        private Button simpan_bt;
        private TextBox TBjumlah;
        private Label label6;
        private TextBox TBharga;
        private Label label5;
        private TextBox TBnama;
        private Label label1;
    }
}