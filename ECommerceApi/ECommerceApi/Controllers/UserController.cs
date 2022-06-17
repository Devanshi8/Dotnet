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
    public class UserController : ControllerBase
    {
        EcommerceDbContext db;
        public UserController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<UserDetail> Get()
        {
            return db.UserDetails;
        }

        [HttpPost]
        public string Post([FromBody] UserDetail userdetail)
        {
            db.UserDetails.Add(userdetail);
            db.SaveChanges();
            return "success";
        }
    }
}
