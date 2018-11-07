using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceV2.Models
{
    // Each individual SKU
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int QuantityAvalable { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        // Computers, video games, or tvs
        public string Catagory { get; set; }

        public string ImageLink { get; set; }

        // Catch all for manufacturer, developer, publisher etc.
        public string Brand { get; set; }

    }
}