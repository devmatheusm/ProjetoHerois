using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.Entities
{//CREATING THE CLASS
    internal class Vilao : Pessoa
    {//CREATING THE VARIABLES
        private string planetaOrigemV, parceiroV, superPoderV, nomeVilao;
        public Vilao() : base()
        {//OBJECT
            planetaOrigemV = parceiroV = superPoderV = nomeVilao = "";
        }
        public string PlanetaOrigemV
        {//CONSTRUCTOR
            get{ return planetaOrigemV; } 
            set{ planetaOrigemV = value; }
        }
        public string ParceiroV
        {//CONSTRUCTOR
            get{ return parceiroV; } 
            set{ parceiroV = value; }
        }
        public string SuperPoderV
        {//CONSTRUCTOR
            get{ return superPoderV; } 
            set{ superPoderV = value; }
        }
        public string NomeVilao
        {//CONSTRUCTOR   
            get{ return nomeVilao; } 
            set{ nomeVilao = value; }
        }
    }
}
