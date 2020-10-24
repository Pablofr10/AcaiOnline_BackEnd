using System.Threading.Tasks;
using AcaiOnline.Core.Interfaces.Repositories;

namespace AcaiOnline.Infrastructure.Repositories
{
    public class AcaiOnlineRepository : IAcaiOnlineRepository
    {
        private readonly AcaiOnlineDbContext _context;

        public AcaiOnlineRepository(AcaiOnlineDbContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}