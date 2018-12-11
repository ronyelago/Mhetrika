using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult ChooseTest(int id = 0)
        {
            if (id != 0)
            {

            }

            return View();
        }
    }
}