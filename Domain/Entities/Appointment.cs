using Core.Entities;
using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Days Days { get; set; }
        public int PriceEntry { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public List<DoctorsAppointments> doctorsAppointments { get; set; }
        
    }
}
