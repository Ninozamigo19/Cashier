using Cashier.Model;
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
        public Product selectedProduct;
        private DataGridViewRow selectedRow;
        public void RdataProduct()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();
        }
        public BarangAdmin()
        {
            InitializeComponent();
            productBindingSource.DataSource = Program.db.Products.ToList();
            RdataProduct();
        }
        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedProduct = (Product)selectedRow.DataBoundItem;

            }
        }

        private void tambahbarang_bt_Click(object sender, EventArgs e)
        {
            AddBarang tambah = new AddBarang(this);
            tambah.ShowDialog();
        }


        private void caribarang_bt_Click(object sender, EventArgs e)
        {

        }

        private void hapusbarang_bt_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin?", "Silahkan Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.db.Products.Remove(selectedProduct);
                    Program.db.SaveChanges();
                    RdataProduct();
                }
            }
            else
            {
                MessageBox.Show("Tolong pilih produk yang ingin di hapus");
            }
        }

        private void ubahbarang_bt_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                EditBarang edit = new EditBarang(selectedProduct, this);
                edit.ShowDialog();
                RdataProduct();
            }
            else
            {
                MessageBox.Show("Tolong pilih produk yang ingin di ubah");
            }
        }
        private void kembali_bt_Click(object sender, EventArgs e)
        {
            BerandaAdmin admin = new BerandaAdmin();
            admin.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Tb_Caribarang_KeyUp(object sender, KeyEventArgs e)
        {
            string textsearch = Tb_Caribarang.Text.ToLower();
            productBindingSource.DataSource = Program.db.Products
                .Where(x => x.Nama.ToLower().Contains(textsearch))
                .ToList();
        }
    }
}
