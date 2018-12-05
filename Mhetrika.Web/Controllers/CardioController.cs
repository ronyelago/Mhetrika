using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class CardioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}