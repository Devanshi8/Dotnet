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
    public class StudentController : ControllerBase
    {
        StudentDBContext sdb = new StudentDBContext();
        //Get Method
        [HttpGet]
        public List<Studentdetail> Get()
        {
            return sdb.Studentdetails.ToList();
        }

       

        //Insert
        [HttpPost]
        public string Post([FromBody] Studentdetail student)
        {
            Studentdetail std = new Studentdetail();
            std.Fname = student.Fname;
            std.Cid = student.Cid;
            sdb.Studentdetails.Add(std);
            sdb.SaveChanges();
            return "Success";
        }

        //Update 
        [HttpPut]
        public string Put([FromBody] Studentdetail std)
        {
            var tbls = sdb.Studentdetails.Where(x => x.Rollno == std.Rollno);
            if (tbls != null)
            {
                sdb.Studentdetails.Update(std);
                sdb.SaveChanges();
                return "Success";
            }

            return "Fail";
        }
        //Delete
        [HttpDelete]
        public string Delete([FromBody] int num)
        {
            var delobj = sdb.Studentdetails.Where(x => x.Rollno == num).FirstOrDefault();
            if (delobj != null)
            {
                sdb.Studentdetails.Remove(delobj);
                sdb.SaveChanges();
                return "Success";
            }
            return "Fail";
        }
    }
}
