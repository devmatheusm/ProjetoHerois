namespace TrabalhoHerois.Model.Entities
{
    public class AmigoHeroi : Pessoa
    {
        protected string hobby;
        // CONSTRUTORES
        public AmigoHeroi() : base()
        {
            hobby = "";
        }
        // PROPRIEDADES
        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }
    }
}