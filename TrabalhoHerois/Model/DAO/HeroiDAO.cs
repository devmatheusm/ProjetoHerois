using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.DAO
{
    static class HeroiDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            SuperHeroi heroi = new SuperHeroi();
            heroi = (SuperHeroi)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE HEROIS set nome = '" + heroi.NomePessoa +
                 "', anoNasc '" + heroi.AnoNasc +
                 "', idade'" + heroi.Idade +
                 "', email'" + heroi.Email +
                 "', caminhoImagem'" + heroi.caminhoImagem +
                 "', nomeHeroi'" + heroi.NomeHeroi +
                 "', planetaOrigem'" + heroi.PlanetaOrigem +
                 "', atividadeProfissional'" + heroi.AtividadeProfissional +
                 "', parceiro '" + heroi.Parceiro +
                 "', superPoder '" + heroi.SuperPoder +
                 "', grupo '" + heroi.Grupo +
                 "', pontoFraco'" + heroi.PontoFraco +
                 "' Where idHeroi =" + heroi.IdPessoa;
            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(UPDATE, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Atualização dos Dados");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Atualização" + ex);
            }
            finally { Conexao.fecharConexao(); }
            return sucesso;
        }
        public bool consultar(object objeto)
        {
            SuperHeroi heroi = new SuperHeroi();
            heroi = (SuperHeroi)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM HEROIS WHERE idHeroi = " + heroi.IdPessoa;

            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Exuta a consulta
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) // Lendo Registro
                {
                    heroi.IdPessoa = dataReader.GetInt32(0);
                    heroi.NomePessoa = dataReader.GetString(1);
                    heroi.AnoNasc = dataReader.GetInt32(2);
                    heroi.Idade = dataReader.GetInt32(3);
                    heroi.Email = dataReader.GetString(4);
                    heroi.caminhoImagem = dataReader.GetString(5);
                    heroi.NomeHeroi = dataReader.GetString(6);
                    heroi.PlanetaOrigem = dataReader.GetString(7);
                    heroi.AtividadeProfissional = dataReader.GetString(8);
                    heroi.Parceiro = dataReader.GetString(9);
                    heroi.SuperPoder = dataReader.GetString(10);
                    heroi.Grupo = dataReader.GetString(11);
                    heroi.PontoFraco = dataReader.GetString(12);

                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
        public List<object> consultar(string sql)
        {
            List<object> listaHeroi = null;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(sql, conexaoDB);

                // DataReader ira receber o resultada da consulta 
                //Somente para leitura
                SqlDataReader dataReader;

                // Executa a consulta 
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                    listaHeroi = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                    SuperHeroi heroi = new SuperHeroi();
                    heroi.IdPessoa = dataReader.GetInt32(0);
                    heroi.NomePessoa = dataReader.GetString(1);
                    heroi.AnoNasc = dataReader.GetInt32(2);
                    heroi.Idade = dataReader.GetInt32(3);
                    heroi.Email = dataReader.GetString(4);
                    heroi.caminhoImagem = dataReader.GetString(5);
                    heroi.NomeHeroi = dataReader.GetString(6);
                    heroi.PlanetaOrigem = dataReader.GetString(7);
                    heroi.AtividadeProfissional = dataReader.GetString(8);
                    heroi.Parceiro = dataReader.GetString(9);
                    heroi.SuperPoder = dataReader.GetString(10);
                    heroi.Grupo = dataReader.GetString(11);
                    heroi.PontoFraco = dataReader.GetString(12);

                    listaHeroi.Add(heroi);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro na Consulta: " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return listaHeroi;
        }
        public bool excluir(object objeto)
        {
            SuperHeroi heroi = new SuperHeroi();
            heroi = (SuperHeroi)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM herois WHERE idHeroi = " + heroi.IdPessoa;
            try
            {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, conexaoDB);
                if (Command.ExecuteNonQuery() == 1)
                {
                    Command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de exclusão" + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
        public bool inserir(object objeto)
        {
            SuperHeroi heroi = new SuperHeroi();
            heroi = (SuperHeroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO HEROIS (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeHeroi, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder, grupo, pontoFraco) " +
                "values (' " + heroi.NomePessoa +
                "', '" + heroi.AnoNasc +
                "', '" + heroi.Idade +
                "', '" + heroi.Email +
                "', '" + heroi.caminhoImagem +
                "', '" + heroi.NomeHeroi +
                "', '" + heroi.PlanetaOrigem +
                "', '" + heroi.AtividadeProfissional +
                "', '" + heroi.Parceiro +
                "', '" + heroi.SuperPoder +
                "', '" + heroi.Grupo +
                "', '" + heroi.PontoFraco +
                "' )";
            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Sucesso na Inscrição");
                    command.Dispose();
                    sucesso = true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro de Inserção " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
    }
}