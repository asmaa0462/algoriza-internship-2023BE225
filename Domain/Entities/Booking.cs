using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Booking
    {
        [Key]
        public int bookId { get; set; }
        public BookState BookState { get; set; }
        public ICollection<Patient> Patients { get; set; }
        public List<PatientsBookings> patientsBookings { get; set; }
        public int discountId { get; set; }
       
    }
}
