using Cashier.Model;


namespace Cashier
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
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
        }
    }
}
