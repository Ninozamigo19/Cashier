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
    public partial class Karyawan : Form
    {
        private User selectedUser;
        private DataGridViewRow selectedRow;

        public void Rdatauser()
        {
            userBindingSource.DataSource = Program.db.Users.ToList();
        }
        public Karyawan()
        {
            InitializeComponent();
            userBindingSource.DataSource = Program.db.Users.ToList();
            Rdatauser();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedUser = (User)selectedRow.DataBoundItem;
            }
        }

        private void tambahkaryawan_bt_Click(object sender, EventArgs e)
        {
            AddKaryawan tambah = new AddKaryawan(this);
            tambah.ShowDialog();
        }

        private void ubahkaryawan_bt_Click(object sender, EventArgs e)
        {
            if (selectedRow != null) 
            {
                EditUsersData edituser = new EditUsersData(this);
                edituser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tolong Pilih data yang ingin di rubah dulu");
            }
        }
    }
}
