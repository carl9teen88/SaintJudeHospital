using Microsoft.EntityFrameworkCore.Migrations;

namespace SaintJudeHospital.Migrations
{
    public partial class Add_symtoms_initial_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Symtoms",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Bleeding" },
                    { 22, null, "Skin lesions" },
                    { 23, null, "Trauma" },
                    { 24, null, "Pain urination" },
                    { 25, null, "Rushes" },
                    { 26, null, "Less appetite" },
                    { 27, null, "LBM" },
                    { 28, null, "Vomiting" },
                    { 29, null, "Dysuria" },
                    { 30, null, "Rashes" },
                    { 31, null, "Dysphagia" },
                    { 32, null, "Vaginal Discharge" },
                    { 33, null, "Urticarial rash" },
                    { 34, null, "Eye discharge" },
                    { 35, null, "Chest gurgling" },
                    { 36, null, "Epistaxis" },
                    { 21, null, "Muscle pain" },
                    { 20, null, "Joint pain" },
                    { 19, null, "Mass" },
                    { 18, null, "Loss of consciousness" },
                    { 2, null, "Bruise" },
                    { 3, null, "Cough" },
                    { 4, null, "Bites" },
                    { 5, null, "Fever" },
                    { 6, null, "Cold" },
                    { 7, null, "Difficulty in swallowing" },
                    { 8, null, "Ear discharge" },
                    { 37, null, "Pustules" },
                    { 9, null, "Ear ache/pain" },
                    { 11, null, "Diarrhea" },
                    { 12, null, "Hair fall" },
                    { 13, null, "Abdominal pain" },
                    { 14, null, "Deformity" },
                    { 15, null, "Headache" },
                    { 16, null, "Infected wounds" },
                    { 17, null, "Itchness" },
                    { 10, null, "Constipation" },
                    { 38, null, "Nasal congestion" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Symtoms",
                keyColumn: "Id",
                keyValue: 38);
        }
    }
}
