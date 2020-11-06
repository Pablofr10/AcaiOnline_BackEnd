using System.ComponentModel.DataAnnotations.Schema;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Entities
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
