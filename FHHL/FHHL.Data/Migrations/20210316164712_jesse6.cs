using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class jesse6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaregiverRaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaregiverId = table.Column<int>(type: "integer", nullable: false),
                    RaceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaregiverRaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralRaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferralId = table.Column<int>(type: "integer", nullable: false),
                    RaceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralRaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralReferralSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferralId = table.Column<int>(type: "integer", nullable: false),
                    ReferralSourceId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralReferralSources", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 123, DateTimeKind.Unspecified).AddTicks(9081), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 125, DateTimeKind.Unspecified).AddTicks(9934), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 125, DateTimeKind.Unspecified).AddTicks(9996), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(5), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(12), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(18), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(25), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(31), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(37), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(50), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(56), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 126, DateTimeKind.Unspecified).AddTicks(63), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(1133), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(2344), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(2404), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(2411), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(2418), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(4476), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(4532), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(4539), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(4597), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(4605), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(5566), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(6630), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(6684), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(6690), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(6696), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(6703), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(7730), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8835), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8854), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8861), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8867), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 127, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(865), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(903), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(1868), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(2933), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(2972), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(2979), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(2998), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(3004), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(3010), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 11, 47, 12, 128, DateTimeKind.Unspecified).AddTicks(3017), new TimeSpan(0, -5, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaregiverRaces");

            migrationBuilder.DropTable(
                name: "ReferralRaces");

            migrationBuilder.DropTable(
                name: "ReferralReferralSources");

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 147, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6422), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6432), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6438), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6451), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6457), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6464), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6470), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6476), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6483), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 149, DateTimeKind.Unspecified).AddTicks(6489), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 150, DateTimeKind.Unspecified).AddTicks(8334), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 150, DateTimeKind.Unspecified).AddTicks(9468), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 150, DateTimeKind.Unspecified).AddTicks(9520), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 150, DateTimeKind.Unspecified).AddTicks(9527), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 150, DateTimeKind.Unspecified).AddTicks(9534), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(505), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(1565), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(1619), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(1626), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(1632), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(1685), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(1692), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(2652), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(3697), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(3737), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(3744), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(3757), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(3763), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(3769), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(4731), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5777), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5836), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5843), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5850), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5856), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5862), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5868), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(6887), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(7980), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(8020), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 151, DateTimeKind.Unspecified).AddTicks(9990), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(33), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(41), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(47), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(53), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(59), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(65), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(71), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 10, 15, 36, 152, DateTimeKind.Unspecified).AddTicks(78), new TimeSpan(0, -5, 0, 0, 0)));
        }
    }
}
