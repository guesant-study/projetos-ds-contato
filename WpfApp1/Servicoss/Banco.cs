using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Servicoss
{
    internal class Banco
    {
        public static MySqlConnection conexao;

        public static MySqlCommand comando;

        static Banco()
        {
            Conexao();
        }


        public static void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_db;user=root;password=root;port=3360";

            conexao = new MySqlConnection(conexaoString);

            comando = conexao.CreateCommand();

            AbrirConexao();
        }

        public static void AbrirConexao()
        {
            conexao.Open();
        }

        public static void FecharConexao()
        {
            conexao.Close();
        }
    }
}
