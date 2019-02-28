using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events3.Data;
using Events3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Events3.Controllers
{
    public class YearlyEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public YearlyEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
          //  return View(await _context.YearlyEvents.ToListAsync());
          return View();
        }
        public IActionResult Create()
        {
            YearlyEventsViewModel yearlyeventsViewModel =
                new YearlyEventsViewModel();


            return View(yearlyeventsViewModel);
        }
        // POST: CalendarSetUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SpecialEvents,Months," +
            "Parshios,StartTime,EndTime")] YearlyEventsViewModel yearlyEvents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yearlyEvents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("YearlyEvents/Create");
        }

    }
}