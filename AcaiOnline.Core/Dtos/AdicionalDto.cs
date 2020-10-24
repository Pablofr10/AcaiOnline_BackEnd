using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Core.Dtos
{
    public class AdicionalDto : BaseDto
    {
        public int AcompanhamentoId { get; set; }
        public decimal? Total { get; set; }
        public int Quantidade { get; set; }
        //public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
    }
}
