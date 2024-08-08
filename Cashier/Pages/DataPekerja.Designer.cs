namespace Cashier.Pages
{
    partial class DataPekerja
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
            deletepekerja_bt = new Button();
            caripekerja_bt = new Button();
            editpekerja_bt = new Button();
            Tb_Caribarang = new TextBox();
            dataGridView1 = new DataGridView();
            tambahpekerja_bt = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            kembali_bt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // deletepekerja_bt
            // 
            deletepekerja_bt.BackColor = Color.Honeydew;
            deletepekerja_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletepekerja_bt.Location = new Point(199, 80);
            deletepekerja_bt.Name = "deletepekerja_bt";
            deletepekerja_bt.Size = new Size(125, 53);
            deletepekerja_bt.TabIndex = 15;
            deletepekerja_bt.Text = "Delete";
            deletepekerja_bt.UseVisualStyleBackColor = false;
            deletepekerja_bt.Click += deletepekerja_bt_Click;
            // 
            // caripekerja_bt
            // 
            caripekerja_bt.BackColor = Color.Honeydew;
            caripekerja_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            caripekerja_bt.Location = new Point(579, 12);
            caripekerja_bt.Name = "caripekerja_bt";
            caripekerja_bt.Size = new Size(125, 53);
            caripekerja_bt.TabIndex = 14;
            caripekerja_bt.Text = "Cari";
            caripekerja_bt.UseVisualStyleBackColor = false;
            caripekerja_bt.Click += caripekerja_bt_CLick;
            // 
            // editpekerja_bt
            // 
            editpekerja_bt.BackColor = Color.Honeydew;
            editpekerja_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editpekerja_bt.Location = new Point(330, 12);
            editpekerja_bt.Name = "editpekerja_bt";
            editpekerja_bt.Size = new Size(125, 53);
            editpekerja_bt.TabIndex = 13;
            editpekerja_bt.Text = "Edit";
            editpekerja_bt.UseVisualStyleBackColor = false;
            editpekerja_bt.Click += editpekerja_bt_Click;
            // 
            // Tb_Caribarang
            // 
            Tb_Caribarang.Location = new Point(710, 12);
            Tb_Caribarang.Multiline = true;
            Tb_Caribarang.Name = "Tb_Caribarang";
            Tb_Caribarang.PlaceholderText = "Cari Pekerja";
            Tb_Caribarang.Size = new Size(286, 33);
            Tb_Caribarang.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(199, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 382);
            dataGridView1.TabIndex = 10;
            // 
            // tambahpekerja_bt
            // 
            tambahpekerja_bt.BackColor = Color.Honeydew;
            tambahpekerja_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tambahpekerja_bt.Location = new Point(199, 12);
            tambahpekerja_bt.Name = "tambahpekerja_bt";
            tambahpekerja_bt.Size = new Size(125, 53);
            tambahpekerja_bt.TabIndex = 12;
            tambahpekerja_bt.Text = "Tambah";
            tambahpekerja_bt.UseVisualStyleBackColor = false;
            tambahpekerja_bt.Click += tambahpekerja_bt_Click;
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
            // DataPekerja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1007, 560);
            Controls.Add(deletepekerja_bt);
            Controls.Add(caripekerja_bt);
            Controls.Add(editpekerja_bt);
            Controls.Add(Tb_Caribarang);
            Controls.Add(dataGridView1);
            Controls.Add(tambahpekerja_bt);
            Controls.Add(panel1);
            Name = "DataPekerja";
            Text = "DataPekerja";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deletepekerja_bt;
        private Button caripekerja_bt;
        private Button editpekerja_bt;
        private TextBox Tb_Caribarang;
        private DataGridView dataGridView1;
        private Button tambahpekerja_bt;
        private Panel panel1;
        private Panel panel2;
        private Button kembali_bt;
    }
}