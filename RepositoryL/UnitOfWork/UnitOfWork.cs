using RepositoryL.Data;
using RepositoryL.Interfaces;
using RepositoryL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        /**private readonly ApplicationDbContext _context;
        public ISpecializationRepository _specialization { get; private set; }
        public IDoctorRepository _doctor { get; private set; }
        //Istilldon'tgetit
        public UnitOfWork(ApplicationDbContext contex)
        {
            _context = contex;
            
        }
        public ISpecializationRepository 
        {
            /**get
            {
                if (_specialization == null)
                {
                    _specialization = new SpecializationRepository(_context);
                }
               // return _context;
            }**/
        public ISpecializationRepository specialization => throw new NotImplementedException();

        public IDoctorRepository doctor => throw new NotImplementedException();

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
