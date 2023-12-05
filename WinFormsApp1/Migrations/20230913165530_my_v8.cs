using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class my_v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Departments_CatalogCat_id",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_employees_AuthorAuth_id",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "Authors");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Catalogs");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_CatalogCat_id",
                table: "Posts",
                newName: "IX_Posts_CatalogCat_id");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_AuthorAuth_id",
                table: "Posts",
                newName: "IX_Posts_AuthorAuth_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Auth_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catalogs",
                table: "Catalogs",
                column: "Cat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Authors_AuthorAuth_id",
                table: "Posts",
                column: "AuthorAuth_id",
                principalTable: "Authors",
                principalColumn: "Auth_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Catalogs_CatalogCat_id",
                table: "Posts",
                column: "CatalogCat_id",
                principalTable: "Catalogs",
                principalColumn: "Cat_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Authors_AuthorAuth_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Catalogs_CatalogCat_id",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catalogs",
                table: "Catalogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Catalogs",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "employees");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_CatalogCat_id",
                table: "Projects",
                newName: "IX_Projects_CatalogCat_id");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AuthorAuth_id",
                table: "Projects",
                newName: "IX_Projects_AuthorAuth_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Cat_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "Auth_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Departments_CatalogCat_id",
                table: "Projects",
                column: "CatalogCat_id",
                principalTable: "Departments",
                principalColumn: "Cat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_employees_AuthorAuth_id",
                table: "Projects",
                column: "AuthorAuth_id",
                principalTable: "employees",
                principalColumn: "Auth_id");
        }
    }
}
