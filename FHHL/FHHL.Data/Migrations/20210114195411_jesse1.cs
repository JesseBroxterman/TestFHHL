using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FHHL.Data.Migrations
{
    public partial class jesse1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PregnancyStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PregnancyStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RiskLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    AddDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: false),
                    ChgUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ChgDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelUser = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    DelDateTimeOffset = table.Column<DateTimeOffset>(type: "datetimeoffset(7)", nullable: true),
                    DelFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitResults", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignees");

            migrationBuilder.DropTable(
                name: "PregnancyStates");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "ReferralSources");

            migrationBuilder.DropTable(
                name: "RiskLevels");

            migrationBuilder.DropTable(
                name: "VisitResults");
        }
    }
}
