using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using MySql.Data.MySqlClient;

namespace WpfApp1.Servicoss
{
    internal class Contexto
    {
        public static void SalvarContato(Contato contato)
        {
            string query = "INSERT INTO contato (nome_con, data_nasc_con, sexo_con, telefone_con, email_con, cpf_con) VALUES (@_nome, @_dataNasc, @_sexo, @_telefone, @_email, @_cpf)";

            var comando = new MySqlCommand(query, Banco.conexao);

            comando.Parameters.AddWithValue("@_nome", contato.Nome);
            comando.Parameters.AddWithValue("@_dataNasc", contato.DataNascimento);
            comando.Parameters.AddWithValue("@_sexo", contato.Sexo);
            comando.Parameters.AddWithValue("@_telefone", contato.Telefone);
            comando.Parameters.AddWithValue("@_email", contato.Email);
            comando.Parameters.AddWithValue("@_cpf", contato.CPF);

            comando.ExecuteNonQuery();
        }


        public static List<Contato> ListarContatos()
        {

            string query = "SELECT * FROM contato";

            var comando = new MySqlCommand(query, Banco.conexao);

            var adapter = new MySqlDataAdapter(comando);

            var tabela = new DataTable();

            adapter.Fill(tabela);


            var items = tabela.AsEnumerable().Select(linha =>
            {
                var con = new Contato();

                con.Id = linha.Field<Int32>("id_con");

                con.Nome = linha.Field<String>("nome_con");
                con.CPF = linha.Field<String>("cpf_con");
                con.DataNascimento = linha.Field<DateTime>("data_nasc_con");
                con.Email = linha.Field<String>("email_con");
                con.Sexo = linha.Field<String>("sexo_con");
                con.Telefone = linha.Field<String>("telefone_con");

                return con;
            }).ToList();

            return items;
        }
    }
}
