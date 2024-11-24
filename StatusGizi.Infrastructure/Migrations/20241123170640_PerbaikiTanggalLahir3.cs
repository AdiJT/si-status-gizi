using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PerbaikiTanggalLahir3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611509215054",
                column: "TanggalLahir",
                value: new DateOnly(2021, 9, 15));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611509215054",
                column: "TanggalLahir",
                value: new DateOnly(2022, 9, 15));
        }
    }
}
