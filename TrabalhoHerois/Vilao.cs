using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois
{
    internal class Vilao : Pessoa
    {
        private string planetaOrigemV, parceiroV, superPoderV, nomeVilao;
        public Vilao() : base()
        {
            planetaOrigemV = parceiroV = superPoderV = nomeVilao = "";
        }
        public string PlanetaOrigemV
        {get{return planetaOrigemV;} set{if(value.Trim() != "") planetaOrigemV = value;}}
        public string ParceiroV
        {get{return parceiroV;} set{if(value.Trim() != "") parceiroV = value;}}
        public string SuperPoderV
        {get{return superPoderV;} set{if(value.Trim() != "") superPoderV = value;}}
        public string NomeVilao
        {get{return nomeVilao;} set{if(value.Trim() != "") nomeVilao = value;}}
    }
}
