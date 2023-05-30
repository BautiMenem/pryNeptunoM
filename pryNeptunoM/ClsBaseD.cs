using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryNeptunoM
{
    internal class ClsBaseD
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader Lector;
        string Proveedor = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
        string RutadeBase;

        public void ConectarBaseD(string RutadeBase)
        {
            try
            {
                conn = new OleDbConnection();

                conn.ConnectionString = Proveedor + "NEPTUNO.accdb";
                conn.Open();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        public void ListarPais(DataGridView dgvDatos, string BaseDeDatos, string Tabla, ComboBox cboPais, ComboBox cboCiudad)
        {
            if (cboPais.SelectedIndex != -1)
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvDatos.Rows.Clear();
                cboCiudad.SelectedIndex = -1;
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = Tabla;
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.Connection.Open();

                    Lector = cmd.ExecuteReader();

                    while (Lector.Read())
                    {
                        if (Lector[8].ToString() == cboPais.Text)
                        {
                            dgvDatos.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                        }
                    }
                    cmd.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        public void ListarCiudad(DataGridView dgvDatos, string BaseDeDatos, string Tabla, ComboBox cboCiudad, ComboBox cboPais)
        {
            if (cboCiudad.SelectedIndex != -1)
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvDatos.Rows.Clear();
                cboPais.SelectedIndex = -1;
                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = Tabla;
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.Connection.Open();

                    Lector = cmd.ExecuteReader();

                    while (Lector.Read())
                    {
                        if (Lector[5].ToString() == cboCiudad.Text)
                        {
                            dgvDatos.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                        }
                    }
                    cmd.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}

