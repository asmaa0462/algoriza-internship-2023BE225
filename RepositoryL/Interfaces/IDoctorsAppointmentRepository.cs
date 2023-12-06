using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Interfaces
{
    public class IDoctorsAppointmentRepository : IBaseRepository<DoctorsAppointments>
    {
        public void Delete(DoctorsAppointments entity)
        {
            throw new NotImplementedException();
        }

        public DoctorsAppointments Find(Expression<Func<DoctorsAppointments, bool>> match)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DoctorsAppointments> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<DoctorsAppointments> FindByCondition(Expression<Func<DoctorsAppointments, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DoctorsAppointments> GetAll()
        {
            throw new NotImplementedException();
        }

        public DoctorsAppointments GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(DoctorsAppointments entity)
        {
            throw new NotImplementedException();
        }

        public DoctorsAppointments Update(DoctorsAppointments entity)
        {
            throw new NotImplementedException();
        }
    }
}
