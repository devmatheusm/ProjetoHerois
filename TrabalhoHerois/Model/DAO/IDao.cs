using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoHerois.Model.DAO
{
    interface IDao
    {
        bool atualizar(object objeto);
        bool excluir(object objeto);
        bool inserir(object objeto);
        bool consultar(object objeto);
        List<Object> consultar(string sql);
    }
}