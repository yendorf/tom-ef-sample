using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TomEFSampleApi.Controllers
{
    public class MyEntity1Controller : Controller
    {
        [HttpGet("RouteName")]
        public IActionResult GetEntity1Record()
        {
            return Ok();
        }
    }
}
