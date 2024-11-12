using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TampaPremierLeague.Data;
using TampaPremierLeague.Models;

namespace TampaPremierLeague.Controllers
{
    public class tpleaguesController : Controller
    {
        private readonly TampaPremierLeagueContext _context;

        public tpleaguesController(TampaPremierLeagueContext context)
        {
            _context = context;
        }

        // GET: tpleagues
        public async Task<IActionResult> Index()
        {
            return View(await _context.tpleague.ToListAsync());
        }

        // GET: tpleagues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tpleague = await _context.tpleague
                .FirstOrDefaultAsync(m => m.Position == id);
            if (tpleague == null)
            {
                return NotFound();
            }

            return View(tpleague);
        }

        // GET: tpleagues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tpleagues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Position,TeamName,Played,Won,Lost,NoResult,NetRunRate,Points,RecentForm")] tpleague tpleague)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tpleague);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tpleague);
        }

        // GET: tpleagues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tpleague = await _context.tpleague.FindAsync(id);
            if (tpleague == null)
            {
                return NotFound();
            }
            return View(tpleague);
        }

        // POST: tpleagues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Position,TeamName,Played,Won,Lost,NoResult,NetRunRate,Points,RecentForm")] tpleague tpleague)
        {
            if (id != tpleague.Position)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tpleague);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tpleagueExists(tpleague.Position))
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
            return View(tpleague);
        }

        // GET: tpleagues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tpleague = await _context.tpleague
                .FirstOrDefaultAsync(m => m.Position == id);
            if (tpleague == null)
            {
                return NotFound();
            }

            return View(tpleague);
        }

        // POST: tpleagues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tpleague = await _context.tpleague.FindAsync(id);
            if (tpleague != null)
            {
                _context.tpleague.Remove(tpleague);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tpleagueExists(int id)
        {
            return _context.tpleague.Any(e => e.Position == id);
        }
    }
}
