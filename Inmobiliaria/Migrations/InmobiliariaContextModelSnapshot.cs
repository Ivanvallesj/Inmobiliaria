﻿// <auto-generated />
using System;
using Inmobiliaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inmobiliaria.Migrations
{
    [DbContext(typeof(InmobiliariaContext))]
    partial class InmobiliariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inmobiliaria.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CondicionIva")
                        .HasColumnType("int");

                    b.Property<double>("Cuil")
                        .HasColumnType("float");

                    b.Property<double>("Cuit")
                        .HasColumnType("float");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<double>("Telefono")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Valle",
                            CondicionIva = 3,
                            Cuil = 20374547144.0,
                            Cuit = 0.0,
                            Dni = 37454714,
                            Domicilio = "Cabal 2608",
                            Email = "ivanvallesj@gmail.com",
                            EstadoCivil = 1,
                            FechaNacimiento = new DateTime(1993, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Localidad = "San Justo",
                            Nombre = "Ivan",
                            Sexo = 1,
                            Telefono = 3498459297.0
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Colombo",
                            CondicionIva = 2,
                            Cuil = 20361962665.0,
                            Cuit = 0.0,
                            Dni = 36196266,
                            Domicilio = "Rafael Bonin 2874",
                            Email = "juampicolombosj@gmail.com",
                            EstadoCivil = 1,
                            FechaNacimiento = new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Localidad = "San Justo",
                            Nombre = "Juan",
                            Sexo = 1,
                            Telefono = 3498463367.0
                        });
                });

            modelBuilder.Entity("Inmobiliaria.Models.DetalleCompraAlquiler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdPropiedad")
                        .HasColumnType("int");

                    b.Property<double>("PrecioAlquiler")
                        .HasColumnType("float");

                    b.Property<double>("PrecioVenta")
                        .HasColumnType("float");

                    b.Property<int?>("PropiedadesId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDetalle")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PropiedadesId");

                    b.ToTable("DetalleCompraAlquilers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaFin = new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdCliente = 1,
                            IdPropiedad = 1,
                            PrecioAlquiler = 15000.0,
                            PrecioVenta = 0.0,
                            TipoDetalle = 1
                        },
                        new
                        {
                            Id = 2,
                            FechaFin = new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaInicio = new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IdCliente = 2,
                            IdPropiedad = 2,
                            PrecioAlquiler = 800000.0,
                            PrecioVenta = 0.0,
                            TipoDetalle = 2
                        });
                });

            modelBuilder.Entity("Inmobiliaria.Models.Propiedades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Disponibilidad")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PropietarioId");

                    b.ToTable("Propiedades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Disponibilidad = true,
                            Nombre = "Propiedad 1",
                            PropietarioId = 1,
                            Ubicacion = "Barrio Parque",
                            Valor = 1500000.0
                        },
                        new
                        {
                            Id = 2,
                            Disponibilidad = true,
                            Nombre = "Propiedad 2",
                            PropietarioId = 1,
                            Ubicacion = "Barrio Levequi",
                            Valor = 800000.0
                        });
                });

            modelBuilder.Entity("Inmobiliaria.Models.Propietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CondicionIva")
                        .HasColumnType("int");

                    b.Property<double>("Cuil")
                        .HasColumnType("float");

                    b.Property<double>("Cuit")
                        .HasColumnType("float");

                    b.Property<int>("Dni")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoCivil")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<double>("Telefono")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Propietario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Parra",
                            CondicionIva = 2,
                            Cuil = 20361962595.0,
                            Cuit = 0.0,
                            Dni = 36196259,
                            Domicilio = "Juan Peron Y urquiza",
                            Email = "inmobiliariajuliandaniel@gmail.com",
                            EstadoCivil = 1,
                            FechaNacimiento = new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Localidad = "San Justo",
                            Nombre = "Julian",
                            Sexo = 1,
                            Telefono = 3498526969.0
                        });
                });

            modelBuilder.Entity("Inmobiliaria.Models.DetalleCompraAlquiler", b =>
                {
                    b.HasOne("Inmobiliaria.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Inmobiliaria.Models.Propiedades", "Propiedades")
                        .WithMany()
                        .HasForeignKey("PropiedadesId");
                });

            modelBuilder.Entity("Inmobiliaria.Models.Propiedades", b =>
                {
                    b.HasOne("Inmobiliaria.Models.Propietario", "Propietario")
                        .WithMany()
                        .HasForeignKey("PropietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
