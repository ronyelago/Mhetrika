using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
