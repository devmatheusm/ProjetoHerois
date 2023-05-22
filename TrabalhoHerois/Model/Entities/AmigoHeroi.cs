namespace TrabalhoHerois.Model.Entities
{
    public class AmigoHeroi : Pessoa
    {
        protected int idAmigo;
        protected string hobby;
        // CONSTRUTORES
        public AmigoHeroi() : base()
        {
            idAmigo = 0;
            hobby = "";
        }
        // PROPRIEDADES
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
        public int IdAmigo
        {
            get { return idAmigo; }
            set { idAmigo = value; }
        }
    }
}