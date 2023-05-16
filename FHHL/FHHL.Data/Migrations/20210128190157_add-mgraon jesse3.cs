using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class addmgraonjesse3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaregiverName = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AssignedTo = table.Column<int>(type: "integer", nullable: true),
                    CaregiverRacePrimary = table.Column<int>(type: "integer", nullable: true),
                    CaregiverRaceSecondary = table.Column<int>(type: "integer", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    EDC = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    CaregiverDateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ReferralDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ReferralSourcePrimary = table.Column<int>(type: "integer", nullable: true),
                    ReferralSourceSecondary = table.Column<int>(type: "integer", nullable: true),
                    ReferralSourceTertiary = table.Column<int>(type: "integer", nullable: true),
                    FirstChild = table.Column<bool>(type: "bit", nullable: false),
                    BaM = table.Column<bool>(type: "bit", nullable: false),
                    FtoF = table.Column<bool>(type: "bit", nullable: false),
                    Spanish = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    LOR = table.Column<int>(type: "integer", nullable: true),
                    Program = table.Column<int>(type: "integer", nullable: true),
                    ChildName = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChildRacePrimary = table.Column<int>(type: "integer", nullable: true),
                    ChildRaceSecondary = table.Column<int>(type: "integer", nullable: true),
                    ChildDateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ReferralReason = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AssignDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    Result = table.Column<int>(type: "integer", nullable: true),
                    ResultDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 773, DateTimeKind.Unspecified).AddTicks(5176), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1755), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1817), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1825), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1830), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1835), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1839), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1843), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1848), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1852), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1856), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1860), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 777, DateTimeKind.Unspecified).AddTicks(1865), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(3979), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(5207), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(5257), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(5267), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(6307), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(7428), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(7433), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(7437), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(7441), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(8444), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(9498), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(9537), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(9543), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(9548), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(9552), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(9557), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 778, DateTimeKind.Unspecified).AddTicks(9561), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(491), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1527), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1589), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1594), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1603), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(1608), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(2517), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(3578), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(3617), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(4517), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5548), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5585), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5595), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5600), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5604), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5609), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 28, 13, 1, 56, 779, DateTimeKind.Unspecified).AddTicks(5618), new TimeSpan(0, -6, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 667, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4088), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4156), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4164), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4168), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4172), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4193), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4198), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4202), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6892), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6948), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(8068), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9169), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9175), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9184), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9188), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(91), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1134), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1171), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1176), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1181), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1186), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1195), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(2119), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3281), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3291), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3300), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3304), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3308), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(6057), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7083), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7088), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7097), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7110), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7114), new TimeSpan(0, -6, 0, 0, 0)));
        }
    }
}
