using AcaiOnline.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Core.Dtos
{
    public class ProdutoDto : BaseDto
    {
        public string Nome { get; set; }        
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string ImagemURL { get; set; }
        public bool IsDisponivel { get; set; }
        public int Quantidade { get; set; }
        //public ICollection<PedidoDto> Pedido { get; set; }
        public ICollection<CategoriaDto> Categoria { get; set; }

    }
}
