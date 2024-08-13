using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier.Pages
{
    public partial class Karyawan : Form
    {
        public Karyawan()
        {
            InitializeComponent();
            userBindingSource.DataSource = Program.db.Users.ToList();
        }

        private void carikaryawan_bt_Click(object sender, EventArgs e)
        {

        }

        private void Karyawan_Load(object sender, EventArgs e)
        {

        }

        private void kembali_bt_Click(object sender, EventArgs e)
        {
            BerandaAdmin admin = new BerandaAdmin();
            admin.Show();
            this.Close();
        }
    }
}
