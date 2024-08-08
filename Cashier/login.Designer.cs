namespace Cashier
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            login_bt = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(73, 57);
            username.Multiline = true;
            username.Name = "username";
            username.PlaceholderText = "Masukan Username";
            username.Size = new Size(338, 34);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(73, 155);
            password.Multiline = true;
            password.Name = "password";
            password.PlaceholderText = "Masukan Password";
            password.Size = new Size(338, 34);
            password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(73, 26);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(73, 124);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // login_bt
            // 
            login_bt.BackColor = Color.Lime;
            login_bt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_bt.Location = new Point(73, 224);
            login_bt.Name = "login_bt";
            login_bt.Size = new Size(126, 48);
            login_bt.TabIndex = 4;
            login_bt.Text = "Login";
            login_bt.UseVisualStyleBackColor = false;
            login_bt.Click += btnlogin_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(285, 224);
            exit.Name = "exit";
            exit.Size = new Size(126, 48);
            exit.TabIndex = 5;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += btnexit_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(474, 284);
            Controls.Add(exit);
            Controls.Add(login_bt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Button login_bt;
        private Button exit;
    }
}
