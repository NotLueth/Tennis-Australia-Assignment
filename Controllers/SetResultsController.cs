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
    public class SetResultsController : Controller
    {
        private readonly TennisContext _context;

        public SetResultsController(TennisContext context)
        {
            _context = context;
        }

        // GET: SetResults
        public async Task<IActionResult> Index()
        {
            var tennisContext = _context.setResults.Include(s => s.Match);
            return View(await tennisContext.ToListAsync());
        }

        // GET: SetResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setResult = await _context.setResults
                .Include(s => s.Match)
                .FirstOrDefaultAsync(m => m.SetResultID == id);
            if (setResult == null)
            {
                return NotFound();
            }

            return View(setResult);
        }

        // GET: SetResults/Create
        public IActionResult Create()
        {
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID");
            return View();
        }

        // POST: SetResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SetResultID,set,FirstRegIDScore,SecondRegIDScore,MatchID")] SetResult setResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(setResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID", setResult.MatchID);
            return View(setResult);
        }

        // GET: SetResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setResult = await _context.setResults.FindAsync(id);
            if (setResult == null)
            {
                return NotFound();
            }
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID", setResult.MatchID);
            return View(setResult);
        }

        // POST: SetResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SetResultID,set,FirstRegIDScore,SecondRegIDScore,MatchID")] SetResult setResult)
        {
            if (id != setResult.SetResultID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(setResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SetResultExists(setResult.SetResultID))
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
            ViewData["MatchID"] = new SelectList(_context.Matches, "MatchID", "MatchID", setResult.MatchID);
            return View(setResult);
        }

        // GET: SetResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setResult = await _context.setResults
                .Include(s => s.Match)
                .FirstOrDefaultAsync(m => m.SetResultID == id);
            if (setResult == null)
            {
                return NotFound();
            }

            return View(setResult);
        }

        // POST: SetResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var setResult = await _context.setResults.FindAsync(id);
            _context.setResults.Remove(setResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SetResultExists(int id)
        {
            return _context.setResults.Any(e => e.SetResultID == id);
        }
    }
}
