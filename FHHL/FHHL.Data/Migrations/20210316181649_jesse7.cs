using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class jesse7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Caregivers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Caregivers",
                type: "nvarchar(256)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Foster",
                table: "Caregivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 528, DateTimeKind.Unspecified).AddTicks(104), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(677), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(737), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(759), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(765), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(771), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(778), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(784), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(790), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(796), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 530, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(1142), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(2293), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(2338), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(2345), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(2351), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(3335), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(4477), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(4526), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(4533), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(4540), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(4546), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(4552), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(5512), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(6681), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(6730), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(6742), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(6748), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(6754), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(7807), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(8971), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(8978), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(8984), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(8990), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(8996), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(9002), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 531, DateTimeKind.Unspecified).AddTicks(9957), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(1039), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(1076), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(2044), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3170), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3177), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3183), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3195), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3201), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3208), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 13, 16, 48, 532, DateTimeKind.Unspecified).AddTicks(3214), new TimeSpan(0, -5, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Caregivers");

            migrationBuilder.DropColumn(
                name: "Foster",
                table: "Caregivers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Caregivers",
                newName: "Name");

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
    }
}
