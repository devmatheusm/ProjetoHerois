using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.Entities
{
    public class Pessoa
    {
        protected int idPessoa;
        private string nomePessoa;
        private int idade;
        private string email;
        private string caminhoImagem;
        private int anoNasc;
        private string planetaOrigem;
        protected string atividadeProfissional;
        // CONSTRUTORES
        public Pessoa()
        {
            idPessoa = idade = anoNasc = 0;
            nomePessoa = email = caminhoImagem = planetaOrigem = atividadeProfissional = "";
        }
        // PROPRIEDADES
        public int IdPessoa
        {
            get { return idPessoa; }
            set { idPessoa = value; }
        }
        public string NomePessoa
        {
            get { return nomePessoa; }
            set { nomePessoa = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int AnoNasc 
        {
            get { return anoNasc; }
            set { anoNasc = value; }
        }
        public string CaminhoImagem
        {
            get { return caminhoImagem; }
            set { caminhoImagem = value; }
        }
        public string AtividadeProfissional
        {
            get { return atividadeProfissional; }
            set { atividadeProfissional = value; }
        }
        public string PlanetaOrigem
        {
            get { return planetaOrigem; }
            set { planetaOrigem = value; }
        }
        // METODO
        public void calcularIdade(int AnoAtual, int AnoNascimento) // CADE O ANO NASCIMENTO
        {
            idade = AnoAtual - AnoNascimento;
            return;
        }
    }
}
