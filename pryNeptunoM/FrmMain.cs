using System;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "Admin")
            {
                if (txtContra.Text == "Admin1")
                {
                    MessageBox.Show("Ingresaste Correctamente" , "Ingreso a Base");
                    var myfrmMenu = new FrmMenu();
                    myfrmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto" , "Ingreso a Base");
                }
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
