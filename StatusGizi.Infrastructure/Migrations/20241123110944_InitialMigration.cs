using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblDesaKelurahan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDesaKelurahan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblStandarBeratMenurutBBTB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KategoriUmur = table.Column<int>(type: "integer", nullable: false),
                    JenisKelamin = table.Column<int>(type: "integer", nullable: false),
                    TinggiBadan = table.Column<double>(type: "double precision", nullable: false),
                    SDMinus3 = table.Column<double>(type: "double precision", nullable: false),
                    SDMinus2 = table.Column<double>(type: "double precision", nullable: false),
                    SDMinus1 = table.Column<double>(type: "double precision", nullable: false),
                    MedianBeratBadan = table.Column<double>(type: "double precision", nullable: false),
                    SDPlus3 = table.Column<double>(type: "double precision", nullable: false),
                    SDPlus2 = table.Column<double>(type: "double precision", nullable: false),
                    SDPlus1 = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStandarBeratMenurutBBTB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblOrangTua",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    DesaKelurahanId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblOrangTua", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblOrangTua_TblDesaKelurahan_DesaKelurahanId",
                        column: x => x.DesaKelurahanId,
                        principalTable: "TblDesaKelurahan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblPosyandu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    DesaKelurahanId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPosyandu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblPosyandu_TblDesaKelurahan_DesaKelurahanId",
                        column: x => x.DesaKelurahanId,
                        principalTable: "TblDesaKelurahan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblBalita",
                columns: table => new
                {
                    NIK = table.Column<string>(type: "text", nullable: false),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    TanggalLahir = table.Column<DateOnly>(type: "date", nullable: false),
                    JenisKelamin = table.Column<int>(type: "integer", nullable: false),
                    BeratBadanWaktuLahir = table.Column<double>(type: "double precision", nullable: false),
                    TinggiBadanWaktuLahir = table.Column<double>(type: "double precision", nullable: false),
                    OrangTuaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBalita", x => x.NIK);
                    table.ForeignKey(
                        name: "FK_TblBalita_TblOrangTua_OrangTuaId",
                        column: x => x.OrangTuaId,
                        principalTable: "TblOrangTua",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblPengecekan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LingkarLenganAtas = table.Column<double>(type: "double precision", nullable: false),
                    BeratBadan = table.Column<double>(type: "double precision", nullable: false),
                    TinggiBadan = table.Column<double>(type: "double precision", nullable: false),
                    TanggalPengecekan = table.Column<DateOnly>(type: "date", nullable: false),
                    KategoriGizi = table.Column<int>(type: "integer", nullable: false),
                    BalitaNIK = table.Column<string>(type: "text", nullable: false),
                    PosyanduId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPengecekan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblPengecekan_TblBalita_BalitaNIK",
                        column: x => x.BalitaNIK,
                        principalTable: "TblBalita",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblPengecekan_TblPosyandu_PosyanduId",
                        column: x => x.PosyanduId,
                        principalTable: "TblPosyandu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TblDesaKelurahan",
                columns: new[] { "Id", "Nama" },
                values: new object[,]
                {
                    { 1, "Beirafu" },
                    { 2, "Berdao" },
                    { 3, "Tulamalae" },
                    { 4, "Umanen" }
                });

            migrationBuilder.InsertData(
                table: "TblOrangTua",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 1, 1, "VALENTINUS C.KIIK " },
                    { 2, 1, "VALENTINUS C.KIIK " }
                });

            migrationBuilder.InsertData(
                table: "TblPosyandu",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 1, 1, "Asparagus" },
                    { 2, 4, "BTN" },
                    { 3, 4, "Hali Nurak" },
                    { 4, 2, "Kampung Jati" },
                    { 5, 1, "Ketapang" },
                    { 6, 2, "Madrasah" },
                    { 7, 1, "Melati" },
                    { 8, 3, "Nekafehan" },
                    { 9, 4, "Onoboi" },
                    { 10, 1, "Sedap Malam" },
                    { 11, 4, "Sesekoe A" },
                    { 12, 4, "Sesekoe B" },
                    { 13, 2, "Tatakiren" },
                    { 14, 3, "Toro" },
                    { 15, 3, "Tulamalae 1" },
                    { 16, 3, "Tulamalae 2" },
                    { 17, 4, "Wekatimun 1" },
                    { 18, 4, "Wekatimun 2" },
                    { 19, 4, "Wekatimun 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblBalita_OrangTuaId",
                table: "TblBalita",
                column: "OrangTuaId");

            migrationBuilder.CreateIndex(
                name: "IX_TblOrangTua_DesaKelurahanId",
                table: "TblOrangTua",
                column: "DesaKelurahanId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPengecekan_BalitaNIK",
                table: "TblPengecekan",
                column: "BalitaNIK");

            migrationBuilder.CreateIndex(
                name: "IX_TblPengecekan_PosyanduId",
                table: "TblPengecekan",
                column: "PosyanduId");

            migrationBuilder.CreateIndex(
                name: "IX_TblPosyandu_DesaKelurahanId",
                table: "TblPosyandu",
                column: "DesaKelurahanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblPengecekan");

            migrationBuilder.DropTable(
                name: "TblStandarBeratMenurutBBTB");

            migrationBuilder.DropTable(
                name: "TblBalita");

            migrationBuilder.DropTable(
                name: "TblPosyandu");

            migrationBuilder.DropTable(
                name: "TblOrangTua");

            migrationBuilder.DropTable(
                name: "TblDesaKelurahan");
        }
    }
}
