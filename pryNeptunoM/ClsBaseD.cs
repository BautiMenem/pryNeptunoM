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
        public OleDbCommand Comando = new OleDbCommand();
        public OleDbDataReader Lector;
        public OleDbConnection Conexion = new OleDbConnection();

        public void MostarClientes(DataGridView dgvDatos, string BaseDeDatos, string Tabla)
        {
            Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            dgvDatos.Rows.Clear();
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandText = Tabla;
                Comando.CommandType = CommandType.TableDirect;
                Comando.Connection.Open();

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    dgvDatos.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                }

                Comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public void ListarPais(DataGridView dgvDatos, string BaseDeDatos, string Tabla, ComboBox cboPais, ComboBox cboCiudad)
        {
            if (cboPais.SelectedIndex != -1)
            {
                Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvDatos.Rows.Clear();
                cboCiudad.SelectedIndex = -1;
                try
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = Tabla;
                    Comando.CommandType = CommandType.TableDirect;
                    Comando.Connection.Open();

                    Lector = Comando.ExecuteReader();

                    while (Lector.Read())
                    {
                        if (Lector[8].ToString() == cboPais.Text)
                        {
                            dgvDatos.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                        }
                    }
                    Comando.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        public void CargarPaisCiudad(ComboBox cboCiudad, ComboBox cboPais, string BaseDeDatos, string Tabla)
        {
            Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            bool CiudadEnc = false;
            bool PaisEnc = false;
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandText = Tabla;
                Comando.CommandType = CommandType.TableDirect;
                Comando.Connection.Open();

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    for (int i = 0; i < cboCiudad.Items.Count; i++)
                    {
                        if (Lector[5].ToString() == cboCiudad.Items[i].ToString())
                        {
                            CiudadEnc = true;
                        }
                    }
                    if (CiudadEnc == false)
                    {
                        cboCiudad.Items.Add(Lector[5]);
                    }
                    CiudadEnc = false;

                    for (int i = 0; i < cboPais.Items.Count; i++)
                    {
                        if (Lector[8].ToString() == cboPais.Items[i].ToString())
                        {
                            PaisEnc = true;
                        }
                    }
                    if (PaisEnc == false)
                    {
                        cboPais.Items.Add(Lector[8]);
                    }
                    PaisEnc = false;
                }
                Comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }




        public void ListarCiudad(DataGridView dgvDatos, string BaseDeDatos, string Tabla, ComboBox cboCiudad, ComboBox cboPais)
        {
            if (cboCiudad.SelectedIndex != -1)
            {
                Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
                dgvDatos.Rows.Clear();
                cboPais.SelectedIndex = -1;
                try
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = Tabla;
                    Comando.CommandType = CommandType.TableDirect;
                    Comando.Connection.Open();

                    Lector = Comando.ExecuteReader();

                    while (Lector.Read())
                    {
                        if (Lector[5].ToString() == cboCiudad.Text)
                        {
                            dgvDatos.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                        }
                    }
                    Comando.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}

