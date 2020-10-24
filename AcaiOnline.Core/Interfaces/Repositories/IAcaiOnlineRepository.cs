using System.Threading.Tasks;

namespace AcaiOnline.Core.Interfaces.Repositories
{
    public interface IAcaiOnlineRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
    }
}