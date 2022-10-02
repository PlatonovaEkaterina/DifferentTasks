using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1
{
    interface InterfaceDB
    {
        Task<IEnumerable<Position>> Get();
    }
}
