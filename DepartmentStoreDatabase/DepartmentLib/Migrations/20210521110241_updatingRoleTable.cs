using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentLib.Migrations
{
    public partial class updatingRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "Staff",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleId1",
                table: "Staff",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Role_RoleId1",
                table: "Staff",
                column: "RoleId1",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Role_RoleId1",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_RoleId1",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "Staff");
        }
    }
}
