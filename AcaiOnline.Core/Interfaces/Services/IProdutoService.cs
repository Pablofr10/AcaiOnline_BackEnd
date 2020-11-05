using System.Collections.Generic;
using System.Threading.Tasks;
using AcaiOnline.Core.Entities;
using AcaiOnline.Entities.Models;

namespace AcaiOnline.Core.Interfaces.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAllProdutos();
        Task<Produto> GetProdutoById(int id);
        Task<bool> AddProduto(Produto produto);
        Task<bool> DeleteProduto(Produto produto);
        Task<bool> UpdateProduto(Produto produto);
    }
}