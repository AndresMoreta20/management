using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using management.Models;

namespace management.Data
{
    public class managementContext : DbContext
    {
        public managementContext (DbContextOptions<managementContext> options)
            : base(options)
        {
        }

        public DbSet<management.Models.Employee> Employee { get; set; } = default!;
    }
}
