using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblOrangTua",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 56, 3, "YOHANES FAHIK" },
                    { 57, 4, "STEFANUS NAIMUNI" },
                    { 58, 3, "MARIA A. SEKAB" }
                });

            migrationBuilder.InsertData(
                table: "TblBalita",
                columns: new[] { "NIK", "BeratBadanWaktuLahir", "JenisKelamin", "Nama", "OrangTuaId", "TanggalLahir", "TinggiBadanWaktuLahir" },
                values: new object[,]
                {
                    { "5306611708215871", 2.5, 0, "GABRIEL RADINGA", 58, new DateOnly(2021, 8, 17), 49.0 },
                    { "5306612404198011", 3.0, 0, "ARYANTO ENYSIUS FAHIK", 56, new DateOnly(2019, 4, 24), 48.0 },
                    { "5306616807201646", 3.0, 1, "AGATHA L.F.NAIMUNI", 57, new DateOnly(2020, 7, 28), 49.0 }
                });

            migrationBuilder.InsertData(
                table: "TblPengecekan",
                columns: new[] { "Id", "BalitaNIK", "BeratBadan", "KategoriGizi", "LingkarLenganAtas", "PosyanduId", "TanggalPengecekan", "TinggiBadan" },
                values: new object[,]
                {
                    { 34, "5306612404198011", 9.0, 0, 14.0, 16, new DateOnly(2022, 8, 11), 88.0 },
                    { 35, "5306616807201646", 7.2999999999999998, 0, 13.0, 19, new DateOnly(2022, 8, 12), 77.0 },
                    { 36, "5306611708215871", 6.2000000000000002, 0, 13.0, 15, new DateOnly(2022, 8, 12), 71.200000000000003 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611708215871");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612404198011");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306616807201646");

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 58);
        }
    }
}
