using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLTE.Data.Migrations
{
    public partial class AddTable_SanSiSp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChiTietTin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(nullable: true),
                    Content1 = table.Column<string>(nullable: true),
                    Content2 = table.Column<string>(nullable: true),
                    UrlImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(nullable: true),
                    GiaSanPham = table.Column<double>(nullable: true),
                    UrlImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TinMoi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(nullable: true),
                    UrlImage = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    ChiTietTinModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinMoi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TinMoi_ChiTietTin_ChiTietTinModelId",
                        column: x => x.ChiTietTinModelId,
                        principalTable: "ChiTietTin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TinMoi_ChiTietTinModelId",
                table: "TinMoi",
                column: "ChiTietTinModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "TinMoi");

            migrationBuilder.DropTable(
                name: "ChiTietTin");
        }
    }
}
