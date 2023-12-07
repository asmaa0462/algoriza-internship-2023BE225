using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class Patient :User
    {
        public Int64 NumberofRequest { get; set; }
        public int PatientId { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public List<PatientBooking> patientsBooking { get; set; }
    }
}
