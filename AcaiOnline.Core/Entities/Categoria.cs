using System.Collections.Generic;

namespace AcaiOnline.Core.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nome { get; set; }
        public ICollection<CategoriaProduto> CategoriaProdutos { get; set; }
    }
}
