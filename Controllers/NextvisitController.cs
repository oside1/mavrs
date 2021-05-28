using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAVRS.Data;
using MAVRS.Models;

namespace MAVRS.Controllers
{
    public class NextvisitController : Controller
    {
        private readonly MAVRSContext _context;

        public NextvisitController(MAVRSContext context)
        {
            _context = context;
        }

        // GET: Nextvisits
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nextvisit.ToListAsync());
        }

        // GET: Nextvisits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nextvisit = await _context.Nextvisit
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nextvisit == null)
            {
                return NotFound();
            }

            return View(nextvisit);
        }

        // GET: Nextvisits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nextvisits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,P_national_id,Full_names,S_national_id,Phone_no")] Nextvisit nextvisit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nextvisit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nextvisit);
        }

        // GET: Nextvisits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nextvisit = await _context.Nextvisit.FindAsync(id);
            if (nextvisit == null)
            {
                return NotFound();
            }
            return View(nextvisit);
        }

        // POST: Nextvisits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,P_national_id,Full_names,S_national_id,Phone_no")] Nextvisit nextvisit)
        {
            if (id != nextvisit.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nextvisit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NextvisitExists(nextvisit.ID))
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
            return View(nextvisit);
        }

        // GET: Nextvisits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nextvisit = await _context.Nextvisit
                .FirstOrDefaultAsync(m => m.ID == id);
            if (nextvisit == null)
            {
                return NotFound();
            }

            return View(nextvisit);
        }

        // POST: Nextvisits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nextvisit = await _context.Nextvisit.FindAsync(id);
            _context.Nextvisit.Remove(nextvisit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NextvisitExists(int id)
        {
            return _context.Nextvisit.Any(e => e.ID == id);
        }
    }
}
