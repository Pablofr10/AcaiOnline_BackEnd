using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Entities
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public DateTime? DataExclusao { get; set; }
        public string Descricao { get; set; }
        public string ImagemURL { get; set; }
        public bool IsDisponivel { get; set; }
        public ICollection<PedidoProduto> PedidoProdutos { get; set; }
        public ICollection<CategoriaProduto> CategoriaProduto { get; set; }


    }
}
