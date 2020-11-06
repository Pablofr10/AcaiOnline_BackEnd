using AcaiOnline.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcaiOnline.Core.Entities;

namespace AcaiOnline.Core.Dtos
{
    public class PedidoDto : BaseDto
    {
        public DateTime DataPedido { get; set; }
        public DateTime? DataExclusao { get; set; }
        public string Observacao { get; set; }
        public int Tempo { get; set; }
        public decimal Total { get; set; }
        public bool Entrega { get; set; }
        public StatusPedido Status { get; set; }        
        public ICollection<PagamentoDto> Pagamento { get; set; }
        public ICollection<ProdutoDto> Produto { get; set; }
        public ICollection<Adicional> Adicionais { get; set; }
        public int ClienteId { get; set; }
        public ClienteDto Cliente { get; set; }
    }
}
