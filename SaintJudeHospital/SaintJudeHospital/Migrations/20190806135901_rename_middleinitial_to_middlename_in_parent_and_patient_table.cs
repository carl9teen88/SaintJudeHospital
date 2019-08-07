using Microsoft.EntityFrameworkCore.Migrations;

namespace SaintJudeHospital.Migrations
{
    public partial class rename_middleinitial_to_middlename_in_parent_and_patient_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MiddleInitial",
                table: "Patients",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "MiddleInitial",
                table: "Parents",
                newName: "MiddleName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Patients",
                newName: "MiddleInitial");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Parents",
                newName: "MiddleInitial");
        }
    }
}
