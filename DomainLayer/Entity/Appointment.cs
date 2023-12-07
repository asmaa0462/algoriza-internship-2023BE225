using DomainLayer.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Days Days { get; set; }
        public int PriceEntry { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public List<DoctorsAppointment> doctorsAppointment { get; set; }
    }
}
