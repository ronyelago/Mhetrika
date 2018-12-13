using AutoMapper;
using mhetrika.core.Entities;
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
            var model = new FibrosisCalcViewModel
            {
                Id = patient.Id,
                Name = patient.Name,
                BirthDate = patient.BirthDate,
                Fibrosis = new Fibrosis
                {
                    Name = "Esteatose",
                    
                }
            };

            return View(model);
        }
    }
}