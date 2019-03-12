using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Events3.Data;
using Events3.Models;
using Events3.ViewModels;

namespace Events3.Controllers
{
    public class YearlyEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public YearlyEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: YearlyEvents
        public async Task<IActionResult> Index()
        {
           // List<YearlyEvents> yearlyEvents = _context.YearlyEvents.ToList();
            return View(await _context.YearlyEvents_1.ToListAsync());
        }

        // GET: YearlyEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yearlyEvents = await _context.YearlyEvents_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yearlyEvents == null)
            {
                return NotFound();
            }

            return View(yearlyEvents);
        }

        // GET: YearlyEvents/Create
        public IActionResult Create()
        { CreateYearlyEventsViewModel createYearlyEventsViewModel =
                new CreateYearlyEventsViewModel();
        
            return View(createYearlyEventsViewModel);
        }

        // POST: YearlyEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create
            ([Bind("Id,StartingDate,EndingDate,SpecialEvents,SpecialShabassos," +
                   "Months,Parshios,StartTime,EndTime,LifeEvents,EventDescription")] YearlyEvents yearlyEvents)
        {
            if (ModelState.IsValid)
               
            {
                _context.Add(yearlyEvents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(yearlyEvents);
        }

        // GET: YearlyEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yearlyEvents = await _context.YearlyEvents_1.FindAsync(id);
            if (yearlyEvents == null)
            {
                return NotFound();
            }
            return View(yearlyEvents);
        }

        // POST: YearlyEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  [Bind("Id,StartDate,EndDate," +
          "SpecialEvents,SpecialShabassos,Months,Parshios,StartTime,EndTime,EventDescription")] YearlyEvents yearlyEvents)
        {
            if (id != yearlyEvents.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yearlyEvents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YearlyEventsExists(yearlyEvents.Id))
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
            return View(yearlyEvents);
        }

        // GET: YearlyEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yearlyEvents = await _context.YearlyEvents_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (yearlyEvents == null)
            {
                return NotFound();
            }

            return View(yearlyEvents);
        }

        // POST: YearlyEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yearlyEvents = await _context.YearlyEvents_1.FindAsync(id);
            _context.YearlyEvents_1.Remove(yearlyEvents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YearlyEventsExists(int id)
        {
            return _context.YearlyEvents_1.Any(e => e.Id == id);
        }
    }
}
