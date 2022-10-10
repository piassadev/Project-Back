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
            conect.ConnectionString = "";

        }

        public SqlConnection Conectar() {

            return;
        }

        public void Desconectar()
        {

        }
    }
}