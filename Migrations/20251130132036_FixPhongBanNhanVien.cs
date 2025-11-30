using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HTQuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class FixPhongBanNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens");

            migrationBuilder.CreateIndex(
                name: "IX_PhongBans_TruongPhongId",
                table: "PhongBans",
                column: "TruongPhongId");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId",
                principalTable: "PhongBans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhongBans_NhanViens_TruongPhongId",
                table: "PhongBans",
                column: "TruongPhongId",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens");

            migrationBuilder.DropForeignKey(
                name: "FK_PhongBans_NhanViens_TruongPhongId",
                table: "PhongBans");

            migrationBuilder.DropIndex(
                name: "IX_PhongBans_TruongPhongId",
                table: "PhongBans");     

            migrationBuilder.AddForeignKey(
                name: "FK_NhanViens_PhongBans_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId",
                principalTable: "PhongBans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
