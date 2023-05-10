using TrabalhoHerois.Model.DAO;
using TrabalhoHerois.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.Entities
{//CREATING THE CLASS
    internal class Vilao : Pessoa
    {//CREATING THE VARIABLES
        public int idVilao;
        protected string nomeVilao;
        public Vilao() : base()
        {//OBJECT
            idVilao = 0;
            nomeVilao = "";
        }
        public string NomeVilao
        { 
            get{ return nomeVilao; } 
            set{ nomeVilao = value; }
        }
        public int IdVilao
        {
            get { return idVilao; }
            set { idVilao = value; }
        }
    }
}
