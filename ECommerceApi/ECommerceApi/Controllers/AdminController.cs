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
    public class AdminController : ControllerBase
    {
        EcommerceDbContext db;
        public AdminController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return db.Admins;
        }

        [HttpPost]
        public string Post([FromBody] Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
            return "success";
        }
    }
}
