using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Discount
    {
        [Key]
        public int discountId { get; set; }
        public DiscountCode DiscountCode { get; set; }
        public DiscountState DiscountState { get; set; }
    }
}
