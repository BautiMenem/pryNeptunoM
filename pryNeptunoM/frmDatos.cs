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

        OleDbConnection ConBaseNep = null;
        OleDbCommand CmdBaseNep = null;
        OleDbDataReader LectorBD = null;

          
        public frmDatos()
        {
            ConBaseNep = new OleDbConnection();
            ConBaseNep.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:NEPTUNO.accdb";
            ConBaseNep.Open();

            InitializeComponent();
        }

        private void lblConectar_Click(object sender, EventArgs e)
        {
                    
        }

        private void frmDatos_Load(object sender, EventArgs e)
        { 

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CmdBaseNep = new OleDbCommand();
            CmdBaseNep.Connection = ConBaseNep;
            CmdBaseNep.CommandType = CommandType.TableDirect;
            CmdBaseNep.CommandText = "Clientes";

            LectorBD = CmdBaseNep.ExecuteReader();

            while (LectorBD.Read())
            {
                dgvDatos.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8], LectorBD[9], LectorBD[10]);

            }
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
