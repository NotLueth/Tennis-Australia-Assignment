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
    public class TournamentTypesController : Controller
    {
        private readonly TennisContext _context;

        public TournamentTypesController(TennisContext context)
        {
            _context = context;
        }

        // GET: TournamentTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TournamentTypes.ToListAsync());
        }

        // GET: TournamentTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentType = await _context.TournamentTypes
                .FirstOrDefaultAsync(m => m.TournamentTypeID == id);
            if (tournamentType == null)
            {
                return NotFound();
            }

            return View(tournamentType);
        }

        // GET: TournamentTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TournamentTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TournamentTypeID,TournamentTypeName,TournamentTypeDescription")] TournamentType tournamentType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tournamentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tournamentType);
        }

        // GET: TournamentTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentType = await _context.TournamentTypes.FindAsync(id);
            if (tournamentType == null)
            {
                return NotFound();
            }
            return View(tournamentType);
        }

        // POST: TournamentTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TournamentTypeID,TournamentTypeName,TournamentTypeDescription")] TournamentType tournamentType)
        {
            if (id != tournamentType.TournamentTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tournamentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournamentTypeExists(tournamentType.TournamentTypeID))
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
            return View(tournamentType);
        }

        // GET: TournamentTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentType = await _context.TournamentTypes
                .FirstOrDefaultAsync(m => m.TournamentTypeID == id);
            if (tournamentType == null)
            {
                return NotFound();
            }

            return View(tournamentType);
        }

        // POST: TournamentTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournamentType = await _context.TournamentTypes.FindAsync(id);
            _context.TournamentTypes.Remove(tournamentType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournamentTypeExists(int id)
        {
            return _context.TournamentTypes.Any(e => e.TournamentTypeID == id);
        }
    }
}
