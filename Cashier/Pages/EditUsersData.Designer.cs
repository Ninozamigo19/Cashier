namespace Cashier.Pages
{
    partial class EditUsersData
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
            TBpassword = new TextBox();
            label6 = new Label();
            TBusername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TB_alamat = new RichTextBox();
            TBnotlp = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TBnama = new TextBox();
            label1 = new Label();
            levelBox = new ComboBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(83, 15);
            label7.Name = "label7";
            label7.Size = new Size(231, 41);
            label7.TabIndex = 29;
            label7.Text = "Ubah Pengguna";
            // 
            // batal_bt
            // 
            batal_bt.BackColor = Color.Honeydew;
            batal_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batal_bt.Location = new Point(270, 490);
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
            simpan_bt.Location = new Point(23, 490);
            simpan_bt.Name = "simpan_bt";
            simpan_bt.Size = new Size(126, 48);
            simpan_bt.TabIndex = 27;
            simpan_bt.Text = "Simpan";
            simpan_bt.UseVisualStyleBackColor = false;
            simpan_bt.Click += simpan_bt_Click;
            // 
            // TBpassword
            // 
            TBpassword.Location = new Point(133, 430);
            TBpassword.Multiline = true;
            TBpassword.Name = "TBpassword";
            TBpassword.PlaceholderText = "Masukan Password";
            TBpassword.Size = new Size(263, 34);
            TBpassword.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(23, 433);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 25;
            label6.Text = "Password";
            // 
            // TBusername
            // 
            TBusername.Location = new Point(133, 374);
            TBusername.Multiline = true;
            TBusername.Name = "TBusername";
            TBusername.PlaceholderText = "Masukan Username";
            TBusername.Size = new Size(263, 34);
            TBusername.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(23, 377);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 23;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(23, 303);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 22;
            label4.Text = "Alamat";
            // 
            // TB_alamat
            // 
            TB_alamat.Location = new Point(133, 283);
            TB_alamat.Name = "TB_alamat";
            TB_alamat.Size = new Size(263, 69);
            TB_alamat.TabIndex = 21;
            TB_alamat.Text = "";
            // 
            // TBnotlp
            // 
            TBnotlp.Location = new Point(133, 229);
            TBnotlp.Multiline = true;
            TBnotlp.Name = "TBnotlp";
            TBnotlp.PlaceholderText = "Masukan No Telp";
            TBnotlp.Size = new Size(263, 34);
            TBnotlp.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(23, 232);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 19;
            label3.Text = "No TELP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(23, 171);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 17;
            label2.Text = "Level";
            // 
            // TBnama
            // 
            TBnama.Location = new Point(133, 102);
            TBnama.Multiline = true;
            TBnama.Name = "TBnama";
            TBnama.PlaceholderText = "Masukan Nama";
            TBnama.Size = new Size(263, 34);
            TBnama.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(23, 105);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 15;
            label1.Text = "Nama";
            // 
            // levelBox
            // 
            levelBox.FormattingEnabled = true;
            levelBox.Items.AddRange(new object[] { "Admin", "Petugas" });
            levelBox.Location = new Point(133, 171);
            levelBox.Name = "levelBox";
            levelBox.Size = new Size(256, 28);
            levelBox.TabIndex = 30;
            // 
            // EditUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(419, 553);
            Controls.Add(levelBox);
            Controls.Add(label7);
            Controls.Add(batal_bt);
            Controls.Add(simpan_bt);
            Controls.Add(TBpassword);
            Controls.Add(label6);
            Controls.Add(TBusername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TB_alamat);
            Controls.Add(TBnotlp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TBnama);
            Controls.Add(label1);
            Name = "EditUsers";
            Text = "EditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button batal_bt;
        private Button simpan_bt;
        private TextBox TBpassword;
        private Label label6;
        private TextBox TBusername;
        private Label label5;
        private Label label4;
        private RichTextBox TB_alamat;
        private TextBox TBnotlp;
        private Label label3;
        private Label label2;
        private TextBox TBnama;
        private Label label1;
        private ComboBox levelBox;
    }
}