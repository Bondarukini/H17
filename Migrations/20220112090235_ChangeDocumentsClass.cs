using Microsoft.EntityFrameworkCore.Migrations;

namespace H17.Migrations
{
    public partial class ChangeDocumentsClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriversLicense",
                table: "PatientDocumentsInfos");

            migrationBuilder.RenameColumn(
                name: "SocialSecurityNumber",
                table: "PatientDocumentsInfos",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "PassportNumber",
                table: "PatientDocumentsInfos",
                newName: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "PatientDocumentsInfos",
                newName: "SocialSecurityNumber");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "PatientDocumentsInfos",
                newName: "PassportNumber");

            migrationBuilder.AddColumn<string>(
                name: "DriversLicense",
                table: "PatientDocumentsInfos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
