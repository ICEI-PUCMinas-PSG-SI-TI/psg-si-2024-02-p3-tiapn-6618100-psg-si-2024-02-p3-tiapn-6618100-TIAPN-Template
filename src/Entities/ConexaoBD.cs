using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace BodyShape_TI.Entities
{
    internal class ConexaoBD
    {
        private const string _user = "root";
        private const string _server = "127.0.0.1";
        private const string _database = "mydb";
        private const string _pwd = "Mvdar@1324";
        public string _connectionString;
        public MySqlConnection conexao;


        public ConexaoBD()
        {
            _connectionString = $"Server={_server};Database={_database};Uid={_user};Pwd={_pwd};";
        }

        public MySqlConnection IniciaConexaoBD()
        {
            conexao = new MySqlConnection(_connectionString);

            return conexao;
        }
    }
}
