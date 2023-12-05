using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient :User
    {
        public Int64 NumberofRequest { get; set; }
        public int PatientId { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public List<PatientsBookings> patientsBookings { get; set; }
    }
}
