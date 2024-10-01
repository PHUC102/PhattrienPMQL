using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

namespace DemoMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVC.Models.Person> Person { get; set; } = default!;
        public DbSet<WebMVC.Models.Employee> Employee { get; set; } = default!;
    }
}
