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
    public class MatchesController : Controller
    {
        private readonly TennisContext _context;

        public MatchesController(TennisContext context)
        {
            _context = context;
        }

        // GET: Matches
        public async Task<IActionResult> Index()
        {
            var tennisContext = _context.Matches.Include(m => m.Registration).Include(m => m.Registration.Player).Include(m => m.TournamentBracket).Include(m => m.Registration);
            return View(await tennisContext.ToListAsync());
        }

        // GET: Matches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Matches
                .Include(m => m.Registration)
                .Include(m => m.Registration.Player)
                .Include(m => m.TournamentBracket)
                .FirstOrDefaultAsync(m => m.MatchID == id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        // GET: Matches/Create
        public IActionResult Create()
        {
            ViewData["TournamentBracketID"] = new SelectList(_context.TournamentBrackets, "TournamentBracketID", "TournamentBracketID");
            ViewData["RegistrationID"] = new SelectList(_context.RegistrationDetails, "RegistrationID", "RegistrationID");
            ViewData["RegistrationID"] = new SelectList(_context.RegistrationDetails, "RegistrationID", "RegistrationID");
            return View();
        }

        // POST: Matches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MatchID,Round,TournamentBracketID,FirstRegistrationID,SecondRegistrationID,RegistrationID")] Match match)
        {
            if (ModelState.IsValid)
            {
                _context.Add(match);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TournamentBracketID"] = new SelectList(_context.TournamentBrackets, "TournamentBracketID", "TournamentBracketID", match.TournamentBracketID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", match.FirstRegistrationID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", match.SecondRegistrationID);
            return View(match);
        }

        // GET: Matches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Matches.FindAsync(id);
            if (match == null)
            {
                return NotFound();
            }
            ViewData["TournamentBracketID"] = new SelectList(_context.TournamentBrackets, "TournamentBracketID", "TournamentBracketID", match.TournamentBracketID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", match.FirstRegistrationID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", match.SecondRegistrationID);
            return View(match);
        }

        // POST: Matches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MatchID,Round,TournamentBracketID,FirstRegistrationID,SecondRegistrationID,RegistrationID")] Match match)
        {
            if (id != match.MatchID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(match);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchExists(match.MatchID))
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
            ViewData["TournamentBracketID"] = new SelectList(_context.TournamentBrackets, "TournamentBracketID", "TournamentBracketID", match.TournamentBracketID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", match.FirstRegistrationID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", match.SecondRegistrationID);
            return View(match);
        }

        // GET: Matches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var match = await _context.Matches
                .Include(m => m.Registration)
                .Include(m => m.Registration.Player)
                .Include(m => m.TournamentBracket)
                .FirstOrDefaultAsync(m => m.MatchID == id);
            if (match == null)
            {
                return NotFound();
            }

            return View(match);
        }

        // POST: Matches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var match = await _context.Matches.FindAsync(id);
            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchExists(int id)
        {
            return _context.Matches.Any(e => e.MatchID == id);
        }
    }
}
