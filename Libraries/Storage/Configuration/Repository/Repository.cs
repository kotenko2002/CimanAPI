using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Configuration.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected CimanDBContext _context;
        protected DbSet<TEntity> dbSet;
        protected readonly ILogger _logger;

        public Repository(CimanDBContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            dbSet.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<TEntity> FindAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }
    }
}
