using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiAdminUser.Migrations
{
    /// <inheritdoc />
    public partial class AllChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AdminUsers",
                newName: "AdminUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdminUserId",
                table: "AdminUsers",
                newName: "Id");
        }
    }
}
