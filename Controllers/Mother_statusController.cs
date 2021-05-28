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
    public class Mother_statusController : Controller
    {
        private readonly MAVRSContext _context;

        public Mother_statusController(MAVRSContext context)
        {
            _context = context;
        }

        // GET: Mother_status
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mother_status.ToListAsync());
        }

        // GET: Mother_status/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mother_status = await _context.Mother_status
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mother_status == null)
            {
                return NotFound();
            }

            return View(mother_status);
        }

        // GET: Mother_status/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mother_status/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,C_mother_status")] Mother_status mother_status)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mother_status);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mother_status);
        }

        // GET: Mother_status/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mother_status = await _context.Mother_status.FindAsync(id);
            if (mother_status == null)
            {
                return NotFound();
            }
            return View(mother_status);
        }

        // POST: Mother_status/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,C_mother_status")] Mother_status mother_status)
        {
            if (id != mother_status.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mother_status);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Mother_statusExists(mother_status.ID))
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
            return View(mother_status);
        }

        // GET: Mother_status/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mother_status = await _context.Mother_status
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mother_status == null)
            {
                return NotFound();
            }

            return View(mother_status);
        }

        // POST: Mother_status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mother_status = await _context.Mother_status.FindAsync(id);
            _context.Mother_status.Remove(mother_status);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Mother_statusExists(int id)
        {
            return _context.Mother_status.Any(e => e.ID == id);
        }
    }
}
