using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dapper.DataBase.Migrations
{
    public partial class changecolname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeoartmentName",
                table: "Departments",
                newName: "DepartmentName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Departments",
                newName: "DeoartmentName");
        }
    }
}
