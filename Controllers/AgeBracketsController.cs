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
    public class AgeBracketsController : Controller
    {
        private readonly TennisContext _context;

        public AgeBracketsController(TennisContext context)
        {
            _context = context;
        }

        // GET: AgeBrackets
        public async Task<IActionResult> Index()
        {
            return View(await _context.AgeBracket.ToListAsync());
        }

        // GET: AgeBrackets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ageBracket = await _context.AgeBracket
                .FirstOrDefaultAsync(m => m.AgeBracketID == id);
            if (ageBracket == null)
            {
                return NotFound();
            }

            return View(ageBracket);
        }

        // GET: AgeBrackets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AgeBrackets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AgeBracketID,AgeBracketName,AgeBracketDescription")] AgeBracket ageBracket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ageBracket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ageBracket);
        }

        // GET: AgeBrackets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ageBracket = await _context.AgeBracket.FindAsync(id);
            if (ageBracket == null)
            {
                return NotFound();
            }
            return View(ageBracket);
        }

        // POST: AgeBrackets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AgeBracketID,AgeBracketName,AgeBracketDescription")] AgeBracket ageBracket)
        {
            if (id != ageBracket.AgeBracketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ageBracket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgeBracketExists(ageBracket.AgeBracketID))
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
            return View(ageBracket);
        }

        // GET: AgeBrackets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ageBracket = await _context.AgeBracket
                .FirstOrDefaultAsync(m => m.AgeBracketID == id);
            if (ageBracket == null)
            {
                return NotFound();
            }

            return View(ageBracket);
        }

        // POST: AgeBrackets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ageBracket = await _context.AgeBracket.FindAsync(id);
            _context.AgeBracket.Remove(ageBracket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgeBracketExists(int id)
        {
            return _context.AgeBracket.Any(e => e.AgeBracketID == id);
        }
    }
}
