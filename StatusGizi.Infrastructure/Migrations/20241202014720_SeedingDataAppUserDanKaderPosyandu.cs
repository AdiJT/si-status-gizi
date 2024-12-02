using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataAppUserDanKaderPosyandu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KaderPosyandu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    PosyanduId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KaderPosyandu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KaderPosyandu_TblPosyandu_PosyanduId",
                        column: x => x.PosyanduId,
                        principalTable: "TblPosyandu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    OrangTuaId = table.Column<int>(type: "integer", nullable: true),
                    KaderPosyanduId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_KaderPosyandu_KaderPosyanduId",
                        column: x => x.KaderPosyanduId,
                        principalTable: "KaderPosyandu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUser_TblOrangTua_OrangTuaId",
                        column: x => x.OrangTuaId,
                        principalTable: "TblOrangTua",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "KaderPosyanduId", "OrangTuaId", "PasswordHash", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, null, 1, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "valentinus" },
                    { 2, null, 2, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "julius" },
                    { 3, null, 3, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "arsiliu" },
                    { 4, null, 4, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "damianus" },
                    { 5, null, 5, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "defri" },
                    { 6, null, 6, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "julius" },
                    { 7, null, 7, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "delviana" },
                    { 8, null, 8, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "oktovianus" },
                    { 9, null, 9, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "muhamad" },
                    { 10, null, 10, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "khanifatul" },
                    { 11, null, 11, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "jasman" },
                    { 12, null, 12, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "ronald" },
                    { 13, null, 13, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "melki" },
                    { 14, null, 14, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "yuven" },
                    { 15, null, 15, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "petrus" },
                    { 16, null, 16, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "misda" },
                    { 17, null, 17, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "adrianus" },
                    { 18, null, 18, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "gaudensia" },
                    { 19, null, 19, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "nobertus" },
                    { 20, null, 20, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "martinus" },
                    { 21, null, 21, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "mustofa" },
                    { 22, null, 22, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "r." },
                    { 23, null, 23, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "hendrikus" },
                    { 24, null, 24, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "ari" },
                    { 25, null, 25, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "rasid" },
                    { 26, null, 26, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "jufrianus" },
                    { 27, null, 27, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "adrianus" },
                    { 28, null, 28, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "melfianus" },
                    { 29, null, 29, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "yeremia" },
                    { 30, null, 30, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "jerikson" },
                    { 31, null, 31, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "apolinaris" },
                    { 32, null, 32, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "linus" },
                    { 33, null, 33, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "flavianus" },
                    { 34, null, 34, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "agustinus" },
                    { 35, null, 35, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "jamaria" },
                    { 36, null, 36, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "hari" },
                    { 37, null, 37, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "paulus" },
                    { 38, null, 38, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "irfan" },
                    { 39, null, 39, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "karlus" },
                    { 40, null, 40, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "jisma" },
                    { 41, null, 41, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "erlin" },
                    { 42, null, 42, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "dionisius" },
                    { 43, null, 43, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "sahrudin" },
                    { 44, null, 44, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "randi" },
                    { 45, null, 45, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "saver" },
                    { 46, null, 46, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "agapitus" },
                    { 47, null, 47, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "pedro" },
                    { 48, null, 48, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "alfred" },
                    { 49, null, 49, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "jhon" },
                    { 50, null, 50, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "aminudin" },
                    { 51, null, 51, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "gerfas" },
                    { 52, null, 52, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "" },
                    { 53, null, 53, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "yohanes" },
                    { 54, null, 54, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "manuel" },
                    { 55, null, 55, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "sonny" },
                    { 56, null, 56, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "yohanes" },
                    { 57, null, 57, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "stefanus" },
                    { 58, null, 58, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "maria" },
                    { 59, null, 59, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "yasintus" },
                    { 60, null, 60, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "susan" },
                    { 61, null, 61, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "dionisius" },
                    { 62, null, 62, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "agustino" },
                    { 63, null, 63, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "yasintus" },
                    { 64, null, 64, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "i" },
                    { 65, null, 65, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "flora" },
                    { 66, null, 66, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "muhammad" },
                    { 67, null, 67, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "fransiskus" },
                    { 68, null, 68, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "adelino" },
                    { 69, null, 69, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "jafrianus" },
                    { 70, null, 70, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "fransiskus" },
                    { 71, null, 71, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "son" },
                    { 72, null, 72, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "longginus" },
                    { 73, null, 73, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "ukat" },
                    { 74, null, 74, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "gerfas" },
                    { 75, null, 75, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "" },
                    { 76, null, 76, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "yohanes" },
                    { 77, null, 77, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "manuel" },
                    { 78, null, 78, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "OrangTua", "sonny" }
                });

            migrationBuilder.InsertData(
                table: "KaderPosyandu",
                columns: new[] { "Id", "Nama", "PosyanduId" },
                values: new object[] { 1, "Kader Posyandu 1", 1 });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "KaderPosyanduId", "OrangTuaId", "PasswordHash", "Role", "UserName" },
                values: new object[] { 79, 1, null, "AQAAAAIAAYagAAAAECmcRXcV5KyEDpMLwLciJBfjfm57BFXhVvSiQjI7RVcix0HYbQjnJCoWh42IjSveEw==", "Kader", "kader1" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_KaderPosyanduId",
                table: "AppUser",
                column: "KaderPosyanduId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUser_OrangTuaId",
                table: "AppUser",
                column: "OrangTuaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KaderPosyandu_PosyanduId",
                table: "KaderPosyandu",
                column: "PosyanduId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "KaderPosyandu");
        }
    }
}
