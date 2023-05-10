//using TrabalhoHerois.Model.DAO;
//using TrabalhoHerois.Model.Entities;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TrabalhoHerois.Model.DAO
//{
//    class VilaoDAO : IDao
//    {
//        public bool atualizar(object objeto)
//        {
//            Vilao vilao = new Vilao();
//            vilao = (Vilao)objeto;

//            bool sucesso = false;

//            string UPDATE = "UPDATE VILOES set nome = '" + vilao.NomePessoa +
//                 "', anoNasc '" + vilao.AnoNasc +
//                 "', idade'" + vilao.Idade +
//                 "', email'" + vilao.Email +
//                 "', caminhoImagem'" + vilao.CaminhoImagem +
//                 "', nomeVilao'" + vilao.NomeVilao +
//                 "', planetaOrigemV'" + vilao.PlanetaOrigemV +
//                 "', parceiro '" + vilao.ParceiroV +
//                 "', superPoder '" + vilao.SuperPoderV +
//                 "', grupo '" + vilao.Grupo +
//                 "', pontoFraco'" + vilao.PontoFraco +
//                 "' Where idHeroi =" + vilao.IdPessoa;
//            try
//            {
//                SqlConnection ConexaoDb = Conexao.obterConexao();
//                SqlCommand command = new SqlCommand(UPDATE, ConexaoDb);

//                if (command.ExecuteNonQuery() == 1)
//                {
//                    Console.WriteLine("Sucesso na Atualização dos Dados");
//                    command.Dispose();
//                    sucesso = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Erro na Atualização" + ex);
//            }
//            finally { Conexao.fecharConexao(); }
//            return sucesso;
//        }
//        public bool consultar(object objeto)
//        {
//            Vilao vilao = new Vilao();
//            vilao = (Vilao)objeto;

//            bool sucesso = false;

//            string SELECT = "SELECT * FROM VILOES WHERE idVilao = " + vilao.IdPessoa;

//            try
//            {
//                SqlConnection conexaoDB = Conexao.obterConexao();
//                SqlCommand command = new SqlCommand(SELECT, conexaoDB);

//                //dataReader ira receber o resultado da consulta
//                // somente para leitura 
//                SqlDataReader dataReader;

//                //Exuta a consulta
//                dataReader = command.ExecuteReader();

//                if (dataReader.Read()) // Lendo Registro
//                {
//                    vilao.IdPessoa = dataReader.GetInt32(0);
//                    vilao.NomePessoa = dataReader.GetString(1);
//                    vilao.AnoNasc = dataReader.GetInt32(2);
//                    vilao.Idade = dataReader.GetInt32(3);
//                    vilao.Email = dataReader.GetString(4);
//                    vilao.caminhoImagem = dataReader.GetString(5);
//                    vilao.NomeVilao = dataReader.GetString(6);
//                    vilao.PlanetaOrigemV = dataReader.GetString(7);
//                    vilao.AtividadeProfissional = dataReader.GetString(8);
//                    vilao.ParceiroV = dataReader.GetString(9);
//                    vilao.SuperPoderV = dataReader.GetString(10);
//                    vilao.Grupo = dataReader.GetString(11);
//                    vilao.PontoFraco = dataReader.GetString(12);

//                    command.Dispose();
//                    sucesso = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Erro na Consulta: " + ex);
//            }
//            finally
//            {
//                Conexao.fecharConexao();
//            }
//            return sucesso;
//        }

//        public List<object> consultar(string sql)
//        {
//            List<object> listaViloes = null;
//            try
//            {
//                SqlConnection conexaoDB = Conexao.obterConexao();
//                SqlCommand command = new SqlCommand(sql, conexaoDB);

//                // DataReader ira receber o resultada da consulta 
//                //Somente para leitura
//                SqlDataReader dataReader;

//                // Executa a consulta 
//                dataReader = command.ExecuteReader();
//                if (dataReader.HasRows)
//                    listaVilao = new List<object>();

//                while (dataReader.Read()) // Lendo Registros 
//                {
//                    Vilao vilao = new Vilao();
//                    vilao.IdPessoa = dataReader.GetInt32(0);
//                    vilao.NomePessoa = dataReader.GetString(1);
//                    vilao.AnoNasc = dataReader.GetInt32(2);
//                    vilao.Idade = dataReader.GetInt32(3);
//                    vilao.Email = dataReader.GetString(4);
//                    vilao.caminhoImagem = dataReader.GetString(5);
//                    vilao.NomeVilao = dataReader.GetString(6);
//                    vilao.PlanetaOrigemV = dataReader.GetString(7);
//                    vilao.AtividadeProfissional = dataReader.GetString(8);
//                    vilao.ParceiroV = dataReader.GetString(9);
//                    vilao.SuperPoderV = dataReader.GetString(10);
//                    vilao.Grupo = dataReader.GetString(11);
//                    vilao.PontoFraco = dataReader.GetString(12);

//                    listaVilao.Add(vilao);
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Erro na Consulta: " + ex);
//            }
//            finally
//            {
//                Conexao.fecharConexao();
//            }
//            return listaHeroi;
//        }

//        public bool excluir(object objeto)
//        {
//            Vilao vilao = new Vilao();
//            vilao = (Vilao)objeto;
//            bool sucesso = false;
//            string DELETE = "DELETE FROM viloes WHERE idVilao = " + vilao.IdPessoa;
//            try
//            {
//                SqlConnection conexaoDB = Conexao.obterConexao();
//                SqlCommand Command = new SqlCommand(DELETE, conexaoDB);
//                if (Command.ExecuteNonQuery() == 1)
//                {
//                    Command.Dispose();
//                    sucesso = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Erro de exclusão" + ex);
//            }
//            finally
//            {
//                Conexao.fecharConexao();
//            }
//            return sucesso;
//        }
//        public bool inserir(object objeto)
//        {
//            Vilao vilao = new Vilao();
//            vilao = (Vilao)objeto;

//            bool sucesso = false;

//            string INSERT = "INSERT INTO VILOES (nome, anoNasc, idade, " +
//                "email, caminhoImagem, nomeVilao, planetaOrigemV, atividadeProfissional, " +
//                "parceiroV, superPoderV, grupo, pontoFraco) " +
//                "values (' " + vilao.NomePessoa +
//                "', '" + vilao.AnoNasc +
//                "', '" + vilao.Idade +
//                "', '" + vilao.Email +
//                "', '" + vilao.caminhoImagem +
//                "', '" + vilao.NomeVilao +
//                "', '" + vilao.PlanetaOrigemV +
//                "', '" + vilao.AtividadeProfissional +
//                "', '" + vilao.ParceiroV +
//                "', '" + vilao.SuperPoderV +
//                "', '" + vilao.Grupo +
//                "', '" + vilao.PontoFraco +
//                "' )";
//            try
//            {
//                SqlConnection ConexaoDb = Conexao.obterConexao();
//                SqlCommand command = new SqlCommand(INSERT, ConexaoDb);

//                if (command.ExecuteNonQuery() == 1)
//                {
//                    Console.WriteLine("Sucesso na Inscrição");
//                    command.Dispose();
//                    sucesso = true;
//                }
//            }
//            catch (SqlException ex)
//            {
//                Console.WriteLine("Erro de Inserção " + ex);
//            }
//            finally
//            {
//                Conexao.fecharConexao();
//            }
//            return sucesso;
//        }
//    }
//}
