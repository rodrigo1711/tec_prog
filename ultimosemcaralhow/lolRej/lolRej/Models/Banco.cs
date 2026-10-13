using Microsoft.Data.Sqlite;

namespace lolRej.Models
{
    public class Banco
    {
        string StringDeConexao= "Data Source=produtos.db";
        public static void CriarBanco()
        {
            SqliteConnection conexao = new SqliteConnection(StringDeConexao);
            conexao.Open();
        }
    }
}
