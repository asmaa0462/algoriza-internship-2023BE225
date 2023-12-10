using Microsoft.EntityFrameworkCore;
using RepositoryL.Data;
using RepositoryL.Interface;
using ServiceL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ServiceL.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected AppDbContext _context { get; set; }
        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<T> FindAll() => _context.Set<T>().AsNoTracking();
        public void Add(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
        public T GetbyId(int id) => _context.Set<T>().Find(id);
        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();
        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        public async Task<T> GetbyIdAsync(int id) => await _context.Set<T>().FindAsync(id);
        public void AddAsync(T entity) => _context.Set<T>().AddAsync(entity);
        public void Count() => _context.Set<T>().Count();
        public async Task<int> CountAsync() => await _context.Set<T>().CountAsync();


    }
}
