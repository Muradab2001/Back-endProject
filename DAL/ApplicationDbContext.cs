using Microsoft.EntityFrameworkCore;
using MultiShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiShop.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }


        public DbSet<Slider> Sliders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var item in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
                )
            {
                item.SetColumnType("decimal(6,2)");
            }

            modelBuilder.Entity<Setting>()
                .HasIndex(p => p.Key)
                .IsUnique();

            //modelBuilder.Entity<Category>()
            //    .HasIndex(c => c.Name)
            //    .IsUnique();

            //base.OnModelCreating(modelBuilder);
        }
    }
}
