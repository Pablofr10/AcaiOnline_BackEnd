using System.Collections.Generic;
using System.Threading.Tasks;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetAllProdutos();
        Task<Produto> GetProdutoById(int pedidoId);
        void AddProduto(Produto produto);
    }
}