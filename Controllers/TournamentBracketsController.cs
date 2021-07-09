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
    public class TournamentBracketsController : Controller
    {
        private readonly TennisContext _context;

        public TournamentBracketsController(TennisContext context)
        {
            _context = context;
        }

        // GET: TournamentBrackets
        public async Task<IActionResult> Index()
        {
            var tennisContext = _context.TournamentBrackets.Include(t => t.AgeBracket).Include(t => t.LeagueRating).Include(t => t.Tournament);
            return View(await tennisContext.ToListAsync());
        }

        // GET: TournamentBrackets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentBracket = await _context.TournamentBrackets
                .Include(t => t.AgeBracket)
                .Include(t => t.LeagueRating)
                .Include(t => t.Tournament)
                .FirstOrDefaultAsync(m => m.TournamentBracketID == id);
            if (tournamentBracket == null)
            {
                return NotFound();
            }

            return View(tournamentBracket);
        }

        // GET: TournamentBrackets/Create
        public IActionResult Create()
        {
            ViewData["AgeBracketID"] = new SelectList(_context.AgeBracket, "AgeBracketID", "AgeBracketDescription");
            ViewData["LeagueRatingLeagueID"] = new SelectList(_context.LeagueRatings, "LeagueID", "LeagueName");
            ViewData["TournamentID"] = new SelectList(_context.Tournaments, "TournamentID", "TournamentName");
            return View();
        }

        // POST: TournamentBrackets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TournamentBracketID,TournamentID,AgeBracketID,LeagueRatingLeagueID")] TournamentBracket tournamentBracket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tournamentBracket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgeBracketID"] = new SelectList(_context.AgeBracket, "AgeBracketID", "AgeBracketDescription", tournamentBracket.AgeBracketID);
            ViewData["LeagueRatingLeagueID"] = new SelectList(_context.LeagueRatings, "LeagueID", "LeagueName", tournamentBracket.LeagueRatingLeagueID);
            ViewData["TournamentID"] = new SelectList(_context.Tournaments, "TournamentID", "TournamentName", tournamentBracket.TournamentID);
            return View(tournamentBracket);
        }

        // GET: TournamentBrackets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentBracket = await _context.TournamentBrackets.FindAsync(id);
            if (tournamentBracket == null)
            {
                return NotFound();
            }
            ViewData["AgeBracketID"] = new SelectList(_context.AgeBracket, "AgeBracketID", "AgeBracketDescription", tournamentBracket.AgeBracketID);
            ViewData["LeagueRatingLeagueID"] = new SelectList(_context.LeagueRatings, "LeagueID", "LeagueName", tournamentBracket.LeagueRatingLeagueID);
            ViewData["TournamentID"] = new SelectList(_context.Tournaments, "TournamentID", "TournamentName", tournamentBracket.TournamentID);
            return View(tournamentBracket);
        }

        // POST: TournamentBrackets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TournamentBracketID,TournamentID,AgeBracketID,LeagueRatingLeagueID")] TournamentBracket tournamentBracket)
        {
            if (id != tournamentBracket.TournamentBracketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tournamentBracket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournamentBracketExists(tournamentBracket.TournamentBracketID))
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
            ViewData["AgeBracketID"] = new SelectList(_context.AgeBracket, "AgeBracketID", "AgeBracketDescription", tournamentBracket.AgeBracketID);
            ViewData["LeagueRatingLeagueID"] = new SelectList(_context.LeagueRatings, "LeagueID", "LeagueName", tournamentBracket.LeagueRatingLeagueID);
            ViewData["TournamentID"] = new SelectList(_context.Tournaments, "TournamentID", "TournamentName", tournamentBracket.TournamentID);
            return View(tournamentBracket);
        }

        // GET: TournamentBrackets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournamentBracket = await _context.TournamentBrackets
                .Include(t => t.AgeBracket)
                .Include(t => t.LeagueRating)
                .Include(t => t.Tournament)
                .FirstOrDefaultAsync(m => m.TournamentBracketID == id);
            if (tournamentBracket == null)
            {
                return NotFound();
            }

            return View(tournamentBracket);
        }

        // POST: TournamentBrackets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournamentBracket = await _context.TournamentBrackets.FindAsync(id);
            _context.TournamentBrackets.Remove(tournamentBracket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournamentBracketExists(int id)
        {
            return _context.TournamentBrackets.Any(e => e.TournamentBracketID == id);
        }
    }
}
