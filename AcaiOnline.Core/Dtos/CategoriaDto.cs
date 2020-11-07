using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiOnline.Core.Dtos
{
    public class CategoriaDto : BaseDto
    {
        public string Nome { get; set; }
        public ICollection<ProdutoDto> Produto { get; set; }
    }
}
