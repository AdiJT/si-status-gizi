using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahKaderPosyanduDanAppUser : Migration
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
                    OrangTuaId = table.Column<int>(type: "integer", nullable: false),
                    KaderPosyanduId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUser_KaderPosyandu_KaderPosyanduId",
                        column: x => x.KaderPosyanduId,
                        principalTable: "KaderPosyandu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUser_TblOrangTua_OrangTuaId",
                        column: x => x.OrangTuaId,
                        principalTable: "TblOrangTua",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
