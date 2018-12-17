using AutoMapper;
using mhetrika.core.Entities;
using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

        //// GET: Laboratory/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var laboratory = await _context.Laboratory
        //        .Include(l => l.Address)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (laboratory == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(laboratory);
        //}

        //// GET: Laboratory/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var laboratory = await _context.Laboratory.FindAsync(id);
        //    if (laboratory == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", laboratory.AddressId);
        //    return View(laboratory);
        //}

        //// POST: Laboratory/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Cnpj,Email,CreationDate,ModifiedDate,AddressId")] Laboratory laboratory)
        //{
        //    if (id != laboratory.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(laboratory);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LaboratoryExists(laboratory.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", laboratory.AddressId);
        //    return View(laboratory);
        //}

        //private bool LaboratoryExists(int id)
        //{
        //    return _context.Laboratory.Any(e => e.Id == id);
        //}
    }
}
