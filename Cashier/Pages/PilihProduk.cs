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
    public partial class PilihProduk : Form
    {
        private BerandaPetugas berandaPetugas;
        public PilihProduk(BerandaPetugas petugas)
        {
            InitializeComponent();
            berandaPetugas = petugas;
            SetupAutoCompleteForProductSeacrh();
        }
        private void SetupAutoCompleteForProductSeacrh()
        {
            var productname = Program.db.Products.Select(p => p.Nama).ToArray();
            var autocompletesource = new AutoCompleteStringCollection();
            autocompletesource.AddRange(productname);

            TBnama.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TBnama.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TBnama.AutoCompleteCustomSource = autocompletesource;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void simpan_bt_Click(object sender, EventArgs e)
        {
            string productName = TBnama.Text.ToLower();
            int Jumlah;

            if (string.IsNullOrEmpty(productName) || int.TryParse(TBjumlah.Text, out Jumlah))
            {
                MessageBox.Show("Silakan masukkan detail produk yang valid.");
                return;
            }

            var product = Program.db.Products.FirstOrDefault(p => p.Nama.ToLower().Contains(productName));

            if (product == null)
            {
                int TotalHargadiGrid = 0;
                DataGridViewRow existingRow = null;

                //foreach (DataGridViewRow row in berandaPetugas.dataGridView1.Rows)
            }
        }
    }
}
