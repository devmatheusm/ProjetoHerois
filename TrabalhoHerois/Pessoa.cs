namespace TrabalhoHerois
{
    public class Pessoa
    {
        protected int idPessoa;
        protected string nomePessoa;
        protected int idade;
        protected string email;
        // CONSTRUTORES
        public Pessoa()
        {
            idPessoa = idade = 0;
            nomePessoa = email = "indefinido.";
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
        // METODO
        public void calcularIdade(int AnoAtual, int AnoNascimento) // CADE O ANO NASCIMENTO
        {
            idade = AnoAtual - AnoNascimento;
            return;
        }
    }
}
