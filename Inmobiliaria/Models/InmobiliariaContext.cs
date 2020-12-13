using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Inmobiliaria.Models
{
    public class InmobiliariaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database = InmobiliariaContext; User Id = sa; Password = 123; MultipleActiveResultSets = True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente {Id =1, Nombre="Ivan", Apellido ="Valle", Dni=37454714, Cuil=20374547144,FechaNacimiento=new DateTime (1993,6,29), Telefono=3498459297, Sexo=SexoEnum.Masculino,Email="ivanvallesj@gmail.com",EstadoCivil=EstadoCivilEnum.Soltero,Localidad="San Justo", CondicionIva=CondicionIvaEnum.ConsumidorFinal, Domicilio="Cabal 2608"},
                new Cliente { Id = 2, Nombre = "Juan", Apellido = "Colombo", Dni = 36196266, Cuil = 20361962665, FechaNacimiento = new DateTime(1992,1, 17), Telefono = 3498463367, Sexo = SexoEnum.Masculino, Email = "juampicolombosj@gmail.com", EstadoCivil = EstadoCivilEnum.Soltero, Localidad = "San Justo", CondicionIva = CondicionIvaEnum.Monotributista, Domicilio = "Rafael Bonin 2874" }
            );
            modelBuilder.Entity<Propietario>().HasData(
                new Propietario { Id = 1, Nombre = "Julian", Apellido = "Parra", Dni = 36196259, Cuil = 20361962595, FechaNacimiento = new DateTime(1992, 1, 10), Telefono = 3498526969, Sexo = SexoEnum.Masculino, Email = "inmobiliariajuliandaniel@gmail.com", EstadoCivil = EstadoCivilEnum.Soltero, Localidad = "San Justo", CondicionIva = CondicionIvaEnum.Monotributista, Domicilio = "Juan Peron Y urquiza" }
           );
            modelBuilder.Entity<Propiedades>().HasData(
              new Propiedades { Id = 1, Nombre = "Propiedad 1", Ubicacion = "Barrio Parque", Valor = 1500000, Disponibilidad = true, PropietarioId = 1 },
               new Propiedades { Id = 2, Nombre = "Propiedad 2", Ubicacion = "Barrio Levequi", Valor = 800000, Disponibilidad = true, PropietarioId = 1 }

          );
            modelBuilder.Entity<DetalleCompraAlquiler>().HasData(
             new DetalleCompraAlquiler { Id = 1, IdCliente = 1, IdPropiedad = 1, FechaInicio = new DateTime(2020, 12, 2), FechaFin = new DateTime(2023, 12, 2), TipoDetalle=TipoDetalleEnum.Alquier,PrecioAlquiler=15000 },
              new DetalleCompraAlquiler { Id = 2, IdCliente = 2, IdPropiedad = 2, FechaInicio = new DateTime(2020, 12, 2), FechaFin = new DateTime(2023, 12, 2), TipoDetalle = TipoDetalleEnum.Venta, PrecioAlquiler = 800000 }
             );


        }
        public DbSet<Propiedades> Propiedades { get; set; }
        public DbSet<Propietario> Propietario { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleCompraAlquiler> DetalleCompraAlquilers { get; set; }



        public InmobiliariaContext(DbContextOptions<InmobiliariaContext> options) : base(options)
        {

        }

        public InmobiliariaContext()
        {
        }

    }
}