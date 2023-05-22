using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrabalhoHerois.Model.DAO
{
    class Conexao
    {
        private static string connString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = DB_Herois_viloes3; Integrated Security = true;";

        //Representa a conexao do Banco
        private static SqlConnection conn = null;

        //Métodos que permitem obter conexao
        public static SqlConnection obterConexao()
        {
            //vamos Criar a conexao
            conn = new SqlConnection(connString);

            //a conexao foi feita com sucesso?
            try
            {
                conn.Open();
                Console.WriteLine("Conexão OK");
            }
            catch (SqlException sqle)
            {
                conn = null;
                MessageBox.Show("Conexão Error :" + sqle);
                Console.WriteLine("Conexão Error :" + sqle);
                //Mostra o erro que ocorreu no campo
            }
            finally
            {
                Console.WriteLine("Executado Sempre");
            }
            return conn;
        }
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
                Console.WriteLine("Conexao Fechada");
            }
        }
    }
}
