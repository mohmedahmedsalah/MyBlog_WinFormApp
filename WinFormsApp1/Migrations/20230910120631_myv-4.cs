using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class myv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Cat_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Cat_id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Auth_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Auth_id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Bref = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Auth_id = table.Column<int>(type: "int", nullable: false),
                    Cat_id = table.Column<int>(type: "int", nullable: false),
                    AuthorAuth_id = table.Column<int>(type: "int", nullable: true),
                    CatalogCat_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Departments_CatalogCat_id",
                        column: x => x.CatalogCat_id,
                        principalTable: "Departments",
                        principalColumn: "Cat_id");
                    table.ForeignKey(
                        name: "FK_Projects_employees_AuthorAuth_id",
                        column: x => x.AuthorAuth_id,
                        principalTable: "employees",
                        principalColumn: "Auth_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AuthorAuth_id",
                table: "Projects",
                column: "AuthorAuth_id");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CatalogCat_id",
                table: "Projects",
                column: "CatalogCat_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
