using DomainLayer.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class Discount
    {
        [Key]
        public int discountId { get; set; }
        public DiscountCode DiscountCode { get; set; }
        public DiscountState DiscountState { get; set; }
    }
}
