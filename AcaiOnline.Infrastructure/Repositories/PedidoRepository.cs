using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcaiOnline.Core.Interfaces.Repositories;
using AcaiOnline.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace AcaiOnline.Infrastructure.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly AcaiOnlineDbContext _context;

        public PedidoRepository(AcaiOnlineDbContext context): base (context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pedido>> GetAll()
        {
            IQueryable<Pedido> query = _context.Pedido
                .Include(p => p.Adicionais)
                .Include(p => p.PedidoProduto)
                .ThenInclude(pr => pr.Produto);

            query = query
                .AsNoTracking()
                .Where(c => c.DataExclusao == null)
                .OrderByDescending(c => c.Id);

            var result = await query.ToArrayAsync();

            return await query.ToArrayAsync();
        }

        public async Task<Pedido> GetById(int pedidoId)
        {
            IQueryable<Pedido> query = _context.Pedido
                .Include(a => a.Adicionais)
                .Include(pag => pag.Pagamento)
                .Include(c => c.Cliente)
                .ThenInclude(f => f.Fidelidade)
                .Include(p => p.PedidoProduto)
                .ThenInclude(pe => pe.Produto)
                .Include(p => p.Pagamento);

            query = query
                .AsNoTracking()
                .OrderBy(c => c.Id)
                .Where(c => c.Id == pedidoId && c.DataExclusao == null);

            return await query.FirstOrDefaultAsync();
        }
    }
}