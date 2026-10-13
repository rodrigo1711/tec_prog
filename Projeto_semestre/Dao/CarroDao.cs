namespace Projeto_semestre.Dao
{
    public class CarroDao
    {
        private int Ano;
        private static string Modelo;

        public static CarroDao login()
        {
            return new CarroDao();
        }
    }
}

