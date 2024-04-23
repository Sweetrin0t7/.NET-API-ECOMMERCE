using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iShirtsAPI.Models;
using iShirtsAPI.Models.Enums;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace iShirtsAPI.Data
{
    public class iShirtsAPIContext : DbContext
    {
        public iShirtsAPIContext (DbContextOptions<iShirtsAPIContext> options) : base(options)
        {
        }

        public DbSet<USUARIO> USUARIO => Set<USUARIO>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<USUARIO>()
                .HasKey(u => u.ID_USUARIO);

            modelBuilder
            .Entity<USUARIO>()
            .Property(e => e.CARGO)
            .HasConversion(
                v => v.ToString(),
                v => (CargoEnum)Enum.Parse(typeof(CargoEnum), v));
        
            modelBuilder
             .Entity<USUARIO>()
             .Property(e => e.ATIVO)
             .HasConversion(
                v => v.ToString(),
                v => (AtivoEnum)Enum.Parse(typeof(AtivoEnum), v));
            }


}
}
