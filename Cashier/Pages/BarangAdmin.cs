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
            productBindingSource.DataSource = Program.db.Products.ToList();
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

        private void caribarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void hapusbarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void ubahbarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
