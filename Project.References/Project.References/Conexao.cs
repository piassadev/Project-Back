using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project.References
{
    public class Conexao
    {
        SqlConnection conect = new SqlConnection();

        public Conexao()
        {
            conect.ConnectionString = @"Data Source=DESKTOP-GEIDCJS\SQLEXPRESS;Initial Catalog=DB_REFERENCE;Integrated Security=True";
        }

        public SqlConnection Conectar() {
            if (conect.State == System.Data.ConnectionState.Closed)
            {
                conect.Open();
            }

            return conect;
        }

        public void Desconectar()
        {
            if(conect.State == System.Data.ConnectionState.Open)
            {
                conect.Close();
            }

        }
    }
}