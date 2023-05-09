using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.Entities
{
    public class AmigoHeroi : Pessoa
    {
        protected string hobby;
        protected string atividadeProfissional;
        // CONSTRUTORES
        public AmigoHeroi() : base()
        {
            hobby = atividadeProfissional = "indefinido.";
        }
        // PROPRIEDADES
        public string Hobby{
            get {return hobby;}
            set {if (value.Trim() != "") hobby = value;}
        }
        public string AtividadeProfissional{
            get {return atividadeProfissional;}
            set {if (value.Trim() != "") atividadeProfissional = value;}
        }
        // no metodos. F.
    }
}