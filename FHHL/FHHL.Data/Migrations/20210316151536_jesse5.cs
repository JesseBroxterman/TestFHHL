using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class jesse5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.CreateTable(
                name: "Caregivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    MomClass = table.Column<bool>(type: "bit", nullable: false),
                    Spanish = table.Column<bool>(type: "bit", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caregivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referrals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignedTo = table.Column<int>(type: "integer", nullable: true),
                    EstimatedDeliveryDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ReferralDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    FirstChild = table.Column<bool>(type: "bit", nullable: false),
                    FtoF = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    LOR = table.Column<int>(type: "integer", nullable: true),
                    Program = table.Column<int>(type: "integer", nullable: true),
                    ChildName = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChildDateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ReferralReason = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AssignDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    Result = table.Column<int>(type: "integer", nullable: true),
                    ResultDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referrals", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caregivers");

            migrationBuilder.DropTable(
                name: "Referrals");

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    AssignDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    AssignedTo = table.Column<int>(type: "integer", nullable: true),
                    BaM = table.Column<bool>(type: "bit", nullable: false),
                    CaregiverDateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    CaregiverName = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    CaregiverRacePrimary = table.Column<int>(type: "integer", nullable: true),
                    CaregiverRaceSecondary = table.Column<int>(type: "integer", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChildDateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    ChildName = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChildRacePrimary = table.Column<int>(type: "integer", nullable: true),
                    ChildRaceSecondary = table.Column<int>(type: "integer", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    EDC = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    FirstChild = table.Column<bool>(type: "bit", nullable: false),
                    FtoF = table.Column<bool>(type: "bit", nullable: false),
                    LOR = table.Column<int>(type: "integer", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    Program = table.Column<int>(type: "integer", nullable: true),
                    ReferralDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ReferralReason = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ReferralSourcePrimary = table.Column<int>(type: "integer", nullable: true),
                    ReferralSourceSecondary = table.Column<int>(type: "integer", nullable: true),
                    ReferralSourceTertiary = table.Column<int>(type: "integer", nullable: true),
                    Result = table.Column<int>(type: "integer", nullable: true),
                    ResultDate = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    Spanish = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(256)", nullable: true)
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
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 192, DateTimeKind.Unspecified).AddTicks(2663), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9450), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9523), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9530), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9535), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9543), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9547), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9552), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9556), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9561), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9566), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9570), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 195, DateTimeKind.Unspecified).AddTicks(9574), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(936), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(2124), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(2173), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(2182), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(3153), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(4269), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(4317), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(4325), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(4329), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(4332), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(4337), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(5247), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(6263), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(6298), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(6302), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(6311), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(6315), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(6320), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8226), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8278), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8282), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8287), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8291), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8295), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8299), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(8303), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 197, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(183), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(217), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2065), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2099), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2104), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2108), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2112), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2116), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2125), new TimeSpan(0, -6, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 1, 29, 12, 56, 8, 198, DateTimeKind.Unspecified).AddTicks(2129), new TimeSpan(0, -6, 0, 0, 0)));
        }
    }
}
