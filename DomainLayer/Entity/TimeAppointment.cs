using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class TimeAppointment
    {
        [Key]
        public int timeId { get; set; }
        public DateTime time { get; set; }
        public int AppointmentId { get; set; }
        public int bookId { get; set; }
    }
}
