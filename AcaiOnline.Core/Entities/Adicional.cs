using System.ComponentModel.DataAnnotations.Schema;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Entities
{
    public class Adicional : BaseEntity
    {
        public int AcompanhamentoId { get; set; }
        public Acompanhamento Acompanhamento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Total { get; set; }        
        public int Quantidade { get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        [NotMapped]
        public Pedido Pedidos { get; set; }
    }
}
