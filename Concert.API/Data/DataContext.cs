using Microsoft.EntityFrameworkCore;
using Concert.Shared.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Concert.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex("Id").IsUnique();
        }
    }
}