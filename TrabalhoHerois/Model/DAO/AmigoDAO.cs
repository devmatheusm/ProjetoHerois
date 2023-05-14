using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.DAO {
    class AmigoDAO : IDao {
        public bool atualizar(object objeto) {
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
                 "' Where idHeroi =" + amigo.IdPessoa;
            try {
                SqlCommand command = new SqlCommand(UPDATE, Conexao.obterConexao());

                if (command.ExecuteNonQuery() == 1) {
                    Console.WriteLine("Sucesso na Atualização dos Dados");
                    command.Dispose();
                    sucesso = true;
                }
            } catch (SqlException ex) {
                Console.WriteLine("Erro na Atualização" + ex);
            } finally { Conexao.fecharConexao(); }
            return sucesso;

        }

        public bool consultar(object objeto) {
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;

            bool sucesso = false;

            string SELECT = "SELECT * FROM HEROIS WHERE idHeroi = " + amigo.IdPessoa;

            try {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(SELECT, conexaoDB);

                //dataReader ira receber o resultado da consulta
                // somente para leitura 
                SqlDataReader dataReader;

                //Exuta a consulta
                dataReader = command.ExecuteReader();

                if (dataReader.Read()) // Lendo Registro
                {
                    amigo.IdPessoa = dataReader.GetInt32(0);
                    amigo.NomePessoa = dataReader.GetString(1);
                    amigo.AnoNasc = dataReader.GetInt32(2);
                    amigo.Idade = dataReader.GetInt32(3);
                    amigo.Email = dataReader.GetString(4);
                    amigo.CaminhoImagem = dataReader.GetString(5);
                    amigo.AtividadeProfissional = dataReader.GetString(7);
                    amigo.Hobby = dataReader.GetString(8);

                    command.Dispose();
                    sucesso = true;
                }
            } catch (SqlException ex) {
                Console.WriteLine("Erro na Consulta: " + ex);
            } finally {
                Conexao.fecharConexao();
            }
            return sucesso;
        }

        public List<object> consultar(string sql) {
            List<object> listaAmigo = null;
            try {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(sql, conexaoDB);

                // DataReader ira receber o resultada da consulta 
                //Somente para leitura
                SqlDataReader dataReader;

                // Executa a consulta 
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                    listaAmigo = new List<object>();

                while (dataReader.Read()) // Lendo Registros 
                {
                    AmigoHeroi amigo = new AmigoHeroi();
                    amigo.IdPessoa = dataReader.GetInt32(0);
                    amigo.NomePessoa = dataReader.GetString(1);
                    amigo.AnoNasc = dataReader.GetInt32(2);
                    amigo.Idade = dataReader.GetInt32(3);
                    amigo.Email = dataReader.GetString(4);
                    amigo.CaminhoImagem = dataReader.GetString(5);
                    amigo.AtividadeProfissional = dataReader.GetString(7);
                    amigo.Hobby = dataReader.GetString(8);

                    listaAmigo.Add(amigo);
                }
            } catch (SqlException ex) {
                Console.WriteLine("Erro na Consulta: " + ex);
            } finally {
                Conexao.fecharConexao();
            }
            return listaAmigo;
        }

        public bool excluir(object objeto) {
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;
            bool sucesso = false;
            string DELETE = "DELETE FROM herois WHERE idHeroi = " + amigo.IdPessoa;
            try {
                SqlConnection conexaoDB = Conexao.obterConexao();
                SqlCommand Command = new SqlCommand(DELETE, conexaoDB);
                if (Command.ExecuteNonQuery() == 1) {
                    Command.Dispose();
                    sucesso = true;
                }
            } catch (SqlException ex) {
                Console.WriteLine("Erro de exclusão" + ex);
            } finally {
                Conexao.fecharConexao();
            }
            return sucesso;
        }

        public bool inserir(object objeto) {
            AmigoHeroi amigo = new AmigoHeroi();
            amigo = (AmigoHeroi)objeto;

            bool sucesso = false;

            string INSERT = "INSERT INTO HEROIS (nome, anoNasc, idade, " +
                "email, caminhoImagem, hobby, atividadeProfissional) " +
                "values (' " + amigo.NomePessoa +
                "', '" + amigo.AnoNasc +
                "', '" + amigo.Idade +
                "', '" + amigo.Email +
                "', '" + amigo.CaminhoImagem +
                "', '" + amigo.Hobby +
                "', '" + amigo.AtividadeProfissional +
                "' )";

            try {
                SqlConnection ConexaoDb = Conexao.obterConexao();
                SqlCommand command = new SqlCommand(INSERT, ConexaoDb);

                if (command.ExecuteNonQuery() == 1) {
                    Console.WriteLine("Sucesso na Inscrição");
                    command.Dispose();
                    sucesso = true;
                }
            } catch (SqlException ex) {
                Console.WriteLine("Erro de Inserção " + ex);
            } finally {
                Conexao.fecharConexao();
            }
            return sucesso;
        }
    }
}