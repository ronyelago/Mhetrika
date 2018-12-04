using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class FibrosisController : Controller
    {
        public IActionResult FibrosisCalc()
        {
            return View();
        }
    }
}