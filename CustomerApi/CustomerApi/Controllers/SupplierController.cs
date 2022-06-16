using CustomerApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        CustomerDB1Context db1;
        public SupplierController(CustomerDB1Context _db)
        {
            db1 = _db;
        }
        [HttpGet]
        public IEnumerable<Supplier> Get()
        {
            return db1.Suppliers;
        }

        [HttpPost]
        public string Post([FromBody] Supplier supplier)
        {
            db1.Suppliers.Add(supplier);
            db1.SaveChanges();
            return "success";
        }
    }
}
