using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HTQuanLyNhanSu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhongBan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongBanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanViens_PhongBans_PhongBanId",
                        column: x => x.PhongBanId,
                        principalTable: "PhongBans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChamCongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChamCongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChamCongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HopDongLaoDongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    LoaiHopDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LuongCoBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HopDongLaoDongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HopDongLaoDongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhenThuongKyLuats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayApDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiDuyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhenThuongKyLuats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhenThuongKyLuats_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Luongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    LuongTheoNgay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhuCap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoNgayCong = table.Column<int>(type: "int", nullable: false),
                    TienKhenThuong = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TienKyLuat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Luongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NghiPheps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    LoaiNghi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiDuyet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NghiPheps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NghiPheps_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChamCongs_NhanVienId",
                table: "ChamCongs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongLaoDongs_NhanVienId",
                table: "HopDongLaoDongs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_KhenThuongKyLuats_NhanVienId",
                table: "KhenThuongKyLuats",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_Luongs_NhanVienId",
                table: "Luongs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NghiPheps_NhanVienId",
                table: "NghiPheps",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_PhongBanId",
                table: "NhanViens",
                column: "PhongBanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChamCongs");

            migrationBuilder.DropTable(
                name: "HopDongLaoDongs");

            migrationBuilder.DropTable(
                name: "KhenThuongKyLuats");

            migrationBuilder.DropTable(
                name: "Luongs");

            migrationBuilder.DropTable(
                name: "NghiPheps");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "PhongBans");
        }
    }
}
