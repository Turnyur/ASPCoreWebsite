using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EmptyAspCore.Services.Repository
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {

       void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity GetByFilter(Expression<Func<TEntity, bool>> predicate); 


    }
}
