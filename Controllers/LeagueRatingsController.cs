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
    public class LeagueRatingsController : Controller
    {
        private readonly TennisContext _context;

        public LeagueRatingsController(TennisContext context)
        {
            _context = context;
        }

        // GET: LeagueRatings
        public async Task<IActionResult> Index()
        {
            return View(await _context.LeagueRatings.ToListAsync());
        }

        // GET: LeagueRatings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leagueRating = await _context.LeagueRatings
                .FirstOrDefaultAsync(m => m.LeagueID == id);
            if (leagueRating == null)
            {
                return NotFound();
            }

            return View(leagueRating);
        }

        // GET: LeagueRatings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeagueRatings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LeagueID,LeagueName")] LeagueRating leagueRating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leagueRating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leagueRating);
        }

        // GET: LeagueRatings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leagueRating = await _context.LeagueRatings.FindAsync(id);
            if (leagueRating == null)
            {
                return NotFound();
            }
            return View(leagueRating);
        }

        // POST: LeagueRatings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LeagueID,LeagueName")] LeagueRating leagueRating)
        {
            if (id != leagueRating.LeagueID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leagueRating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeagueRatingExists(leagueRating.LeagueID))
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
            return View(leagueRating);
        }

        // GET: LeagueRatings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leagueRating = await _context.LeagueRatings
                .FirstOrDefaultAsync(m => m.LeagueID == id);
            if (leagueRating == null)
            {
                return NotFound();
            }

            return View(leagueRating);
        }

        // POST: LeagueRatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leagueRating = await _context.LeagueRatings.FindAsync(id);
            _context.LeagueRatings.Remove(leagueRating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeagueRatingExists(int id)
        {
            return _context.LeagueRatings.Any(e => e.LeagueID == id);
        }
    }
}
