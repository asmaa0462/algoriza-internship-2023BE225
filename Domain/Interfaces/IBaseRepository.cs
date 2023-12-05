using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Find (Expression<Func<T, bool>> match);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        void Savechanges();

        
    }
}
