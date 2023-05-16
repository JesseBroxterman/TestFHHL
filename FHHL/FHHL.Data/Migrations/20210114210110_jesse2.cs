using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class jesse2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignees",
                columns: new[] { "Id", "ActiveFlag", "AddDateTimeOffset", "AddUser", "ChgDateTimeOffset", "ChgUser", "DelDateTimeOffset", "DelFlag", "DelUser", "Label" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 667, DateTimeKind.Unspecified).AddTicks(9368), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Teresa" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4088), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Bonnie" },
                    { 3, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4156), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Missy" },
                    { 4, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4164), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Marla" },
                    { 5, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4168), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Ariona" },
                    { 6, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4172), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Outreach Letter" },
                    { 7, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Felica" },
                    { 8, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4181), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Jene" },
                    { 9, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Abby" },
                    { 10, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Tandem" },
                    { 11, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4193), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Renee" },
                    { 12, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4198), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Emma" },
                    { 13, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 671, DateTimeKind.Unspecified).AddTicks(4202), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Marsue" }
                });

            migrationBuilder.InsertData(
                table: "PregnancyStates",
                columns: new[] { "Id", "ActiveFlag", "AddDateTimeOffset", "AddUser", "ChgDateTimeOffset", "ChgUser", "DelDateTimeOffset", "DelFlag", "DelUser", "Label" },
                values: new object[,]
                {
                    { 5, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6983), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Postpartum" },
                    { 4, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6948), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Infant" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6892), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Birth" },
                    { 1, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(5634), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Prebirth" },
                    { 3, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Toddler" }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "ActiveFlag", "AddDateTimeOffset", "AddUser", "ChgDateTimeOffset", "ChgUser", "DelDateTimeOffset", "DelFlag", "DelUser", "Label" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(8068), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "HSHV" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9122), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "NBHV" },
                    { 3, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9169), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "NFP" },
                    { 4, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9175), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "PHN" },
                    { 5, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9180), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "PART C" },
                    { 6, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9184), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "FS" },
                    { 7, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 672, DateTimeKind.Unspecified).AddTicks(9188), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Outreach" }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "ActiveFlag", "AddDateTimeOffset", "AddUser", "ChgDateTimeOffset", "ChgUser", "DelDateTimeOffset", "DelFlag", "DelUser", "Label" },
                values: new object[,]
                {
                    { 6, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1186), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Non-Hispanic" },
                    { 8, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1195), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Other" },
                    { 7, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1190), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Unknown" },
                    { 5, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1181), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Asian" },
                    { 3, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1171), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Black/White" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1134), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Black" },
                    { 1, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(91), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "White" },
                    { 4, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(1176), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "American Indian" }
                });

            migrationBuilder.InsertData(
                table: "ReferralSources",
                columns: new[] { "Id", "ActiveFlag", "AddDateTimeOffset", "AddUser", "ChgDateTimeOffset", "ChgUser", "DelDateTimeOffset", "DelFlag", "DelUser", "Label" },
                values: new object[,]
                {
                    { 7, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3300), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Washburn" },
                    { 1, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(2119), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "PG Testing" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3237), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "M & I" },
                    { 3, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3281), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Hopsital" },
                    { 4, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "WIC" },
                    { 5, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3291), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Successful Connections" },
                    { 6, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3295), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "TARC" },
                    { 8, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3304), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Other" },
                    { 9, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(3308), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Lincoln Center" }
                });

            migrationBuilder.InsertData(
                table: "RiskLevels",
                columns: new[] { "Id", "ActiveFlag", "AddDateTimeOffset", "AddUser", "ChgDateTimeOffset", "ChgUser", "DelDateTimeOffset", "DelFlag", "DelUser", "Label" },
                values: new object[,]
                {
                    { 3, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(5202), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Low" },
                    { 1, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "High" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Medium" }
                });

            migrationBuilder.InsertData(
                table: "VisitResults",
                columns: new[] { "Id", "ActiveFlag", "AddDateTimeOffset", "AddUser", "ChgDateTimeOffset", "ChgUser", "DelDateTimeOffset", "DelFlag", "DelUser", "Label" },
                values: new object[,]
                {
                    { 6, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7097), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Moved" },
                    { 8, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7106), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Deferred" },
                    { 7, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Lost" },
                    { 5, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Miscarried" },
                    { 9, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7110), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Enrolled" },
                    { 3, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7083), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "No Response" },
                    { 2, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Declined" },
                    { 1, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(6057), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Home Visit" },
                    { 4, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7088), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Failed" },
                    { 10, true, new DateTimeOffset(new DateTime(2021, 1, 14, 15, 1, 9, 673, DateTimeKind.Unspecified).AddTicks(7114), new TimeSpan(0, -6, 0, 0, 0)), "Seed", null, null, null, false, null, "Other" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Assignees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PregnancyStates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReferralSources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RiskLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VisitResults",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
