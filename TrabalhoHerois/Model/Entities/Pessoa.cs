namespace TrabalhoHerois.Model.Entities
{
    public class Pessoa
    {
        private int idPessoa;
        private string nomePessoa;
        private int idade;
        private string email;
        private string caminhoImagem;
        private int anoNasc;
        // CONSTRUTORES
        public Pessoa()
        {
            idPessoa = idade = anoNasc = 0;
            nomePessoa = email = caminhoImagem = "indefinido.";
        }
        // PROPRIEDADES
        public int IdPessoa
        {
            get { return idPessoa; }
            set { if (value > 0) idPessoa = value; }
        }
        public string NomePessoa
        {
            get { return nomePessoa; }
            set { if (value.Trim() != "") nomePessoa = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { if (value > 0) idade = value; }
        }
        public string Email
        {
            get { return email; }
            set { if (value.Trim() != "") email = value; }
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
        // METODO
        public void calcularIdade(int AnoAtual, int AnoNascimento) // CADE O ANO NASCIMENTO
        {
            idade = AnoAtual - AnoNascimento;
            return;
        }
    }
}
