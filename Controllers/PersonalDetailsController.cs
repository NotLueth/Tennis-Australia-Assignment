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
    public class PersonalDetailsController : Controller
    {
        private readonly TennisContext _context;

        public PersonalDetailsController(TennisContext context)
        {
            _context = context;
        }

        // GET: PersonalDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonalDetails.ToListAsync());
        }

        // GET: PersonalDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetails = await _context.PersonalDetails
                .FirstOrDefaultAsync(m => m.PersonalID == id);
            if (personalDetails == null)
            {
                return NotFound();
            }

            return View(personalDetails);
        }

        // GET: PersonalDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonalDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Age,Street,City,Postcode,Email,Phone")] PersonalDetails personalDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalDetails);
        }

        // GET: PersonalDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetails = await _context.PersonalDetails.FindAsync(id);
            if (personalDetails == null)
            {
                return NotFound();
            }
            return View(personalDetails);
        }

        // POST: PersonalDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Age,Street,City,Postcode,Email,Phone")] PersonalDetails personalDetails)
        {
            if (id != personalDetails.PersonalID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalDetailsExists(personalDetails.PersonalID))
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
            return View(personalDetails);
        }

        // GET: PersonalDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetails = await _context.PersonalDetails
                .FirstOrDefaultAsync(m => m.PersonalID == id);
            if (personalDetails == null)
            {
                return NotFound();
            }

            return View(personalDetails);
        }

        // POST: PersonalDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalDetails = await _context.PersonalDetails.FindAsync(id);
            _context.PersonalDetails.Remove(personalDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalDetailsExists(int id)
        {
            return _context.PersonalDetails.Any(e => e.PersonalID == id);
        }
    }
}
