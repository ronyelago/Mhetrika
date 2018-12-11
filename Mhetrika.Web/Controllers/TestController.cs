using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult ChooseTest()
        {
            return View();
        }
    }
}