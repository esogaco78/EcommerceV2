using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceV2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}