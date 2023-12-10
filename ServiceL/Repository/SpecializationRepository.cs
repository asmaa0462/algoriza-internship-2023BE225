using Domain.Entities;
using RepositoryL.Data;
using RepositoryL.Interface;
using ServiceL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceL.Repository
{
    internal class SpecializationRepository : RepositoryBase<Specialization>, ISpecializationRepository
    {
        public SpecializationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
