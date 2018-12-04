using AutoMapper;
using mhetrika.core.Entities;
using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mhetrika.Web.Controllers
{
    public class PatientController : Controller
    {
        private readonly PatientRepository patientRepository = new PatientRepository();

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(PatientViewModel patientViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var patient = Mapper.Map<Patient>(patientViewModel);
                    patientRepository.Add(patient);

                    TempData["Title"] = "Sucesso";
                    TempData["Message"] = "Paciente cadastrado com sucesso.";

                    return RedirectToAction("Index", "Home");
                }
                catch (System.Exception ex)
                {
                    TempData["Title"] = "Erro";
                    TempData["Message"] = $"Ocorreu um erro ao tentar cadastrar o paciente. {ex.Message}";

                    return View();
                }
            }

            return View();
        }
    }
}