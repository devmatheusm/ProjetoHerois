using System;

namespace TrabalhoHerois.Model.Entities
{
    public class Pessoa
    {
        protected int idPessoa;
        protected string nomePessoa;
        protected int idade;
        protected string email;
        protected string caminhoImagem;
        protected int anoNasc;
        protected string atividadeProfissional;
        // CONSTRUTORES
        public Pessoa()
        {
            idPessoa = idade = anoNasc = 0;
            nomePessoa = email = caminhoImagem = atividadeProfissional = "";
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
        // METODO
        public void calcularIdade(int AnoNascimento) // CADE O ANO NASCIMENTO
        {
            idade = DateTime.Today.Year - AnoNascimento;
            return;
        }
    }
}
