using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerceApi.Models
{
    public partial class Addcart
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductFinal { get; set; }
        public int? ProductQuantity { get; set; }
    }
}
