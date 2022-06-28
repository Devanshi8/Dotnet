using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerceApi.Models
{
    public partial class OrderList
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductMrp { get; set; }
    }
}
