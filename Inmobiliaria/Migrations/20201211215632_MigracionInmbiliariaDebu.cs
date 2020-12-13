using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inmobiliaria.Migrations
{
    public partial class MigracionInmbiliariaDebu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    Cuil = table.Column<double>(nullable: false),
                    Cuit = table.Column<double>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<int>(nullable: false),
                    Localidad = table.Column<string>(nullable: true),
                    Domicilio = table.Column<string>(nullable: false),
                    CondicionIva = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propietario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<double>(nullable: false),
                    Cuil = table.Column<double>(nullable: false),
                    Cuit = table.Column<double>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono = table.Column<double>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<int>(nullable: false),
                    Localidad = table.Column<string>(nullable: true),
                    Domicilio = table.Column<string>(nullable: false),
                    CondicionIva = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propiedades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Ubicacion = table.Column<string>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Disponibilidad = table.Column<bool>(nullable: false),
                    PropietarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propiedades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Propiedades_Propietario_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCompraAlquilers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    IdPropiedad = table.Column<int>(nullable: false),
                    PropiedadesId = table.Column<int>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    PrecioVenta = table.Column<double>(nullable: false),
                    PrecioAlquiler = table.Column<double>(nullable: false),
                    TipoDetalle = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCompraAlquilers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCompraAlquilers_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleCompraAlquilers_Propiedades_PropiedadesId",
                        column: x => x.PropiedadesId,
                        principalTable: "Propiedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Apellido", "CondicionIva", "Cuil", "Cuit", "Dni", "Domicilio", "Email", "EstadoCivil", "FechaNacimiento", "Localidad", "Nombre", "Sexo", "Telefono" },
                values: new object[,]
                {
                    { 1, "Valle", 3, 20374547144.0, 0.0, 37454714, "Cabal 2608", "ivanvallesj@gmail.com", 1, new DateTime(1993, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Ivan", 1, 3498459297.0 },
                    { 2, "Colombo", 2, 20361962665.0, 0.0, 36196266, "Rafael Bonin 2874", "juampicolombosj@gmail.com", 1, new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Juan", 1, 3498463367.0 }
                });

            migrationBuilder.InsertData(
                table: "DetalleCompraAlquilers",
                columns: new[] { "Id", "ClienteId", "FechaFin", "FechaInicio", "IdCliente", "IdPropiedad", "PrecioAlquiler", "PrecioVenta", "PropiedadesId", "TipoDetalle" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 15000.0, 0.0, null, 1 },
                    { 2, null, new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, 800000.0, 0.0, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Propietario",
                columns: new[] { "Id", "Apellido", "CondicionIva", "Cuil", "Cuit", "Dni", "Domicilio", "Email", "EstadoCivil", "FechaNacimiento", "Localidad", "Nombre", "Sexo", "Telefono" },
                values: new object[] { 1, "Parra", 2, 20361962595.0, 0.0, 36196259.0, "Juan Peron Y urquiza", "inmobiliariajuliandaniel@gmail.com", 1, new DateTime(1992, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "San Justo", "Julian", 1, 3498526969.0 });

            migrationBuilder.InsertData(
                table: "Propiedades",
                columns: new[] { "Id", "Disponibilidad", "Nombre", "PropietarioId", "Ubicacion", "Valor" },
                values: new object[] { 1, true, "Propiedad 1", 1, "Barrio Parque", 1500000.0 });

            migrationBuilder.InsertData(
                table: "Propiedades",
                columns: new[] { "Id", "Disponibilidad", "Nombre", "PropietarioId", "Ubicacion", "Valor" },
                values: new object[] { 2, true, "Propiedad 2", 1, "Barrio Levequi", 800000.0 });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompraAlquilers_ClienteId",
                table: "DetalleCompraAlquilers",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompraAlquilers_PropiedadesId",
                table: "DetalleCompraAlquilers",
                column: "PropiedadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Propiedades_PropietarioId",
                table: "Propiedades",
                column: "PropietarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCompraAlquilers");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Propiedades");

            migrationBuilder.DropTable(
                name: "Propietario");
        }
    }
}
