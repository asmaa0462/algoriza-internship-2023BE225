using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class GetAppointmentDto
    {
        public Days Days { get; set; }
        public DateTime timebooked { get; set; }
        public string doctorName {  get; set; }
        public int finalprice { get; set; }
        public DiscountState discountState { get; set; }
        public DiscountCode discountCode { get; set; }
        public int price {  get; set; }
    }
}
