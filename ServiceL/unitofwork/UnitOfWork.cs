using Domain.Entities;
using Domain.Entities.Enum;
using RepositoryL.Data;
using RepositoryL.Interface;
using ServiceL.Interface;
using ServiceL.Repository;
using ServiceL.UnitOfWork.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceL.unitofwork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ITimeRepository _time { get; private set; }
        public IBookingRepository _book { get; private set; }
        public IAppointmentRepository _appointment { get; private set; }
        public IPatientRepository _patient { get; private set; }
        public IDoctorRepository _doctor { get; private set; }
        public ISpecializationRepository _specialization { get; private set; }
        public IDiscountRepository _discount { get; private set; }

        public IAppointmentRepository _appoint => throw new NotImplementedException();

        public IBookingRepository _booking => throw new NotImplementedException();

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            _time = new TimeRepository(_context);
            _book = new BookingRepository(_context);
            _appointment = new AppointmentRepository(_context);
            _patient = new PatientRepository(_context);
            _doctor = new DoctorRepository(_context);
            _specialization = new SpecializationRepository(_context);
            _discount = new DiscountRepository(_context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
