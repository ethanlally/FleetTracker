using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetTracker.Services.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRentalIndexes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RentalAgreements_CustomerId",
                table: "RentalAgreements",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgreements_VehicleId",
                table: "RentalAgreements",
                column: "VehicleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RentalAgreements_CustomerId",
                table: "RentalAgreements");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgreements_VehicleId",
                table: "RentalAgreements");
        }
    }
}
