using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Core.Dtos
{
    public class PagamentoDto : BaseDto
    {
        public int FormaPagamento { get; set; }
        public decimal? Valor { get; set; }
    }
}
