using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class CreateAppointmentDto
    {
        public int price { get; set; }
        public Days days { get; set; }
        public DateTime time { get; set; }
    }
}
