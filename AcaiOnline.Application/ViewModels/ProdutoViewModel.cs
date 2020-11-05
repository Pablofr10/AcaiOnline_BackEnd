using System.Collections.Generic;
using AcaiOnline.Core.Dtos;

namespace AcaiOnline.Application.ViewModels
{
    public class ProdutoViewModel
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