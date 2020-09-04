using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemestralkaDataControl.EF
{
    public class ApplicationContext : DbContext
    {
        internal ApplicationContext()
        {

        }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.EnsureDeleted();
            Database.Migrate();
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB;database=Semestralka;integrated security=True;
                    MultipleActiveResultSets=True;App=EntityFramework;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany(t => t.Reservations)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
