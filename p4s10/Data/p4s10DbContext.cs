using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using p4s10.Models;

namespace p4s10.Data
{
    public class p4s10DbContext : DbContext
    {
        public p4s10DbContext (DbContextOptions<p4s10DbContext> options)
            : base(options)
        {
        }

        public DbSet<p4s10.Models.Student> Student { get; set; } = default!;

        public DbSet<p4s10.Models.Subject>? Subject { get; set; }

        public DbSet<p4s10.Models.Teacher>? Teacher { get; set; }
    }
}
