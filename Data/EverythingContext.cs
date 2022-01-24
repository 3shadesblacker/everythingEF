#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Everything.Models;

    public class EverythingContext : DbContext
    {
        public EverythingContext (DbContextOptions<EverythingContext> options)
            : base(options)
        {
        }

        public DbSet<Everything.Models.Transaction> Transaction { get; set; }
    }
