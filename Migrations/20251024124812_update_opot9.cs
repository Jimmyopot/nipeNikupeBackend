using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NipeNikupe.Migrations
{
    /// <inheritdoc />
    public partial class update_opot9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "skill_search_logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Skill = table.Column<string>(type: "text", nullable: false),
                    County = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    IpAddress = table.Column<string>(type: "text", nullable: true),
                    UserAgent = table.Column<string>(type: "text", nullable: true),
                    ResultsCount = table.Column<int>(type: "integer", nullable: false),
                    SearchTimeUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill_search_logs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 912,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 913,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 914,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 915,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 916,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 917,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 918,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 919,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 920,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 921,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 922,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 923,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 924,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 925,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 926,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 927,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 928,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 929,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 930,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 931,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 932,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 933,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 934,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 935,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 936,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 937,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 938,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 939,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 940,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 941,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 942,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 943,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 944,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 945,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 946,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 947,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 948,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 949,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 950,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 951,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 952,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 953,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 954,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 955,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 956,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 957,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 958,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 959,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 960,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 961,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 962,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 963,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 964,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 965,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 966,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 967,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 968,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 969,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 970,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 971,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 972,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 973,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 974,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 975,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 976,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 977,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 978,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 979,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 980,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 981,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 982,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 983,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 984,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 985,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 986,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 987,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 988,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 989,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 990,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 24, 12, 48, 11, 604, DateTimeKind.Utc).AddTicks(7561));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "skill_search_logs");

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3612));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 912,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 913,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 914,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 915,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 916,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 917,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 918,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 919,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 920,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 921,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 922,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 923,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 924,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 925,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 926,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 927,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 928,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 929,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 930,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 931,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 932,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 933,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 934,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 935,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 936,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 937,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 938,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 939,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 940,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 941,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 942,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 943,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 944,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 945,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 946,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 947,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 948,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 949,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 950,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 951,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 952,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 953,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 954,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 955,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 956,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 957,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 958,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 959,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 960,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 961,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 962,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 963,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 964,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 965,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 966,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 967,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 968,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 969,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 970,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 971,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 972,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 973,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 974,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 975,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 976,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 977,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 978,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 979,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 980,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 981,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 982,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 983,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 984,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 985,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 986,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 987,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 988,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 989,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 990,
                column: "CreatedAt",
                value: new DateTime(2025, 10, 14, 10, 3, 8, 120, DateTimeKind.Utc).AddTicks(4474));
        }
    }
}
