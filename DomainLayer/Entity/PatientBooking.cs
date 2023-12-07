using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class PatientBooking
    {
        public int bookId { get; set; }
        public int PatientId { get; set; }
        public Booking Booking { get; set; }
        public Patient Patient { get; set; }
    }
}
