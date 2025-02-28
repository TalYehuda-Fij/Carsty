using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReserverPrice",
                table: "Auctions",
                newName: "ReservePrice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservePrice",
                table: "Auctions",
                newName: "ReserverPrice");
        }
    }
}
