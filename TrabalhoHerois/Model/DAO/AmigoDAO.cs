using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrabalhoHerois.Model.Entities;

namespace TrabalhoHerois.Model.DAO
{
    class AmigoDAO : IDao
    {
        public bool atualizar(object objeto)
        {
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;

            bool sucesso = false;

            string UPDATE = "UPDATE AmigosHeroi set nome = '" + amigo.NomePessoa +
                 "', idade'" + amigo.Idade +
                 "', anoNasc'" + amigo.AnoNasc +
                 "', email'" + amigo.Email +
                 "', caminhoImagem'" + amigo.CaminhoImagem +
                 "', hobby'" + amigo.Hobby +
                 "', atividadeProfissional'" + amigo.AtividadeProfissional +
                 "' Where idAmigo =" + amigo.IdAmigo;
            try
            {
                SqlCommand command = new SqlCommand(UPDATE, Conexao.obterConexao());

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
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM amigosheroi WHERE idAmigo = " + amigo.IdAmigo;
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
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO AmigosHeroi (nome, anoNasc, idade, " +
                "email, caminhoImagem, hobby, atividadeProfissional) " +
                "values (' " + amigo.NomePessoa +
                "', '" + amigo.AnoNasc +
                "', '" + amigo.Idade +
                "', '" + amigo.Email +
                "', '" + amigo.CaminhoImagem +
                "', '" + amigo.Hobby +
                "', '" + amigo.AtividadeProfissional +
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
                MessageBox.Show("Erro de Inserção " + ex);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
    }
}