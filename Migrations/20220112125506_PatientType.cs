using Microsoft.EntityFrameworkCore.Migrations;

namespace H17.Migrations
{
    public partial class PatientType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ethnicity",
                table: "PatientTypeInfos");

            migrationBuilder.RenameColumn(
                name: "Race",
                table: "PatientTypeInfos",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "Language",
                table: "PatientTypeInfos",
                newName: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "PatientTypeInfos",
                newName: "Race");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "PatientTypeInfos",
                newName: "Language");

            migrationBuilder.AddColumn<string>(
                name: "Ethnicity",
                table: "PatientTypeInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
