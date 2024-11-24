using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PerbaikiTanggalLahir4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611410216937",
                column: "TanggalLahir",
                value: new DateOnly(2021, 10, 14));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612709216413",
                column: "TanggalLahir",
                value: new DateOnly(2021, 9, 27));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 6,
                column: "TanggalPengecekan",
                value: new DateOnly(2022, 8, 18));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611410216937",
                column: "TanggalLahir",
                value: new DateOnly(2022, 10, 14));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612709216413",
                column: "TanggalLahir",
                value: new DateOnly(2022, 9, 27));

            migrationBuilder.UpdateData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 6,
                column: "TanggalPengecekan",
                value: new DateOnly(2021, 8, 18));
        }
    }
}
