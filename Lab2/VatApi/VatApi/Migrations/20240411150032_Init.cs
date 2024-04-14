using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VatApi.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ViesApproximateDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    street = table.Column<string>(type: "TEXT", nullable: true),
                    postalCode = table.Column<string>(type: "TEXT", nullable: true),
                    city = table.Column<string>(type: "TEXT", nullable: true),
                    companyType = table.Column<string>(type: "TEXT", nullable: true),
                    matchName = table.Column<int>(type: "INTEGER", nullable: true),
                    matchStreet = table.Column<int>(type: "INTEGER", nullable: true),
                    matchPostalCode = table.Column<int>(type: "INTEGER", nullable: true),
                    matchCity = table.Column<int>(type: "INTEGER", nullable: true),
                    matchCompanyType = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViesApproximateDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    isValid = table.Column<bool>(type: "INTEGER", nullable: false),
                    requestDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    userError = table.Column<string>(type: "TEXT", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    address = table.Column<string>(type: "TEXT", nullable: true),
                    requestIdentifier = table.Column<string>(type: "TEXT", nullable: true),
                    originalVatNumber = table.Column<string>(type: "TEXT", nullable: true),
                    vatNumber = table.Column<string>(type: "TEXT", nullable: false),
                    viesApproximateId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vats_ViesApproximateDb_viesApproximateId",
                        column: x => x.viesApproximateId,
                        principalTable: "ViesApproximateDb",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "vats",
                columns: new[] { "Id", "address", "isValid", "name", "originalVatNumber", "requestDate", "requestIdentifier", "userError", "vatNumber", "viesApproximateId" },
                values: new object[,]
                {
                    { 1, null, true, null, null, null, null, null, "123456789", null },
                    { 2, null, false, null, null, null, null, null, "123", null },
                    { 3, null, true, null, null, null, null, null, "4455", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_vats_viesApproximateId",
                table: "vats",
                column: "viesApproximateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vats");

            migrationBuilder.DropTable(
                name: "ViesApproximateDb");
        }
    }
}
