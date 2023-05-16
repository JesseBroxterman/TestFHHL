using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class jesse4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ResultDate",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ReferralDate",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ChildDateOfBirth",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AssignDate",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AddDateTimeOffset",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ResultDate",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ReferralDate",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ChildDateOfBirth",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AssignDate",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "AddDateTimeOffset",
                table: "Records",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset(7)",
                oldNullable: true);

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
    }
}
