using AutoMapper;
using mhetrika.core.Entities;
using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Mhetrika.Web.Controllers
{
    public class FibrosisController : Controller
    {
        readonly PatientRepository patientRepository = new PatientRepository();
        readonly ExamRepository examRepository = new ExamRepository();

        public ActionResult FibrosisCalc(int id)
        {
            var patient = patientRepository.GetById(id);

            var viewModel = new FibrosisViewModel
            {
                Name = "Esteatose Hepática",
                PatientId = patient.Id,
                PatientName = patient.Name
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(FibrosisViewModel viewModel)
        {
            viewModel.DoctorId = 1;
            viewModel.LaboratoryId = 1;

            try
            {
                var fibrosis = Mapper.Map<Fibrosis>(viewModel);
                examRepository.Add(fibrosis);

                return Json(new { result = "Redirect", url = Url.Action(action: "List", controller:"Patient") });
            }

            catch (Exception ex)
            {
                return Json(new { result = "Error", error = ex.InnerException.Message });
            }
        }
    }
}