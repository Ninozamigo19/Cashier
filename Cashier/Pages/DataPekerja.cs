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
    public partial class DataPekerja : Form
    {
        public DataPekerja()
        {
            InitializeComponent();
        }

        private void caripekerja_bt_CLick(object sender, EventArgs e)
        {

        }

        private void editpekerja_bt_Click(object sender, EventArgs e)
        {

        }

        private void tambahpekerja_bt_Click(object sender, EventArgs e)
        {

        }

        private void deletepekerja_bt_Click(object sender, EventArgs e)
        {

        }

        private void kembali_bt_Click(object sender, EventArgs e)
        {
            BerandaAdmin admin = new BerandaAdmin();
            admin.Show();
            this.Close();
        }
    }
}
