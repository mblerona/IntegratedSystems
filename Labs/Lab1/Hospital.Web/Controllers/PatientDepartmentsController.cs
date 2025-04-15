using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital.Domain.DomainModels;
using Hospital.Web.Data;

namespace Hospital.Web.Controllers
{
    public class PatientDepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientDepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PatientDepartments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PatientDepartment.Include(p => p.department).Include(p => p.patient);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PatientDepartments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientDepartment = await _context.PatientDepartment
                .Include(p => p.department)
                .Include(p => p.patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientDepartment == null)
            {
                return NotFound();
            }

            return View(patientDepartment);
        }

        // GET: PatientDepartments/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id");
            ViewData["PatientId"] = new SelectList(_context.Patient, "Id", "DateOfBirth");
            return View();
        }

        // POST: PatientDepartments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateAssigned,PatientId,DepartmentId")] PatientDepartment patientDepartment)
        {
            if (ModelState.IsValid)
            {
                patientDepartment.Id = Guid.NewGuid();
                _context.Add(patientDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", patientDepartment.DepartmentId);
            ViewData["PatientId"] = new SelectList(_context.Patient, "Id", "DateOfBirth", patientDepartment.PatientId);
            return View(patientDepartment);
        }

        // GET: PatientDepartments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientDepartment = await _context.PatientDepartment.FindAsync(id);
            if (patientDepartment == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", patientDepartment.DepartmentId);
            ViewData["PatientId"] = new SelectList(_context.Patient, "Id", "DateOfBirth", patientDepartment.PatientId);
            return View(patientDepartment);
        }

        // POST: PatientDepartments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,DateAssigned,PatientId,DepartmentId")] PatientDepartment patientDepartment)
        {
            if (id != patientDepartment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patientDepartment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientDepartmentExists(patientDepartment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Department, "Id", "Id", patientDepartment.DepartmentId);
            ViewData["PatientId"] = new SelectList(_context.Patient, "Id", "DateOfBirth", patientDepartment.PatientId);
            return View(patientDepartment);
        }

        // GET: PatientDepartments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patientDepartment = await _context.PatientDepartment
                .Include(p => p.department)
                .Include(p => p.patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patientDepartment == null)
            {
                return NotFound();
            }

            return View(patientDepartment);
        }

        // POST: PatientDepartments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var patientDepartment = await _context.PatientDepartment.FindAsync(id);
            if (patientDepartment != null)
            {
                _context.PatientDepartment.Remove(patientDepartment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientDepartmentExists(Guid id)
        {
            return _context.PatientDepartment.Any(e => e.Id == id);
        }
    }
}
