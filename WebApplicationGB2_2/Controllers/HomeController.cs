using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationGB2_2.Controllers
{
    public class HomeController : Controller
    {
        // /api/example/index
        public IActionResult Index()
        {
            return Content("Проверка работы контроллера.");
        }

        [HttpGet]
        public IEnumerable<int> GetNumbers()
        {
            return Enumerable.Range(1, 100);
        }
    }
}
