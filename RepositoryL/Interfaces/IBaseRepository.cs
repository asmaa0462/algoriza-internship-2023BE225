using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IQueryable<T> FindAll();
        T Find (Expression<Func<T, bool>> match);
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
