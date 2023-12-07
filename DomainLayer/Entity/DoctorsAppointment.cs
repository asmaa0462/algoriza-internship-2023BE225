using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class DoctorsAppointment
    {
        public int AppointmentId { get; set; }
        public int doctorid { get; set; }
        public Doctor Doctor { get; set; }
        public Appointment Appointment { get; set; }
    }
}
