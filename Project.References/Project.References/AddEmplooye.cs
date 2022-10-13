using System;
using System.Data.SqlClient;

namespace Project.References
{
    internal class AddEmplooye
    {
        Conexao conect = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;


        public AddEmplooye(string nome, int Idade)
        {
            //Comando Sql ----SqlCommand
            cmd.CommandText = "Insert into dbo.REGISTER_EMPLOOYE(Nome_Emplooye, Idade_Emplooye) values (@Nome_Emplooye, @Idade_Emplooye)";

            //Parametros
            cmd.Parameters.AddWithValue("@Nome_Emplooye", nome);
            cmd.Parameters.AddWithValue("@Idade_Emplooye", Idade);


            try
            {
                //Conectar ao Bacno -- Conexao
                cmd.Connection = conect.Conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conect.Desconectar();
                //mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Cadastrado com Sucesso!!";
            }
            catch (SqlException error)
            {
                this.mensagem = "Erro ao se Conectar com Banco de Dados!!";
            }




        }
    }
}