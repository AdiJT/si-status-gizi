using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TblBalita",
                columns: new[] { "NIK", "BeratBadanWaktuLahir", "JenisKelamin", "Nama", "OrangTuaId", "TanggalLahir", "TinggiBadanWaktuLahir" },
                values: new object[,]
                {
                    { "5306610207221488", 3.0, 0, "LEANDER CHESTER ANDRADA", 2, new DateOnly(2022, 7, 2), 48.0 },
                    { "5306611607227754", 3.0, 0, "LEANDREY C.KIIK", 1, new DateOnly(2022, 7, 16), 49.0 }
                });

            migrationBuilder.UpdateData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nama",
                value: "VALENTINUS C.KIIK");

            migrationBuilder.UpdateData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nama",
                value: "JULIUS S.ANDRADA");

            migrationBuilder.InsertData(
                table: "TblOrangTua",
                columns: new[] { "Id", "DesaKelurahanId", "Nama" },
                values: new object[,]
                {
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
                    { 45, 2, "SAVER TAEK" }
                });

            migrationBuilder.InsertData(
                table: "TblBalita",
                columns: new[] { "NIK", "BeratBadanWaktuLahir", "JenisKelamin", "Nama", "OrangTuaId", "TanggalLahir", "TinggiBadanWaktuLahir" },
                values: new object[,]
                {
                    { "5306610305228386", 2.7999999999999998, 0, "MUHAMAD ARHAM SYAKAL", 43, new DateOnly(2022, 5, 3), 49.0 },
                    { "5306610310212700", 2.8999999999999999, 0, "GIRLAND WADU", 36, new DateOnly(2022, 10, 3), 49.0 },
                    { "5306610606224235", 3.0, 0, "SEAN", 12, new DateOnly(2022, 6, 6), 46.0 },
                    { "5306610805228603", 2.6000000000000001, 0, "ARSENIUS NAHAK", 42, new DateOnly(2022, 5, 8), 49.0 },
                    { "5306611008217236", 2.8999999999999999, 0, "AGUS R. BEREMEO", 39, new DateOnly(2022, 8, 10), 49.0 },
                    { "5306611503229344", 3.0, 0, "CANELO ALVARES MANEK", 44, new DateOnly(2022, 3, 15), 50.0 },
                    { "5306611505225327", 3.0, 0, "MEIDA AMELIA Y FAOT", 13, new DateOnly(2022, 6, 6), 48.0 },
                    { "5306611506221514", 3.0, 0, "KHAMALIK SAVERIO", 9, new DateOnly(2022, 6, 15), 49.0 },
                    { "5306611509215054", 3.0, 0, "GAMALIEL DAVIN LAHERA", 6, new DateOnly(2022, 9, 15), 48.0 },
                    { "5306611608216534", 3.0, 0, "AGUSTINUS I. NITBANI", 7, new DateOnly(2022, 8, 16), 50.0 },
                    { "5306611708211553", 3.0, 0, "DIRGARIUS A.TANEO", 8, new DateOnly(2022, 8, 17), 48.0 },
                    { "5306611807227328", 3.0, 0, "ADRIELO HABU PAH", 35, new DateOnly(2022, 7, 18), 48.0 },
                    { "5306611808214604", 2.7999999999999998, 0, "ABIMAE AMALO", 38, new DateOnly(2022, 8, 18), 48.0 },
                    { "5306612105226289", 3.0, 0, "FARHAN ZAKY", 11, new DateOnly(2022, 5, 21), 50.0 },
                    { "5306612109211986", 3.0, 0, "SAMUEL A. LEKY", 4, new DateOnly(2022, 9, 21), 50.0 },
                    { "5306612306228330", 3.0, 0, "RAFLY JALEXA", 3, new DateOnly(2022, 6, 23), 48.0 },
                    { "5306612404221654", 3.0, 0, "ALEXANDRIO Z. KEFI", 41, new DateOnly(2022, 4, 24), 50.0 },
                    { "5306612608217549", 3.3999999999999999, 0, "AGUSTINUS H. PRAWIRA", 37, new DateOnly(2022, 8, 26), 50.0 },
                    { "5306612705226233", 3.2000000000000002, 0, "MUH. SYAHKIRULLAH ALGHANI", 10, new DateOnly(2022, 5, 27), 50.0 },
                    { "5306612804228187", 3.1000000000000001, 0, "KRISTIAN PARERA", 40, new DateOnly(2022, 4, 28), 50.0 },
                    { "5306613009216892", 3.1000000000000001, 0, "DERIL TAMPANI", 5, new DateOnly(2022, 9, 30), 50.0 }
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
                    { 15, "5306610310212700", 9.0999999999999996, 2, 15.5, 6, new DateOnly(2022, 8, 9), 71.900000000000006 },
                    { 16, "5306612608217549", 10.699999999999999, 2, 15.0, 4, new DateOnly(2022, 8, 12), 78.0 },
                    { 17, "5306611808214604", 8.9000000000000004, 2, 16.0, 4, new DateOnly(2022, 8, 12), 71.400000000000006 },
                    { 18, "5306611008217236", 9.5999999999999996, 2, 14.0, 13, new DateOnly(2022, 8, 10), 82.200000000000003 },
                    { 19, "5306612804228187", 5.5, 2, 13.0, 13, new DateOnly(2022, 8, 10), 60.899999999999999 },
                    { 20, "5306612404221654", 5.25, 2, 12.5, 13, new DateOnly(2022, 8, 10), 59.200000000000003 },
                    { 21, "5306610805228603", 5.5999999999999996, 2, 0.0, 4, new DateOnly(2022, 8, 12), 58.200000000000003 },
                    { 22, "5306610305228386", 5.7000000000000002, 2, 0.0, 4, new DateOnly(2022, 8, 12), 61.200000000000003 },
                    { 23, "5306611503229344", 6.7000000000000002, 2, 14.5, 4, new DateOnly(2022, 8, 12), 63.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TblPengecekan",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306610207221488");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306610305228386");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306610310212700");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306610606224235");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306610805228603");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611008217236");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611503229344");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611505225327");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611506221514");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611509215054");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611607227754");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611608216534");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611708211553");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611807227328");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306611808214604");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612105226289");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612109211986");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612306228330");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612404221654");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612608217549");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612705226233");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306612804228187");

            migrationBuilder.DeleteData(
                table: "TblBalita",
                keyColumn: "NIK",
                keyValue: "5306613009216892");

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.UpdateData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nama",
                value: "VALENTINUS C.KIIK ");

            migrationBuilder.UpdateData(
                table: "TblOrangTua",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nama",
                value: "VALENTINUS C.KIIK ");
        }
    }
}
