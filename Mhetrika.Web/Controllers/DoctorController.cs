﻿using AutoMapper;
using mhetrika.core.Entities;
using mhetrika.Infrastructure.Repository;
using Mhetrika.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Mhetrika.Web.Controllers
{
    public class DoctorController : Controller
    {
        private readonly DoctorRepository doctorRepository = new DoctorRepository();

        public IActionResult Index()
        {
            var doctors = doctorRepository.GetAll().ToList();
            var doctorList = Mapper.Map<List<DoctorListViewModel>>(doctors);

            return View(doctorList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Crm,Uf,Phone,Specialty,Id,Name,Email,Password")] DoctorViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var doctor = Mapper.Map<Doctor>(viewModel);
                doctorRepository.Add(doctor);

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var doc = doctorRepository.GetById(id);

            doctorRepository.Remove(doc);

            return RedirectToAction("Index");
        }

        // GET: Doctor/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var doctor = await _context.Doctors
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (doctor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(doctor);
        //}

        // GET: Doctor/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var doctor = await _context.Doctors.FindAsync(id);
        //    if (doctor == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(doctor);
        //}

        // POST: Doctor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Crm,Uf,Phone,Specialty,Id,Name,Email,Password,CreationDate,ModifiedDate")] Doctor doctor)
        //{
        //    if (id != doctor.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(doctor);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!DoctorExists(doctor.Id))
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
        //    return View(doctor);
        //}

        // GET: Doctor/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var doctor = await _context.Doctors
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (doctor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(doctor);
        //}

        // POST: Doctor/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var doctor = await _context.Doctors.FindAsync(id);
        //    _context.Doctors.Remove(doctor);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool DoctorExists(int id)
        //{
        //    return _context.Doctors.Any(e => e.Id == id);
        //}
    }
}
