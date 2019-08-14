using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Accounting.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        Task<TEntity> GetByIDAsync(Guid? id);
        Task<IEnumerable<TEntity>> GetAllAsync();

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task SaveAsync();

        void Dispose();
    }
}