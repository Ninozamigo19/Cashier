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
            Tb_Caribarang = new TextBox();
            editbarang_bt = new Button();
            caribarang_bt = new Button();
            deletebarang_bt = new Button();
            productBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            tambahbarang_bt.Location = new Point(198, 12);
            tambahbarang_bt.Name = "tambahbarang_bt";
            tambahbarang_bt.Size = new Size(125, 53);
            tambahbarang_bt.TabIndex = 5;
            tambahbarang_bt.Text = "Tambah";
            tambahbarang_bt.UseVisualStyleBackColor = false;
            tambahbarang_bt.Click += tambahbarang_bt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(198, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 382);
            dataGridView1.TabIndex = 2;
            // 
            // Tb_Caribarang
            // 
            Tb_Caribarang.Location = new Point(709, 12);
            Tb_Caribarang.Multiline = true;
            Tb_Caribarang.Name = "Tb_Caribarang";
            Tb_Caribarang.PlaceholderText = "Cari barang";
            Tb_Caribarang.Size = new Size(286, 33);
            Tb_Caribarang.TabIndex = 3;
            Tb_Caribarang.TextChanged += textBox1_TextChanged;
            // 
            // editbarang_bt
            // 
            editbarang_bt.BackColor = Color.Honeydew;
            editbarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbarang_bt.Location = new Point(329, 12);
            editbarang_bt.Name = "editbarang_bt";
            editbarang_bt.Size = new Size(125, 53);
            editbarang_bt.TabIndex = 6;
            editbarang_bt.Text = "Edit";
            editbarang_bt.UseVisualStyleBackColor = false;
            editbarang_bt.Click += editbarang_bt_Click;
            // 
            // caribarang_bt
            // 
            caribarang_bt.BackColor = Color.Honeydew;
            caribarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            caribarang_bt.Location = new Point(578, 12);
            caribarang_bt.Name = "caribarang_bt";
            caribarang_bt.Size = new Size(125, 53);
            caribarang_bt.TabIndex = 7;
            caribarang_bt.Text = "Cari";
            caribarang_bt.UseVisualStyleBackColor = false;
            caribarang_bt.Click += caribarang_bt_Click;
            // 
            // deletebarang_bt
            // 
            deletebarang_bt.BackColor = Color.Honeydew;
            deletebarang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebarang_bt.Location = new Point(198, 80);
            deletebarang_bt.Name = "deletebarang_bt";
            deletebarang_bt.Size = new Size(125, 53);
            deletebarang_bt.TabIndex = 8;
            deletebarang_bt.Text = "Delete";
            deletebarang_bt.UseVisualStyleBackColor = false;
            deletebarang_bt.Click += deletebarang_bt_Click;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Model.Product);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // BarangAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1007, 560);
            Controls.Add(deletebarang_bt);
            Controls.Add(caribarang_bt);
            Controls.Add(editbarang_bt);
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
        private Button editbarang_bt;
        private Button caribarang_bt;
        private Button deletebarang_bt;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
    }
}