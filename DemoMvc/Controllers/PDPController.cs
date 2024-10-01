using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Data;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class PDPController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PDPController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PDP
        public async Task<IActionResult> Index()
        {
            return View(await _context.PDP.ToListAsync());
        }

        // GET: PDP/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDP = await _context.PDP
                .FirstOrDefaultAsync(m => m.FullName == id);
            if (pDP == null)
            {
                return NotFound();
            }

            return View(pDP);
        }

        // GET: PDP/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PDP/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,Age,Hight")] PDP pDP)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pDP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pDP);
        }

        // GET: PDP/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDP = await _context.PDP.FindAsync(id);
            if (pDP == null)
            {
                return NotFound();
            }
            return View(pDP);
        }

        // POST: PDP/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FullName,Age,Hight")] PDP pDP)
        {
            if (id != pDP.FullName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pDP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PDPExists(pDP.FullName))
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
            return View(pDP);
        }

        // GET: PDP/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDP = await _context.PDP
                .FirstOrDefaultAsync(m => m.FullName == id);
            if (pDP == null)
            {
                return NotFound();
            }

            return View(pDP);
        }

        // POST: PDP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pDP = await _context.PDP.FindAsync(id);
            if (pDP != null)
            {
                _context.PDP.Remove(pDP);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PDPExists(string id)
        {
            return _context.PDP.Any(e => e.FullName == id);
        }
    }
}
