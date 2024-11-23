using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblOrangTua",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 46, 3, "AGAPITUS UN" },
                    { 47, 3, "PEDRO DOS REIS" },
                    { 48, 3, "ALFRED BESSIE" },
                    { 49, 3, "JHON NAHAK" },
                    { 50, 3, "AMINUDIN" }
                });

            migrationBuilder.InsertData(
                table: "TblBalita",
                columns: new[] { "NIK", "BeratBadanWaktuLahir", "JenisKelamin", "Nama", "OrangTuaId", "TanggalLahir", "TinggiBadanWaktuLahir" },
                values: new object[,]
                {
                    { "5306610807221629", 3.2000000000000002, 0, "DANTE A. BESSIE", 48, new DateOnly(2022, 7, 8), 50.0 },
                    { "5306611106228326", 3.0, 0, "VASCO PEREIRA REIS", 47, new DateOnly(2022, 6, 11), 49.0 },
                    { "5306611410216937", 2.7999999999999998, 0, "KORNELIS D. NAHAK", 49, new DateOnly(2022, 10, 14), 48.0 },
                    { "5306611607222447", 2.6000000000000001, 0, "ALEXSIUS EL KAPITAN", 46, new DateOnly(2022, 7, 16), 49.0 },
                    { "5306612709216413", 3.1000000000000001, 0, "ILHAM BAHMID", 50, new DateOnly(2022, 9, 27), 50.0 }
                });

            migrationBuilder.InsertData(
                table: "TblPengecekan",
                columns: new[] { "Id", "BalitaNIK", "BeratBadan", "KategoriGizi", "LingkarLenganAtas", "PosyanduId", "TanggalPengecekan", "TinggiBadan" },
                values: new object[,]
                {
                    { 24, "5306611607222447", 4.2000000000000002, 2, 0.0, 16, new DateOnly(2022, 8, 11), 53.5 },
                    { 25, "5306611106228326", 6.2999999999999998, 2, 0.0, 14, new DateOnly(2022, 8, 8), 63.0 },
                    { 26, "5306610807221629", 4.7999999999999998, 2, 0.0, 16, new DateOnly(2022, 8, 11), 58.5 },
                    { 27, "5306611410216937", 7.5, 1, 12.5, 8, new DateOnly(2022, 8, 16), 71.799999999999997 },
                    { 28, "5306612709216413", 9.4000000000000004, 2, 14.5, 15, new DateOnly(2022, 8, 12), 72.299999999999997 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306610807221629");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611106228326");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611410216937");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611607222447");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612709216413");

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
