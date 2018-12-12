using AutoMapper;
using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class TestController : Controller
    {
        readonly PatientRepository patientRepository = new PatientRepository();

        public IActionResult ChooseTest(int id = 0)
        {
            if (id != 0)
            {
                var patient = patientRepository.GetById(id);
                var model = Mapper.Map<PatientViewModel>(patient);

                return View(model);
            }

            return View();
        }
    }
}