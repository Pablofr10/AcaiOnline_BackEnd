using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            IQueryable<Produto> query = _context.Produto;

            query = query
                .AsNoTracking()
                .Where(p => p.DataExclusao != null)
                .OrderByDescending(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Produto> GetProdutoById(int produtoId)
        {
            IQueryable<Produto> query = _context.Produto;
            
            query = query
                .AsNoTracking()
                .Where(p => p.Id == produtoId && p.DataExclusao != null)
                .OrderByDescending(c => c.Id);

            return await query.FirstOrDefaultAsync();
        }

        public void AddProduto(Produto produto)
        {
             _context.Add(produto);
        }
    }
}