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
    public class MothersController : Controller
    {
        private readonly MAVRSContext _context;

        public MothersController(MAVRSContext context)
        {
            _context = context;
        }

        // GET: Mothers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mothers.ToListAsync());
        }

        // GET: Mothers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mothers = await _context.Mothers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mothers == null)
            {
                return NotFound();
            }

            return View(mothers);
        }

        // GET: Mothers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mothers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Full_Names,ID,Age,Location,Phone_number,Date,EDD,Next_Visit")] Mothers mothers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mothers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mothers);
        }

        // GET: Mothers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mothers = await _context.Mothers.FindAsync(id);
            if (mothers == null)
            {
                return NotFound();
            }
            return View(mothers);
        }

        // POST: Mothers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Full_Names,ID,Age,Location,Phone_number,Date,EDD,Next_Visit")] Mothers mothers)
        {
            if (id != mothers.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mothers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MothersExists(mothers.ID))
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
            return View(mothers);
        }

        // GET: Mothers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mothers = await _context.Mothers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mothers == null)
            {
                return NotFound();
            }

            return View(mothers);
        }

        // POST: Mothers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mothers = await _context.Mothers.FindAsync(id);
            _context.Mothers.Remove(mothers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MothersExists(int id)
        {
            return _context.Mothers.Any(e => e.ID == id);
        }
    }
}
