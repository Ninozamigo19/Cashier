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
    public partial class BerandaPetugas : Form
    {
        public BerandaPetugas()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_bt_Click(object sender, EventArgs e)
        {
            login kembali = new login();
            kembali.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hapusbarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void pilihproduk_bt_Click(object sender, EventArgs e)
        {
            PilihProduk pindah = new PilihProduk();
            pindah.ShowDialog();
        }
    }
}
