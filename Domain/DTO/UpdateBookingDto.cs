using Domain.Entities.Enum;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UpdateBookingDto
    {
        public int bookId { get; set; }
        public BookState BookState { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public List<PatientsBookings> patientsBookings { get; set; }
    }
}
