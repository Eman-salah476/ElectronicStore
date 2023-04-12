using ApplicationDemo.Infrastructure.Context;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ApplicationDemo.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _context;
        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return Save();
        }

        public bool Delete(Guid id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity is null)
                return false;
            else
                _context.Set<T>().Remove(entity);

            return Save();
        }

        public List<T> FindByCondition(Expression<Func<T, bool>> expression = null,
                                       Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _context.Set<T>();
            if (expression != null)
                query = query.Where(expression);

            if (include != null)
                query = include(query);

            return query.ToList();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return Save();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
