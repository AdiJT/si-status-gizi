using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblOrangTua",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 51, 4, "GERFAS LOLOMSAIT" },
                    { 52, 4, "" },
                    { 53, 4, "YOHANES KENJAM" },
                    { 54, 4, "MANUEL N" },
                    { 55, 4, "SONNY LY RAU" }
                });

            migrationBuilder.InsertData(
                table: "TblBalita",
                columns: new[] { "NIK", "BeratBadanWaktuLahir", "JenisKelamin", "Nama", "OrangTuaId", "TanggalLahir", "TinggiBadanWaktuLahir" },
                values: new object[,]
                {
                    { "5303244310870001", 3.1000000000000001, 0, "ALANA FERNANDES", 53, new DateOnly(2022, 7, 18), 50.0 },
                    { "5304214606940004", 2.8999999999999999, 0, "ALFIAN E. N", 54, new DateOnly(2022, 7, 1), 49.0 },
                    { "5306611706223451", 3.5, 0, "GIBRAN M. LY RATU", 55, new DateOnly(2022, 6, 17), 50.0 },
                    { "5306611907229365", 2.6000000000000001, 0, "GRACIANO LOLOMSAIT", 51, new DateOnly(2022, 7, 19), 49.0 },
                    { "5306612807224014", 2.6000000000000001, 0, "AGNESIA TIARA SIN MAU", 52, new DateOnly(2022, 7, 28), 45.0 }
                });

            migrationBuilder.InsertData(
                table: "TblPengecekan",
                columns: new[] { "Id", "BalitaNIK", "BeratBadan", "KategoriGizi", "LingkarLenganAtas", "PosyanduId", "TanggalPengecekan", "TinggiBadan" },
                values: new object[,]
                {
                    { 29, "5306611907229365", 4.7000000000000002, 2, 0.0, 17, new DateOnly(2022, 8, 5), 57.0 },
                    { 30, "5306612807224014", 3.6000000000000001, 2, 0.0, 9, new DateOnly(2022, 8, 19), 51.0 },
                    { 31, "5303244310870001", 4.0999999999999996, 2, 0.0, 12, new DateOnly(2022, 8, 18), 53.200000000000003 },
                    { 32, "5304214606940004", 4.2999999999999998, 2, 0.0, 12, new DateOnly(2022, 8, 18), 53.399999999999999 },
                    { 33, "5306611706223451", 5.0999999999999996, 2, 0.0, 17, new DateOnly(2022, 8, 5), 55.799999999999997 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5303244310870001");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5304214606940004");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611706223451");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611907229365");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612807224014");

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 55);
        }
    }
}
