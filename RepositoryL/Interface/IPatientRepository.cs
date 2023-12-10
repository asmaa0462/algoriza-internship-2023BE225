using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Interface
{
    public interface IPatientRepository : IRepository<Patient>
    {
        void AddNumberRequest();
        int GenerateDiscount();
    }
}
