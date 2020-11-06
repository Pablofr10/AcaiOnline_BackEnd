using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Entities
{
    public class Pedido : BaseEntity
    {
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public DateTime? DataExclusao { get; set; }
        public int Tempo { get; set; }
        public string Observacao { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        public bool entrega { get; set; }
        public StatusPedido Status { get; set; }
        public ICollection<Adicional> Adicionais { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Pagamento> Pagamento { get; set; }
        public ICollection<PedidoProduto> PedidoProduto { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o cliente.")]
        public int ClienteId { get; set; }

    }
}
