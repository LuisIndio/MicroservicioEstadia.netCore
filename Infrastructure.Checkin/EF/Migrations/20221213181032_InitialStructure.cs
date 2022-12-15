using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Estadia.EF.Migrations
{
    /// <inheritdoc />
    public partial class InitialStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreditCard",
                columns: table => new
                {
                    creditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tipotarjeta = table.Column<string>(name: "tipo_tarjeta", type: "nvarchar(max)", nullable: false),
                    numerotarjeta = table.Column<string>(name: "numero_tarjeta", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreditCard", x => x.creditCardId);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    facturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    detallefactura = table.Column<string>(name: "detalle_factura", type: "nvarchar(max)", nullable: false),
                    numerofactura = table.Column<string>(name: "numero_factura", type: "nvarchar(max)", nullable: false),
                    total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechafactura = table.Column<string>(name: "fecha_factura", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.facturaId);
                });

            migrationBuilder.CreateTable(
                name: "Habitacion",
                columns: table => new
                {
                    habitacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    codigohabitacion = table.Column<string>(name: "codigo_habitacion", type: "nvarchar(max)", nullable: true),
                    limitepersona = table.Column<int>(name: "limite_persona", type: "int", nullable: false),
                    tipohabitacion = table.Column<Guid>(name: "tipo_habitacion", type: "uniqueidentifier", nullable: false),
                    preciohabitacion = table.Column<double>(name: "precio_habitacion", type: "float", nullable: false),
                    numerohabitacion = table.Column<int>(name: "numero_habitacion", type: "int", nullable: false),
                    caracteristicahabitacion = table.Column<string>(name: "caracteristica_habitacion", type: "nvarchar(max)", nullable: true),
                    disponibilidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitacion", x => x.habitacionId);
                });

            migrationBuilder.CreateTable(
                name: "Huesped",
                columns: table => new
                {
                    huespedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    dni = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huesped", x => x.huespedId);
                });

            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    pagoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.pagoId);
                });

            migrationBuilder.CreateTable(
                name: "Checkin",
                columns: table => new
                {
                    checkinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    reservaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    habitacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HuespedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkin", x => x.checkinId);
                    table.ForeignKey(
                        name: "FK_Checkin_CreditCard_CreditCardId",
                        column: x => x.CreditCardId,
                        principalTable: "CreditCard",
                        principalColumn: "creditCardId");
                    table.ForeignKey(
                        name: "FK_Checkin_Habitacion_habitacionId",
                        column: x => x.habitacionId,
                        principalTable: "Habitacion",
                        principalColumn: "habitacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkin_Huesped_HuespedId",
                        column: x => x.HuespedId,
                        principalTable: "Huesped",
                        principalColumn: "huespedId");
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    checkoutId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    checkinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    creditCardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacturaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PagoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.checkoutId);
                    table.ForeignKey(
                        name: "FK_Checkout_Checkin_checkinId",
                        column: x => x.checkinId,
                        principalTable: "Checkin",
                        principalColumn: "checkinId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkout_CreditCard_creditCardId",
                        column: x => x.creditCardId,
                        principalTable: "CreditCard",
                        principalColumn: "creditCardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkout_Factura_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Factura",
                        principalColumn: "facturaId");
                    table.ForeignKey(
                        name: "FK_Checkout_Pago_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pago",
                        principalColumn: "pagoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_CreditCardId",
                table: "Checkin",
                column: "CreditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_habitacionId",
                table: "Checkin",
                column: "habitacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_HuespedId",
                table: "Checkin",
                column: "HuespedId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_checkinId",
                table: "Checkout",
                column: "checkinId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_creditCardId",
                table: "Checkout",
                column: "creditCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_FacturaId",
                table: "Checkout",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_PagoId",
                table: "Checkout",
                column: "PagoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "CreditCard");

            migrationBuilder.DropTable(
                name: "Habitacion");

            migrationBuilder.DropTable(
                name: "Huesped");
        }
    }
}
