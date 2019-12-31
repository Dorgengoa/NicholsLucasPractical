using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NicholsLucasPractical.Controllers
{
    public class FormController : Controller
    {
        [HttpPost]
        public IActionResult Index(int submittingAUN)
        {
            return Content($"Hello {submittingAUN}");

        }
    }
}
