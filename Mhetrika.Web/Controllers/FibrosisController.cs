using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class FibrosisController : Controller
    {
        readonly PatientRepository patientRepository = new PatientRepository();

        public ActionResult FibrosisCalc(int id)
        {
            var patient = patientRepository.GetById(id);

            var viewModel = new FibrosisViewModel
            {
                PatientId = patient.Id,
                PatientName = patient.Name
            };

            return View(viewModel);
        }

        
    }
}