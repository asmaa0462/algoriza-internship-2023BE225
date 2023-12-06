using Microsoft.EntityFrameworkCore;
using RepositoryL.Data;
using RepositoryL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match);
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        //check for id
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            if(entity is null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }
        }

        public T Update(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
                return entity;
            }
        }
    }
}
