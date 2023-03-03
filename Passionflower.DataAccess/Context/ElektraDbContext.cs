using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passionflower.DataAccess.Context
{
    public class ElektraDbContext : DbContext
    {
        public ElektraDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FISARSIV> FisArsiv { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FISARSIV>().ToTable("FISARSIV");
        }

    }
}
