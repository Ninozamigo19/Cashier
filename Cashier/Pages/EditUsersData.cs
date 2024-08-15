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
    public partial class EditUsersData : Form
    {
        private User user;
        private Karyawan karyawanForm;

        public EditUsersData(Karyawan karyawan)
        {
        }

        public EditUsersData(User user, Karyawan karyawan)
        {
            InitializeComponent();
            this.user = user;
            this.karyawanForm = karyawan;
            Loaddatauser();
        }
        public void Loaddatauser()
        {
            TBnama.Text = user.Nama;
            levelBox.Text = user.Level;
            TBnotlp.Text = user.No_Telp;
            TB_alamat.Text = user.Alamat;
            TBusername.Text = user.Username;
            TBpassword.Text = user.Password;

        }
        private void batal_bt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pembaruan belum tersimpan", "Apakah Anda yakin ingin membatalkan nya?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void simpan_bt_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("Apakah Anda Yakin?", "Silahkan konfirmasi!", MessageBoxButtons.YesNo);

            if(resut == DialogResult.Yes)
            {
                user.Nama = TBnama.Text;
                user.Level = levelBox.Text;
                user.No_Telp = TBnotlp.Text;
                user.Alamat = TB_alamat.Text;
                user.Username = TBusername.Text;
                user.Password = TBpassword.Text;

                Program.db.Update(user);
                Program.db.SaveChanges();
                karyawanForm.Rdatauser();
                this.Close();
            }
        }
    }
}
