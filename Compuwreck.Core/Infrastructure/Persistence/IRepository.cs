using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Compuwreck.Core.Infrastructure.Model;

namespace Compuwreck.Core.Infrastructure.Persistence {
    public interface IRepository<T> {
        void Create(T entity);
        void Delete(T entity);
        void DeleteById<TId>(TId id);
        T GetById<TId>(TId id);
        void Update(T entity);
        IQueryable<T> All();
        IQueryable<T> All(Expression<Func<T, bool>> expression);

        PagedList<T> All(Expression<Func<T, bool>> expression, string orderBy, bool ascending,
            int currentPage, int pageSize);
    }
}

