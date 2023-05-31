namespace TrabalhoHerois.Model.Entities
{//criando as classes
    internal class Vilao : Pessoa
    {
        //VARIAVEIS DO VILÃO
        protected string nomeVilao;
        protected string planetaOrigem;
        protected string parceiro;
        protected string superPoder;
        protected string grupo;
        protected string pontoFraco;
        // CONSTRUTOR DO VILÃO
        public Vilao() : base()
        {
            nomeVilao = parceiro = superPoder = planetaOrigem = grupo = pontoFraco = "";
        }
        //PROPRIEDADES DO VILÃO
        public string NomeVilao
        {
            get { return nomeVilao; }
            set { nomeVilao = value; }
        }
        public string PlanetaOrigem
        {
            get { return planetaOrigem; }
            set { planetaOrigem = value; }
        }
        public string Parceiro
        {
            get { return parceiro; }
            set { parceiro = value; }
        }
        public string SuperPoder
        {
            get { return superPoder; }
            set { superPoder = value; }
        }
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        public string PontoFraco
        {
            get { return pontoFraco; }
            set { pontoFraco = value; }
        }
    }
}
