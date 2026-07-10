using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IYA.Flow.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddWorkspaceProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Workspaces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Workspaces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Workspaces",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Workspaces");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Workspaces");

            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Workspaces");
        }
    }
}
