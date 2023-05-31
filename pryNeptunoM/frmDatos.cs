using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryNeptunoM
{
    public partial class frmDatos : Form
    {

    

          
        public frmDatos()
        {
          

            InitializeComponent();
        }

        private void lblConectar_Click(object sender, EventArgs e)
        {
                    
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            ClsBaseD clsBaseDeDatos = new ClsBaseD();
            clsBaseDeDatos.CargarPaisCiudad(cboCiudad, cboPais, "NEPTUNO", "Clientes");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ClsBaseD clsBaseDeDatos = new ClsBaseD();
            clsBaseDeDatos.MostarClientes(dgvDatos, "NEPTUNO", "Clientes");
            
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           
        }

        private void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsBaseD clsBaseDeDatos = new ClsBaseD();
            clsBaseDeDatos.ListarPais(dgvDatos, "NEPTUNO", "Clientes", cboPais, cboCiudad);
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsBaseD clsBaseDeDatos = new ClsBaseD();
            clsBaseDeDatos.ListarCiudad(dgvDatos, "NEPTUNO", "Clientes", cboCiudad, cboPais);
        }
    }
    
}
