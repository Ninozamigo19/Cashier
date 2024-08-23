using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cashier.Model;

namespace Cashier.Pages
{
    public partial class AddKaryawan : Form
    {
        private Karyawan karyawanForm;
        public AddKaryawan(Karyawan karyawan)
        {
            InitializeComponent();
            karyawanForm = karyawan;
        }

        private void AddKaryawan_Load(object sender, EventArgs e)
        {

        }

        private void simpan_bt_Click(object sender, EventArgs e)
        {
            Model.User user = new Model.User
            {
                Nama = TBnama.Text,
                Level = levelBox.Text,
                No_Telp = TBnotlp.Text,
                Alamat = TB_alamat.Text,
                Username = TBusername.Text,
                Password = TBpassword.Text,
            };
            if (string.IsNullOrEmpty(TBnama.Text) || string.IsNullOrEmpty(levelBox.Text) || string.IsNullOrEmpty(TBnotlp.Text) || string.IsNullOrEmpty(TB_alamat.Text) || string.IsNullOrEmpty(TBusername.Text) || string.IsNullOrEmpty(TBpassword.Text))
            {
                MessageBox.Show("Silakan masukkan detail pengguna yang valid.");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin?", "Silahkan Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.db.Users.Add(user);
                    Program.db.SaveChanges();
                    karyawanForm.Rdatauser();
                    this.Close();
                }
            }
        }

        private void batal_bt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pembaruan belum tersimpan", "Apakah Anda yakin ingin membatalkan nya?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
