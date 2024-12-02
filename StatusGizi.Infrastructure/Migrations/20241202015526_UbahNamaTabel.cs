using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StatusGizi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UbahNamaTabel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_KaderPosyandu_KaderPosyanduId",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUser_TblOrangTua_OrangTuaId",
                table: "AppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_KaderPosyandu_TblPosyandu_PosyanduId",
                table: "KaderPosyandu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KaderPosyandu",
                table: "KaderPosyandu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "KaderPosyandu",
                newName: "TblKaderPosyandu");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "TblAppUser");

            migrationBuilder.RenameIndex(
                name: "IX_KaderPosyandu_PosyanduId",
                table: "TblKaderPosyandu",
                newName: "IX_TblKaderPosyandu_PosyanduId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_OrangTuaId",
                table: "TblAppUser",
                newName: "IX_TblAppUser_OrangTuaId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUser_KaderPosyanduId",
                table: "TblAppUser",
                newName: "IX_TblAppUser_KaderPosyanduId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblKaderPosyandu",
                table: "TblKaderPosyandu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblAppUser",
                table: "TblAppUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblAppUser_TblKaderPosyandu_KaderPosyanduId",
                table: "TblAppUser",
                column: "KaderPosyanduId",
                principalTable: "TblKaderPosyandu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblAppUser_TblOrangTua_OrangTuaId",
                table: "TblAppUser",
                column: "OrangTuaId",
                principalTable: "TblOrangTua",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblKaderPosyandu_TblPosyandu_PosyanduId",
                table: "TblKaderPosyandu",
                column: "PosyanduId",
                principalTable: "TblPosyandu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblAppUser_TblKaderPosyandu_KaderPosyanduId",
                table: "TblAppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TblAppUser_TblOrangTua_OrangTuaId",
                table: "TblAppUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TblKaderPosyandu_TblPosyandu_PosyanduId",
                table: "TblKaderPosyandu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblKaderPosyandu",
                table: "TblKaderPosyandu");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblAppUser",
                table: "TblAppUser");

            migrationBuilder.RenameTable(
                name: "TblKaderPosyandu",
                newName: "KaderPosyandu");

            migrationBuilder.RenameTable(
                name: "TblAppUser",
                newName: "AppUser");

            migrationBuilder.RenameIndex(
                name: "IX_TblKaderPosyandu_PosyanduId",
                table: "KaderPosyandu",
                newName: "IX_KaderPosyandu_PosyanduId");

            migrationBuilder.RenameIndex(
                name: "IX_TblAppUser_OrangTuaId",
                table: "AppUser",
                newName: "IX_AppUser_OrangTuaId");

            migrationBuilder.RenameIndex(
                name: "IX_TblAppUser_KaderPosyanduId",
                table: "AppUser",
                newName: "IX_AppUser_KaderPosyanduId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KaderPosyandu",
                table: "KaderPosyandu",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_KaderPosyandu_KaderPosyanduId",
                table: "AppUser",
                column: "KaderPosyanduId",
                principalTable: "KaderPosyandu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUser_TblOrangTua_OrangTuaId",
                table: "AppUser",
                column: "OrangTuaId",
                principalTable: "TblOrangTua",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_KaderPosyandu_TblPosyandu_PosyanduId",
                table: "KaderPosyandu",
                column: "PosyanduId",
                principalTable: "TblPosyandu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
