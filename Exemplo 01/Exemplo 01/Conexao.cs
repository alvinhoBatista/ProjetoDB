using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_01
{
    public class Conexao
    {
        //ATRIBUTOS
        private string string_conexao = "Server=localhost;Database=mydb;Uid=alvaro;Pwd=alvaro123";

        //MÉTODOS
        public MySqlDataReader mysql_data_reade(string string_consulta)
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.ConnectionString = this.string_conexao;
            conexao.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = string_consulta;
            comando.Connection = conexao;

            MySqlDataReader reader = comando.ExecuteReader();

            return reader;
        }
    }
}
