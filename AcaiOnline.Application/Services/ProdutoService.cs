using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcaiOnline.Core.Entities;
using AcaiOnline.Core.Interfaces.Repositories;
using AcaiOnline.Core.Interfaces.Services;

namespace AcaiOnline.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IUnitOfWork _repository;

        public ProdutoService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Produto>> GetAllProdutos()
        {
            var produtos = await _repository.ProdutoRepository.GetAllProdutos();

            return produtos;
        }

        public async Task<Produto> GetProdutoById(int id)
        {
            var produto = await _repository.ProdutoRepository.GetProdutoById(id);

            if (produto == null)
            {
                return null;
            }

            return produto;
        }

        public async Task<bool> AddProduto(Produto produto)
        {
            _repository.ProdutoRepository.AddProduto(produto);

            return await _repository.SaveAll();
        }

        public Task<bool> DeleteProduto(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateProduto(Produto produto)
        {
            throw new System.NotImplementedException();
        }
    }
}