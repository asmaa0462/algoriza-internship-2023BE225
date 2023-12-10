using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class GetDiscountDto
    {
        public DiscountCode DiscountCode { get; set; }
        public DiscountState DiscountState { get; set; }
    }
}
