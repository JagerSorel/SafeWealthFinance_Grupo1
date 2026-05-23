using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Datos
{
    internal class Conexion
    {
        SqlConnection cn = new SqlConnection("Data Source=PC-ELite;Initial Catalog=SafeWealthFinanceDB;Integrated Security=True;Encrypt=False");
        public SqlConnection AbrirConexion()
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }
        public SqlConnection CerrarConexion()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            return cn;
        }
    }
}
