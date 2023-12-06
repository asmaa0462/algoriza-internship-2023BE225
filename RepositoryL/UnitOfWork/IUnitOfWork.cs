using RepositoryL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.UnitOfWork
{
    public interface IUnitOfWork
    {
        ISpecializationRepository specialization {  get; }
        IDoctorRepository doctor { get; }
        void Save();
    }
}
