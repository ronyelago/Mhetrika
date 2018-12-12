using AutoMapper;
using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class FibrosisController : Controller
    {
        readonly PatientRepository patientRepository = new PatientRepository();

        public IActionResult FibrosisCalc(int id)
        {
            var patient = patientRepository.GetById(id);
            var model = Mapper.Map<PatientViewModel>(patient);

            return View(model);
        }
    }
}