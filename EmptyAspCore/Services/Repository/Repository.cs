using EmptyAspCore.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EmptyAspCore.Services.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
         where TEntity : class
    {

        protected readonly ApplicationDbContext _context;
        private bool disposed = false;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(TEntity entity)
        {
             _context.Remove(entity);
            Save();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                _context.Dispose();
                this.disposed = true;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            IEnumerable<TEntity> entityList = _context.Set<TEntity>().ToList();
            return entityList;
        }

        public TEntity GetByFilter(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).FirstOrDefault();
            
        }

        public TEntity GetById(int id)
        {
            return _context.Find<TEntity>(id);
        }

        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            Save();
        }

        public void Save()=>_context.SaveChanges();
        

        public void Update(TEntity entity)
        {
          _context.Entry(entity).State = EntityState.Modified;
            Save();

        }
    }
}
