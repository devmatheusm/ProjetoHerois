using System;

namespace TrabalhoHerois.Model.Entities
{
    public class Pessoa
    {
        //VARIAVEIS GERAIS DA PESSOA
        protected int idPessoa;
        protected string nomePessoa;
        protected int idade;
        protected string email;
        protected string caminhoImagem;
        protected int anoNasc;
        protected string atividadeProfissional;
        // CONSTRUTOR DA PESSOA
        public Pessoa()
        {
            idPessoa = idade = anoNasc = 0;
            nomePessoa = email = caminhoImagem = atividadeProfissional = "";
        }
        // PROPRIEDADES DA PESSOA
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
        // METODO DA PESSOA
        //metodo que calcula a idade
        public void calcularIdade(int AnoNascimento)
        {
            idade = DateTime.Today.Year - AnoNascimento;
            return;
        }
    }
}
