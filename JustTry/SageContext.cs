using JustTry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustTry
{
    public class SageContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SageContext(DbContextOptions<SageContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
