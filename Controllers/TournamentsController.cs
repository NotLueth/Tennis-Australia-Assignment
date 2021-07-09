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
    public class TournamentsController : Controller
    {
        private readonly TennisContext _context;

        public TournamentsController(TennisContext context)
        {
            _context = context;
        }

        // GET: Tournaments
        public async Task<IActionResult> Index()
        {
            var tennisContext = _context.Tournaments.Include(t => t.Organiser).Include(t => t.TournamentType).Include(t => t.Venue);
            return View(await tennisContext.ToListAsync());
        }

        // GET: Tournaments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournaments
                .Include(t => t.Organiser)
                .Include(t => t.TournamentType)
                .Include(t => t.Venue)
                .FirstOrDefaultAsync(m => m.TournamentID == id);
            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        // GET: Tournaments/Create
        public IActionResult Create()
        {
            ViewData["OrganiserPersonalID"] = new SelectList(_context.Organisers, "PersonalID", "FullName");
            ViewData["TournamentTypeID"] = new SelectList(_context.TournamentTypes, "TournamentTypeID", "TournamentTypeName");
            ViewData["VenueID"] = new SelectList(_context.Venue, "VenueID", "VenueName");
            return View();
        }

        // POST: Tournaments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TournamentID,TournamentName,Qualifier,StartDate,EndDate,SingupStartDate,SingupEndDate,PrizeMoney,VenueID,TournamentTypeID,OrganiserPersonalID")] Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tournament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrganiserPersonalID"] = new SelectList(_context.Organisers, "PersonalID", "FullName", tournament.OrganiserPersonalID);
            ViewData["TournamentTypeID"] = new SelectList(_context.TournamentTypes, "TournamentTypeID", "TournamentTypeName", tournament.TournamentTypeID);
            ViewData["VenueID"] = new SelectList(_context.Venue, "VenueID", "VenueName", tournament.VenueID);
            return View(tournament);
        }

        // GET: Tournaments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournaments.FindAsync(id);
            if (tournament == null)
            {
                return NotFound();
            }
            ViewData["OrganiserPersonalID"] = new SelectList(_context.Organisers, "PersonalID", "FullName", tournament.OrganiserPersonalID);
            ViewData["TournamentTypeID"] = new SelectList(_context.TournamentTypes, "TournamentTypeID", "TournamentTypeName", tournament.TournamentTypeID);
            ViewData["VenueID"] = new SelectList(_context.Venue, "VenueID", "VenueName", tournament.VenueID);
            return View(tournament);
        }

        // POST: Tournaments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TournamentID,TournamentName,Qualifier,StartDate,EndDate,SingupStartDate,SingupEndDate,PrizeMoney,VenueID,TournamentTypeID,OrganiserPersonalID")] Tournament tournament)
        {
            if (id != tournament.TournamentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tournament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournamentExists(tournament.TournamentID))
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
            ViewData["OrganiserPersonalID"] = new SelectList(_context.Organisers, "PersonalID", "FullName", tournament.OrganiserPersonalID);
            ViewData["TournamentTypeID"] = new SelectList(_context.TournamentTypes, "TournamentTypeID", "TournamentTypeName", tournament.TournamentTypeID);
            ViewData["VenueID"] = new SelectList(_context.Venue, "VenueID", "VenueName", tournament.VenueID);
            return View(tournament);
        }

        // GET: Tournaments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournaments
                .Include(t => t.Organiser)
                .Include(t => t.TournamentType)
                .Include(t => t.Venue)
                .FirstOrDefaultAsync(m => m.TournamentID == id);
            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        // POST: Tournaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournament = await _context.Tournaments.FindAsync(id);
            _context.Tournaments.Remove(tournament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournamentExists(int id)
        {
            return _context.Tournaments.Any(e => e.TournamentID == id);
        }
    }
}
