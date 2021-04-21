using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DrivingSchool.Models;

namespace DrivingSchoolVS.Controllers
{
    public class DrivingCategoriesController : Controller
    {
        private readonly DrivingSchoolContext _context;

        public DrivingCategoriesController(DrivingSchoolContext context)
        {
            _context = context;
        }

        // GET: DrivingCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.DrivingCategories.ToListAsync());
        }

        // GET: DrivingCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drivingCategory = await _context.DrivingCategories
                .FirstOrDefaultAsync(m => m.DrivingCategoryId == id);
            if (drivingCategory == null)
            {
                return NotFound();
            }

            return View(drivingCategory);
        }

        // GET: DrivingCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrivingCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DrivingCategoryId,CategoryName,Price")] DrivingCategory drivingCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drivingCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drivingCategory);
        }

        // GET: DrivingCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drivingCategory = await _context.DrivingCategories.FindAsync(id);
            if (drivingCategory == null)
            {
                return NotFound();
            }
            return View(drivingCategory);
        }

        // POST: DrivingCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DrivingCategoryId,CategoryName,Price")] DrivingCategory drivingCategory)
        {
            if (id != drivingCategory.DrivingCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drivingCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrivingCategoryExists(drivingCategory.DrivingCategoryId))
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
            return View(drivingCategory);
        }

        // GET: DrivingCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drivingCategory = await _context.DrivingCategories
                .FirstOrDefaultAsync(m => m.DrivingCategoryId == id);
            if (drivingCategory == null)
            {
                return NotFound();
            }

            return View(drivingCategory);
        }

        // POST: DrivingCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drivingCategory = await _context.DrivingCategories.FindAsync(id);
            _context.DrivingCategories.Remove(drivingCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrivingCategoryExists(int id)
        {
            return _context.DrivingCategories.Any(e => e.DrivingCategoryId == id);
        }
    }
}
