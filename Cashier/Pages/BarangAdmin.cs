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
    public partial class BarangAdmin : Form
    {
        public BarangAdmin()
        {
            InitializeComponent();
        }

        private void tambahbarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void kembali_bt_Click(object sender, EventArgs e)
        {
            BerandaAdmin admin = new BerandaAdmin();
            admin.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void editbarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void caribarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void deletebarang_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
