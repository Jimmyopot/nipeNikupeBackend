using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NipeNikupe.Migrations
{
    /// <inheritdoc />
    public partial class update_opot3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_counties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "counties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mombasa" },
                    { 2, "Kwale" },
                    { 3, "Kilifi" },
                    { 4, "Tana River" },
                    { 5, "Lamu" },
                    { 6, "Taita-Taveta" },
                    { 7, "Garissa" },
                    { 8, "Wajir" },
                    { 9, "Mandera" },
                    { 10, "Marsabit" },
                    { 11, "Isiolo" },
                    { 12, "Meru" },
                    { 13, "Tharaka-Nithi" },
                    { 14, "Embu" },
                    { 15, "Kitui" },
                    { 16, "Machakos" },
                    { 17, "Makueni" },
                    { 18, "Nyandarua" },
                    { 19, "Nyeri" },
                    { 20, "Kirinyaga" },
                    { 21, "Murang'a" },
                    { 22, "Kiambu" },
                    { 23, "Turkana" },
                    { 24, "West Pokot" },
                    { 25, "Samburu" },
                    { 26, "Trans-Nzoia" },
                    { 27, "Uasin Gishu" },
                    { 28, "Elgeyo-Marakwet" },
                    { 29, "Nandi" },
                    { 30, "Baringo" },
                    { 31, "Laikipia" },
                    { 32, "Nakuru" },
                    { 33, "Narok" },
                    { 34, "Kajiado" },
                    { 35, "Kericho" },
                    { 36, "Bomet" },
                    { 37, "Kakamega" },
                    { 38, "Vihiga" },
                    { 39, "Bungoma" },
                    { 40, "Busia" },
                    { 41, "Siaya" },
                    { 42, "Kisumu" },
                    { 43, "Homa Bay" },
                    { 44, "Migori" },
                    { 45, "Kisii" },
                    { 46, "Nyamira" },
                    { 47, "Nairobi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "counties");
        }
    }
}
