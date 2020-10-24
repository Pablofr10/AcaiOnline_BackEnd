using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Entities.Models
{
    public class Categoria : BaseEntity
    {
        public string Nome { get; set; }
        public ICollection<CategoriaProduto> CategoriaProdutos { get; set; }
    }
}
