using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc_agile_process.Models;

namespace mvc_agile_process.Data
{
    public class mvc_agile_processContext : DbContext
    {
        public mvc_agile_processContext (DbContextOptions<mvc_agile_processContext> options)
            : base(options)
        {
        }

        public DbSet<mvc_agile_process.Models.Movie> Movie { get; set; } = default!;
    }
}
