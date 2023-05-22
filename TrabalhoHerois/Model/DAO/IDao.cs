using System;
using System.Collections.Generic;

namespace TrabalhoHerois.Model.DAO
{
    interface IDao
    {
        bool atualizar(object objeto);
        bool excluir(object objeto);
        bool inserir(object objeto);
    }
}