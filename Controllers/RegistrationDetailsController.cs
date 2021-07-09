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
    public class RegistrationDetailsController : Controller
    {
        private readonly TennisContext _context;

        public RegistrationDetailsController(TennisContext context)
        {
            _context = context;
        }

        // GET: RegistrationDetails
        public async Task<IActionResult> Index()
        {
            var tennisContext = _context.RegistrationDetails.Include(r => r.Player).Include(r => r.Registration);
            return View(await tennisContext.ToListAsync());
        }

        // GET: RegistrationDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationDetails = await _context.RegistrationDetails
                .Include(r => r.Player)
                .Include(r => r.Registration)
                .FirstOrDefaultAsync(m => m.RegistrationDetailsID == id);
            if (registrationDetails == null)
            {
                return NotFound();
            }

            return View(registrationDetails);
        }

        // GET: RegistrationDetails/Create
        public IActionResult Create()
        {
            ViewData["PlayerPersonalID"] = new SelectList(_context.Players, "PersonalID", "FullName");
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID");
            return View();
        }

        // POST: RegistrationDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegistrationDetailsID,RegistrationID,PlayerPersonalID")] RegistrationDetails registrationDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrationDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerPersonalID"] = new SelectList(_context.Players, "PersonalID", "FullName", registrationDetails.PlayerPersonalID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", registrationDetails.RegistrationID);
            return View(registrationDetails);
        }

        // GET: RegistrationDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationDetails = await _context.RegistrationDetails.FindAsync(id);
            if (registrationDetails == null)
            {
                return NotFound();
            }
            ViewData["PlayerPersonalID"] = new SelectList(_context.Players, "PersonalID", "FullName", registrationDetails.PlayerPersonalID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", registrationDetails.RegistrationID);
            return View(registrationDetails);
        }

        // POST: RegistrationDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegistrationDetailsID,RegistrationID,PlayerPersonalID")] RegistrationDetails registrationDetails)
        {
            if (id != registrationDetails.RegistrationDetailsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrationDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrationDetailsExists(registrationDetails.RegistrationDetailsID))
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
            ViewData["PlayerPersonalID"] = new SelectList(_context.Players, "PersonalID", "FullName", registrationDetails.PlayerPersonalID);
            ViewData["RegistrationID"] = new SelectList(_context.registrations, "RegistrationID", "RegistrationID", registrationDetails.RegistrationID);
            return View(registrationDetails);
        }

        // GET: RegistrationDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrationDetails = await _context.RegistrationDetails
                .Include(r => r.Player)
                .Include(r => r.Registration)
                .FirstOrDefaultAsync(m => m.RegistrationDetailsID == id);
            if (registrationDetails == null)
            {
                return NotFound();
            }

            return View(registrationDetails);
        }

        // POST: RegistrationDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrationDetails = await _context.RegistrationDetails.FindAsync(id);
            _context.RegistrationDetails.Remove(registrationDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrationDetailsExists(int id)
        {
            return _context.RegistrationDetails.Any(e => e.RegistrationDetailsID == id);
        }
    }
}
