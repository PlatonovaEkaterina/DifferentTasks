using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DBController : Controller, InterfaceDB
    {
        DataBaseContext dataBaseContext;
        public DBController(DataBaseContext context)
        {
            dataBaseContext = context;
        }
         [HttpGet]
        public async Task<IEnumerable<Position>> Get()
        {
            return await dataBaseContext.Positions.ToListAsync();
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
