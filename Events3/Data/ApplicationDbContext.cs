using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Events3.ViewModels;
using Events3.Models;

namespace Events3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public object YearlyEvents { get; internal set; }

        public DbSet<Events3.ViewModels.YearlyEventsViewModel> YearlyEventsViewModel { get; set; }

        public DbSet<Events3.Models.YearlyEvents> YearlyEvents_1 { get; set; }
    }
}
