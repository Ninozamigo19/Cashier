namespace Cashier.Pages
{
    partial class BerandaAdmin
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
            panel1 = new Panel();
            karyawan_bt = new Button();
            panel2 = new Panel();
            logout_bt = new Button();
            barang_bt = new Button();
            profile_bt = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(karyawan_bt);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(logout_bt);
            panel1.Controls.Add(barang_bt);
            panel1.Controls.Add(profile_bt);
            panel1.Location = new Point(1, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 612);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // karyawan_bt
            // 
            karyawan_bt.BackColor = Color.Honeydew;
            karyawan_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            karyawan_bt.Location = new Point(26, 245);
            karyawan_bt.Name = "karyawan_bt";
            karyawan_bt.Size = new Size(126, 61);
            karyawan_bt.TabIndex = 6;
            karyawan_bt.Text = "Daftar Karyawan";
            karyawan_bt.UseVisualStyleBackColor = false;
            karyawan_bt.Click += karyawan_bt_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 39);
            panel2.TabIndex = 1;
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
            // barang_bt
            // 
            barang_bt.BackColor = Color.Honeydew;
            barang_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            barang_bt.Location = new Point(26, 324);
            barang_bt.Name = "barang_bt";
            barang_bt.Size = new Size(126, 48);
            barang_bt.TabIndex = 5;
            barang_bt.Text = "Barang";
            barang_bt.UseVisualStyleBackColor = false;
            barang_bt.Click += barang_bt_Click;
            // 
            // profile_bt
            // 
            profile_bt.BackColor = Color.Honeydew;
            profile_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profile_bt.Location = new Point(26, 177);
            profile_bt.Name = "profile_bt";
            profile_bt.Size = new Size(126, 48);
            profile_bt.TabIndex = 5;
            profile_bt.Text = "Profile";
            profile_bt.UseVisualStyleBackColor = false;
            profile_bt.Click += profile_bt_Click;
            // 
            // BerandaAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1007, 560);
            Controls.Add(panel1);
            Name = "BerandaAdmin";
            Text = "BerandaAdmin";
            Load += BerandaAdmin_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button logout_bt;
        private Button barang_bt;
        private Button profile_bt;
        private Panel panel2;
        private Button karyawan_bt;
    }
}