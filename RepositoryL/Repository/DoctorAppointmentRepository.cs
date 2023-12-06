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
    public class DoctorAppointmentRepository : BaseRepository<DoctorsAppointments>, IDoctorsAppointmentRepository
    {
        public DoctorAppointmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
