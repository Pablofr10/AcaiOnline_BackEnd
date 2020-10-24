using System.Threading.Tasks;
using AcaiOnline.Core.Interfaces.Repositories;

namespace AcaiOnline.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AcaiOnlineDbContext _context;
        private IPedidoRepository _pedidoRepository;

        public UnitOfWork(AcaiOnlineDbContext context)
        {
            _context = context;
        }

        public IPedidoRepository PedidoRepository
        {
            get
            {
                return _pedidoRepository ??= new PedidoRepository(_context);
            }
        }
        
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}