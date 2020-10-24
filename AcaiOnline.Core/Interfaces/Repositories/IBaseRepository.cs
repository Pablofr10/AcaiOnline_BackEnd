using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcaiOnline.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}