using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryNeptunoM
{
    internal class ClsBaseD
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataReader reader;
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

        public void ListarGrilla()
        {

        }

    }
}
