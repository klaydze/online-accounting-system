using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Accounting.Domain.Interfaces;

namespace Accounting.Domain.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext Context;
        private bool disposed = false;

        public Repository(ApplicationDbContext context) 
            => Context = context;

        public void Create(TEntity entity) 
            => Context.Set<TEntity>().AddAsync(entity);

        public virtual async Task<TEntity> GetByIDAsync(Guid? id)
            => await Context.Set<TEntity>().FindAsync(id);
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() 
            => await Context.Set<TEntity>().ToListAsync();

        public void Update(TEntity entity)
        {
            Context.Entry<TEntity>(entity).State = EntityState.Modified;
            //Context.Set<TEntity>().Attach(entity);
        }

        public void Delete(TEntity entity) 
            => Context.Set<TEntity>().Remove(entity);

        public async Task SaveAsync() 
            => await Context.SaveChangesAsync();

        public void Dispose()
        {
            if (!disposed)
            {
                Context.Dispose();
                disposed = true;
            }
        }
    }
}
