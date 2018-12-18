using AutoMapper;
using mhetrika.core.Entities;
using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mhetrika.Web.Controllers
{
    public class LaboratoryController : Controller
    {
        private readonly LaboratoryRepository laboratoryRepository = new LaboratoryRepository();

        // GET: Laboratory
        public ActionResult Index()
        {
            var laboratories = laboratoryRepository.GetAll().ToList();
            var viewModel = Mapper.Map<List<LaboratoryListViewModel>>(laboratories);

            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewLaboratoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var laboratory = Mapper.Map<Laboratory>(viewModel);
                laboratoryRepository.Add(laboratory);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var lab = laboratoryRepository.GetById(id);
            laboratoryRepository.Remove(lab);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var lab = laboratoryRepository.GetByIdWithAddress(id);
            var viewModel = Mapper.Map<EditLaboratoryViewModel>(lab);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditLaboratoryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var lab = Mapper.Map<Laboratory>(viewModel);

                try
                {
                    laboratoryRepository.Update(lab);
                }
                catch (Exception ex)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        //private bool LaboratoryExists(int id)
        //{
        //    return _context.Laboratory.Any(e => e.Id == id);
        //}
    }
}
