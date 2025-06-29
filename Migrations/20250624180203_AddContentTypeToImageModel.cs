using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace uploads_api.Migrations
{
    /// <inheritdoc />
    public partial class AddContentTypeToImageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "ImageModel",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "ImageModel");
        }
    }
}
