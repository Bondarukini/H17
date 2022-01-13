using Microsoft.EntityFrameworkCore.Migrations;

namespace H17.Migrations
{
    public partial class UpdateTelecomValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "PatientTelecomInfos",
                newName: "Value");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "PatientTelecomInfos",
                newName: "Phone");
        }
    }
}
