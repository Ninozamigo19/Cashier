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
    public partial class EditBarang : Form
    {
        private Product product;
        private BarangAdmin barangadminForm;

        public EditBarang(Product produk, BarangAdmin admin)
        {
            InitializeComponent();
            this.product = produk;
            this.barangadminForm = admin;
            LoadDataProduct();
        }
        public void LoadDataProduct()
        {
            TBnama.Text = product.Nama;
            TBharga.Text = product.Harga.ToString();
            TBjumlah.Text = product.Jumlah.ToString();
        }

        private void simpan_bt_Click(object sender, EventArgs e)
        {
            product.Nama = TBnama.Text;
            product.Harga = Convert.ToDecimal(TBharga.Text);
            product.Jumlah = Convert.ToInt32(TBjumlah.Text);

            if (string.IsNullOrEmpty(TBnama.Text) || string.IsNullOrEmpty(TBharga.Text) || string.IsNullOrEmpty(TBjumlah.Text))
            {
                MessageBox.Show("Please enter valid product details.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin?", "Silahkan Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.db.SaveChanges();
                    barangadminForm.RdataProduct();
                    this.Close();
                }
            }
        }
    }
}
