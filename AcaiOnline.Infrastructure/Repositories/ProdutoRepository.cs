using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcaiOnline.Core.Entities;
using AcaiOnline.Core.Interfaces.Repositories;
using AcaiOnline.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace AcaiOnline.Infrastructure.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly AcaiOnlineDbContext _context;

        public ProdutoRepository(AcaiOnlineDbContext context): base(context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Produto>> GetAllProdutos()
        {
            var produtos = _context.Produto
                .AsNoTracking()
                .Include(p => p.CategoriaProduto)
                .ThenInclude(c => c.Categoria);

            var produtosFiltrados = await produtos.Where(p => p.DataExclusao == null)
                .OrderByDescending(c => c.Id).ToArrayAsync();
            
            return produtosFiltrados;
        }

        public async Task<Produto> GetProdutoById(int produtoId)
        {
            var produtos = _context.Produto
                .AsNoTracking()
                .Include(p => p.CategoriaProduto)
                .ThenInclude(c => c.Categoria);
                
                
                
            var produtoFiltrado = await produtos.Where(p => p.Id == produtoId && p.DataExclusao == null)
                .OrderByDescending(c => c.Id).FirstOrDefaultAsync();
            
            return produtoFiltrado;
        }

        public void AddProduto(Produto produto)
        {
             _context.Add(produto);
        }
    }
}