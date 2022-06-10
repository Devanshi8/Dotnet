using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        StudentDBContext sdb = new StudentDBContext();
        [HttpGet]
        public List<Coursedetail> Get()
        {
            return sdb.Coursedetails.ToList();
        }
    }
}
