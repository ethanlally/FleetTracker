using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetTracker.Services.Data.Migrations
{
    /// <inheritdoc />
    public partial class DecoupleRentalHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgreements_Customers_CustomerId",
                table: "RentalAgreements");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgreements_Vehicles_VehicleId",
                table: "RentalAgreements");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgreements_CustomerId",
                table: "RentalAgreements");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgreements_VehicleId",
                table: "RentalAgreements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RentalAgreements_CustomerId",
                table: "RentalAgreements",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgreements_VehicleId",
                table: "RentalAgreements",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgreements_Customers_CustomerId",
                table: "RentalAgreements",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgreements_Vehicles_VehicleId",
                table: "RentalAgreements",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}