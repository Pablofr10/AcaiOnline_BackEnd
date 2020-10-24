using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Entities.Models
{
    public class Pagamento : BaseEntity
    {
        public FormaPagamento FormaPagamento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Valor { get; set; }
        public int PedidoId { get; set; }
        [NotMapped]
        public Pedido Pedidos { get; set; }
    }
}
