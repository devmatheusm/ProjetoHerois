namespace TrabalhoHerois.Model.Entities
{
    public class AmigoHeroi : Pessoa
    {
        //VARIAVEL DO AMIGO
        protected string hobby;
        // CONSTRUTOR DO AMIGO
        public AmigoHeroi() : base()
        {
            hobby = "";
        }
        // PROPRIEDADE DO AMIGO
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
    }
}