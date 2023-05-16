using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class jesse9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Caregivers",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "[FirstName] + ' ' + [LastName]");

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 866, DateTimeKind.Unspecified).AddTicks(2829), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7042), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7051), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7057), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7070), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7076), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7089), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 868, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(6440), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(7629), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(7677), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(8691), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(9810), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(9860), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(9868), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(9874), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(9880), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 869, DateTimeKind.Unspecified).AddTicks(9887), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(883), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(1973), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(2014), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(2022), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(2028), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(2034), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(2041), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(3043), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4237), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4245), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4252), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4258), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4265), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4271), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(4277), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(5288), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(6390), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(6429), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(7442), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8539), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8582), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8589), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8596), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8602), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8608), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8615), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8621), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 22, 13, 36, 47, 870, DateTimeKind.Unspecified).AddTicks(8627), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_CaregiverId",
                table: "Referrals",
                column: "CaregiverId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralReferralSources_ReferralId",
                table: "ReferralReferralSources",
                column: "ReferralId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralReferralSources_ReferralSourceId",
                table: "ReferralReferralSources",
                column: "ReferralSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralRaces_RaceId",
                table: "ReferralRaces",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralRaces_ReferralId",
                table: "ReferralRaces",
                column: "ReferralId");

            migrationBuilder.CreateIndex(
                name: "IX_CaregiverRaces_CaregiverId",
                table: "CaregiverRaces",
                column: "CaregiverId");

            migrationBuilder.CreateIndex(
                name: "IX_CaregiverRaces_RaceId",
                table: "CaregiverRaces",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaregiverRaces_Caregivers_CaregiverId",
                table: "CaregiverRaces",
                column: "CaregiverId",
                principalTable: "Caregivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CaregiverRaces_Races_RaceId",
                table: "CaregiverRaces",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferralRaces_Races_RaceId",
                table: "ReferralRaces",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferralRaces_Referrals_ReferralId",
                table: "ReferralRaces",
                column: "ReferralId",
                principalTable: "Referrals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferralReferralSources_Referrals_ReferralId",
                table: "ReferralReferralSources",
                column: "ReferralId",
                principalTable: "Referrals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ReferralReferralSources_ReferralSources_ReferralSourceId",
                table: "ReferralReferralSources",
                column: "ReferralSourceId",
                principalTable: "ReferralSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Referrals_Caregivers_CaregiverId",
                table: "Referrals",
                column: "CaregiverId",
                principalTable: "Caregivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaregiverRaces_Caregivers_CaregiverId",
                table: "CaregiverRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_CaregiverRaces_Races_RaceId",
                table: "CaregiverRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferralRaces_Races_RaceId",
                table: "ReferralRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferralRaces_Referrals_ReferralId",
                table: "ReferralRaces");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferralReferralSources_Referrals_ReferralId",
                table: "ReferralReferralSources");

            migrationBuilder.DropForeignKey(
                name: "FK_ReferralReferralSources_ReferralSources_ReferralSourceId",
                table: "ReferralReferralSources");

            migrationBuilder.DropForeignKey(
                name: "FK_Referrals_Caregivers_CaregiverId",
                table: "Referrals");

            migrationBuilder.DropIndex(
                name: "IX_Referrals_CaregiverId",
                table: "Referrals");

            migrationBuilder.DropIndex(
                name: "IX_ReferralReferralSources_ReferralId",
                table: "ReferralReferralSources");

            migrationBuilder.DropIndex(
                name: "IX_ReferralReferralSources_ReferralSourceId",
                table: "ReferralReferralSources");

            migrationBuilder.DropIndex(
                name: "IX_ReferralRaces_RaceId",
                table: "ReferralRaces");

            migrationBuilder.DropIndex(
                name: "IX_ReferralRaces_ReferralId",
                table: "ReferralRaces");

            migrationBuilder.DropIndex(
                name: "IX_CaregiverRaces_CaregiverId",
                table: "CaregiverRaces");

            migrationBuilder.DropIndex(
                name: "IX_CaregiverRaces_RaceId",
                table: "CaregiverRaces");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Caregivers");

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 130, DateTimeKind.Unspecified).AddTicks(571), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1789), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1855), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1864), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1871), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1878), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1885), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1891), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1898), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1905), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1911), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1918), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 132, DateTimeKind.Unspecified).AddTicks(1925), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(2709), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(3907), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(3914), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(3921), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(4937), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(6033), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(6081), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(6089), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(6095), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(6101), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(6108), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(7092), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(8270), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(8317), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(8324), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(8330), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(8337), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(8343), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(8349), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 133, DateTimeKind.Unspecified).AddTicks(9351), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(419), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(486), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(527), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(534), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(541), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(547), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(554), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(560), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(2692), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(3771), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4896), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4936), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4943), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4949), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4956), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4969), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4975), new TimeSpan(0, -5, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10,
                column: "AddDateTimeOffset",
                value: new DateTimeOffset(new DateTime(2021, 3, 16, 14, 50, 28, 134, DateTimeKind.Unspecified).AddTicks(4981), new TimeSpan(0, -5, 0, 0, 0)));
        }
    }
}
