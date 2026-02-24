using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NipeNikupe.Migrations
{
    /// <inheritdoc />
    public partial class update_opot12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "notifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RecipientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ChatId = table.Column<Guid>(type: "uuid", nullable: false),
                    MessagePreview = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    TimestampUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false),
                    SenderId = table.Column<Guid>(type: "uuid", nullable: true),
                    NotificationType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notifications_chat_messages_ChatId",
                        column: x => x.ChatId,
                        principalTable: "chat_messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 912,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 913,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 914,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 915,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 916,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 917,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 918,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 919,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 920,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 921,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 922,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 923,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 924,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 925,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 926,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 927,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 928,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 929,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 930,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 931,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 932,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 933,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 934,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 935,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 936,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 937,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 938,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 939,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 940,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 941,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 942,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 943,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 944,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 945,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 946,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 947,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 948,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 949,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 950,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 951,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 952,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 953,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 954,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 955,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 956,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 957,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 958,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 959,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 960,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 961,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 962,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 963,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 964,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 965,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 966,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 967,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 968,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 969,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 970,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 971,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 972,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 973,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 974,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 975,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 976,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 977,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 978,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 979,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 980,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 981,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 982,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 983,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 984,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 985,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 986,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 987,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 988,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 989,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 990,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 24, 5, 22, 41, 83, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.CreateIndex(
                name: "IX_notifications_ChatId",
                table: "notifications",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_RecipientId",
                table: "notifications",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_RecipientId_IsRead",
                table: "notifications",
                columns: new[] { "RecipientId", "IsRead" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "notifications");

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3764));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 582,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 583,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 584,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 585,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 586,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 587,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 588,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 589,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 590,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 591,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 592,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 593,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 595,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 596,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 597,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 598,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 599,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 600,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 601,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 602,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 603,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 604,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 605,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 606,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 607,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 608,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 609,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 610,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 611,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 612,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 613,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 614,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 615,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 616,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 617,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 618,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 619,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 620,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 621,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 622,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 623,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 624,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 625,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 626,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 627,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 628,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 629,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 630,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 631,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 632,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 633,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 634,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 635,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 636,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 637,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 638,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 639,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 640,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 641,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 642,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 643,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 644,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 645,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 646,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 647,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 648,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 649,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 650,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 651,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 652,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 653,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 654,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 655,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 656,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 657,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 658,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 659,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 660,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 661,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 662,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 663,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 664,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 665,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 666,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 667,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 668,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 669,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 670,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 671,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 672,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 673,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 674,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 675,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 676,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 677,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 678,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 679,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 680,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 681,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 682,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 683,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 684,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 685,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 686,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 687,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 688,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 689,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 690,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 691,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 692,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 693,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 694,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 695,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 696,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 697,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 698,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 699,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 700,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 701,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 702,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 703,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 704,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 705,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 706,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 707,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 708,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 709,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 710,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 711,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 712,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 713,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 714,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 715,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 716,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 717,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 718,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 719,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 720,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 721,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 722,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 723,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 724,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 725,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 726,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 727,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 728,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 729,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 730,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 731,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 732,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 733,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 734,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 735,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 736,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 737,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 738,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 739,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 740,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 741,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 742,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 743,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 744,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 745,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 746,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 747,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 748,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 749,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 750,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 751,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 752,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 753,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 754,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 755,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 756,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 757,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 758,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 759,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 760,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 761,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 762,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 763,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 764,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 765,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 766,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 767,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 768,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 769,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 770,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 771,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 772,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 773,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 774,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 775,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 776,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 777,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 778,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 779,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 780,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 781,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 782,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 783,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 784,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 785,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 786,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 787,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 788,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 789,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 790,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 791,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 792,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 793,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 794,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 795,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 796,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 797,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 798,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 799,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 800,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 801,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 802,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 803,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 804,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 805,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 806,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 807,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 808,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 809,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 810,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 811,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 812,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 813,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 814,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 815,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 816,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 817,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 818,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 819,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 820,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 821,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 822,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 823,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 824,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 825,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 826,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 827,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 828,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 829,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 830,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 831,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 832,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 833,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 834,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 835,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 836,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 837,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 838,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 839,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 840,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 841,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 842,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 843,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 844,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 845,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 846,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 847,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 848,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 849,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 850,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 851,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 852,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 853,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 854,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 855,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 856,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 857,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 858,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 859,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 860,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 861,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 862,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 863,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 864,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 865,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 866,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 867,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 868,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 869,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 870,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 871,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 872,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 873,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 874,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 875,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 876,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 877,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 878,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 879,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 880,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 881,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 882,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 883,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 884,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 885,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 886,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 887,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 888,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 889,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 890,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 891,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 892,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 893,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 894,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 895,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 896,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 897,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 898,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 899,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 900,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 901,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 902,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 903,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 904,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 905,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 906,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 907,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 908,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 909,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 910,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 911,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 912,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 913,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 914,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 915,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 916,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 917,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 918,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 919,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 920,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 921,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 922,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 923,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 924,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 925,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 926,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 927,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 928,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 929,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 930,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 931,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 932,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 933,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 934,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 935,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 936,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 937,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 938,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 939,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 940,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 941,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 942,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 943,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 944,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 945,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 946,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 947,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 948,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 949,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 950,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 951,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 952,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 953,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 954,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 955,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 956,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 957,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 958,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 959,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 960,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 961,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 962,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 963,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 964,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 965,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 966,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 967,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 968,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 969,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 970,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 971,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 972,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 973,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 974,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 975,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 976,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 977,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 978,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 979,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 980,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 981,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 982,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 983,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 984,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 985,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 986,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 987,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 988,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 989,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "skills",
                keyColumn: "Id",
                keyValue: 990,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 19, 32, 42, 571, DateTimeKind.Utc).AddTicks(6319));
        }
    }
}
