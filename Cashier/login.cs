using Cashier.Model;
using Cashier.Pages;
using System.Runtime.InteropServices;


namespace Cashier
{
    public partial class login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(20, 20, Width, Height, 20, 20));
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            LoginAction();
        }

        private void LoginAction()
        {
            User? user = Program.db.Users.FirstOrDefault(u => u.Username == username.Text && u.Password == password.Text);
            if (username.Text.Length == 0 || password.Text.Length == 0)
            {
                MessageBox.Show("Username atau Password Tidak boleh Kosong");
                return;
            }
            if (user == null)
            {
                MessageBox.Show("Username atau Password salah");
                return;
            }

            switch (user.Level)
            {
                case "Admin":
                    BerandaAdmin admin = new BerandaAdmin();
                    admin.Show();
                    this.Hide();
                    break;

                case "Petugas":
                    BerandaPetugas petugas = new BerandaPetugas();
                    petugas.Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("User tidak di temukan");
                    break;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
