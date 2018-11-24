using Microsoft.EntityFrameworkCore.Migrations;

namespace SaintJudeHospital.Migrations
{
    public partial class add_immunizes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Immunizes",
                columns: new[] { "Id", "Amount", "Name" },
                values: new object[,]
                {
                    { 1, 3000m, "HEXA" },
                    { 19, 1000m, "FLU" },
                    { 18, 2200m, "ROTATEQ" },
                    { 17, 3000m, "ROTARIX" },
                    { 16, 1700m, "RABIES" },
                    { 15, 1700m, "PNEUMO-23" },
                    { 14, 3000m, "MMR-V" },
                    { 13, 900m, "BCG-1" },
                    { 12, 2500m, "PENTA" },
                    { 20, 4000m, "PCV" },
                    { 11, 2200m, "CHICKEN POX" },
                    { 9, 1600m, "TETRAXIM" },
                    { 8, 700m, "HEP B" },
                    { 7, 1800m, "HEP A" },
                    { 6, 1300m, "TYPHOID" },
                    { 5, 4000m, "MENINGO" },
                    { 4, 1300m, "HIB" },
                    { 3, 750m, "MEASLES" },
                    { 2, 3200m, "PCV 10" },
                    { 10, 1200m, "MMR" },
                    { 21, 0m, "BCG-2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Immunizes",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
