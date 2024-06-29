using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //Configuracion de las relaciones
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Congiguracion para Departamento
            modelBuilder.Entity<Departamento>()
                .HasKey(d => d.Id); // pk de departamento

            modelBuilder.Entity<Departamento>()
            .Property(d => d.Id)
            .ValueGeneratedOnAdd(); //pk autoincremental

            //configuracion para Empleado
            modelBuilder.Entity<Empleado>()
            .HasKey(e => e.Id); //pk de empleado

            modelBuilder.Entity<Empleado>()
             .Property(e => e.Id)
             .ValueGeneratedOnAdd(); //pk autoincremental

            modelBuilder.Entity<Empleado>()
            .HasOne(e => e.Departamento)//relacion con departamento
            .WithMany()
            .HasForeignKey(e => e.IdDepartamento)//Atributo de relacion fk
            .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Departamento> Departamento{set;get;}
        public DbSet<Empleado> Empleado{set;get;}
    }
}