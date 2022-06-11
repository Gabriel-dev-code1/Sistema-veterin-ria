using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.dal
{
    public class Conexão

    {
        SqlConnection con = new SqlConnection();
        public Conexão()
        {
            con.ConnectionString = @"Data Source=DUKE\SQLEXPRESS01;Initial Catalog=login_vet;Integrated Security=True";
        }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {

        }

    }
}
