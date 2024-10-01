using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DemoMvc.Models.Student> Student { get; set; } = default!;
        public DbSet<DemoMvc.Models.PDP> PDP { get; set; } = default!;
        public DbSet<DemoMvc.Models.Employee> Employee { get; set; } = default!;
        public DbSet<DemoMvc.Models.Person> Person { get; set; } = default!;
    }
}
