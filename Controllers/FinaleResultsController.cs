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
    public class FinaleResultsController : Controller
    {
        private readonly TennisContext _context;

        public FinaleResultsController(TennisContext context)
        {
            _context = context;
        }

        // GET: FinaleResults
        public async Task<IActionResult> Index()
        {
            var tennisContext = _context.FinaleResults.Include(f => f.Match);
            return View(await tennisContext.ToListAsync());
        }

        // GET: FinaleResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finaleResult = await _context.FinaleResults
                .Include(f => f.Match)
                .FirstOrDefaultAsync(m => m.FinaleResultID == id);
            if (finaleResult == null)
            {
                return NotFound();
            }

            return View(finaleResult);
        }

        // GET: FinaleResults/Create
        public IActionResult Create()
        {
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID");
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID");
            return View();
        }

        // POST: FinaleResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FinaleResultID,MatchID,WinRegistrationID,WinRegistrationFinaleScore,SecondRegistrationID,SecondPlayerScore,SetsPlayed")] FinaleResult finaleResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(finaleResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID", finaleResult.MatchID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", finaleResult.WinRegistrationFinaleScore);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", finaleResult.SecondRegistrationID);
            return View(finaleResult);
        }

        // GET: FinaleResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finaleResult = await _context.FinaleResults.FindAsync(id);
            if (finaleResult == null)
            {
                return NotFound();
            }
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID", finaleResult.MatchID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", finaleResult.WinRegistrationFinaleScore);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", finaleResult.SecondRegistrationID);
            return View(finaleResult);
        }

        // POST: FinaleResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FinaleResultID,MatchID,WinRegistrationID,WinRegistrationFinaleScore,SecondRegistrationID,SecondPlayerScore,SetsPlayed")] FinaleResult finaleResult)
        {
            if (id != finaleResult.FinaleResultID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(finaleResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinaleResultExists(finaleResult.FinaleResultID))
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
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID", finaleResult.MatchID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", finaleResult.WinRegistrationFinaleScore);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", finaleResult.SecondRegistrationID);
            return View(finaleResult);
        }

        // GET: FinaleResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var finaleResult = await _context.FinaleResults
                .Include(f => f.Match)
                .FirstOrDefaultAsync(m => m.FinaleResultID == id);
            if (finaleResult == null)
            {
                return NotFound();
            }

            return View(finaleResult);
        }

        // POST: FinaleResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var finaleResult = await _context.FinaleResults.FindAsync(id);
            _context.FinaleResults.Remove(finaleResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinaleResultExists(int id)
        {
            return _context.FinaleResults.Any(e => e.FinaleResultID == id);
        }
    }
}
