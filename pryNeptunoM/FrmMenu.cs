﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryNeptunoM
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var myfrmDatos = new frmDatos();
            myfrmDatos.Show();
            this.Hide();
        }

        private void mostarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myfrmDatos = new frmDatos();
            myfrmDatos.Show();
            this.Hide();
        }

        private void filtarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
