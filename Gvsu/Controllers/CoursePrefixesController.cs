using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gvsu.Data;
using Gvsu.Models;

namespace Gvsu.Controllers
{
    public class CoursePrefixesController : Controller
    {
        private readonly GvsuContext _context;

        public CoursePrefixesController(GvsuContext context)
        {
            _context = context;
        }

        // GET: CoursePrefixes
        public async Task<IActionResult> Index()
        {
            return View(await _context.CoursePrefixes.ToListAsync());
        }

        // GET: CoursePrefixes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePrefix = await _context.CoursePrefixes
                .FirstOrDefaultAsync(m => m.CoursePrefixID == id);
            if (coursePrefix == null)
            {
                return NotFound();
            }

            return View(coursePrefix);
        }

        // GET: CoursePrefixes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CoursePrefixes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoursePrefixID,Prefix")] CoursePrefix coursePrefix)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coursePrefix);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coursePrefix);
        }

        // GET: CoursePrefixes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePrefix = await _context.CoursePrefixes.FindAsync(id);
            if (coursePrefix == null)
            {
                return NotFound();
            }
            return View(coursePrefix);
        }

        // POST: CoursePrefixes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CoursePrefixID,Prefix")] CoursePrefix coursePrefix)
        {
            if (id != coursePrefix.CoursePrefixID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coursePrefix);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoursePrefixExists(coursePrefix.CoursePrefixID))
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
            return View(coursePrefix);
        }

        // GET: CoursePrefixes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coursePrefix = await _context.CoursePrefixes
                .FirstOrDefaultAsync(m => m.CoursePrefixID == id);
            if (coursePrefix == null)
            {
                return NotFound();
            }

            return View(coursePrefix);
        }

        // POST: CoursePrefixes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coursePrefix = await _context.CoursePrefixes.FindAsync(id);
            if (coursePrefix != null)
            {
                _context.CoursePrefixes.Remove(coursePrefix);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoursePrefixExists(int id)
        {
            return _context.CoursePrefixes.Any(e => e.CoursePrefixID == id);
        }
    }
}
