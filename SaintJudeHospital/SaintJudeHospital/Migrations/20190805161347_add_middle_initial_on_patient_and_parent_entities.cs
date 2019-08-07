using Microsoft.EntityFrameworkCore.Migrations;

namespace SaintJudeHospital.Migrations
{
    public partial class add_middle_initial_on_patient_and_parent_entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MiddleInitial",
                table: "Patients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleInitial",
                table: "Parents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiddleInitial",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "MiddleInitial",
                table: "Parents");
        }
    }
}
