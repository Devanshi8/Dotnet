using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        SampleDBContext db = new SampleDBContext();

        //Get Method
        [HttpGet]
        public List<Tblsample> Get()
        {
            return db.Tblsamples.ToList();
        }

        //insert record from body
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            Tblsample t = new Tblsample();
            t.Text = sample;
            db.Tblsamples.Add(t);
            db.SaveChanges();
            return "Success";
        }

        //Update record 
        [HttpPut]
        public string Put([FromBody] Tblsample tblsample)
        {
            var tblSampleObj = db.Tblsamples.Where(x => x.Id == tblsample.Id);
            if (tblSampleObj != null)
            {
                db.Tblsamples.Update(tblsample);
                db.SaveChanges();
                return "Success";
            }
            return "Fail";
        }
        //Delete Record
        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tblSampleObj = db.Tblsamples.Where(x => x.Id == Id).FirstOrDefault();
            if (tblSampleObj != null)
            {
                db.Tblsamples.Remove(tblSampleObj);
                db.SaveChanges();
                return "Success";
            }
            return "Fail";
        }

        //MyCode***//Delete the record using id

        //[HttpPost]
        //public string Post([FromBody] int del)
        //{
        //    Tblsample tb = new Tblsample();//table object
        //    tb.Id = del;//table Id column
        //    db.Tblsamples.Remove(tb);//delete the record from row 
        //    db.SaveChanges();//save the changes
        //    return "Success!!";
        //}***//
    }
}
