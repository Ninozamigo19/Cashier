﻿using System;
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
    public partial class BerandaAdmin : Form
    {
        public BerandaAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile_bt_Click(object sender, EventArgs e)
        {

        }

        private void barang_bt_Click(object sender, EventArgs e)
        {

        }

        private void logout_bt_Click(object sender, EventArgs e)
        {
            login Logout = new login();
            Logout.Show();
            this.Close();
        }
    }
}
