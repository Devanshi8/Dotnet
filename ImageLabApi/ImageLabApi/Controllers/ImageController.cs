using ImageLabApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageLabApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ImageController : ControllerBase
    {
        ImageLabDBContext db;
        public ImageController(ImageLabDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblImage> GetTblImages()
        {
            return db.TblImages;
        }
        [HttpPost]
        public string Post(TblImage tblImage)
        {

            db.TblImages.Add(tblImage);
            db.SaveChanges();
            return "success";
        }
    }
}
