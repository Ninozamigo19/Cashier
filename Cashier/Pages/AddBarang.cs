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
    public partial class AddBarang : Form
    {
        private BarangAdmin barangAdminForm;
        public AddBarang(BarangAdmin barang)
        {
            InitializeComponent();
            barangAdminForm = barang;
        }

        private void simpan_bt_Click(object sender, EventArgs e)
        {
            Model.Product product = new Model.Product
            {
                Nama = TBnama.Text,
                Harga = Convert.ToDecimal(TBharga.Text),
                Jumlah = Convert.ToInt32(TBjumlah.Text),
            };
            if (string.IsNullOrEmpty(TBnama.Text) || string.IsNullOrEmpty(TBharga.Text) || string.IsNullOrEmpty(TBjumlah.Text))
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin?", "Silahkan Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.db.Add(product);
                    Program.db.SaveChanges();
                    barangAdminForm.RdataProduct();
                    this.Close();
                }
            }
        }

        private void batal_bt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin?", "Silahkan Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
