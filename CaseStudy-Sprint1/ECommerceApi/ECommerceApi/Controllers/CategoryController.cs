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
    public class CategoryController : ControllerBase
    {
        EcommerceDbContext db;
        public CategoryController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblCategory> GetTblCategories()
        {
            return db.TblCategories;
        }
        [HttpPost]
        public string Post(TblCategory tblCategory)
        {

            db.TblCategories.Add(tblCategory);
            db.SaveChanges();
            return "success";
        }
    }
}
