using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AcaiOnline.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AcaiOnline.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AcaiOnlineDbContext _context;

        public BaseRepository(AcaiOnlineDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Attach(entity);
            _context.Remove(entity);
        }
    }
}