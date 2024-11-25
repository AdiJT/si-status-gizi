using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
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

            migrationBuilder.InsertData(
                table: "TblOrangTua",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
                    { 1, 1, "VALENTINUS C.KIIK" },
                    { 2, 1, "JULIUS S.ANDRADA" },
                    { 3, 1, "ARSILIU NENOBAIS" },
                    { 4, 1, "DAMIANUS LEKY" },
                    { 5, 1, "DEFRI TAMPANI" },
                    { 6, 1, "JULIUS D LAHERA" },
                    { 7, 1, "DELVIANA MORUK" },
                    { 8, 1, "OKTOVIANUS TANEO" },
                    { 9, 1, "MUHAMAD SAVERIO" },
                    { 10, 1, "KHANIFATUL" },
                    { 11, 1, "JASMAN SEO" },
                    { 12, 1, "RONALD" },
                    { 13, 1, "MELKI SEDIK FAOT" },
                    { 14, 1, "YUVEN SERAN" },
                    { 15, 1, "PETRUS KAPITAN" },
                    { 16, 1, "MISDA" },
                    { 17, 1, "ADRIANUS IMPI" },
                    { 18, 1, "GAUDENSIA N. TAEK" },
                    { 19, 1, "NOBERTUS KLAU" },
                    { 20, 1, "MARTINUS TEFLOPO" },
                    { 21, 1, "MUSTOFA" },
                    { 22, 1, "R. PRASONG" },
                    { 23, 1, "HENDRIKUS LAISNESI" },
                    { 24, 1, "ARI PANO" },
                    { 25, 1, "RASID HANNS" },
                    { 26, 1, "JUFRIANUS SERAN" },
                    { 27, 1, "ADRIANUS LOROK" },
                    { 28, 1, "MELFIANUS WALENG" },
                    { 29, 1, "YEREMIA G.KABOSU" },
                    { 30, 1, "JERIKSON E FAOT" },
                    { 31, 1, "APOLINARIS AFEANPAH" },
                    { 32, 1, "LINUS UN ARYANDI" },
                    { 33, 1, "FLAVIANUS A. D. UN" },
                    { 34, 1, "AGUSTINUS TALAN" },
                    { 35, 2, "JAMARIA NAMANG" },
                    { 36, 2, "HARI WADU" },
                    { 37, 2, "PAULUS PRAWIRA" },
                    { 38, 2, "IRFAN AMALO" },
                    { 39, 2, "KARLUS BEREMEO" },
                    { 40, 2, "JISMA" },
                    { 41, 2, "ERLIN KAMLASI" },
                    { 42, 2, "DIONISIUS NAHAK" },
                    { 43, 2, "SAHRUDIN" },
                    { 44, 2, "RANDI MANEK" },
                    { 45, 2, "SAVER TAEK" },
                    { 46, 3, "AGAPITUS UN" },
                    { 47, 3, "PEDRO DOS REIS" },
                    { 48, 3, "ALFRED BESSIE" },
                    { 49, 3, "JHON NAHAK" },
                    { 50, 3, "AMINUDIN" },
                    { 51, 4, "GERFAS LOLOMSAIT" },
                    { 52, 4, "" },
                    { 53, 4, "YOHANES KENJAM" },
                    { 54, 4, "MANUEL N" },
                    { 55, 4, "SONNY LY RAU" },
                    { 56, 3, "YOHANES FAHIK" },
                    { 57, 4, "STEFANUS NAIMUNI" },
                    { 58, 3, "MARIA A. SEKAB" },
                    { 59, 3, "YASINTUS NAHAK" },
                    { 60, 3, "SUSAN NAES" },
                    { 61, 4, "DIONISIUS MAU" },
                    { 62, 4, "AGUSTINO DE. J" },
                    { 63, 4, "YASINTUS KOFI" },
                    { 64, 4, "I PUTU DEDI SETIAWAN" },
                    { 65, 4, "FLORA" },
                    { 66, 4, "MUHAMMAD ISA F USI" },
                    { 67, 4, "FRANSISKUS PONGKI SERAN" },
                    { 68, 4, "ADELINO O. SOARES" },
                    { 69, 4, "JAFRIANUS NAIFATIN" },
                    { 70, 4, "FRANSISKUS TRINDADE" },
                    { 71, 4, "SON UKAT" },
                    { 72, 4, "LONGGINUS LOE" },
                    { 73, 4, "UKAT" },
                    { 74, 4, "GERFAS LOLOMSAIT" },
                    { 75, 4, "" },
                    { 76, 4, "YOHANES KENJAM" },
                    { 77, 4, "MANUEL N" },
                    { 78, 4, "SONNY LY RAU" }
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

            migrationBuilder.InsertData(
                table: "TblBalita",
                columns: new[] { "NIK", "BeratBadanWaktuLahir", "JenisKelamin", "Nama", "OrangTuaId", "TanggalLahir", "TinggiBadanWaktuLahir" },
                values: new object[,]
                {
                    { "5303244310870001", 3.1000000000000001, 0, "ALANA FERNANDES", 53, new DateOnly(2022, 7, 18), 50.0 },
                    { "5304214606940004", 2.8999999999999999, 0, "ALFIAN E. N", 54, new DateOnly(2022, 7, 1), 49.0 },
                    { "5306610207221488", 3.0, 0, "LEANDER CHESTER ANDRADA", 2, new DateOnly(2022, 7, 2), 48.0 },
                    { "5306610305228386", 2.7999999999999998, 0, "MUHAMAD ARHAM SYAKAL", 43, new DateOnly(2022, 5, 3), 49.0 },
                    { "5306610306226179", 3.0, 0, "MARIA RASTIANA DE.J", 62, new DateOnly(2022, 6, 3), 48.0 },
                    { "5306610310212700", 2.8999999999999999, 0, "GIRLAND WADU", 36, new DateOnly(2022, 10, 3), 49.0 },
                    { "5306610310217582", 3.0, 0, "MUHAMMAD SYFID", 66, new DateOnly(2021, 10, 3), 48.0 },
                    { "5306610311217965", 3.1000000000000001, 0, "MIKHAEL O. SOARES", 68, new DateOnly(2021, 11, 3), 50.0 },
                    { "5306610606224235", 3.0, 0, "SEAN", 12, new DateOnly(2022, 6, 6), 46.0 },
                    { "5306610805228603", 2.6000000000000001, 0, "ARSENIUS NAHAK", 42, new DateOnly(2022, 5, 8), 49.0 },
                    { "5306610807221629", 3.2000000000000002, 0, "DANTE A. BESSIE", 48, new DateOnly(2022, 7, 8), 50.0 },
                    { "5306611008217236", 2.8999999999999999, 0, "AGUS R. BEREMEO", 39, new DateOnly(2022, 8, 10), 49.0 },
                    { "5306611106228326", 3.0, 0, "VASCO PEREIRA REIS", 47, new DateOnly(2022, 6, 11), 49.0 },
                    { "5306611401221414", 3.0, 0, "JEREMI TURNIP", 65, new DateOnly(2022, 1, 14), 48.0 },
                    { "5306611410216937", 2.7999999999999998, 0, "KORNELIS D. NAHAK", 49, new DateOnly(2021, 10, 14), 48.0 },
                    { "5306611502224363", 2.5, 0, "DAFA UKAT", 71, new DateOnly(2022, 2, 15), 49.0 },
                    { "5306611503229344", 3.0, 0, "CANELO ALVARES MANEK", 44, new DateOnly(2022, 3, 15), 50.0 },
                    { "5306611505225327", 3.0, 0, "MEIDA AMELIA Y FAOT", 13, new DateOnly(2022, 6, 6), 48.0 },
                    { "5306611506221514", 3.0, 0, "KHAMALIK SAVERIO", 9, new DateOnly(2022, 6, 15), 49.0 },
                    { "5306611509215054", 3.0, 0, "GAMALIEL DAVIN LAHERA", 6, new DateOnly(2021, 9, 15), 48.0 },
                    { "5306611607222447", 2.6000000000000001, 0, "ALEXSIUS EL KAPITAN", 46, new DateOnly(2022, 7, 16), 49.0 },
                    { "5306611607227754", 3.0, 0, "LEANDREY C.KIIK", 1, new DateOnly(2022, 7, 16), 49.0 },
                    { "5306611608216534", 3.0, 0, "AGUSTINUS I. NITBANI", 7, new DateOnly(2021, 8, 16), 50.0 },
                    { "5306611706223451", 3.5, 0, "GIBRAN M. LY RATU", 55, new DateOnly(2022, 6, 17), 50.0 },
                    { "5306611707228503", 3.0, 0, "JOAKIM JOVANO MAU", 61, new DateOnly(2022, 7, 17), 48.0 },
                    { "5306611708211553", 3.0, 0, "DIRGARIUS A.TANEO", 8, new DateOnly(2021, 8, 17), 48.0 },
                    { "5306611708215871", 2.5, 0, "GABRIEL RADINGA", 58, new DateOnly(2021, 8, 17), 49.0 },
                    { "5306611807227328", 3.0, 0, "ADRIELO HABU PAH", 35, new DateOnly(2022, 7, 18), 48.0 },
                    { "5306611808214604", 2.7999999999999998, 0, "ABIMAE AMALO", 38, new DateOnly(2021, 8, 18), 48.0 },
                    { "5306611907229365", 2.6000000000000001, 0, "GRACIANO LOLOMSAIT", 51, new DateOnly(2022, 7, 19), 49.0 },
                    { "5306612010213287", 2.7999999999999998, 0, "EDWARD F. C. LOE", 72, new DateOnly(2021, 10, 20), 48.0 },
                    { "5306612104224910", 3.0, 0, "APRILIO ADEN KOFI", 63, new DateOnly(2022, 4, 21), 50.0 },
                    { "5306612105226289", 3.0, 0, "FARHAN ZAKY", 11, new DateOnly(2022, 5, 21), 50.0 },
                    { "5306612109211986", 3.0, 0, "SAMUEL A. LEKY", 4, new DateOnly(2021, 9, 21), 50.0 },
                    { "5306612303229952", 3.0, 0, "KOMANG B.D.S.P", 64, new DateOnly(2022, 3, 23), 48.0 },
                    { "5306612306228330", 3.0, 0, "RAFLY JALEXA", 3, new DateOnly(2022, 6, 23), 48.0 },
                    { "5306612404198011", 3.0, 0, "ARYANTO ENYSIUS FAHIK", 56, new DateOnly(2019, 4, 24), 48.0 },
                    { "5306612404221654", 3.0, 0, "ALEXANDRIO Z. KEFI", 41, new DateOnly(2022, 4, 24), 50.0 },
                    { "5306612405226168", 3.0, 0, "ALBERT SERAN", 67, new DateOnly(2022, 5, 24), 48.0 },
                    { "5306612509215198", 2.7000000000000002, 0, "VARELIO NAHAK", 59, new DateOnly(2021, 9, 25), 49.0 },
                    { "5306612601222598", 3.2000000000000002, 0, "GILBERT BANUNAEK", 60, new DateOnly(2022, 1, 26), 50.0 },
                    { "5306612608217549", 3.3999999999999999, 0, "AGUSTINUS H. PRAWIRA", 37, new DateOnly(2021, 8, 26), 50.0 },
                    { "5306612609215986", 3.1000000000000001, 0, "GILBERT NAIFATIN", 69, new DateOnly(2021, 9, 26), 50.0 },
                    { "5306612705226233", 3.2000000000000002, 0, "MUH. SYAHKIRULLAH ALGHANI", 10, new DateOnly(2022, 5, 27), 50.0 },
                    { "5306612709216413", 3.1000000000000001, 0, "ILHAM BAHMID", 50, new DateOnly(2021, 9, 27), 50.0 },
                    { "5306612804228187", 3.1000000000000001, 0, "KRISTIAN PARERA", 40, new DateOnly(2022, 4, 28), 50.0 },
                    { "5306612807224014", 2.6000000000000001, 0, "AGNESIA TIARA SIN MAU", 52, new DateOnly(2022, 7, 28), 45.0 },
                    { "5306612907215730", 3.1000000000000001, 0, "JESON UKAT", 73, new DateOnly(2021, 7, 29), 50.0 },
                    { "5306613009216892", 3.1000000000000001, 0, "DERIL TAMPANI", 5, new DateOnly(2021, 9, 30), 50.0 },
                    { "5306613103226645", 3.0, 0, "ANTONIO TRINDADE DA COSTA", 70, new DateOnly(2022, 3, 31), 48.0 },
                    { "5306616807201646", 3.0, 1, "AGATHA L.F.NAIMUNI", 57, new DateOnly(2020, 7, 28), 49.0 }
                });

            migrationBuilder.InsertData(
                table: "TblPengecekan",
                columns: new[] { "Id", "BalitaNIK", "BeratBadan", "KategoriGizi", "LingkarLenganAtas", "PosyanduId", "TanggalPengecekan", "TinggiBadan" },
                values: new object[,]
                {
                    { 1, "5306611607227754", 5.2999999999999998, 5, 13.0, 1, new DateOnly(2022, 8, 15), 52.899999999999999 },
                    { 2, "5306610207221488", 4.0999999999999996, 2, 11.800000000000001, 1, new DateOnly(2022, 8, 15), 52.700000000000003 },
                    { 3, "5306612306228330", 5.0999999999999996, 2, 11.5, 1, new DateOnly(2022, 8, 15), 57.200000000000003 },
                    { 4, "5306612109211986", 8.4000000000000004, 2, 15.0, 10, new DateOnly(2022, 8, 8), 71.400000000000006 },
                    { 5, "5306613009216892", 8.4499999999999993, 2, 13.5, 10, new DateOnly(2022, 8, 8), 72.900000000000006 },
                    { 6, "5306611509215054", 8.4000000000000004, 2, 14.0, 7, new DateOnly(2022, 8, 18), 72.099999999999994 },
                    { 7, "5306611608216534", 9.5999999999999996, 2, 14.199999999999999, 10, new DateOnly(2022, 8, 8), 76.200000000000003 },
                    { 8, "5306611708211553", 8.0, 2, 12.4, 1, new DateOnly(2022, 8, 15), 72.0 },
                    { 9, "5306611506221514", 5.2000000000000002, 2, 15.0, 1, new DateOnly(2022, 8, 15), 55.899999999999999 },
                    { 10, "5306612705226233", 4.8499999999999996, 2, 0.0, 10, new DateOnly(2022, 8, 8), 57.299999999999997 },
                    { 11, "5306612105226289", 5.2000000000000002, 2, 14.0, 10, new DateOnly(2022, 8, 8), 59.200000000000003 },
                    { 12, "5306610606224235", 6.2999999999999998, 2, 14.0, 5, new DateOnly(2022, 8, 12), 61.299999999999997 },
                    { 13, "5306611505225327", 5.4000000000000004, 2, 13.199999999999999, 1, new DateOnly(2022, 8, 15), 57.700000000000003 },
                    { 14, "5306611807227328", 3.7999999999999998, 2, 11.699999999999999, 6, new DateOnly(2022, 8, 9), 52.899999999999999 },
                    { 15, "5306610310212700", 9.0999999999999996, 2, 15.5, 6, new DateOnly(2021, 8, 9), 71.900000000000006 },
                    { 16, "5306612608217549", 10.699999999999999, 2, 15.0, 4, new DateOnly(2022, 8, 12), 78.0 },
                    { 17, "5306611808214604", 8.9000000000000004, 2, 16.0, 4, new DateOnly(2022, 8, 12), 71.400000000000006 },
                    { 18, "5306611008217236", 9.5999999999999996, 2, 14.0, 13, new DateOnly(2021, 8, 10), 82.200000000000003 },
                    { 19, "5306612804228187", 5.5, 2, 13.0, 13, new DateOnly(2022, 8, 10), 60.899999999999999 },
                    { 20, "5306612404221654", 5.25, 2, 12.5, 13, new DateOnly(2022, 8, 10), 59.200000000000003 },
                    { 21, "5306610805228603", 5.5999999999999996, 2, 0.0, 4, new DateOnly(2022, 8, 12), 58.200000000000003 },
                    { 22, "5306610305228386", 5.7000000000000002, 2, 0.0, 4, new DateOnly(2022, 8, 12), 61.200000000000003 },
                    { 23, "5306611503229344", 6.7000000000000002, 2, 14.5, 4, new DateOnly(2022, 8, 12), 63.0 },
                    { 24, "5306611607222447", 4.2000000000000002, 2, 0.0, 16, new DateOnly(2022, 8, 11), 53.5 },
                    { 25, "5306611106228326", 6.2999999999999998, 2, 0.0, 14, new DateOnly(2022, 8, 8), 63.0 },
                    { 26, "5306610807221629", 4.7999999999999998, 2, 0.0, 16, new DateOnly(2022, 8, 11), 58.5 },
                    { 27, "5306611410216937", 7.5, 1, 12.5, 8, new DateOnly(2021, 8, 16), 71.799999999999997 },
                    { 28, "5306612709216413", 9.4000000000000004, 2, 14.5, 15, new DateOnly(2021, 8, 12), 72.299999999999997 },
                    { 29, "5306611907229365", 4.7000000000000002, 2, 0.0, 17, new DateOnly(2022, 8, 5), 57.0 },
                    { 30, "5306612807224014", 3.6000000000000001, 2, 0.0, 9, new DateOnly(2022, 8, 19), 51.0 },
                    { 31, "5303244310870001", 4.0999999999999996, 2, 0.0, 12, new DateOnly(2022, 8, 18), 53.200000000000003 },
                    { 32, "5304214606940004", 4.2999999999999998, 2, 0.0, 12, new DateOnly(2022, 8, 18), 53.399999999999999 },
                    { 33, "5306611706223451", 5.0999999999999996, 2, 0.0, 17, new DateOnly(2022, 8, 5), 55.799999999999997 },
                    { 34, "5306612404198011", 9.0, 0, 14.0, 16, new DateOnly(2022, 8, 11), 88.0 },
                    { 35, "5306616807201646", 7.2999999999999998, 0, 13.0, 19, new DateOnly(2022, 8, 12), 77.0 },
                    { 36, "5306611708215871", 6.2000000000000002, 0, 13.0, 15, new DateOnly(2022, 8, 12), 71.200000000000003 },
                    { 37, "5306612509215198", 8.0999999999999996, 3, 14.0, 15, new DateOnly(2022, 8, 12), 65.299999999999997 },
                    { 38, "5306612509215198", 8.0999999999999996, 3, 15.0, 15, new DateOnly(2022, 8, 12), 64.700000000000003 },
                    { 39, "5306611707228503", 5.0999999999999996, 3, 0.0, 15, new DateOnly(2022, 8, 19), 54.299999999999997 },
                    { 40, "5306610306226179", 5.2000000000000002, 3, 15.0, 11, new DateOnly(2022, 8, 9), 55.299999999999997 },
                    { 41, "5306612104224910", 6.7999999999999998, 3, 0.0, 17, new DateOnly(2022, 8, 5), 60.799999999999997 },
                    { 42, "5306612303229952", 8.9000000000000004, 3, 19.0, 9, new DateOnly(2022, 8, 9), 66.299999999999997 },
                    { 43, "5306611401221414", 9.5, 3, 17.0, 2, new DateOnly(2022, 8, 8), 70.0 },
                    { 44, "5306610310217582", 10.0, 4, 14.0, 18, new DateOnly(2022, 8, 15), 70.0 },
                    { 45, "5306610310217582", 6.9000000000000004, 4, 14.4, 3, new DateOnly(2022, 8, 20), 58.0 },
                    { 46, "5306610311217965", 10.0, 4, 14.0, 9, new DateOnly(2022, 8, 19), 69.0 },
                    { 47, "5306612609215986", 7.2999999999999998, 1, 14.0, 12, new DateOnly(2022, 8, 18), 72.799999999999997 },
                    { 48, "5306613103226645", 5.5, 1, 13.0, 11, new DateOnly(2022, 8, 9), 62.0 },
                    { 49, "5306611502224363", 5.7999999999999998, 1, 0.0, 17, new DateOnly(2022, 8, 5), 63.700000000000003 },
                    { 50, "5306612010213287", 6.7999999999999998, 1, 13.0, 18, new DateOnly(2022, 8, 15), 68.799999999999997 },
                    { 51, "5306612907215730", 7.7999999999999998, 1, 14.0, 2, new DateOnly(2022, 8, 8), 74.0 }
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
