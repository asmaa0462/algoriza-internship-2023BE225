using Domain.Entities;
using RepositoryL.Interface;
using ServiceL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceL.UnitOfWork.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAppointmentRepository _appoint {  get; }
        IBookingRepository _booking { get; }
        IDiscountRepository _discount { get; }
        IDoctorRepository _doctor { get; }
        IPatientRepository _patient { get; }
        ISpecializationRepository _specialization { get; }
        ITimeRepository _time { get; }
        int Save();
        Task<int> SaveAsync();
    }
}
