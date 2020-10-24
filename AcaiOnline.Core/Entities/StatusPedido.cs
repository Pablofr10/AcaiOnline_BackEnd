using System;
using System.Collections.Generic;
using System.Text;

namespace AcaiOnline.Entities.Models
{
    public enum StatusPedido
    {
        Pendente = 0,
        Aprovado = 1,
        EmPreparo = 2,
        Pronto = 3,
        SaiuParaEntrega = 4,
        Atrasado = 5,
        Cancelado = 6,
    }
}
