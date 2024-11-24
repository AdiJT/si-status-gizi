using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PerbaikiTanggalLahir1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611608216534",
                column: "TanggalLahir",
                value: new DateOnly(2021, 8, 16));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611708211553",
                column: "TanggalLahir",
                value: new DateOnly(2021, 8, 17));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611608216534",
                column: "TanggalLahir",
                value: new DateOnly(2022, 8, 16));

            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611708211553",
                column: "TanggalLahir",
                value: new DateOnly(2022, 8, 17));
        }
    }
}
