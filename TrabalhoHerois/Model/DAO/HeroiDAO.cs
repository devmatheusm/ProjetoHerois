using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.Model.DAO
{
    public class HeroiDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            Heroi heroi = new Heroi();
            heroi = (Heroi)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE HEROIS set nome = '" + heroi.NomePessoa +
                 "', anoNasc '" + heroi.AnoNasc +
                 "', idade'" + heroi.Idade +
                 "', email'" + heroi.Email +
                 "', caminhoImagem'" + heroi.CaminhoImagem +
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
        
        public bool excluir(object objeto)
        {
            Heroi heroi = new Heroi();
            heroi = (Heroi)objeto;
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
            Heroi heroi = new Heroi();
            heroi = (Heroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO HEROIS (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeHeroi, planetaOrigem, atividadeProfissional, " +
                "parceiro, superPoder, grupo, pontoFraco) " +
                "values (' " + heroi.NomePessoa +
                "', '" + heroi.AnoNasc +
                "', '" + heroi.Idade +
                "', '" + heroi.Email +
                "', '" + heroi.CaminhoImagem +
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