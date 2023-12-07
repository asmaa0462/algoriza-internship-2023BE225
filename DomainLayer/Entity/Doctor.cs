using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class Doctor :User
    {
        public int price { get; set; }
        public int doctorid { get; set; }
        public int SpecializationId { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public List<DoctorsAppointment> doctorsAppointment { get; set; }
    }
}
