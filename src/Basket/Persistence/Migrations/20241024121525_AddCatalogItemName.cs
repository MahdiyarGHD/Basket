using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Basket.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCatalogItemName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BasketType",
                table: "UserBaskets",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.AddColumn<string>(
                name: "CatalogItemName",
                table: "BasketCatalogItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatalogItemName",
                table: "BasketCatalogItems");

            migrationBuilder.AlterColumn<string>(
                name: "BasketType",
                table: "UserBaskets",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);
        }
    }
}
