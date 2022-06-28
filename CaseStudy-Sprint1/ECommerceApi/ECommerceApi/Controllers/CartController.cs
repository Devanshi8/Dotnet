using ECommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        EcommerceDbContext db;
        public CartController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Addcart> GetAddcarts()
        {
            return db.Addcarts;
        }
       [HttpPost]
        public string Post(Addcart addcart)
        {
           
            db.Addcarts.Add(addcart);
            db.SaveChanges();
            return "success";
        }
        
    }
}
