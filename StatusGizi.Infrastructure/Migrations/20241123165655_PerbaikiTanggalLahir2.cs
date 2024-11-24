using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PerbaikiTanggalLahir2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611808214604",
                column: "TanggalLahir",
                value: new DateOnly(2021, 8, 18));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612109211986",
                column: "TanggalLahir",
                value: new DateOnly(2021, 9, 21));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612608217549",
                column: "TanggalLahir",
                value: new DateOnly(2021, 8, 26));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306613009216892",
                column: "TanggalLahir",
                value: new DateOnly(2021, 9, 30));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 6,
                column: "TanggalPengecekan",
                value: new DateOnly(2021, 8, 18));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 15,
                column: "TanggalPengecekan",
                value: new DateOnly(2021, 8, 9));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 18,
                column: "TanggalPengecekan",
                value: new DateOnly(2021, 8, 10));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 27,
                column: "TanggalPengecekan",
                value: new DateOnly(2021, 8, 16));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 28,
                column: "TanggalPengecekan",
                value: new DateOnly(2021, 8, 12));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611808214604",
                column: "TanggalLahir",
                value: new DateOnly(2022, 8, 18));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612109211986",
                column: "TanggalLahir",
                value: new DateOnly(2022, 9, 21));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612608217549",
                column: "TanggalLahir",
                value: new DateOnly(2022, 8, 26));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306613009216892",
                column: "TanggalLahir",
                value: new DateOnly(2022, 9, 30));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 6,
                column: "TanggalPengecekan",
                value: new DateOnly(2022, 8, 18));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 15,
                column: "TanggalPengecekan",
                value: new DateOnly(2022, 8, 9));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 18,
                column: "TanggalPengecekan",
                value: new DateOnly(2022, 8, 10));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 27,
                column: "TanggalPengecekan",
                value: new DateOnly(2022, 8, 16));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 28,
                column: "TanggalPengecekan",
                value: new DateOnly(2022, 8, 12));
        }
    }
}
