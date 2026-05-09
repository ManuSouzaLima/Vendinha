using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vendinha.Models;

namespace Vendinha.Database
{
    public class VendinhaDB : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        private string connectionString = "Server=localhost;Port=5432;Password=;User Id=postgres;Database=postgres;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var modelCliente = modelBuilder.Entity<Cliente>();
            modelCliente.ToTable("clientes");

            //Continuar registrando as propriedades do cliente aqui 
        }
    }
}
