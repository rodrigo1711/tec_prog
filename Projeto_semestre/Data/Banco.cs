using Microsoft.Data.Sqlite;

namespace Projeto_semestre.Data
{
    public class Banco
    {
        private static string caminho = "Data Source = agencia.db";

        public static SqliteConnection obterConexao() //metodo cria retorno de con sql
        {
            SqliteConnection conexao = new SqliteConnection(caminho); // conexão = var que vai receber resultado do tipo conexao de sql
            conexao.Open();
            return conexao;
            // se existir ele conecta, se nao cria e conecta
        }
        public static void CriarBanco()
        {
            SqliteConnection conexao = obterConexao();
            conexao.Open();
            String sql = """
            CREATE TABLE IF NOT EXISTS CarroDao(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nome TEXT NOT NULL,
                descricao TEXT NOT NULL,
                ano INTEGER,
                quilometragem INTEGER,
                cambio TEXT NOT NULL,
                preco REAL NOT NULL
            
            )
            """;
            SqliteCommand cmd = new SqliteCommand(sql,conexao);
            cmd.ExecuteNonQuery(); //criar tabela

        }
    }
    
}
