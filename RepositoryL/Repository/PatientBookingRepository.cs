using Domain.Entities;
using RepositoryL.Data;
using RepositoryL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Repository
{
    public class PatientBookingRepository : BaseRepository<PatientsBookings>, IPatientsBookingRepository
    {
        public PatientBookingRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
