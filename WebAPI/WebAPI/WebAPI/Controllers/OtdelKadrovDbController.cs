using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class OtdelKadrovDbController : Controller 
    {
        OtdelKadrovDbContext dataBaseContext;


        public OtdelKadrovDbController(OtdelKadrovDbContext context)
        {
            dataBaseContext = context;
        }

        [HttpGet]

        public IEnumerable<Education> Get()
        {
            return dataBaseContext.Educations.ToList();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
