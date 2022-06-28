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
    public class ProductController : ControllerBase
    {
        EcommerceDbContext db;
        public ProductController(EcommerceDbContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblProduct> GetProducts()
        {
            return db.TblProducts;
        }
        [HttpPost]

        public string Post([FromBody] TblProduct tblProduct)
        {
            db.TblProducts.Add(tblProduct);
            db.SaveChanges();
            return "success";
        }
        

    }
}
