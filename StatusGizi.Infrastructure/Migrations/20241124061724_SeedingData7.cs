using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblStandarBeratMenurutBBTB",
                columns: new[] { "Id", "JenisKelamin", "KategoriUmur", "MedianBeratBadan", "SDMinus1", "SDMinus2", "SDMinus3", "SDPlus1", "SDPlus2", "SDPlus3", "TinggiBadan" },
                values: new object[,]
                {
                    { 1, 0, 0, 2.3999999999999999, 2.2000000000000002, 2.0, 1.8999999999999999, 2.7000000000000002, 3.0, 3.2999999999999998, 45.0 },
                    { 2, 0, 0, 2.5, 2.2999999999999998, 2.1000000000000001, 1.8999999999999999, 2.7999999999999998, 3.1000000000000001, 3.3999999999999999, 45.5 },
                    { 3, 0, 0, 2.6000000000000001, 2.3999999999999999, 2.2000000000000002, 2.0, 2.8999999999999999, 3.1000000000000001, 3.5, 46.0 },
                    { 4, 0, 0, 2.7000000000000002, 2.5, 2.2999999999999998, 2.1000000000000001, 3.0, 3.2000000000000002, 3.6000000000000001, 46.5 },
                    { 5, 0, 0, 2.7999999999999998, 2.5, 2.2999999999999998, 2.1000000000000001, 3.0, 3.2999999999999998, 3.7000000000000002, 47.0 },
                    { 6, 0, 0, 2.8999999999999999, 2.6000000000000001, 2.3999999999999999, 2.2000000000000002, 3.1000000000000001, 3.3999999999999999, 3.7999999999999998, 47.5 },
                    { 7, 0, 0, 2.8999999999999999, 2.7000000000000002, 2.5, 2.2999999999999998, 3.2000000000000002, 3.6000000000000001, 3.8999999999999999, 48.0 },
                    { 8, 0, 0, 3.0, 2.7999999999999998, 2.6000000000000001, 2.2999999999999998, 3.2000000000000002, 3.7000000000000002, 4.0, 48.5 },
                    { 9, 0, 0, 3.1000000000000001, 2.8999999999999999, 2.6000000000000001, 2.3999999999999999, 3.3999999999999999, 3.7999999999999998, 4.2000000000000002, 49.0 },
                    { 10, 0, 0, 3.2000000000000002, 3.0, 2.7000000000000002, 2.5, 3.5, 3.8999999999999999, 4.2999999999999998, 49.5 },
                    { 11, 0, 0, 3.2999999999999998, 3.0, 2.7999999999999998, 2.6000000000000001, 3.6000000000000001, 4.0, 4.4000000000000004, 50.0 },
                    { 12, 0, 0, 3.3999999999999999, 3.1000000000000001, 2.8999999999999999, 2.7000000000000002, 3.7999999999999998, 4.0999999999999996, 4.5, 50.5 },
                    { 13, 0, 0, 3.5, 3.2000000000000002, 3.0, 2.7000000000000002, 3.8999999999999999, 4.2000000000000002, 4.7000000000000002, 51.0 },
                    { 14, 0, 0, 3.6000000000000001, 3.2999999999999998, 3.1000000000000001, 2.7999999999999998, 4.0, 4.4000000000000004, 4.7999999999999998, 51.5 },
                    { 15, 0, 0, 3.7999999999999998, 3.5, 3.2000000000000002, 2.8999999999999999, 4.0999999999999996, 4.5, 5.0, 52.0 },
                    { 16, 0, 0, 3.8999999999999999, 3.6000000000000001, 3.2999999999999998, 3.0, 4.2000000000000002, 4.5999999999999996, 5.0999999999999996, 52.5 },
                    { 17, 0, 0, 4.0, 3.7000000000000002, 3.3999999999999999, 3.1000000000000001, 4.4000000000000004, 4.7999999999999998, 5.2999999999999998, 53.0 },
                    { 18, 0, 0, 4.0999999999999996, 3.7999999999999998, 3.5, 3.2000000000000002, 4.5, 4.9000000000000004, 5.4000000000000004, 53.5 },
                    { 19, 0, 0, 4.2999999999999998, 3.8999999999999999, 3.6000000000000001, 3.2999999999999998, 4.7000000000000002, 5.0999999999999996, 5.5999999999999996, 54.0 },
                    { 20, 0, 0, 4.4000000000000004, 4.0, 3.7000000000000002, 3.3999999999999999, 4.7999999999999998, 5.2999999999999998, 5.7999999999999998, 54.5 },
                    { 21, 0, 0, 4.5, 4.2000000000000002, 3.7999999999999998, 3.6000000000000001, 5.0, 5.4000000000000004, 6.0, 55.0 },
                    { 22, 0, 0, 4.7000000000000002, 4.2999999999999998, 4.0, 3.7000000000000002, 5.0999999999999996, 5.5999999999999996, 6.0999999999999996, 55.5 },
                    { 23, 0, 0, 4.7999999999999998, 4.4000000000000004, 4.0999999999999996, 3.7999999999999998, 5.2999999999999998, 5.7999999999999998, 6.2999999999999998, 56.0 },
                    { 24, 0, 0, 5.0, 4.5999999999999996, 4.2000000000000002, 3.8999999999999999, 5.4000000000000004, 5.9000000000000004, 6.5, 56.5 },
                    { 35, 0, 0, 5.0999999999999996, 4.7000000000000002, 4.2999999999999998, 4.0, 5.5999999999999996, 6.0999999999999996, 6.7000000000000002, 57.0 },
                    { 36, 0, 0, 5.2999999999999998, 4.9000000000000004, 4.5, 4.0999999999999996, 5.7000000000000002, 6.2999999999999998, 6.9000000000000004, 57.5 },
                    { 37, 0, 0, 5.4000000000000004, 5.0, 4.5999999999999996, 4.2999999999999998, 5.9000000000000004, 6.4000000000000004, 7.0999999999999996, 58.0 },
                    { 38, 0, 0, 5.5999999999999996, 5.0999999999999996, 4.7000000000000002, 4.4000000000000004, 6.0999999999999996, 6.5999999999999996, 7.2000000000000002, 58.5 },
                    { 39, 0, 0, 5.7000000000000002, 5.2999999999999998, 4.7999999999999998, 4.5, 6.2000000000000002, 6.7999999999999998, 7.4000000000000004, 59.0 },
                    { 40, 0, 0, 5.9000000000000004, 5.4000000000000004, 5.0, 4.5999999999999996, 6.4000000000000004, 7.0, 7.5999999999999996, 59.5 },
                    { 41, 0, 0, 6.0, 5.5, 5.0999999999999996, 4.7000000000000002, 6.5, 7.0999999999999996, 7.7999999999999998, 60.0 },
                    { 42, 0, 0, 6.0999999999999996, 5.5999999999999996, 5.2000000000000002, 4.7999999999999998, 6.7000000000000002, 7.2999999999999998, 8.0, 60.5 },
                    { 43, 0, 0, 6.2999999999999998, 5.7999999999999998, 5.2999999999999998, 4.9000000000000004, 6.7999999999999998, 7.4000000000000004, 8.0999999999999996, 61.0 },
                    { 44, 0, 0, 6.4000000000000004, 5.9000000000000004, 5.4000000000000004, 5.0, 7.0, 7.5999999999999996, 8.3000000000000007, 61.5 },
                    { 45, 0, 0, 6.5, 6.0, 5.5999999999999996, 5.0999999999999996, 7.0999999999999996, 7.7000000000000002, 8.5, 62.0 },
                    { 46, 0, 0, 6.7000000000000002, 6.0999999999999996, 5.7000000000000002, 5.2000000000000002, 7.2000000000000002, 7.9000000000000004, 8.5999999999999996, 62.5 },
                    { 47, 0, 0, 6.7999999999999998, 6.2000000000000002, 5.7999999999999998, 5.2999999999999998, 7.4000000000000004, 8.0, 8.8000000000000007, 63.0 },
                    { 48, 0, 0, 6.9000000000000004, 6.4000000000000004, 5.9000000000000004, 5.4000000000000004, 7.5, 8.1999999999999993, 8.9000000000000004, 63.5 },
                    { 49, 0, 0, 7.0, 6.5, 6.0, 5.5, 7.5999999999999996, 8.3000000000000007, 9.0999999999999996, 64.0 },
                    { 50, 0, 0, 7.0999999999999996, 6.5999999999999996, 6.0999999999999996, 5.5999999999999996, 7.7999999999999998, 8.5, 9.3000000000000007, 64.5 },
                    { 51, 0, 0, 7.2999999999999998, 6.7000000000000002, 6.2000000000000002, 5.7000000000000002, 7.9000000000000004, 8.5999999999999996, 9.4000000000000004, 65.0 },
                    { 52, 0, 0, 7.4000000000000004, 6.7999999999999998, 6.2999999999999998, 5.7999999999999998, 8.0, 8.6999999999999993, 9.5999999999999996, 65.5 },
                    { 53, 0, 0, 7.5, 6.9000000000000004, 6.4000000000000004, 5.9000000000000004, 8.1999999999999993, 8.9000000000000004, 9.6999999999999993, 66.0 },
                    { 54, 0, 0, 7.5999999999999996, 7.0, 6.5, 6.0, 8.3000000000000007, 9.0, 9.9000000000000004, 66.5 },
                    { 55, 0, 0, 7.7000000000000002, 7.0999999999999996, 6.5999999999999996, 6.0999999999999996, 8.4000000000000004, 9.1999999999999993, 10.0, 67.0 },
                    { 56, 0, 0, 7.9000000000000004, 7.2000000000000002, 6.7000000000000002, 6.2000000000000002, 8.5, 9.3000000000000007, 10.199999999999999, 67.5 },
                    { 57, 0, 0, 8.0, 7.2999999999999998, 6.7999999999999998, 6.2999999999999998, 8.6999999999999993, 9.4000000000000004, 10.300000000000001, 68.0 },
                    { 58, 0, 0, 8.0999999999999996, 7.5, 6.9000000000000004, 6.4000000000000004, 8.8000000000000007, 9.5999999999999996, 10.5, 68.5 },
                    { 59, 0, 0, 8.1999999999999993, 7.5999999999999996, 7.0, 6.5, 8.9000000000000004, 9.6999999999999993, 10.6, 69.0 },
                    { 60, 0, 0, 8.3000000000000007, 7.7000000000000002, 7.0999999999999996, 6.5999999999999996, 9.0, 9.8000000000000007, 10.800000000000001, 69.5 },
                    { 61, 0, 0, 8.4000000000000004, 7.7999999999999998, 7.2000000000000002, 6.5999999999999996, 9.1999999999999993, 10.0, 10.9, 70.5 },
                    { 62, 0, 0, 8.5, 7.9000000000000004, 7.2999999999999998, 6.7000000000000002, 9.3000000000000007, 10.1, 11.1, 70.5 },
                    { 63, 0, 0, 8.5999999999999996, 8.0, 7.4000000000000004, 6.7999999999999998, 9.4000000000000004, 10.199999999999999, 11.199999999999999, 71.0 },
                    { 64, 0, 0, 8.8000000000000007, 8.0999999999999996, 7.5, 6.9000000000000004, 9.5, 10.4, 11.300000000000001, 71.5 },
                    { 65, 0, 0, 8.9000000000000004, 8.1999999999999993, 7.5999999999999996, 7.0, 9.5999999999999996, 10.5, 11.5, 72.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "TblStandarBeratMenurutBBTB",
                keyColumn: "Id",
                keyValue: 65);
        }
    }
}
