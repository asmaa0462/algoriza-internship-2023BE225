using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Interface
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        IEnumerable<T> GetAll();
        T GetbyId(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> GetbyIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        void AddAsync(T entity);
        void Count();
        Task<int> CountAsync();


    }
}
