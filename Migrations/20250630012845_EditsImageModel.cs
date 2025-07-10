using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uploads_api.Migrations
{
    /// <inheritdoc />
    public partial class EditsImageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "ImageModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ImageModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "ImageModel");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ImageModel");
        }
    }
}
