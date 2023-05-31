using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.Model.DAO
{
    class VilaoDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            Vilao vilao = new Vilao();
            vilao = (Vilao)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE VILOES set nome = '" + vilao.NomePessoa +
                 "', anoNasc '" + vilao.AnoNasc +
                 "', idade'" + vilao.Idade +
                 "', email'" + vilao.Email +
                 "', caminhoImagem'" + vilao.CaminhoImagem +
                 "', nomeVilao'" + vilao.NomeVilao +
                 "', planetaOrigem'" + vilao.PlanetaOrigem +
                 "', parceiro '" + vilao.Parceiro +
                 "', superPoder '" + vilao.SuperPoder +
                 "', grupo '" + vilao.Grupo +
                 "', pontoFraco'" + vilao.PontoFraco +
                 "' Where idVilao =" + vilao.IdPessoa;
            try
            {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(UPDATE, ConexaoDb);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucesso na Atualização dos Dados");
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
            Vilao vilao = new Vilao();
            vilao = (Vilao)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM viloes WHERE idVilao = " + vilao.IdPessoa;
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
            Vilao vilao = new Vilao();
            vilao = (Vilao)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO VILOES (nome, anoNasc, idade, " +
                "email, caminhoImagem, nomeVilao, planetaOrigem, " +
                "parceiro, superPoder) " +
                "values (' " + vilao.NomePessoa +
                "', '" + vilao.AnoNasc +
                "', '" + vilao.Idade +
                "', '" + vilao.Email +
                "', '" + vilao.CaminhoImagem +
                "', '" + vilao.NomeVilao +
                "', '" + vilao.PlanetaOrigem +
                "', '" + vilao.Parceiro +
                "', '" + vilao.SuperPoder +
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
