using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace H17.Migrations
{
    public partial class addedNameInPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientNameInfos");

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Given",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MothersMaidenName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prefix",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Family",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Given",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MothersMaidenName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Prefix",
                table: "Patients");

            migrationBuilder.CreateTable(
                name: "PatientNameInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Given = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersMaidenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientNameInfos", x => x.Id);
                });
        }
    }
}
