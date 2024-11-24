using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblDesaKelurahan",
                columns: new[] { "Id", "Nama" },
                values: new object[,]
                {
                    { 5, "Bangka Kuleng" },
                    { 6, "Bangka Leleng" },
                    { 7, "Bangka Pau" },
                    { 8, "Bea Waek" },
                    { 9, "Compang Wesang" },
                    { 10, "Golo Lobos" },
                    { 11, "Golo Nderu" },
                    { 12, "Golo Rengket" },
                    { 13, "Gurung Turi" },
                    { 14, "Mando Sawu" },
                    { 15, "Nggalak Leleng" },
                    { 16, "Pocolia" },
                    { 17, "Satar Tesem" }
                });

            migrationBuilder.InsertData(
                table: "TblOrangTua",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 59, 14, "BONEFASIUS KEOR" },
                    { 60, 13, "ELFRIDA NDIMUN" }
                });

            migrationBuilder.InsertData(
                table: "TblPosyandu",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 20, 7, "Bealing 1" },
                    { 21, 7, "Bealing 2" },
                    { 22, 7, "Bealing 2" },
                    { 23, 5, "Leci" },
                    { 24, 6, "Ceka Likang" },
                    { 25, 6, "Golo Tenda" },
                    { 26, 8, "Carang" },
                    { 27, 9, "Geleng" },
                    { 28, 9, "Golo Ara" },
                    { 29, 9, "Wesang" },
                    { 30, 10, "Lame 2" },
                    { 31, 10, "Pelus" },
                    { 32, 11, "Lamba" },
                    { 33, 11, "Nderu" },
                    { 34, 11, "Nggari" },
                    { 35, 12, "Majung" },
                    { 36, 13, "Ncuang" },
                    { 37, 13, "Ndueng" },
                    { 38, 13, "Nengkal" },
                    { 39, 13, "Pocong" },
                    { 40, 14, "Benteng Dima" },
                    { 41, 14, "Golo Laci" },
                    { 42, 14, "Kompas" },
                    { 43, 15, "Lewe" },
                    { 44, 15, "Watu Cie" },
                    { 45, 16, "Pandang" },
                    { 46, 16, "Pongkor" },
                    { 47, 17, "Moncok" }
                });

            migrationBuilder.InsertData(
                table: "TblBalita",
                columns: new[] { "NIK", "BeratBadanWaktuLahir", "JenisKelamin", "Nama", "OrangTuaId", "TanggalLahir", "TinggiBadanWaktuLahir" },
                values: new object[,]
                {
                    { "5319024912229990", 3.2000000000000002, 1, "MELTIADES KEOR", 59, new DateOnly(2022, 12, 9), 51.0 },
                    { "5319025103229974", 3.2000000000000002, 1, "MARIA Y.T. QUIN", 60, new DateOnly(2022, 3, 11), 51.0 }
                });

            migrationBuilder.InsertData(
                table: "TblPengecekan",
                columns: new[] { "Id", "BalitaNIK", "BeratBadan", "KategoriGizi", "LingkarLenganAtas", "PosyanduId", "TanggalPengecekan", "TinggiBadan" },
                values: new object[,]
                {
                    { 37, "5319024912229990", 3.3999999999999999, 0, 10.5, 40, new DateOnly(2022, 12, 9), 59.899999999999999 },
                    { 38, "5319025103229974", 6.7999999999999998, 0, 13.699999999999999, 36, new DateOnly(2022, 3, 11), 75.900000000000006 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5319024912229990");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5319025103229974");

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblPosyandu",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblDesaKelurahan",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
