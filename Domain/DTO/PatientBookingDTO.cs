using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class PatientBookingDTO
    {
        public Booking Booking { get; set; }
        public Patient Patient { get; set; }
    }
}
