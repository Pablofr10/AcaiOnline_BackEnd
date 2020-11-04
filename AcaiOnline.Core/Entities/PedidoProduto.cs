using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AcaiOnline.Core.Entities;

namespace AcaiOnline.Entities.Models
{
    public class PedidoProduto
    {
        [Key]
        public int RelId { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }
        [NotMapped]
        public Pedido Pedido { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        [NotMapped]
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
