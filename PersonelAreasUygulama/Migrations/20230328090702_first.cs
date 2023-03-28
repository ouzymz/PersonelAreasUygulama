using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonelAreasUygulama.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumGunu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "PersonelId", "Ad", "DogumGunu", "Email", "Maas", "Soyad" },
                values: new object[] { 1, "William", new DateTime(2023, 3, 28, 12, 7, 1, 999, DateTimeKind.Local).AddTicks(1584), "HotShakes@gmail.com", 50m, "Shakespeare" });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "PersonelId", "Ad", "DogumGunu", "Email", "Maas", "Soyad" },
                values: new object[] { 2, "Oguzhan", new DateTime(2023, 3, 28, 12, 7, 1, 999, DateTimeKind.Local).AddTicks(1622), "ogzhnylmz95@gmail.com", 100m, "Yilmaz" });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "PersonelId", "Ad", "DogumGunu", "Email", "Maas", "Soyad" },
                values: new object[] { 3, "Cansu", new DateTime(2023, 3, 28, 12, 7, 1, 999, DateTimeKind.Local).AddTicks(1623), "Cansu91@gmail.com", 150m, "Yilmaz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");
        }
    }
}
