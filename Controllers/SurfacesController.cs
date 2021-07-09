using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TennisAustraliaAssignment.Data;
using TennisAustraliaAssignment.Models;

namespace TennisAustraliaAssignment.Controllers
{
    public class SurfacesController : Controller
    {
        private readonly TennisContext _context;

        public SurfacesController(TennisContext context)
        {
            _context = context;
        }

        // GET: Surfaces
        public async Task<IActionResult> Index()
        {
            return View(await _context.Surface.ToListAsync());
        }

        // GET: Surfaces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surface = await _context.Surface
                .FirstOrDefaultAsync(m => m.SurfaceID == id);
            if (surface == null)
            {
                return NotFound();
            }

            return View(surface);
        }

        // GET: Surfaces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Surfaces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurfaceID,SurfaceName,SurfaceDescription")] Surface surface)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surface);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(surface);
        }

        // GET: Surfaces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surface = await _context.Surface.FindAsync(id);
            if (surface == null)
            {
                return NotFound();
            }
            return View(surface);
        }

        // POST: Surfaces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurfaceID,SurfaceName,SurfaceDescription")] Surface surface)
        {
            if (id != surface.SurfaceID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surface);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurfaceExists(surface.SurfaceID))
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
            return View(surface);
        }

        // GET: Surfaces/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surface = await _context.Surface
                .FirstOrDefaultAsync(m => m.SurfaceID == id);
            if (surface == null)
            {
                return NotFound();
            }

            return View(surface);
        }

        // POST: Surfaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surface = await _context.Surface.FindAsync(id);
            _context.Surface.Remove(surface);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurfaceExists(int id)
        {
            return _context.Surface.Any(e => e.SurfaceID == id);
        }
    }
}
