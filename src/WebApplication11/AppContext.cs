using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11
{
    public class AppContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }

        public AppContext(DbContextOptions<AppContext> options) 
            : base(options)
        {
        }
    }
}
