using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerceApi.Models
{
    public partial class TblLogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IsAdmin { get; set; }
        public string Address { get; set; }
        public int? PhoneNo { get; set; }
        public string City { get; set; }
    }
}
