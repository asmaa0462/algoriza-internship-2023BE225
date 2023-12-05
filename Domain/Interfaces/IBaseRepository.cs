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
        //T Find(Expression<Func<T, bool>> match, string[] includes = null);//if if i have like book I could represent data of authors also in it 
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        void Savechanges();

        
    }
}
